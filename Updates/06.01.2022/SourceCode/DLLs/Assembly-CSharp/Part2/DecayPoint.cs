using System;
using Il2CppDummyDll;

// Token: 0x02000304 RID: 772
[Token(Token = "0x200021C")]
public class DecayPoint : PrefabAttribute
{
	// Token: 0x06001C24 RID: 7204 RVA: 0x0000DB78 File Offset: 0x0000BD78
	[Token(Token = "0x6001680")]
	[Address(RVA = "0x8BCAA0", Offset = "0x8BB8A0", VA = "0x1808BCAA0")]
	public bool IsOccupied(BaseEntity entity)
	{
		return default(bool);
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001681")]
	[Address(RVA = "0x8BCA40", Offset = "0x8BB840", VA = "0x1808BCA40", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001682")]
	[Address(RVA = "0x8BCAD0", Offset = "0x8BB8D0", VA = "0x1808BCAD0")]
	public DecayPoint()
	{
	}

	// Token: 0x04001714 RID: 5908
	[Token(Token = "0x40012CF")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xADA70", Offset = "0xACE70")]
	public float protection;

	// Token: 0x04001715 RID: 5909
	[Token(Token = "0x40012D0")]
	[FieldOffset(Offset = "0xA0")]
	public Socket_Base socket;
}
