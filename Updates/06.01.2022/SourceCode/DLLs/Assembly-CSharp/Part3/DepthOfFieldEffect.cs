using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x0200075D RID: 1885
[Token(Token = "0x2000583")]
[Attribute(Name = "PostProcessAttribute", RVA = "0x91D00", Offset = "0x91100")]
[Serializable]
public class DepthOfFieldEffect : PostProcessEffectSettings
{
	// Token: 0x06002FCE RID: 12238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002863")]
	[Address(RVA = "0xB692D0", Offset = "0xB680D0", VA = "0x180B692D0")]
	public DepthOfFieldEffect()
	{
	}

	// Token: 0x04002C86 RID: 11398
	[Token(Token = "0x4002374")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter focalLength;

	// Token: 0x04002C87 RID: 11399
	[Token(Token = "0x4002375")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter focalSize;

	// Token: 0x04002C88 RID: 11400
	[Token(Token = "0x4002376")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter aperture;

	// Token: 0x04002C89 RID: 11401
	[Token(Token = "0x4002377")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter maxBlurSize;

	// Token: 0x04002C8A RID: 11402
	[Token(Token = "0x4002378")]
	[FieldOffset(Offset = "0x50")]
	public BoolParameter highResolution;

	// Token: 0x04002C8B RID: 11403
	[Token(Token = "0x4002379")]
	[FieldOffset(Offset = "0x58")]
	public DOFBlurSampleCountParameter blurSampleCount;

	// Token: 0x04002C8C RID: 11404
	[Token(Token = "0x400237A")]
	[FieldOffset(Offset = "0x60")]
	public Transform focalTransform;
}
