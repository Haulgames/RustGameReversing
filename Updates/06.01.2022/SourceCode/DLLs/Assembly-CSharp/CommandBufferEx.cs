using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008FA RID: 2298
[Token(Token = "0x2000677")]
public static class CommandBufferEx
{
	// Token: 0x060037D8 RID: 14296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F0D")]
	[Address(RVA = "0x4A0060", Offset = "0x49EE60", VA = "0x1804A0060")]
	public static void BlitArray(this CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Material mat, int slice, int pass = 0)
	{
	}

	// Token: 0x060037D9 RID: 14297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0x49FE90", Offset = "0x49EC90", VA = "0x18049FE90")]
	public static void BlitArray(this CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Texture target, Material mat, int slice, int pass = 0)
	{
	}

	// Token: 0x060037DA RID: 14298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0x49FB60", Offset = "0x49E960", VA = "0x18049FB60")]
	public static void BlitArrayMip(this CommandBuffer cb, Mesh blitMesh, Texture source, int sourceMip, int sourceSlice, Texture target, int targetMip, int targetSlice, Material mat, int pass = 0)
	{
	}

	// Token: 0x060037DB RID: 14299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F10")]
	[Address(RVA = "0x4A01C0", Offset = "0x49EFC0", VA = "0x1804A01C0")]
	public static void BlitMip(this CommandBuffer cb, Mesh blitMesh, Texture source, Texture target, int mip, int slice, Material mat, int pass = 0)
	{
	}
}
