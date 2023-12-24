Shader "Graph/Point Surface"
{
    Properties
    {
        _Smoothness ("Smoothness", Range(0,1)) = 0.5
    }
    SubShader
    {
        CGPROGRAM
        #pragma surface ConfigureSurface Standard fullforwardshadows
        #pragma target 3.0

        struct Input
        {
            float3 worldPos;
        };

        float _Smoothness;

        void ConfigureSurface(Input input, inout SurfaceOutputStandard surface)
        {
            //设置反射的颜色（仅将xy发配到rg，不把z的值分配到b）
            surface.Albedo.rg = input.worldPos.xy * 0.5 + 0.5;
            //设置反光特性
            surface.Smoothness = _Smoothness;
        }
        ENDCG
    }

    FallBack "Diffuse"
}