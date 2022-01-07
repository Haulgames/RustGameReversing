using System;
using Il2CppDummyDll;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x02000758 RID: 1880
[Token(Token = "0x200057E")]
[Attribute(Name = "PostProcessAttribute", RVA = "0x91570", Offset = "0x90970")]
[Serializable]
public class BlurOptimized : PostProcessEffectSettings
{
	// Token: 0x06002FC8 RID: 12232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600285D")]
	[Address(RVA = "0x460190", Offset = "0x45EF90", VA = "0x180460190")]
	public BlurOptimized()
	{
	}

	// Token: 0x04002C7A RID: 11386
	[Token(Token = "0x4002368")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x8ED20", Offset = "0x8E120")]
	public FixedIntParameter downsample;

	// Token: 0x04002C7B RID: 11387
	[Token(Token = "0x4002369")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x8EA70", Offset = "0x8DE70")]
	public FixedIntParameter blurIterations;

	// Token: 0x04002C7C RID: 11388
	[Token(Token = "0x400236A")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x846B0", Offset = "0x83AB0")]
	public FloatParameter blurSize;

	// Token: 0x04002C7D RID: 11389
	[Token(Token = "0x400236B")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter fadeToBlurDistance;

	// Token: 0x04002C7E RID: 11390
	[Token(Token = "0x400236C")]
	[FieldOffset(Offset = "0x50")]
	public BlurTypeParameter blurType;
}
