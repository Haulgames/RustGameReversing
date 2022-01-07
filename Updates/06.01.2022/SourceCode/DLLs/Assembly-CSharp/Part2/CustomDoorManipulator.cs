using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000085 RID: 133
[Token(Token = "0x200004C")]
public class CustomDoorManipulator : DoorManipulator
{
	// Token: 0x06000975 RID: 2421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x6DC300", Offset = "0x6DB100", VA = "0x1806DC300", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000976 RID: 2422 RVA: 0x000054D8 File Offset: 0x000036D8
	[Token(Token = "0x1700008F")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x6DCCA0", Offset = "0x6DBAA0", VA = "0x1806DCCA0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x000054F0 File Offset: 0x000036F0
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x6DCB00", Offset = "0x6DB900", VA = "0x1806DCB00", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00005508 File Offset: 0x00003708
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "158")]
	public override bool PairWithLockedDoors()
	{
		return default(bool);
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00005520 File Offset: 0x00003720
	[Token(Token = "0x6000521")]
	[Address(RVA = "0x6DC260", Offset = "0x6DB060", VA = "0x1806DC260")]
	public bool CanPlayerAdmin(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00005538 File Offset: 0x00003738
	[Token(Token = "0x6000522")]
	[Address(RVA = "0x6DC870", Offset = "0x6DB670", VA = "0x1806DC870")]
	public bool IsPaired()
	{
		return default(bool);
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x6DC970", Offset = "0x6DB770", VA = "0x1806DC970")]
	[Attribute(Name = "Menu", RVA = "0xC4720", Offset = "0xC3B20")]
	[Attribute(Name = "Description", RVA = "0xC4720", Offset = "0xC3B20")]
	[Attribute(Name = "Icon", RVA = "0xC4720", Offset = "0xC3B20")]
	[Attribute(Name = "ShowIf", RVA = "0xC4720", Offset = "0xC3B20")]
	public void Menu_Pair(BasePlayer player)
	{
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00005550 File Offset: 0x00003750
	[Token(Token = "0x6000524")]
	[Address(RVA = "0x6DC8D0", Offset = "0x6DB6D0", VA = "0x1806DC8D0")]
	public bool Menu_Pair_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x6DCC50", Offset = "0x6DBA50", VA = "0x1806DCC50")]
	public void RequestPair()
	{
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000526")]
	[Address(RVA = "0x6DCBF0", Offset = "0x6DB9F0", VA = "0x1806DCBF0")]
	public void RequestActionChange(DoorManipulator.DoorEffect newAction)
	{
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000527")]
	[Address(RVA = "0x6DCA30", Offset = "0x6DB830", VA = "0x1806DCA30")]
	[Attribute(Name = "Menu", RVA = "0xC4B30", Offset = "0xC3F30")]
	[Attribute(Name = "Description", RVA = "0xC4B30", Offset = "0xC3F30")]
	[Attribute(Name = "Icon", RVA = "0xC4B30", Offset = "0xC3F30")]
	[Attribute(Name = "ShowIf", RVA = "0xC4B30", Offset = "0xC3F30")]
	public void Menu_SetOpen(BasePlayer player)
	{
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00005568 File Offset: 0x00003768
	[Token(Token = "0x6000528")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030")]
	public bool Menu_SetOpen_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x6DCA30", Offset = "0x6DB830", VA = "0x1806DCA30")]
	[Attribute(Name = "Menu", RVA = "0xC4DF0", Offset = "0xC41F0")]
	[Attribute(Name = "Description", RVA = "0xC4DF0", Offset = "0xC41F0")]
	[Attribute(Name = "Icon", RVA = "0xC4DF0", Offset = "0xC41F0")]
	[Attribute(Name = "ShowIf", RVA = "0xC4DF0", Offset = "0xC41F0")]
	public void Menu_SetClose(BasePlayer player)
	{
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00005580 File Offset: 0x00003780
	[Token(Token = "0x600052A")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030")]
	public bool Menu_SetClose_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x6DCC90", Offset = "0x6DBA90", VA = "0x1806DCC90")]
	public CustomDoorManipulator()
	{
	}

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x288")]
	private Option __menuOption_Menu_Pair;

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x2E0")]
	private Option __menuOption_Menu_SetClose;

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x338")]
	private Option __menuOption_Menu_SetOpen;
}
