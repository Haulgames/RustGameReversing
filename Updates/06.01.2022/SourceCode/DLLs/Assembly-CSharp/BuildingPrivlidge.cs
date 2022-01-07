using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;

// Token: 0x02000078 RID: 120
[Token(Token = "0x2000044")]
public class BuildingPrivlidge : StorageContainer
{
	// Token: 0x060008CA RID: 2250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x63DC20", Offset = "0x63CA20", VA = "0x18063DC20", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060008CB RID: 2251 RVA: 0x00004ED8 File Offset: 0x000030D8
	[Token(Token = "0x1700007C")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x63F0D0", Offset = "0x63DED0", VA = "0x18063F0D0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00004EF0 File Offset: 0x000030F0
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x63EE20", Offset = "0x63DC20", VA = "0x18063EE20", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00004F08 File Offset: 0x00003108
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x63DBF0", Offset = "0x63C9F0", VA = "0x18063DBF0")]
	public float CalculateUpkeepPeriodMinutes()
	{
		return 0f;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00004F20 File Offset: 0x00003120
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x63DBC0", Offset = "0x63C9C0", VA = "0x18063DBC0")]
	public float CalculateUpkeepCostFraction()
	{
		return 0f;
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x63DA20", Offset = "0x63C820", VA = "0x18063DA20")]
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts)
	{
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00004F38 File Offset: 0x00003138
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x63E7F0", Offset = "0x63D5F0", VA = "0x18063E7F0")]
	public float GetProtectedMinutes(bool force = false)
	{
		return 0f;
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x63EF10", Offset = "0x63DD10", VA = "0x18063EF10", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00004F50 File Offset: 0x00003150
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x63E8E0", Offset = "0x63D6E0", VA = "0x18063E8E0")]
	public bool IsAuthed(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00004F68 File Offset: 0x00003168
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x63E830", Offset = "0x63D630", VA = "0x18063E830")]
	public bool IsAuthed(ulong userID)
	{
		return default(bool);
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00004F80 File Offset: 0x00003180
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x63D9D0", Offset = "0x63C7D0", VA = "0x18063D9D0")]
	public bool AnyAuthed()
	{
		return default(bool);
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x63E9A0", Offset = "0x63D7A0", VA = "0x18063E9A0", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000485")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void BuildingDirty()
	{
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000486")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0xBDED0", Offset = "0xBD2D0")]
	[Attribute(Name = "Description", RVA = "0xBDED0", Offset = "0xBD2D0")]
	[Attribute(Name = "Icon", RVA = "0xBDED0", Offset = "0xBD2D0")]
	[Attribute(Name = "ShowIf", RVA = "0xBDED0", Offset = "0xBD2D0")]
	public void Menu_MaxAuth(global::BasePlayer player)
	{
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00004F98 File Offset: 0x00003198
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x63ECB0", Offset = "0x63DAB0", VA = "0x18063ECB0")]
	public bool MenuMaxAuth_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x63EB00", Offset = "0x63D900", VA = "0x18063EB00")]
	[Attribute(Name = "Menu", RVA = "0xBE000", Offset = "0xBD400")]
	[Attribute(Name = "Description", RVA = "0xBE000", Offset = "0xBD400")]
	[Attribute(Name = "Icon", RVA = "0xBE000", Offset = "0xBD400")]
	[Attribute(Name = "ShowIf", RVA = "0xBE000", Offset = "0xBD400")]
	public void MenuAuthorize(global::BasePlayer player)
	{
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x63EAC0", Offset = "0x63D8C0", VA = "0x18063EAC0")]
	public bool MenuAuthorize_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x63EC70", Offset = "0x63DA70", VA = "0x18063EC70")]
	[Attribute(Name = "Menu", RVA = "0xBE360", Offset = "0xBD760")]
	[Attribute(Name = "Description", RVA = "0xBE360", Offset = "0xBD760")]
	[Attribute(Name = "Icon", RVA = "0xBE360", Offset = "0xBD760")]
	[Attribute(Name = "ShowIf", RVA = "0xBE360", Offset = "0xBD760")]
	public void MenuDeauthorize(global::BasePlayer player)
	{
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00004FC8 File Offset: 0x000031C8
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x63EC60", Offset = "0x63DA60", VA = "0x18063EC60")]
	public bool MenuDeauthorize_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x63EC20", Offset = "0x63DA20", VA = "0x18063EC20")]
	[Attribute(Name = "Menu", RVA = "0xBE750", Offset = "0xBDB50")]
	[Attribute(Name = "Description", RVA = "0xBE750", Offset = "0xBDB50")]
	[Attribute(Name = "Icon", RVA = "0xBE750", Offset = "0xBDB50")]
	[Attribute(Name = "ShowIf", RVA = "0xBE750", Offset = "0xBDB50")]
	public void MenuClearList(global::BasePlayer player)
	{
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00004FE0 File Offset: 0x000031E0
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x63EB40", Offset = "0x63D940", VA = "0x18063EB40")]
	public bool MenuClearList_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00004FF8 File Offset: 0x000031F8
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x63EF70", Offset = "0x63DD70", VA = "0x18063EF70", Slot = "150")]
	public override bool ShouldShowLootMenus()
	{
		return default(bool);
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048F")]
	[Address(RVA = "0x63EDE0", Offset = "0x63DBE0", VA = "0x18063EDE0")]
	[Attribute(Name = "Menu", RVA = "0xBE950", Offset = "0xBDD50")]
	[Attribute(Name = "Description", RVA = "0xBE950", Offset = "0xBDD50")]
	[Attribute(Name = "Icon", RVA = "0xBE950", Offset = "0xBDD50")]
	[Attribute(Name = "ShowIf", RVA = "0xBE950", Offset = "0xBDD50")]
	public void Menu_RotateVM(global::BasePlayer player)
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00005010 File Offset: 0x00003210
	[Token(Token = "0x6000490")]
	[Address(RVA = "0x63ED00", Offset = "0x63DB00", VA = "0x18063ED00")]
	public bool Menu_RotateTC_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00005028 File Offset: 0x00003228
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x63E820", Offset = "0x63D620", VA = "0x18063E820", Slot = "85")]
	public override bool HasSlot(global::BaseEntity.Slot slot)
	{
		return default(bool);
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x63F040", Offset = "0x63DE40", VA = "0x18063F040")]
	public BuildingPrivlidge()
	{
	}

	// Token: 0x040004AC RID: 1196
	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x3C8")]
	private Option __menuOption_Menu_MaxAuth;

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x420")]
	private Option __menuOption_Menu_RotateVM;

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x478")]
	private Option __menuOption_MenuAuthorize;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x4D0")]
	private Option __menuOption_MenuClearList;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x528")]
	private Option __menuOption_MenuDeauthorize;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x580")]
	private float cachedProtectedMinutes;

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x584")]
	private float cachedUpkeepPeriodMinutes;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x588")]
	private float cachedUpkeepCostFraction;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x590")]
	public List<PlayerNameID> authorizedPlayers;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40003CF")]
	public const global::BaseEntity.Flags Flag_MaxAuths = global::BaseEntity.Flags.Reserved5;

	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000A74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass19_0
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass19_0()
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0x65BF50", Offset = "0x65AD50", VA = "0x18065BF50")]
		internal bool <IsAuthed>b__0(PlayerNameID x)
		{
			return default(bool);
		}

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x4003E25")]
		[FieldOffset(Offset = "0x10")]
		public global::BasePlayer player;
	}

	// Token: 0x0200007A RID: 122
	[Token(Token = "0x2000A75")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass20_0
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass20_0()
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x65BF80", Offset = "0x65AD80", VA = "0x18065BF80")]
		internal bool <IsAuthed>b__0(PlayerNameID x)
		{
			return default(bool);
		}

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x4003E26")]
		[FieldOffset(Offset = "0x10")]
		public ulong userID;
	}
}
