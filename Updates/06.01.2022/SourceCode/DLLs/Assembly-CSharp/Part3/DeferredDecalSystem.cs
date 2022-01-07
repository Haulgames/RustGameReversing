using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

// Token: 0x020008CE RID: 2254
[Token(Token = "0x2000659")]
public class DeferredDecalSystem
{
	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x060036AA RID: 13994 RVA: 0x00016D40 File Offset: 0x00014F40
	[Token(Token = "0x170003FC")]
	public static bool IsEmpty
	{
		[Token(Token = "0x6002DF2")]
		[Address(RVA = "0x8C2ED0", Offset = "0x8C1CD0", VA = "0x1808C2ED0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060036AB RID: 13995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x8C1F20", Offset = "0x8C0D20", VA = "0x1808C1F20")]
	public static void Clear()
	{
	}

	// Token: 0x060036AC RID: 13996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x8C2100", Offset = "0x8C0F00", VA = "0x1808C2100")]
	private static ListHashSet<DeferredDecal> GetList(DeferredDecal decal, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> dict, int pass)
	{
		return null;
	}

	// Token: 0x060036AD RID: 13997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x8C1B60", Offset = "0x8C0960", VA = "0x1808C1B60")]
	public static void AddDecal(DeferredDecal decal)
	{
	}

	// Token: 0x060036AE RID: 13998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x8C22C0", Offset = "0x8C10C0", VA = "0x1808C22C0")]
	public static void RemoveDecal(DeferredDecal decal)
	{
	}

	// Token: 0x060036AF RID: 13999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x8C2260", Offset = "0x8C1060", VA = "0x1808C2260")]
	public static void RefreshDecal(DeferredDecal decal)
	{
	}

	// Token: 0x060036B0 RID: 14000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
	public DeferredDecalSystem()
	{
	}

	// Token: 0x04003308 RID: 13064
	[Token(Token = "0x400275C")]
	[FieldOffset(Offset = "0x0")]
	internal static bool IsDirty;

	// Token: 0x04003309 RID: 13065
	[Token(Token = "0x400275D")]
	internal const int QueueSize = 2;

	// Token: 0x0400330A RID: 13066
	[Token(Token = "0x400275E")]
	[FieldOffset(Offset = "0x8")]
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] DiffuseDecals;

	// Token: 0x0400330B RID: 13067
	[Token(Token = "0x400275F")]
	[FieldOffset(Offset = "0x10")]
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] SpecularDecals;

	// Token: 0x0400330C RID: 13068
	[Token(Token = "0x4002760")]
	[FieldOffset(Offset = "0x18")]
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] NormalsDecals;

	// Token: 0x0400330D RID: 13069
	[Token(Token = "0x4002761")]
	[FieldOffset(Offset = "0x20")]
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] EmissionDecals;

	// Token: 0x0400330E RID: 13070
	[Token(Token = "0x4002762")]
	[FieldOffset(Offset = "0x28")]
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] CombinedDecals;

	// Token: 0x0400330F RID: 13071
	[Token(Token = "0x4002763")]
	[FieldOffset(Offset = "0x30")]
	internal static int DiffusePass;

	// Token: 0x04003310 RID: 13072
	[Token(Token = "0x4002764")]
	[FieldOffset(Offset = "0x34")]
	internal static int SpecularPass;

	// Token: 0x04003311 RID: 13073
	[Token(Token = "0x4002765")]
	[FieldOffset(Offset = "0x38")]
	internal static int NormalsPass;

	// Token: 0x04003312 RID: 13074
	[Token(Token = "0x4002766")]
	[FieldOffset(Offset = "0x3C")]
	internal static int EmissionPass;

	// Token: 0x04003313 RID: 13075
	[Token(Token = "0x4002767")]
	[FieldOffset(Offset = "0x40")]
	internal static int CombinedPass;

	// Token: 0x04003314 RID: 13076
	[Token(Token = "0x4002768")]
	[FieldOffset(Offset = "0x48")]
	internal static RenderTargetIdentifier[] DiffuseRenderTarget;

	// Token: 0x04003315 RID: 13077
	[Token(Token = "0x4002769")]
	[FieldOffset(Offset = "0x50")]
	internal static RenderTargetIdentifier[] SpecularRenderTarget;

	// Token: 0x04003316 RID: 13078
	[Token(Token = "0x400276A")]
	[FieldOffset(Offset = "0x58")]
	internal static RenderTargetIdentifier[] NormalsRenderTarget;

	// Token: 0x04003317 RID: 13079
	[Token(Token = "0x400276B")]
	[FieldOffset(Offset = "0x60")]
	internal static RenderTargetIdentifier[] EmissionRenderTarget;

	// Token: 0x04003318 RID: 13080
	[Token(Token = "0x400276C")]
	[FieldOffset(Offset = "0x68")]
	internal static RenderTargetIdentifier[] CombinedRenderTarget;
}
