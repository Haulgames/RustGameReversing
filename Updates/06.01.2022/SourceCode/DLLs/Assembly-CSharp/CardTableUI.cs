using System;
using System.Collections.Generic;
using Facepunch.CardGames;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009AA RID: 2474
[Token(Token = "0x20006F3")]
public class CardTableUI : UIDialog
{
	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06003A94 RID: 14996 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A95 RID: 14997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700042C")]
	public CardTableUI.ICardGameSubUI curGameTypeUI
	{
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x652150", Offset = "0x650F50", VA = "0x180652150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x6521E0", Offset = "0x650FE0", VA = "0x1806521E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06003A96 RID: 14998 RVA: 0x000179B8 File Offset: 0x00015BB8
	[Token(Token = "0x1700042D")]
	private float dismountNormalisedProgress
	{
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x652160", Offset = "0x650F60", VA = "0x180652160")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06003A97 RID: 14999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003163")]
	[Address(RVA = "0x64F9B0", Offset = "0x64E7B0", VA = "0x18064F9B0")]
	protected void Awake()
	{
	}

	// Token: 0x06003A98 RID: 15000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003164")]
	[Address(RVA = "0x6518D0", Offset = "0x6506D0", VA = "0x1806518D0")]
	protected void Update()
	{
	}

	// Token: 0x06003A99 RID: 15001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003165")]
	[Address(RVA = "0x650350", Offset = "0x64F150", VA = "0x180650350")]
	public void OnPlayerPressedEscape()
	{
	}

