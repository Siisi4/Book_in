Shader "Unlit/Glass"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _NormalMap ("Normal Map", 2D) = "bump" {}
    }
    SubShader
    {
        Tags 
        { 
            "Queue" = "Transparent"
            "RenderType" = "Opaque" 
        }

        LOD 100

        GrabPass
        {
            "_GrabbedTexture"
        }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
                float4 uvgrab : TEXCOORD1;

            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            sampler2D _GrabbedTexture;
            sampler2D _NormalMap;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);

                o.uvgrab = ComputeGrabScreenPos(o.vertex);

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // Distortion
                half4 normal = tex2D(_NormalMap, i.uv);
                half2 distortion = UnpackNormal(normal).rg;

                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                half4 uvgrab = i.uvgrab;
                uvgrab.xy += distortion;

                fixed4 grabCol = tex2Dproj(_GrabbedTexture, uvgrab);
                col *= grabCol;                

                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);

                return col;
            }
            ENDCG
        }
    }
}
