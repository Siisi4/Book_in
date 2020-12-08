Shader "Interface3/Grass1"
{
    Properties
    {
        _BottomColor("Bottom Color", Color) = (1, 1, 1, 1)
        _TopColor("Top Color", Color) = (1, 1, 1, 1)
        _BendRotationRandom("Bend Rotation Random", Range(0, 1)) = 0.2
        _BladeWidth("Blade Width", Float) = 0.05
        _BladeWidthRandom("Blade Width Random", Float) = 0.02
        _BladeHeight("Blade Height", Float) = 0.5
        _BladeHeightRandom("Blade Height Random", Float) = 0.3
        _TessellationUniform("Tesselation Uniform", Range(1, 64)) = 1
    }

    CGINCLUDE
    #include "UnityCG.cginc"
    #include "Autolight.cginc"
    #include "ShaderFunctions.cginc"
    #include "CustomTessellation.cginc"

    half4 _BottomColor, _TopColor;
    half _BendRotationRandom;
    half _BladeWidth, _BladeWidthRandom, _BladeHeight, _BladeHeightRandom;

    

    // structure
    struct geometryOutput {
        float4 pos : SV_POSITION;
        half2 uv : TEXCOORD0;
    };

    // fonction qui va nous renvoyer un geometryOutput qu'on va append
    // du coup on peut simplifier ensuite le geometryoutput 
    geometryOutput VertexOutput(half3 pos, float2 uv){
        geometryOutput o;
        o.pos = UnityObjectToClipPos(pos);
        o.uv = uv;
        return o;
    }


    // fonction de g�om�trie
    //  notre fonction geom re�oit des triangles form�s de vertOutput (des triangles de chacun 3 point qui sont des vert output)
    //  un param�tre inout qui est une suite, un flux de triangles
    [maxvertexcount(3)]
    void geo(triangle vertOutput IN[3], inout TriangleStream<geometryOutput> triStream){
        half3 pos = IN[0].vertex;

        half3 vNormal = IN[0].normal;
        half4 vTangent = IN[0].tangent;
        // cross() c'est pour multiplier des vecteurs
        half3 vBinormal = cross(vNormal, vTangent) * vTangent.w;


        // matrice avec nos 3 vecteurs sous forme de colomne 
        half3x3 tangentToLocal = half3x3(
            vTangent.x, vBinormal.x, vNormal.x,
            vTangent.y, vBinormal.y, vNormal.y,
            vTangent.z, vBinormal.z, vNormal.z
        );

        half3x3 facingRotationMatrix = AngleAxis3x3(rand(pos) * UNITY_TWO_PI, half3(0, 0, 1));
        half3x3 bendRotationMatrix = AngleAxis3x3(rand(pos.zzx) * UNITY_PI * 0.5 * _BendRotationRandom, half3(-1, 0, 0));

        half3x3 transformationMatrix = mul(mul(tangentToLocal, facingRotationMatrix), bendRotationMatrix);

        // random hauteur et largeur 
        float height = (rand(pos.zyx) * 2 - 1) * _BladeHeightRandom + _BladeHeight;
        float width = (rand(pos.zyz) * 2 - 1) * _BladeWidthRandom + _BladeWidth;


        //geometryOutput o;

        triStream.Append(VertexOutput(
            pos + mul(transformationMatrix, half3(width, 0, 0)),
            half2(0, 0)
            ));

        //o.pos = UnityObjectToClipPos(pos + half4(0.5, 0, 0, 1));
        //triStream.Append(o);

        triStream.Append(VertexOutput(
            pos + mul(transformationMatrix, half3(-width, 0, 0)),
            half2(1, 0)
            ));
        
        //o.pos = UnityObjectToClipPos(pos + half4(-0.5, 0, 0, 1));
        //triStream.Append(o);

        triStream.Append(VertexOutput(
            pos + mul(transformationMatrix, half3(0, 0, height)),
            half2(0.5, 1)
        ));
        
        //o.pos = UnityObjectToClipPos(pos + half4(0, 1, 0, 1));
        //triStream.Append(o);
    }

    ENDCG

    SubShader
    {
        Cull Off

        Pass
        {
            Tags
            {
                "RenderType" = "Opaque"
                "LightMode" = "ForwardBase"
            }

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 4.6
            #pragma geometry geo
            #pragma hull hull 
            #pragma domain domain
            
            #include "Lighting.cginc"

            float4 frag (geometryOutput o) : COLOR
            {	
                return lerp(_BottomColor, _TopColor, o.uv.y);
            }
            ENDCG
        }
    }
}