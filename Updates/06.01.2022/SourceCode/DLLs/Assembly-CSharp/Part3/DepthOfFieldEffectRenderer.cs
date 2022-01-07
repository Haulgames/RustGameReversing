using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x0200075E RID: 1886
[Token(Token = "0x2000584")]
public class DepthOfFieldEffectRenderer : PostProcessEffectRenderer<DepthOfFieldEffect>
{
	// Token: 0x06002FCF RID: 12239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002864")]
	[Address(RVA = "0xB685D0", Offset = "0xB673D0", VA = "0x180B685D0", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x00014748 File Offset: 0x00012948
	[Token(Token = "0x6002865")]
	[Address(RVA = "0xB68430", Offset = "0xB67230", VA = "0x180B68430")]
	private float FocalDistance01(Camera cam, float worldDist)
	{
		return 0f;
	}

	// Token: 0x06002FD1 RID: 12241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002866")]
	[Address(RVA = "0xB68D20", Offset = "0xB67B20", VA = "0x180B68D20")]
	private void WriteCoc(PostProcessRenderContext context, PropertySheet sheet)
	{
	}

	// Token: 0x06002FD2 RID: 12242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002867")]
	[Address(RVA = "0xB68620", Offset = "0xB67420", VA = "0x180B68620", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	// Token: 0x06002FD3 RID: 12243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002868")]
	[Address(RVA = "0xB69280", Offset = "0xB68080", VA = "0x180B69280")]
	public DepthOfFieldEffectRenderer()
	{
	}

	// Token: 0x04002C8D RID: 11405
	[Token(Token = "0x400237B")]
	[FieldOffset(Offset = "0x20")]
	private float focalDistance01;

	// Token: 0x04002C8E RID: 11406
	[Token(Token = "0x400237C")]
	[FieldOffset(Offset = "0x24")]
	private float internalBlurWidth;

	// Token: 0x04002C8F RID: 11407
	[Token(Token = "0x400237D")]
	[FieldOffset(Offset = "0x28")]
	private Shader dofShader;
}
