#include "UnityCG.cginc"

uniform float u_heightExaggeration;
uniform float u_oneOverClipmapSize;
uniform float og_radiansPerDegree;

uniform float2 u_patchOriginInClippedLevel;
uniform float2 u_levelScaleFactor;
uniform float2 u_levelZeroWorldScaleFactor;
uniform float2 u_levelOffsetFromWorldOrigin;
uniform float2 u_fineLevelOriginInCoarse;
uniform float2 u_viewPosInClippedLevel;
uniform float2 u_unblendedRegionSize;
uniform float2 u_oneOverBlendedRegionSize;
uniform float2 u_fineTextureOrigin;
uniform float2 u_terrainToImageryResolutionRatio;
uniform float2 u_terrainOffsetInImagery;
uniform float2 u_oneOverImagerySize;

uniform float3 og_sunPosition;
uniform float3 u_sunPositionRelativeToViewer;
uniform float3 u_globeRadiiSquared;

uniform float4x4 og_modelViewPerspectiveMatrix;

uniform bool u_useBlendRegions;

uniform sampler2D og_texture0;    // finer height map
uniform sampler2D og_texture1;    // coarser height map

uniform float4 og_diffuseSpecularAmbientShininess;
uniform sampler2D og_texture2;    // finer normal map
uniform sampler2D og_texture3;    // coarser normal map
uniform sampler2D og_texture4;    // color map

uniform bool u_showImagery;
uniform bool u_showBlendRegions;
uniform bool u_shade;
uniform float3 u_color;
uniform float3 u_blendRegionColor;

struct appdata
{
    float4 vertex : POSITION;
    float2 uv : TEXCOORD0;
};

/*
float4 pos : SV_POSITION;
                float3 normal : NORMAL;
                float3 localNormal : TEXCOORD9;
                float2 uv : TEXCOORD0;
                float3 p : TEXCOORD1;
                float3 p3 : TEXCOORD7;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float2 uv3 : TEXCOORD8;
                float4 vv : TEXCOORD5;
                float h : TEXCOORD4;
                float2 pv : TEXCOORD6;
                */

struct VertexOutput
{
    float2 fsFineUv : TEXCOORD0;
    float2 fsCoarseUv : TEXCOORD1;
    float2 fsFineColorUv : TEXCOORD2;
    float4 fsPositionToLight_fsAlpha : SV_POSITION;
	float fsHeight : TEXCOORD3;
	float2 fsLonLat : TEXCOORD4;
};

float3 GeodeticSurfaceNormal(float3 geodetic)
{
	float cosLatitude = cos(geodetic.y);

	return float3(
		cosLatitude * cos(geodetic.x),
		cosLatitude * sin(geodetic.x),
		sin(geodetic.y));
}

float3 GeodeticToCartesian(float3 globeRadiiSquared, float3 geodetic)
{
	float3 n = GeodeticSurfaceNormal(geodetic);
	float3 k = globeRadiiSquared * n;
	float3 g = k * n;
	float gamma = sqrt(g.x + g.y + g.z);

	float3 rSurface = k / gamma;
	return rSurface + (geodetic.z * n);
}

float SampleHeight(float2 fsFineUv, float2 fsCoarseUv, float fsAlpha)
{
    float fineHeight = tex2Dlod(og_texture0, float4(fsFineUv, 0.0, 0.0) ).r;
    float coarseHeight = tex2Dlod(og_texture1, float4(fsCoarseUv, 0.0, 0.0)).r;
    return lerp(fineHeight, coarseHeight, fsAlpha) * u_heightExaggeration;
}

float3 ComputeNormal(float2 fsFineUv, float2 fsCoarseUv, float fsAlpha)
{
    float3 fineNormal = normalize(tex2Dlod(og_texture2, float4(fsFineUv, 0.0, 0.0)).rgb);
	float3 coarseNormal = normalize(tex2Dlod(og_texture3, float4(fsCoarseUv, 0.0, 0.0)).rgb);
	return normalize(lerp(fineNormal, coarseNormal, fsAlpha));
}