Shader "Custom/Sprites-Bumped Cutout"{
Properties {
	_Color ("Main Color", Color) = (1,1,1,1)
	[PerRendererData] _MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
	_BumpMap ("Normalmap", 2D) = "bump" {}
	_Cutoff("Cutoff", Range (0,1)) = 0.01
}

SubShader {
	Tags { 
		"Queue"="Transparent"
		"IgnoreProjector"="True"
		"RenderType"="TransparentCutOut"
		"PreviewType"="Plane"
		"CanUseSpriteAtlas"="True"
	}
	LOD 300

	CGPROGRAM
	#pragma surface surf Lambert addshadow fullforwardshadows alphatest:_Cutoff
	#pragma multi_compile DUMMY PIXELSNAP_ON
	
	sampler2D _MainTex;
	sampler2D _BumpMap;
	fixed4 _Color;
	
	struct Input {
		float2 uv_MainTex;
		float2 uv_BumpMap;
	};
	
	void surf (Input IN, inout SurfaceOutput o) {
		
		fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
		o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
		o.Albedo = c.rgb;
		o.Alpha = c.a;
	}
	ENDCG
}

Fallback "Transparent/Diffuse"
}