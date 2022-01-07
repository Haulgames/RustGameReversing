using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008CC RID: 2252
[Token(Token = "0x2000657")]
[ExecuteInEditMode]
public class DeferredDecalRenderer : BaseCommandBuffer
{
	// Token: 0x060036A2 RID: 13986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEA")]
	[Address(RVA = "0x8C0E20", Offset = "0x8BFC20", VA = "0x1808C0E20")]
	private void RefreshCommandBuffer(Camera camera)
	{
	}

	// Token: 0x060036A3 RID: 13987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEB")]
	[Address(RVA = "0x8C0B60", Offset = "0x8BF960", VA = "0x1808C0B60")]
	private void Clear(ListDictionary<InstancingKey, InstancingBuffer> dict)
	{
	}

	// Token: 0x060036A4 RID: 13988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEC")]
	[Address(RVA = "0x8C0550", Offset = "0x8BF350", VA = "0x1808C0550")]
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> src, ListDictionary<InstancingKey, InstancingBuffer> dst, MaterialPropertyBlock block)
	{
	}

	// Token: 0x060036A5 RID: 13989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DED")]
	[Address(RVA = "0x8C0840", Offset = "0x8BF640", VA = "0x1808C0840")]
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListHashSet<DeferredDecal> src, InstancingBuffer dst, MaterialPropertyBlock block)
	{
	}

	// Token: 0x060036A6 RID: 13990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002DEE")]
	[Address(RVA = "0x8C0C00", Offset = "0x8BFA00", VA = "0x1808C0C00")]
	private InstancingBuffer GetBuffer(ListDictionary<InstancingKey, InstancingBuffer> dict, InstancingKey key)
	{
		return null;
	}

	// Token: 0x060036A7 RID: 13991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEF")]
	[Address(RVA = "0x8C0D30", Offset = "0x8BFB30", VA = "0x1808C0D30")]
	protected void OnPreRender()
	{
	}

	// Token: 0x060036A8 RID: 13992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x8C1B50", Offset = "0x8C0950", VA = "0x1808C1B50")]
	public DeferredDecalRenderer()
	{
	}

	// Token: 0x040032FF RID: 13055
	[Token(Token = "0x4002753")]
	[FieldOffset(Offset = "0x0")]
	private static ListDictionary<InstancingKey, InstancingBuffer>[] DiffuseBuffer;

	// Token: 0x04003300 RID: 13056
	[Token(Token = "0x4002754")]
	[FieldOffset(Offset = "0x8")]
	private static ListDictionary<InstancingKey, InstancingBuffer>[] SpecularBuffer;

	// Token: 0x04003301 RID: 13057
	[Token(Token = "0x4002755")]
	[FieldOffset(Offset = "0x10")]
	private static ListDictionary<InstancingKey, InstancingBuffer>[] NormalsBuffer;

	// Token: 0x04003302 RID: 13058
	[Token(Token = "0x4002756")]
	[FieldOffset(Offset = "0x18")]
	private static ListDictionary<InstancingKey, InstancingBuffer>[] EmissionBuffer;

	// Token: 0x04003303 RID: 13059
	[Token(Token = "0x4002757")]
	[FieldOffset(Offset = "0x20")]
	private static ListDictionary<InstancingKey, InstancingBuffer>[] CombinedBuffer;

	// Token: 0x04003304 RID: 13060
	[Token(Token = "0x4002758")]
	[FieldOffset(Offset = "0x28")]
	private static MaterialPropertyBlock block;
}
