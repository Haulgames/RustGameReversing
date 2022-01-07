using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x02000759 RID: 1881
[Token(Token = "0x200057F")]
public class BlurOptimizedRenderer : PostProcessEffectRenderer<BlurOptimized>
{
	// Token: 0x06002FC9 RID: 12233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600285E")]
	[Address(RVA = "0x45F8C0", Offset = "0x45E6C0", VA = "0x18045F8C0", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x06002FCA RID: 12234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600285F")]
	[Address(RVA = "0x45F910", Offset = "0x45E710", VA = "0x18045F910", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002860")]
	[Address(RVA = "0x460140", Offset = "0x45EF40", VA = "0x180460140")]
	public BlurOptimizedRenderer()
	{
	}

	// Token: 0x04002C7F RID: 11391
	[Token(Token = "0x400236D")]
	[FieldOffset(Offset = "0x20")]
	private int dataProperty;

	// Token: 0x04002C80 RID: 11392
	[Token(Token = "0x400236E")]
	[FieldOffset(Offset = "0x28")]
	private Shader blurShader;
}
