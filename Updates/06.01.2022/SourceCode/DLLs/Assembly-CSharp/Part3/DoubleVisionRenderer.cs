using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x02000760 RID: 1888
[Token(Token = "0x2000586")]
public class DoubleVisionRenderer : PostProcessEffectRenderer<DoubleVision>
{
	// Token: 0x06002FD5 RID: 12245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600286A")]
	[Address(RVA = "0x97A810", Offset = "0x979610", VA = "0x18097A810", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x06002FD6 RID: 12246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600286B")]
	[Address(RVA = "0x97A860", Offset = "0x979660", VA = "0x18097A860", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	// Token: 0x06002FD7 RID: 12247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600286C")]
	[Address(RVA = "0x97AB50", Offset = "0x979950", VA = "0x18097AB50")]
	public DoubleVisionRenderer()
	{
	}

	// Token: 0x04002C92 RID: 11410
	[Token(Token = "0x4002380")]
	[FieldOffset(Offset = "0x20")]
	private int displaceProperty;

	// Token: 0x04002C93 RID: 11411
	[Token(Token = "0x4002381")]
	[FieldOffset(Offset = "0x24")]
	private int amountProperty;

	// Token: 0x04002C94 RID: 11412
	[Token(Token = "0x4002382")]
	[FieldOffset(Offset = "0x28")]
	private Shader doubleVisionShader;
}
