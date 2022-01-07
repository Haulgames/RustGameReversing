using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200002F")]
public class AdventCalendar : BaseCombatEntity
{
	// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x823340", Offset = "0x822140", VA = "0x180823340", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600054A RID: 1354 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x17000010")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x823880", Offset = "0x822680", VA = "0x180823880", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x823660", Offset = "0x822460", VA = "0x180823660", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x823620", Offset = "0x822420", VA = "0x180823620")]
	[Attribute(Name = "Menu", RVA = "0x9F620", Offset = "0x9EA20")]
	[Attribute(Name = "Description", RVA = "0x9F620", Offset = "0x9EA20")]
	[Attribute(Name = "Icon", RVA = "0x9F620", Offset = "0x9EA20")]
	[Attribute(Name = "ShowIf", RVA = "0x9F620", Offset = "0x9EA20")]
	public void Menu_OpenCalendar(global::BasePlayer player)
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10")]
	public bool Menu_OpenCalendar_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x8232B0", Offset = "0x8220B0", VA = "0x1808232B0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x8231A0", Offset = "0x821FA0", VA = "0x1808231A0")]
	public void CheckCrosses()
	{
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x2EF040", Offset = "0x2EDE40", VA = "0x1802EF040")]
	public AdventCalendar()
	{
	}

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x238")]
	private Option __menuOption_Menu_OpenCalendar;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x290")]
	public int startMonth;

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x294")]
	public int startDay;

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x298")]
	public AdventCalendar.DayReward[] days;

	// Token: 0x0400020A RID: 522
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObject[] crosses;

	// Token: 0x0400020B RID: 523
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x0")]
	public static List<AdventCalendar> all;

	// Token: 0x0400020C RID: 524
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<ulong, List<int>> playerRewardHistory;

	// Token: 0x0400020D RID: 525
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Translate.Phrase CheckLater;

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x18")]
	public static readonly Translate.Phrase EventOver;

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x2A8")]
	public GameObjectRef giftEffect;

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObjectRef boxCloseEffect;

	// Token: 0x0200003F RID: 63
	[Token(Token = "0x2000A51")]
	[Serializable]
	public class DayReward
	{
		// Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public DayReward()
		{
		}

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4003D91")]
		[FieldOffset(Offset = "0x10")]
		public ItemAmount[] rewards;
	}
}
