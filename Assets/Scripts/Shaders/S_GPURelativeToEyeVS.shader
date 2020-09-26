Shader "Unlit/S_GPURelativeToEyeVS"
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

            #include "Assets/Scripts/Shaders/Planet.cginc"

            /*
            struct v2f
            {
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

                UNITY_VERTEX_INPUT_INSTANCE_ID
            };
            */

            sampler2D _MainTex;
            float4 _MainTex_ST;

            VertexOutput vert (appdata v)
            {
                VertexOutput o;
                o.pos = GetPosition(v);
                o.col = GetColor(v);
                o.pointSize = GetPointSize();

                return o;
            }

            fixed4 frag (VertexOutput i) : COLOR
            {
                fixed4 col = i.col;
                return col;
            }
            ENDCG
        }
    }
}
