Shader "Custom/PointShader"
{
    Properties
    {
        _Color ("Color", Color) = (1, 1, 1, 1)
//        _Radius ("Radius", Range(0, 100)) = 0.5
//        _Center ("Center", Vector) = (0.5, 0.5, 0, 0)
    }

    SubShader
    {
        Tags
        {
            "Queue"="Transparent"
        }
        ZWrite Off
        Cull Off
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            float4 _Color;
            // float _Radius;
            // float4 _Center;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                // Calculate distance from centre of quad (dst > 1 is outside circle)
				// float2 centreOffset = (i.uv.xy - 0.5) * 2;
				// float sqrDst = dot(centreOffset, centreOffset);
				// float dst = sqrt(sqrDst);
				//
				// // Smoothly blend from 0 to 1 alpha across edge of circle
				// float delta = fwidth(dst);
				// float alpha = 1 - smoothstep(1 - delta, 1 + delta, sqrDst);
				//
				// return float4(_Color.rgb, alpha * _Color.a);
                const float dist = distance(i.uv, float2(0.5, 0.5));
                const float radius = 0.5;
                if (dist > radius) discard;
                return _Color;
                
            }
            ENDCG
        }
    }
}