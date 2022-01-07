using System;
using Il2CppDummyDll;

// Token: 0x02000991 RID: 2449
[Token(Token = "0x20006DE")]
public class ContainerSourceLocalPlayer : ItemContainerSource
{
	// Token: 0x06003A0D RID: 14861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60030E1")]
	[Address(RVA = "0x6D01F0", Offset = "0x6CEFF0", VA = "0x1806D01F0", Slot = "4")]
	public override ItemContainer GetItemContainer()
	{
		return null;
	}

	// Token: 0x06003A0E RID: 14862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030E2")]
	[Address(RVA = "0x2F6C50", Offset = "0x2F5A50", VA = "0x1802F6C50")]
	public ContainerSourceLocalPlayer()
	{
	}

	// Token: 0x040036AD RID: 13997
	[Token(Token = "0x40029E2")]
	[FieldOffset(Offset = "0x18")]
	public PlayerInventory.Type type;
}
