using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x0200008E RID: 142
[Token(Token = "0x2000055")]
public class ElectricalBranch : IOEntity
{
	// Token: 0x06000A01 RID: 2561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x98C520", Offset = "0x98B320", VA = "0x18098C520", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x1700009D")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x98CC40", Offset = "0x98BA40", VA = "0x18098CC40", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x98CAF0", Offset = "0x98B8F0", VA = "0x18098CAF0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x501BB0", Offset = "0x5009B0", VA = "0x180501BB0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x98C8E0", Offset = "0x98B6E0", VA = "0x18098C8E0")]
	[Attribute(Name = "Menu", RVA = "0xC9920", Offset = "0xC8D20")]
	[Attribute(Name = "Description", RVA = "0xC9920", Offset = "0xC8D20")]
	[Attribute(Name = "Icon", RVA = "0xC9920", Offset = "0xC8D20")]
	[Attribute(Name = "ShowIf", RVA = "0xC9920", Offset = "0xC8D20")]
	public void Menu_SetBranch(BasePlayer player)
	{
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x98C830", Offset = "0x98B630", VA = "0x18098C830")]
	public bool Menu_SetBranch_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x98C4D0", Offset = "0x98B2D0", VA = "0x18098C4D0")]
	public void ClientChangePower(int newAmount)
	{
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x98CBE0", Offset = "0x98B9E0", VA = "0x18098CBE0")]
	public ElectricalBranch()
	{
	}

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x268")]
	private Option __menuOption_Menu_SetBranch;

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x2C0")]
	public int branchAmount;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x2C8")]
	public GameObjectRef branchPanelPrefab;
}
