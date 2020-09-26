    Shader "Unlit/GlobeClipmap"
    {
        Properties
        {
        }
        SubShader
        {
            Pass
            {
                Cull back
                
                CGPROGRAM

                #pragma multi_compile_instancing

                #pragma vertex vert
                #pragma fragment frag


                #include "Assets/Scripts/Shaders/ClipMap/ClipMapHelpers.cginc"

                sampler2D _MainTex;
                float4 _MainTex_ST;

                VertexOutput vert (appdata v)
                {
                    VertexOutput o;

                    float2 levelPos = v.vertex.xy + u_patchOriginInClippedLevel;
                        
                    o.fsFineUv = (levelPos + u_fineTextureOrigin) * u_oneOverClipmapSize;
                    o.fsCoarseUv = (levelPos * 0.5 + u_fineLevelOriginInCoarse) * u_oneOverClipmapSize;
        
                    // Set alpha
                    if (u_useBlendRegions)
                    {
                        float2 alpha = clamp((abs(levelPos - u_viewPosInClippedLevel) - u_unblendedRegionSize) * u_oneOverBlendedRegionSize, 0, 1);
                        o.fsPositionToLight_fsAlpha.w = max(alpha.x, alpha.y);
                    }
                    else
                    {
                        o.fsPositionToLight_fsAlpha.w = 0.0;
                    }

                    float height = SampleHeight(o.fsFineUv, o.fsCoarseUv, o.fsPositionToLight_fsAlpha.w);
                    o.fsHeight = height;

                    float2 worldPos = (levelPos + u_levelOffsetFromWorldOrigin) * u_levelScaleFactor * u_levelZeroWorldScaleFactor;
                    o.fsLonLat = worldPos;

                    o.fsFineColorUv = (levelPos * u_terrainToImageryResolutionRatio + u_terrainOffsetInImagery) * u_oneOverImagerySize;
                    
                    float3 displacedPosition;
                    if (abs(worldPos.y) > 90.0)
                    {
                        displacedPosition = float3(0.0, 0.0, 0.0);
                    }
                    else
                    {
                        displacedPosition = GeodeticToCartesian(u_globeRadiiSquared, float3(worldPos * og_radiansPerDegree, height));
                    }

                    float3 positionToLight = og_sunPosition - displacedPosition;
                    o.fsPositionToLight_fsAlpha.xyz = positionToLight;
                    return o;
                }

                fixed4 frag (VertexOutput i) : SV_Target
                {
                    float3 color = u_showImagery ? tex2Dlod(og_texture4, float4(i.fsFineColorUv, 0.0, 0.0)).rgb : u_color;
                    fixed3 col = u_showBlendRegions ? lerp(color, u_blendRegionColor, i.fsPositionToLight_fsAlpha.w) : color;

                    if (u_shade)
                    {
                        float3 positionToLight = normalize(i.fsPositionToLight_fsAlpha.xyz);
                        float3 normal = ComputeNormal(i.fsFineUv, i.fsCoarseUv, i.fsPositionToLight_fsAlpha.w);
                        float diffuse = og_diffuseSpecularAmbientShininess.x * max(dot(positionToLight, normal), 0.0);
                        float intensity = diffuse + og_diffuseSpecularAmbientShininess;
                        col *= intensity;
                    }

                    return fixed4(col.x, col.y, col.z, 1.0);
                }
                ENDCG
            }
        }
    }
