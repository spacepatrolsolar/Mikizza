Shader "miku_refrect" {
Properties {
 _InkSize ("Ink Size", Range(0.0001,0.01)) = 0.00012
 _DiffuseSampler ("Diffuse", 2D) = "white" {}
 _InkSampler ("Ink Color Texture", 2D) = "white" {}
 _LightSampler ("Light Texture", 2D) = "white" {}
}
	//DummyShaderTextExporter
	
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Lambert
#pragma target 3.0
		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};
		void surf(Input IN, inout SurfaceOutput o)
		{
			float4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
		}
		ENDCG
	}
}