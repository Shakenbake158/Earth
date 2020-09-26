#include "UnityCG.cginc"

uniform float3 u_cameraEyeHigh;
uniform float3 u_cameraEyeLow;
uniform float4x4 u_modelViewPerspectiveMatrixRelativeToEye;
uniform float u_pointSize;

struct appdata
{
    float4 positionHigh : POSITION;
    float4 positionLow : NORMAL;
    float4 texcoord : TEXCOORD0;
    fixed4 color : COLOR;
};

struct VertexOutput
{
    float4 pos : SV_POSITION;
    float4 col : COLOR;
    float pointSize: PSIZE;
};

float4 GetPosition(appdata v)
{
    float3 t1 = v.positionLow.xyz - u_cameraEyeLow;
    float3 e = t1 - v.positionLow.xyz;
    
    float3 t2 =  ((-u_cameraEyeLow - e) + (v.positionLow.xyz - (t1 - e))) + v.positionHigh.xyz - u_cameraEyeHigh;

    float3 highDifference = t1 + t2;
    float3 lowDifference = t2 - (highDifference - t1);

    return mul(u_modelViewPerspectiveMatrixRelativeToEye, float4(highDifference + lowDifference, 1.0));    
}

float4 GetColor(appdata v)
{
    return v.color;
}

float GetPointSize()
{
    return u_pointSize;
}