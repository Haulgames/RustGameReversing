using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000084 RID: 132
[Token(Token = "0x200004B")]
public class ContainerIOEntity : IOEntity, IItemContainerEntity, LootPanel.IHasLootPanel
{
	// Token: 0x06000967 RID: 2407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050F")]
	[Address(RVA = "0x6CF720", Offset = "0x6CE520", VA = "0x1806CF720", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000968 RID: 2408 RVA: 0x00005418 File Offset: 0x00003618
	[Token(Token = "0x1700008D")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x6D00A0", Offset = "0x6CEEA0", VA = "0x1806D00A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00005430 File Offset: 0x00003630
	[Token(Token = "0x6000511")]
	[Address(RVA = "0x6CFDE0", Offset = "0x6CEBE0", VA = "0x1806CFDE0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600096A RID: 2410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008E")]
	public Translate.Phrase LootPanelTitle
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x6D01E0", Offset = "0x6CEFE0", VA = "0x1806D01E0", Slot = "160")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00005448 File Offset: 0x00003648
	[Token(Token = "0x6000513")]
	[Address(RVA = "0x6CFD00", Offset = "0x6CEB00", VA = "0x1806CFD00")]
	public bool OccupiedCheck([Optional] BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000514")]
	[Address(RVA = "0x6CFC60", Offset = "0x6CEA60", VA = "0x1806CFC60", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000515")]
	[Address(RVA = "0x6CFCC0", Offset = "0x6CEAC0", VA = "0x1806CFCC0")]
	[Attribute(Name = "Menu", RVA = "0x761D0", Offset = "0x755D0")]
	[Attribute(Name = "Description", RVA = "0x761D0", Offset = "0x755D0")]
	[Attribute(Name = "Icon", RVA = "0x761D0", Offset = "0x755D0")]
	[Attribute(Name = "ShowIf", RVA = "0x761D0", Offset = "0x755D0")]
	public void Menu_Open(BasePlayer player)
	{
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000516")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0x763E0", Offset = "0x757E0")]
	[Attribute(Name = "Description", RVA = "0x763E0", Offset = "0x757E0")]
	[Attribute(Name = "Icon", RVA = "0x763E0", Offset = "0x757E0")]
	[Attribute(Name = "ShowIf", RVA = "0x763E0", Offset = "0x757E0")]
	public void Menu_Occupied(BasePlayer player)
	{
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x6000517")]
	[Address(RVA = "0x6CFC80", Offset = "0x6CEA80", VA = "0x1806CFC80")]
	public bool Menu_Occupied_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x6000518")]
	[Address(RVA = "0x6CFCA0", Offset = "0x6CEAA0", VA = "0x1806CFCA0")]
	public bool Menu_Open_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00005490 File Offset: 0x00003690
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x6CFED0", Offset = "0x6CECD0", VA = "0x1806CFED0", Slot = "161")]
	public virtual bool ShouldShowLootMenus()
	{
		return default(bool);
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x000054A8 File Offset: 0x000036A8
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "162")]
	public virtual int GetMoveToContainerIndex(BasePlayer player, Item item)
	{
		return 0;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x66C850", Offset = "0x66B650", VA = "0x18066C850", Slot = "163")]
	public virtual int GetMoveToSlotIndex(BasePlayer player, Item item)
	{
		return 0;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x6CFFD0", Offset = "0x6CEDD0", VA = "0x1806CFFD0")]
	public ContainerIOEntity()
	{
	}

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private Option __menuOption_Menu_Occupied;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private Option __menuOption_Menu_Open;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public ItemDefinition onlyAllowedItem;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public ItemContainer.ContentsType allowedContents;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
	public int maxStackSize;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public int numSlots;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public string lootPanelName;

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public Translate.Phrase panelTitle;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public bool needsBuildingPrivilegeToUse;

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x341")]
	public bool isLootable;

	// Token: 0x04000511 RID: 1297
	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x342")]
	public bool dropsLoot;

	// Token: 0x04000512 RID: 1298
	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x343")]
	public bool dropFloats;

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	public bool onlyOneUser;
}
