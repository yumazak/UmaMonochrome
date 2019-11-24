Shader "Hidden/Uma/Monochrome"
{
	Properties
	{
		_MainTex("-", 2D) = "" {}
	}
	CGINCLUDE

	#include "UnityCG.cginc"

	sampler2D _MainTex;
	half4 frag(v2f_img i) : COLOR
	{
		fixed4 color = tex2D(_MainTex, i.uv);
		float grayColor = color.r * 0.3 + color.g * 0.6 + color.b * 0.1;
		color.rgb = fixed3(grayColor, grayColor, grayColor);
		return color;
	}
	ENDCG
	SubShader
	{
		Pass
		{
			ZTest Always Cull Off ZWrite Off
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#pragma target 3.0
			ENDCG
		}
	}
}