	// Token: 0x06003A9A RID: 15002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003166")]
	[Address(RVA = "0x64FE90", Offset = "0x64EC90", VA = "0x18064FE90", Slot = "9")]
	public override void CloseDialog()
	{
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003167")]
	[Address(RVA = "0x650200", Offset = "0x64F000", VA = "0x180650200", Slot = "7")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06003A9C RID: 15004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003168")]
	[Address(RVA = "0x650E90", Offset = "0x64FC90", VA = "0x180650E90")]
	public void SetOwner(CardTable owner)
	{
	}

	// Token: 0x06003A9D RID: 15005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003169")]
	[Address(RVA = "0x6504A0", Offset = "0x64F2A0", VA = "0x1806504A0", Slot = "8")]
	public override void OpenDialog()
	{
	}

	// Token: 0x06003A9E RID: 15006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600316A")]
	[Address(RVA = "0x650050", Offset = "0x64EE50", VA = "0x180650050")]
	public static Sprite GetImage(int cardIndex, CardTableUI.CardType type)
	{
		return null;
	}

	// Token: 0x06003A9F RID: 15007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316B")]
	[Address(RVA = "0x650B00", Offset = "0x64F900", VA = "0x180650B00")]
	public void SetImage(Image image, int cardIndex, CardTableUI.CardType size)
	{
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316C")]
	[Address(RVA = "0x6509C0", Offset = "0x64F7C0", VA = "0x1806509C0")]
	public void SetImage(Image image, Sprite sprite)
	{
	}

	// Token: 0x06003AA1 RID: 15009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316D")]
	[Address(RVA = "0x651260", Offset = "0x650060", VA = "0x180651260")]
	public void ShowTimer()
	{
	}

	// Token: 0x06003AA2 RID: 15010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316E")]
	[Address(RVA = "0x6501D0", Offset = "0x64EFD0", VA = "0x1806501D0")]
	public void HideTimer()
	{
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316F")]
	[Address(RVA = "0x650900", Offset = "0x64F700", VA = "0x180650900")]
	private void RefreshUIState(CardPlayerData localPlayerData, bool forced = false)
	{
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003170")]
	[Address(RVA = "0x650F10", Offset = "0x64FD10", VA = "0x180650F10")]
	private void SetUIState(CardTableUI.UIState newState, bool forced = false)
	{
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003171")]
	[Address(RVA = "0x651350", Offset = "0x650150", VA = "0x180651350")]
	private void UpdateVitals()
	{
	}

	// Token: 0x06003AA6 RID: 15014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003172")]
	[Address(RVA = "0x650DC0", Offset = "0x64FBC0", VA = "0x180650DC0")]
	private void SetInfoUI(CardTableUI.InfoTextUI infoTextUI, string text, CardTableUI.InfoTextUI.Attitude attitude)
	{
	}

	// Token: 0x06003AA7 RID: 15015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003173")]
	[Address(RVA = "0x650570", Offset = "0x64F370", VA = "0x180650570")]
	private void RefreshAvailableInputs(CardPlayerData localPlayerData)
	{
	}

	// Token: 0x06003AA8 RID: 15016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003174")]
	[Address(RVA = "0x650350", Offset = "0x64F150", VA = "0x180650350")]
	private void StartDismountTime()
	{
	}

	// Token: 0x06003AA9 RID: 15017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003175")]
	[Address(RVA = "0x64FDE0", Offset = "0x64EBE0", VA = "0x18064FDE0")]
	private void CheckDismount()
	{
	}

	// Token: 0x06003AAA RID: 15018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003176")]
	[Address(RVA = "0x6520E0", Offset = "0x650EE0", VA = "0x1806520E0")]
	public CardTableUI()
	{
	}

	// Token: 0x04003725 RID: 14117
	[Token(Token = "0x4002A4D")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xBF540", Offset = "0xBE940")]
	[SerializeField]
	private CardTableUI.InfoTextUI primaryInfo;

	// Token: 0x04003726 RID: 14118
	[Token(Token = "0x4002A4E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CardTableUI.InfoTextUI secondaryInfo;

	// Token: 0x04003727 RID: 14119
	[Token(Token = "0x4002A4F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private CardTableUI.InfoTextUI playerLeaveInfo;

	// Token: 0x04003728 RID: 14120
	[Token(Token = "0x4002A50")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject playingUI;

	// Token: 0x04003729 RID: 14121
	[Token(Token = "0x4002A51")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject availableInputsUI;

	// Token: 0x0400372A RID: 14122
	[Token(Token = "0x4002A52")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CardTableUI.PlayingCardImage[] cardImages;

	// Token: 0x0400372B RID: 14123
	[Token(Token = "0x4002A53")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private CardInputWidget[] inputWidgets;

	// Token: 0x0400372C RID: 14124
	[Token(Token = "0x4002A54")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private RustSlider dismountProgressSlider;

	// Token: 0x0400372D RID: 14125
	[Token(Token = "0x4002A55")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Translate.Phrase phraseLoading;

	// Token: 0x0400372E RID: 14126
	[Token(Token = "0x4002A56")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Translate.Phrase phraseWaitingForNextRound;

	// Token: 0x0400372F RID: 14127
	[Token(Token = "0x4002A57")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Translate.Phrase phraseNotEnoughPlayers;

	// Token: 0x04003730 RID: 14128
	[Token(Token = "0x4002A58")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Translate.Phrase phraseYourTurn;

	// Token: 0x04003731 RID: 14129
	[Token(Token = "0x4002A59")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Translate.Phrase phrasePlayerLeftGame;

	// Token: 0x04003732 RID: 14130
	[Token(Token = "0x4002A5A")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color colourNeutralUI;

	// Token: 0x04003733 RID: 14131
	[Token(Token = "0x4002A5B")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Color colourGoodUI;

	// Token: 0x04003734 RID: 14132
	[Token(Token = "0x4002A5C")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Color colourBadUI;

	// Token: 0x04003735 RID: 14133
	[Token(Token = "0x4002A5D")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private CanvasGroup timerCanvas;

	// Token: 0x04003736 RID: 14134
	[Token(Token = "0x4002A5E")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private RustSlider timerSlider;

	// Token: 0x04003737 RID: 14135
	[Token(Token = "0x4002A5F")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UIChat chat;

	// Token: 0x04003738 RID: 14136
	[Token(Token = "0x4002A60")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private HudElement Hunger;

	// Token: 0x04003739 RID: 14137
	[Token(Token = "0x4002A61")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private HudElement Thirst;

	// Token: 0x0400373A RID: 14138
	[Token(Token = "0x4002A62")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private HudElement Health;

	// Token: 0x0400373B RID: 14139
	[Token(Token = "0x4002A63")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private HudElement PendingHealth;

	// Token: 0x0400373C RID: 14140
	[Token(Token = "0x4002A64")]
	[FieldOffset(Offset = "0x100")]
	public Sprite cardNone;

	// Token: 0x0400373D RID: 14141
	[Token(Token = "0x4002A65")]
	[FieldOffset(Offset = "0x108")]
	public Sprite cardBackLarge;

	// Token: 0x0400373E RID: 14142
	[Token(Token = "0x4002A66")]
	[FieldOffset(Offset = "0x110")]
	public Sprite cardBackSmall;

	// Token: 0x0400373F RID: 14143
	[Token(Token = "0x4002A67")]
	[FieldOffset(Offset = "0x0")]
	private static Sprite cardBackLargeStatic;

	// Token: 0x04003740 RID: 14144
	[Token(Token = "0x4002A68")]
	[FieldOffset(Offset = "0x8")]
	private static Sprite cardBackSmallStatic;

	// Token: 0x04003741 RID: 14145
	[Token(Token = "0x4002A69")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private TexasHoldEmUI texasHoldEmUI;

	// Token: 0x04003742 RID: 14146
	[Token(Token = "0x4002A6A")]
	[FieldOffset(Offset = "0x120")]
	private CardTable owner;

	// Token: 0x04003743 RID: 14147
	[Token(Token = "0x4002A6B")]
	[FieldOffset(Offset = "0x128")]
	private CardTableUI.UIState uiState;

	// Token: 0x04003744 RID: 14148
	[Token(Token = "0x4002A6C")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private CardTableUI.ICardGameSubUI <curGameTypeUI>k__BackingField;

	// Token: 0x04003745 RID: 14149
	[Token(Token = "0x4002A6D")]
	[FieldOffset(Offset = "0x138")]
	private int lastInputCount;

	// Token: 0x04003746 RID: 14150
	[Token(Token = "0x4002A6E")]
	[FieldOffset(Offset = "0x13C")]
	private TimeSince showInputTimer;

	// Token: 0x04003747 RID: 14151
	[Token(Token = "0x4002A6F")]
	private const float DismountTime = 1f;

	// Token: 0x04003748 RID: 14152
	[Token(Token = "0x4002A70")]
	[FieldOffset(Offset = "0x140")]
	private bool dismountInProgress;

	// Token: 0x04003749 RID: 14153
	[Token(Token = "0x4002A71")]
	[FieldOffset(Offset = "0x144")]
	private TimeSince dismountStart;

	// Token: 0x0400374A RID: 14154
	[Token(Token = "0x4002A72")]
	[FieldOffset(Offset = "0x148")]
	public CardTableUI.KeycodeWithAction dismountInput;

	// Token: 0x0400374B RID: 14155
	[Token(Token = "0x4002A73")]
	[FieldOffset(Offset = "0x168")]
	public List<CardTableUI.KeycodeWithAction> availableInputs;

	// Token: 0x0400374C RID: 14156
	[Token(Token = "0x4002A74")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<int, Sprite> largeCardImageDict;

	// Token: 0x0400374D RID: 14157
	[Token(Token = "0x4002A75")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<int, Sprite> smallCardImageDict;

	// Token: 0x0400374E RID: 14158
	[Token(Token = "0x4002A76")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<int, Sprite> transparentCardImageDict;

	// Token: 0x020009AB RID: 2475
	[Token(Token = "0x2000CE1")]
	[Serializable]
	public class PlayingCardImage
	{
		// Token: 0x06003AAC RID: 15020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public PlayingCardImage()
		{
		}

		// Token: 0x0400374F RID: 14159
		[Token(Token = "0x40049C6")]
		[FieldOffset(Offset = "0x10")]
		public Rank rank;

		// Token: 0x04003750 RID: 14160
		[Token(Token = "0x40049C7")]
		[FieldOffset(Offset = "0x14")]
		public Suit suit;

		// Token: 0x04003751 RID: 14161
		[Token(Token = "0x40049C8")]
		[FieldOffset(Offset = "0x18")]
		public Sprite image;

		// Token: 0x04003752 RID: 14162
		[Token(Token = "0x40049C9")]
		[FieldOffset(Offset = "0x20")]
		public Sprite imageSmall;

		// Token: 0x04003753 RID: 14163
		[Token(Token = "0x40049CA")]
		[FieldOffset(Offset = "0x28")]
		public Sprite imageTransparent;
	}

	// Token: 0x020009AC RID: 2476
	[Token(Token = "0x2000CE2")]
	[Serializable]
	public class InfoTextUI
	{
		// Token: 0x06003AAD RID: 15021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public InfoTextUI()
		{
		}

		// Token: 0x04003754 RID: 14164
		[Token(Token = "0x40049CB")]
		[FieldOffset(Offset = "0x10")]
		public GameObject gameObj;

		// Token: 0x04003755 RID: 14165
		[Token(Token = "0x40049CC")]
		[FieldOffset(Offset = "0x18")]
		public RustText rustText;

		// Token: 0x04003756 RID: 14166
		[Token(Token = "0x40049CD")]
		[FieldOffset(Offset = "0x20")]
		public Image background;

		// Token: 0x020009AD RID: 2477
		[Token(Token = "0x2000E75")]
		public enum Attitude
		{
			// Token: 0x04003758 RID: 14168
			[Token(Token = "0x400503A")]
			Neutral,
			// Token: 0x04003759 RID: 14169
			[Token(Token = "0x400503B")]
			Good,
			// Token: 0x0400375A RID: 14170
			[Token(Token = "0x400503C")]
			Bad
		}
	}

	// Token: 0x020009AE RID: 2478
	[Token(Token = "0x2000CE3")]
	public interface ICardGameSubUI
	{
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06003AAE RID: 15022
		[Token(Token = "0x1700077F")]
		int DynamicBetAmount { [Token(Token = "0x60050AB")] get; }

		// Token: 0x06003AAF RID: 15023
		[Token(Token = "0x60050AC")]
		void UpdateInGameUI(CardTableUI ui, CardGameController game);

		// Token: 0x06003AB0 RID: 15024
		[Token(Token = "0x60050AD")]
		string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude);

		// Token: 0x06003AB1 RID: 15025
		[Token(Token = "0x60050AE")]
		void UpdateInGameUI_NoPlayer(CardTableUI ui);
	}

	// Token: 0x020009AF RID: 2479
	[Token(Token = "0x2000CE4")]
	public enum UIState
	{
		// Token: 0x0400375C RID: 14172
		[Token(Token = "0x40049CF")]
		None,
		// Token: 0x0400375D RID: 14173
		[Token(Token = "0x40049D0")]
		Loading,
		// Token: 0x0400375E RID: 14174
		[Token(Token = "0x40049D1")]
		WaitingForNextRound,
		// Token: 0x0400375F RID: 14175
		[Token(Token = "0x40049D2")]
		Playing,
		// Token: 0x04003760 RID: 14176
		[Token(Token = "0x40049D3")]
		CannotJoin,
		// Token: 0x04003761 RID: 14177
		[Token(Token = "0x40049D4")]
		NotEnoughPlayers
	}

	// Token: 0x020009B0 RID: 2480
	[Token(Token = "0x2000CE5")]
	public struct KeycodeWithAction
	{
		// Token: 0x06003AB2 RID: 15026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AF")]
		[Address(RVA = "0xEF950", Offset = "0xEED50", VA = "0x1800EF950")]
		public KeycodeWithAction(KeyCode keyCode, Action action, Translate.Phrase displayPhrase, string extraString)
		{
		}

		// Token: 0x04003762 RID: 14178
		[Token(Token = "0x40049D5")]
		[FieldOffset(Offset = "0x0")]
		public KeyCode keyCode;

		// Token: 0x04003763 RID: 14179
		[Token(Token = "0x40049D6")]
		[FieldOffset(Offset = "0x8")]
		public Action action;

		// Token: 0x04003764 RID: 14180
		[Token(Token = "0x40049D7")]
		[FieldOffset(Offset = "0x10")]
		public Translate.Phrase display;

		// Token: 0x04003765 RID: 14181
		[Token(Token = "0x40049D8")]
		[FieldOffset(Offset = "0x18")]
		public string extraString;
	}

	// Token: 0x020009B1 RID: 2481
	[Token(Token = "0x2000CE6")]
	public enum CardType
	{
		// Token: 0x04003767 RID: 14183
		[Token(Token = "0x40049DA")]
		Large,
		// Token: 0x04003768 RID: 14184
		[Token(Token = "0x40049DB")]
		Small,
		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x40049DC")]
		LargeTransparent
	}
}
