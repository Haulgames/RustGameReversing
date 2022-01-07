using System;
using Il2CppDummyDll;

// Token: 0x02000271 RID: 625
[Token(Token = "0x20001B0")]
public class AIPoint : BaseMonoBehaviour
{
	// Token: 0x06001930 RID: 6448 RVA: 0x0000CD38 File Offset: 0x0000AF38
	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x816730", Offset = "0x815530", VA = "0x180816730")]
	public bool InUse()
	{
		return default(bool);
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x0000CD50 File Offset: 0x0000AF50
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x816790", Offset = "0x815590", VA = "0x180816790")]
	public bool IsUsedBy(BaseEntity user)
	{
		return default(bool);
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x0000CD68 File Offset: 0x0000AF68
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x816580", Offset = "0x815380", VA = "0x180816580")]
	public bool CanBeUsedBy(BaseEntity user)
	{
		return default(bool);
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x816890", Offset = "0x815690", VA = "0x180816890")]
	public void SetUsedBy(BaseEntity user, float duration = 5f)
	{
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x484E20", Offset = "0x483C20", VA = "0x180484E20")]
	public void SetUsedBy(BaseEntity user)
	{
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x816710", Offset = "0x815510", VA = "0x180816710")]
	public void ClearUsed()
	{
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x816680", Offset = "0x815480", VA = "0x180816680")]
	public void ClearIfUsedBy(BaseEntity user)
	{
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public AIPoint()
	{
	}

	// Token: 0x04001376 RID: 4982
	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0x18")]
	private BaseEntity currentUser;
}
