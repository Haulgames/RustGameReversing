using System;
using System.Collections.Generic;
using Facepunch.CardGames;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200007C RID: 124
[Token(Token = "0x2000046")]
public class CardTable : global::BaseVehicle
{
	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049B")]
	[Address(RVA = "0x652A00", Offset = "0x651800", VA = "0x180652A00", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060008F1 RID: 2289 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x1700007E")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x6555E0", Offset = "0x6543E0", VA = "0x1806555E0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x000050E8 File Offset: 0x000032E8
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x653610", Offset = "0x652410", VA = "0x180653610", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00005100 File Offset: 0x00003300
	[Token(Token = "0x1700007F")]
	public static bool LocalPlayerInCardsUI
	{
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x655730", Offset = "0x654530", VA = "0x180655730")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00005118 File Offset: 0x00003318
	[Token(Token = "0x17000080")]
	public bool ShowTakeWinningsTip
	{
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x6557E0", Offset = "0x6545E0", VA = "0x1806557E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000081")]
	public string recentlyLeftPlayerName
	{
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x655810", Offset = "0x654610", VA = "0x180655810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x655820", Offset = "0x654620", VA = "0x180655820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x652240", Offset = "0x651040", VA = "0x180652240", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x654B10", Offset = "0x653910", VA = "0x180654B10")]
	public void RefreshLocalPlayer(CardPlayerData localPlayerData)
	{
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x655440", Offset = "0x654240", VA = "0x180655440")]
	public void UIClosed()
	{
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00005130 File Offset: 0x00003330
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x652F60", Offset = "0x651D60", VA = "0x180652F60")]
	public CardTableUI.UIState GetUIGameState(CardPlayerData localPlayerData)
	{
		return CardTableUI.UIState.None;
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x652870", Offset = "0x651670", VA = "0x180652870")]
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList)
	{
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x6535D0", Offset = "0x6523D0", VA = "0x1806535D0")]
	[Attribute(Name = "Menu", RVA = "0xC1450", Offset = "0xC0850")]
	[Attribute(Name = "Description", RVA = "0xC1450", Offset = "0xC0850")]
	[Attribute(Name = "Icon", RVA = "0xC1450", Offset = "0xC0850")]
	[Attribute(Name = "ShowIf", RVA = "0xC1450", Offset = "0xC0850")]
	public void Menu_Play(global::BasePlayer player)
	{
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00005148 File Offset: 0x00003348
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x653520", Offset = "0x652320", VA = "0x180653520")]
	public bool Menu_Play_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x6534E0", Offset = "0x6522E0", VA = "0x1806534E0")]
	[Attribute(Name = "Menu", RVA = "0x761D0", Offset = "0x755D0")]
	[Attribute(Name = "Description", RVA = "0x761D0", Offset = "0x755D0")]
	[Attribute(Name = "Icon", RVA = "0x761D0", Offset = "0x755D0")]
	[Attribute(Name = "ShowIf", RVA = "0x761D0", Offset = "0x755D0")]
	public void Menu_Open(global::BasePlayer player)
	{
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00005160 File Offset: 0x00003360
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x653340", Offset = "0x652140", VA = "0x180653340")]
	public bool Menu_Open_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x654940", Offset = "0x653740", VA = "0x180654940")]
	public void PlayerClosedUI(global::BasePlayer player)
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x652710", Offset = "0x651510", VA = "0x180652710")]
	private void DelayedViewModelDeploy(float timeDelay)
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x6527B0", Offset = "0x6515B0", VA = "0x1806527B0")]
	private void DeployViewModel()
	{
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x653190", Offset = "0x651F90", VA = "0x180653190")]
	private void HolsterViewmodel()
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00005178 File Offset: 0x00003378
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x654ED0", Offset = "0x653CD0", VA = "0x180654ED0")]
	public bool RefreshPlayerCards()
	{
		return default(bool);
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x655020", Offset = "0x653E20", VA = "0x180655020")]
	private void RefreshTableVisuals(List<PlayingCard> cards, int scrap)
	{
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x652910", Offset = "0x651710", VA = "0x180652910")]
	private static Sprite GetImage(int cardIndex)
	{
		return null;
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x655300", Offset = "0x654100", VA = "0x180655300")]
	private void ShowStack(global::CardTable.ChipStack stack, ref int remainingScrap)
	{
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x654840", Offset = "0x653640", VA = "0x180654840")]
	[global::BaseEntity.RPC_Client]
	private void OnWinnersDeclared(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x654980", Offset = "0x653780", VA = "0x180654980")]
	[global::BaseEntity.RPC_Client]
	private void ReceiveCardsForPlayer(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x652490", Offset = "0x651290", VA = "0x180652490")]
	public void ClientInput(int inputType, int inputValue = 0)
	{
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x652650", Offset = "0x651450", VA = "0x180652650")]
	[global::BaseEntity.RPC_Client]
	private void ClientPlaySound(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x6526B0", Offset = "0x6514B0", VA = "0x1806526B0")]
	[global::BaseEntity.RPC_Client]
	private void ClientStartTurnTimer(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x652500", Offset = "0x651300", VA = "0x180652500")]
	[global::BaseEntity.RPC_Client]
	private void ClientOnPlayerLeft(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x6521F0", Offset = "0x650FF0", VA = "0x1806521F0")]
	private void ClearRecentlyLeftPlayer()
	{
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x0600090F RID: 2319 RVA: 0x00005190 File Offset: 0x00003390
	[Token(Token = "0x17000082")]
	public int ScrapItemID
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x6557C0", Offset = "0x6545C0", VA = "0x1806557C0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000083")]
	public CardGameController GameController
	{
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x655540", Offset = "0x654340", VA = "0x180655540")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x652830", Offset = "0x651630", VA = "0x180652830", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x6528B0", Offset = "0x6516B0", VA = "0x1806528B0")]
	private CardGameController GetGameController()
	{
		return null;
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x653270", Offset = "0x652070", VA = "0x180653270", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x655530", Offset = "0x654330", VA = "0x180655530")]
	public CardTable()
	{
	}

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_Open;

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x400")]
	private Option __menuOption_Menu_Play;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x0")]
	[NonSerialized]
	public static CardTableUI clientUI;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x458")]
	private TimeSince showWinningsTipFor;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x45C")]
	private bool? localWasHoldingCards;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x460")]
	private int lastVisualScrap;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, Sprite> tableCardImageDict;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x10")]
	private static Sprite blankCardStatic;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x468")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private string <recentlyLeftPlayerName>k__BackingField;

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x470")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xBF540", Offset = "0xBE940")]
	[SerializeField]
	private GameObjectRef uiPrefab;

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x478")]
	[SerializeField]
	private GameObjectRef playerStoragePrefab;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x480")]
	[SerializeField]
	private GameObjectRef potPrefab;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x488")]
	[SerializeField]
	private ViewModel viewModel;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x490")]
	[SerializeField]
	private CardTableUI.PlayingCardImage[] tableCards;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x498")]
	[SerializeField]
	private Renderer[] tableCardBackings;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x4A0")]
	[SerializeField]
	private Canvas cardUICanvas;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x4A8")]
	[SerializeField]
	private Image[] tableCardImages;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x4B0")]
	[SerializeField]
	private Sprite blankCard;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x4B8")]
	[SerializeField]
	private Transform chipStacksParent;

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x4C0")]
	[SerializeField]
	private global::CardTable.ChipStack[] chipStacks;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x4C8")]
	[SerializeField]
	private global::CardTable.ChipStack[] fillerStacks;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x4D0")]
	public ItemDefinition scrapItemDef;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x4D8")]
	public global::CardTable.PlayerStorageInfo[] playerStoragePoints;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x4E0")]
	public global::CardTable.CardGameOption gameOption;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x4E8")]
	private CardGameController _gameCont;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40003EB")]
	private const float MAX_STORAGE_INTERACTION_DIST = 1f;

	// Token: 0x0200007D RID: 125
	[Token(Token = "0x2000A76")]
	[Serializable]
	public class ChipStack : IComparable<global::CardTable.ChipStack>
	{
		// Token: 0x06000916 RID: 2326 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x65B4D0", Offset = "0x65A2D0", VA = "0x18065B4D0", Slot = "4")]
		public int CompareTo(global::CardTable.ChipStack other)
		{
			return 0;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public ChipStack()
		{
		}

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x4003E27")]
		[FieldOffset(Offset = "0x10")]
		public int chipValue;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x4003E28")]
		[FieldOffset(Offset = "0x18")]
		public GameObject[] chips;
	}

	// Token: 0x0200007E RID: 126
	[Token(Token = "0x2000A77")]
	public enum CardGameOption
	{
		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x4003E2A")]
		TexasHoldEm
	}

	// Token: 0x0200007F RID: 127
	[Token(Token = "0x2000A78")]
	[Serializable]
	public class PlayerStorageInfo
	{
		// Token: 0x06000918 RID: 2328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE7")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public PlayerStorageInfo()
		{
		}

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x4003E2B")]
		[FieldOffset(Offset = "0x10")]
		public Transform storagePos;
	}
}
