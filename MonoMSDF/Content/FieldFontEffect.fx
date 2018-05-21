#define VS_SHADERMODEL vs_5_0
#define PS_SHADERMODEL ps_5_0


matrix WorldViewProjection;
float2 TextureSize;
float4 ForegroundColor;
float PxRange;

texture GlyphTexture;
sampler glyphSampler = sampler_state
{
	Texture = (GlyphTexture);
	AddressU = CLAMP;
	AddressV = CLAMP;
	MagFilter = LINEAR;
	MinFilter = LINEAR;
	Mipfilter = LINEAR;
};

struct VertexShaderInput
{
	float4 Position : POSITION0;
	float2 TexCoord : TEXCOORD0;
};

struct VertexShaderOutput
{
	float4 Position : POSITION0;
	float2 TexCoord : TEXCOORD0;
};

VertexShaderOutput MainVS(in VertexShaderInput input)
{
	VertexShaderOutput output = (VertexShaderOutput)0;
	output.Position = mul(input.Position, WorldViewProjection);	
	output.TexCoord = input.TexCoord;

	return output;
}

float2 SafeNormalize(in float2 v)
{
	float len = length(v);
	len = (len > 0.0) ? 1.0 / len : 0.0;
	return v * len;
}

float Median(float a, float b, float c)
{	
	return max(min(a, b), min(max(a, b), c));
}

float4 MainPS(VertexShaderOutput input) : COLOR
{	
	// Convert normalized texture coordinates to absolute texture coordinates
	float2 uv = input.TexCoord * TextureSize;

	// Calculate derivatives
	float2 Jdx = ddx(uv);
	float2 Jdy = ddy(uv);

	// Sample texture
	float3 samp = tex2D(glyphSampler, input.TexCoord).rgb;

	// Calculate the signed distance (in texels)
	float sigDist = Median(samp.r, samp.g, samp.b) - 0.5f;

	// For proper anti-aliasing we need to calculate the signed distance in pixels.
	// We do this using the derivatives.	
	float2 gradDist = SafeNormalize(float2(ddx(sigDist), ddy(sigDist)));
	float2 grad = float2(gradDist.x * Jdx.x + gradDist.y * Jdy.x, gradDist.x * Jdx.y + gradDist.y * Jdy.y);

	// Apply anit-aliasing
	const float thickness = 0.125f;
	const float normalization = thickness * 0.5f * sqrt(2.0f);

	float afWidth = min(normalization * length(grad), 0.5f);
	float opacity = smoothstep(0.0f - afWidth, 0.0f + afWidth, sigDist);

	// Apply pre-multiplied alpha with gamma correction

	float4 color;
	color.a = pow(abs(ForegroundColor.a * opacity), 1.0f / 2.2f);
	color.rgb = ForegroundColor.rgb * color.a;

	return color;
}

float4 AltPS(VertexShaderOutput input) : COLOR
{
	/*if (input.TexCoord.x < 0.05f ||
		input.TexCoord.x > 0.95f ||
		input.TexCoord.y < 0.05f ||
		input.TexCoord.y > 0.95f)
	{
		return float4(0, 0, 0, 1);
	}*/


	float2 msdfUnit = PxRange / TextureSize;
	float3 samp = tex2D(glyphSampler, input.TexCoord).rgb;

	float sigDist = Median(samp.r, samp.g, samp.b) - 0.5f;
	sigDist = sigDist * dot(msdfUnit, 0.5f / fwidth(input.TexCoord));

	float opacity = clamp(sigDist + 0.5f, 0.0f, 1.0f);
	return ForegroundColor * opacity;
}

technique BasicColorDrawing
{
	pass P0
	{
		VertexShader = compile VS_SHADERMODEL MainVS();
		//PixelShader = compile PS_SHADERMODEL MainPS();
		PixelShader = compile PS_SHADERMODEL AltPS();
	}
};
