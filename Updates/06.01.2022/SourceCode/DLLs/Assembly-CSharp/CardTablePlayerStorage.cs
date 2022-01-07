using System;
using Il2CppDummyDll;

// Token: 0x020004F6 RID: 1270
[Token(Token = "0x20003AB")]
public class CardTablePlayerStorage : StorageContainer
{
	// Token: 0x06002574 RID: 9588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x64F200", Offset = "0x64E000", VA = "0x18064F200")]
	public CardTable GetCardTable()
	{
		return null;
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0x64F2E0", Offset = "0x64E0E0", VA = "0x18064F2E0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0x64F340", Offset = "0x64E140", VA = "0x18064F340")]
	public CardTablePlayerStorage()
	{
	}

	// Token: 0x04002015 RID: 8213
	[Token(Token = "0x4001A12")]
	[FieldOffset(Offset = "0x3C8")]
	private EntityRef cardTableRef;
}
