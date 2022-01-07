using System;
using Il2CppDummyDll;

// Token: 0x0200062D RID: 1581
[Token(Token = "0x200049E")]
public class DecalCull : LODComponent
{
	// Token: 0x06002B9C RID: 11164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002497")]
	[Address(RVA = "0x8BB760", Offset = "0x8BA560", VA = "0x1808BB760", Slot = "8")]
	protected override void InitLOD()
	{
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002498")]
	[Address(RVA = "0x542D80", Offset = "0x541B80", VA = "0x180542D80", Slot = "9")]
	protected override void EnableLOD()
	{
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002499")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "10")]
	protected override void DisableLOD()
	{
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249A")]
	[Address(RVA = "0x8BB7B0", Offset = "0x8BA5B0", VA = "0x1808BB7B0", Slot = "13")]
	protected override void Show()
	{
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249B")]
	[Address(RVA = "0x8BB730", Offset = "0x8BA530", VA = "0x1808BB730", Slot = "14")]
	protected override void Hide()
	{
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249C")]
	[Address(RVA = "0x542E50", Offset = "0x541C50", VA = "0x180542E50", Slot = "12")]
	protected override void SetLOD(int newlod)
	{
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x00012D38 File Offset: 0x00010F38
	[Token(Token = "0x600249D")]
	[Address(RVA = "0x542D90", Offset = "0x541B90", VA = "0x180542D90", Slot = "11")]
	protected override int GetLOD(float distance)
	{
		return 0;
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600249E")]
	[Address(RVA = "0x8BB7E0", Offset = "0x8BA5E0", VA = "0x1808BB7E0")]
	public DecalCull()
	{
	}

	// Token: 0x040026D0 RID: 9936
	[Token(Token = "0x4001FA0")]
	[FieldOffset(Offset = "0x80")]
	public float Distance;

	// Token: 0x040026D1 RID: 9937
	[Token(Token = "0x4001FA1")]
	[FieldOffset(Offset = "0x88")]
	private DeferredDecal decal;

	// Token: 0x040026D2 RID: 9938
	[Token(Token = "0x4001FA2")]
	[FieldOffset(Offset = "0x90")]
	private int curlod;

	// Token: 0x040026D3 RID: 9939
	[Token(Token = "0x4001FA3")]
	[FieldOffset(Offset = "0x94")]
	private bool force;
}
