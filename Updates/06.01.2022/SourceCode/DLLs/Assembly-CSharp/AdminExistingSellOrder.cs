using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x020001C3 RID: 451
[Token(Token = "0x200011A")]
public class AdminExistingSellOrder : MonoBehaviour
{
	// Token: 0x06001602 RID: 5634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x820CF0", Offset = "0x81FAF0", VA = "0x180820CF0")]
	public void Setup(ProtoBuf.VendingMachine.SellOrder so, int newIndex, VendingPanelAdmin admin)
	{
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x820C70", Offset = "0x81FA70", VA = "0x180820C70")]
	public void DeleteClick()
	{
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AdminExistingSellOrder()
	{
	}

	// Token: 0x04000FB5 RID: 4021
	[Token(Token = "0x4000C94")]
	[FieldOffset(Offset = "0x18")]
	public VirtualItemIcon MerchandiseIcon;

	// Token: 0x04000FB6 RID: 4022
	[Token(Token = "0x4000C95")]
	[FieldOffset(Offset = "0x20")]
	public VirtualItemIcon CurrencyIcon;

	// Token: 0x04000FB7 RID: 4023
	[Token(Token = "0x4000C96")]
	[FieldOffset(Offset = "0x28")]
	private VendingPanelAdmin adminPanel;

	// Token: 0x04000FB8 RID: 4024
	[Token(Token = "0x4000C97")]
	[FieldOffset(Offset = "0x30")]
	private int index;
}
