using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x0200008C RID: 140
[Token(Token = "0x2000053")]
public class DroppedItemContainer : BaseCombatEntity, LootPanel.IHasLootPanel
{
	// Token: 0x060009EF RID: 2543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x97D670", Offset = "0x97C470", VA = "0x18097D670", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00005958 File Offset: 0x00003B58
	[Token(Token = "0x17000099")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00005970 File Offset: 0x00003B70
	[Token(Token = "0x6000599")]
	[Address(RVA = "0x97D9B0", Offset = "0x97C7B0", VA = "0x18097D9B0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700009A")]
	public Translate.Phrase LootPanelTitle
	{
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x97DB00", Offset = "0x97C900", VA = "0x18097DB00", Slot = "144")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009B")]
	public string playerName
	{
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x97DBC0", Offset = "0x97C9C0", VA = "0x18097DBC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x97DC80", Offset = "0x97CA80", VA = "0x18097DC80")]
		set
		{
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x97D8F0", Offset = "0x97C6F0", VA = "0x18097D8F0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x97D970", Offset = "0x97C770", VA = "0x18097D970")]
	[Attribute(Name = "Menu", RVA = "0xC9430", Offset = "0xC8830")]
	[Attribute(Name = "Description", RVA = "0xC9430", Offset = "0xC8830")]
	[Attribute(Name = "Icon", RVA = "0xC9430", Offset = "0xC8830")]
	public void Menu_Open(BasePlayer player)
	{
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x97DAA0", Offset = "0x97C8A0", VA = "0x18097DAA0")]
	public DroppedItemContainer()
	{
	}

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x238")]
	private Option __menuOption_Menu_Open;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x290")]
	public string lootPanelName;

	// Token: 0x04000548 RID: 1352
	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x298")]
	public int maxItemCount;

	// Token: 0x04000549 RID: 1353
	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x2A0")]
	[NonSerialized]
	public ulong playerSteamID;

	// Token: 0x0400054A RID: 1354
	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x2A8")]
	[NonSerialized]
	public string _playerName;

	// Token: 0x0400054B RID: 1355
	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x2B0")]
	public bool onlyOwnerLoot;
}
