using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x020005FE RID: 1534
[Token(Token = "0x2000479")]
public class BaseGameMode : global::BaseEntity
{
	// Token: 0x06002AAE RID: 10926 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023BC")]
	[Address(RVA = "0x89AA40", Offset = "0x899840", VA = "0x18089AA40")]
	public GameMode GetGameScores()
	{
		return null;
	}

	// Token: 0x06002AAF RID: 10927 RVA: 0x000127B0 File Offset: 0x000109B0
	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x89C350", Offset = "0x89B150", VA = "0x18089C350")]
	public int ScoreColumnIndex(string scoreName)
	{
		return 0;
	}

	// Token: 0x06002AB0 RID: 10928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x89B790", Offset = "0x89A590", VA = "0x18089B790")]
	public void InitScores()
	{
	}

	// Token: 0x06002AB1 RID: 10929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x89A120", Offset = "0x898F20", VA = "0x18089A120")]
	public void CopyGameModeScores(GameMode from, GameMode to)
	{
	}

	// Token: 0x06002AB2 RID: 10930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C0")]
	[Address(RVA = "0x89ADB0", Offset = "0x899BB0", VA = "0x18089ADB0")]
	public GameMode.PlayerScore GetPlayerScoreForPlayer(global::BasePlayer player)
	{
		return null;
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x000127C8 File Offset: 0x000109C8
	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x89B040", Offset = "0x899E40", VA = "0x18089B040")]
	public int GetScoreIndexByName(string name)
	{
		return 0;
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x000127E0 File Offset: 0x000109E0
	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x89BD60", Offset = "0x89AB60", VA = "0x18089BD60", Slot = "130")]
	public virtual bool IsDraw()
	{
		return default(bool);
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x89B220", Offset = "0x89A020", VA = "0x18089B220", Slot = "131")]
	public virtual string GetWinnerName()
	{
		return null;
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x000127F8 File Offset: 0x000109F8
	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "132")]
	public virtual int GetPlayerTeamPosition(global::BasePlayer player)
	{
		return 0;
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x00012810 File Offset: 0x00010A10
	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x89ABA0", Offset = "0x8999A0", VA = "0x18089ABA0", Slot = "133")]
	public virtual int GetPlayerRank(global::BasePlayer player)
	{
		return 0;
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x00012828 File Offset: 0x00010A28
	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x89B4D0", Offset = "0x89A2D0", VA = "0x18089B4D0")]
	public int GetWinningTeamIndex()
	{
		return 0;
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x00012840 File Offset: 0x00010A40
	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x89A800", Offset = "0x899600", VA = "0x18089A800", Slot = "134")]
	public virtual bool DidPlayerWin(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x00012858 File Offset: 0x00010A58
	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x89C030", Offset = "0x89AE30", VA = "0x18089C030")]
	public bool IsTeamGame()
	{
		return default(bool);
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x00012870 File Offset: 0x00010A70
	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x89C070", Offset = "0x89AE70", VA = "0x18089C070")]
	public bool KeepScores()
	{
		return default(bool);
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06002ABC RID: 10940 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06002ABD RID: 10941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000003")]
	public static event Action<BaseGameMode> GameModeChanged
	{
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x89CA50", Offset = "0x89B850", VA = "0x18089CA50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		add
		{
		}
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x89CB40", Offset = "0x89B940", VA = "0x18089CB40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		remove
		{
		}
	}

	// Token: 0x06002ABE RID: 10942 RVA: 0x00012888 File Offset: 0x00010A88
	[Token(Token = "0x60023CC")]
	[Address(RVA = "0x89B5D0", Offset = "0x89A3D0", VA = "0x18089B5D0")]
	public bool HasAnyGameModeTag(string[] tags)
	{
		return default(bool);
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x000128A0 File Offset: 0x00010AA0
	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x89B6A0", Offset = "0x89A4A0", VA = "0x18089B6A0")]
	public bool HasGameModeTag(string tag)
	{
		return default(bool);
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x000128B8 File Offset: 0x00010AB8
	[Token(Token = "0x60023CE")]
	[Address(RVA = "0x89B750", Offset = "0x89A550", VA = "0x18089B750")]
	public bool HasLoadouts()
	{
		return default(bool);
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x000128D0 File Offset: 0x00010AD0
	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x89AB70", Offset = "0x899970", VA = "0x18089AB70")]
	public int GetNumTeams()
	{
		return 0;
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x000128E8 File Offset: 0x00010AE8
	[Token(Token = "0x60023D0")]
	[Address(RVA = "0x89B150", Offset = "0x899F50", VA = "0x18089B150")]
	public int GetTeamScore(int teamIndex)
	{
		return 0;
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x89C400", Offset = "0x89B200", VA = "0x18089C400")]
	public static void SetActiveGameMode(BaseGameMode newActive, bool serverside)
	{
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x89A9E0", Offset = "0x8997E0", VA = "0x18089A9E0")]
	public static BaseGameMode GetActiveGameMode(bool serverside)
	{
		return null;
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x89C0A0", Offset = "0x89AEA0", VA = "0x18089C0A0", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x00012900 File Offset: 0x00010B00
	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x89B780", Offset = "0x89A580", VA = "0x18089B780", Slot = "135")]
	public virtual bool InWarmup()
	{
		return default(bool);
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x00012918 File Offset: 0x00010B18
	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x89C060", Offset = "0x89AE60", VA = "0x18089C060", Slot = "136")]
	public virtual bool IsWaitingForPlayers()
	{
		return default(bool);
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x00012930 File Offset: 0x00010B30
	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x89C020", Offset = "0x89AE20", VA = "0x18089C020", Slot = "137")]
	public virtual bool IsMatchOver()
	{
		return default(bool);
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x00012948 File Offset: 0x00010B48
	[Token(Token = "0x60023D7")]
	[Address(RVA = "0x89BFB0", Offset = "0x89ADB0", VA = "0x18089BFB0", Slot = "138")]
	public virtual bool IsMatchActive()
	{
		return default(bool);
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D8")]
	[Address(RVA = "0x89B9F0", Offset = "0x89A7F0", VA = "0x18089B9F0", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x89A6D0", Offset = "0x8994D0", VA = "0x18089A6D0", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x89C110", Offset = "0x89AF10", VA = "0x18089C110", Slot = "139")]
	protected virtual void OnCreated()
	{
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x89C180", Offset = "0x89AF80", VA = "0x18089C180", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x89A030", Offset = "0x898E30", VA = "0x18089A030", Slot = "140")]
	protected virtual void ClientWarmupStart()
	{
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DD")]
	[Address(RVA = "0x899F20", Offset = "0x898D20", VA = "0x180899F20", Slot = "141")]
	protected virtual void ClientMatchEnd()
	{
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DE")]
	[Address(RVA = "0x89A010", Offset = "0x898E10", VA = "0x18089A010", Slot = "142")]
	protected virtual void ClientMatchStart()
	{
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023DF")]
	[Address(RVA = "0x89B1C0", Offset = "0x899FC0", VA = "0x18089B1C0", Slot = "143")]
	public virtual SoundDefinition GetWarmupMusic()
	{
		return null;
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E0")]
	[Address(RVA = "0x89AA50", Offset = "0x899850", VA = "0x18089AA50", Slot = "144")]
	public virtual SoundDefinition GetMatchEndMusic()
	{
		return null;
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x00012960 File Offset: 0x00010B60
	[Token(Token = "0x60023E1")]
	[Address(RVA = "0x89C720", Offset = "0x89B520", VA = "0x18089C720")]
	public float TimeUntilWarmupEnds()
	{
		return 0f;
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x00012978 File Offset: 0x00010B78
	[Token(Token = "0x60023E2")]
	[Address(RVA = "0x89C650", Offset = "0x89B450", VA = "0x18089C650")]
	public float TimeUntilMatchResets()
	{
		return 0f;
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x00012990 File Offset: 0x00010B90
	[Token(Token = "0x60023E3")]
	[Address(RVA = "0x89C580", Offset = "0x89B380", VA = "0x18089C580")]
	public float TimeUntilMatchEnds()
	{
		return 0f;
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E4")]
	[Address(RVA = "0x89C880", Offset = "0x89B680", VA = "0x18089C880")]
	public BaseGameMode()
	{
	}

	// Token: 0x040025CD RID: 9677
	[Token(Token = "0x4001ED5")]
	[FieldOffset(Offset = "0x160")]
	private GameMode gameModeScores;

	// Token: 0x040025CE RID: 9678
	[Token(Token = "0x4001ED6")]
	[FieldOffset(Offset = "0x168")]
	public string[] scoreColumns;

	// Token: 0x040025CF RID: 9679
	[Token(Token = "0x4001ED7")]
	public const global::BaseEntity.Flags Flag_Warmup = global::BaseEntity.Flags.Reserved1;

	// Token: 0x040025D0 RID: 9680
	[Token(Token = "0x4001ED8")]
	public const global::BaseEntity.Flags Flag_GameOver = global::BaseEntity.Flags.Reserved2;

	// Token: 0x040025D1 RID: 9681
	[Token(Token = "0x4001ED9")]
	public const global::BaseEntity.Flags Flag_WaitingForPlayers = global::BaseEntity.Flags.Reserved3;

	// Token: 0x040025D3 RID: 9683
	[Token(Token = "0x4001EDB")]
	[FieldOffset(Offset = "0x170")]
	public string shortname;

	// Token: 0x040025D4 RID: 9684
	[Token(Token = "0x4001EDC")]
	[FieldOffset(Offset = "0x178")]
	public float matchDuration;

	// Token: 0x040025D5 RID: 9685
	[Token(Token = "0x4001EDD")]
	[FieldOffset(Offset = "0x17C")]
	public float warmupDuration;

	// Token: 0x040025D6 RID: 9686
	[Token(Token = "0x4001EDE")]
	[FieldOffset(Offset = "0x180")]
	public float timeBetweenMatches;

	// Token: 0x040025D7 RID: 9687
	[Token(Token = "0x4001EDF")]
	[FieldOffset(Offset = "0x184")]
	public int minPlayersToStart;

	// Token: 0x040025D8 RID: 9688
	[Token(Token = "0x4001EE0")]
	[FieldOffset(Offset = "0x188")]
	public bool useCustomSpawns;

	// Token: 0x040025D9 RID: 9689
	[Token(Token = "0x4001EE1")]
	[FieldOffset(Offset = "0x190")]
	public string victoryScoreName;

	// Token: 0x040025DA RID: 9690
	[Token(Token = "0x4001EE2")]
	[FieldOffset(Offset = "0x198")]
	public string teamScoreName;

	// Token: 0x040025DB RID: 9691
	[Token(Token = "0x4001EE3")]
	[FieldOffset(Offset = "0x1A0")]
	public int numScoreForVictory;

	// Token: 0x040025DC RID: 9692
	[Token(Token = "0x4001EE4")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObjectRef startingWeapon;

	// Token: 0x040025DD RID: 9693
	[Token(Token = "0x4001EE5")]
	[FieldOffset(Offset = "0x1B0")]
	public string gamemodeTitle;

	// Token: 0x040025DE RID: 9694
	[Token(Token = "0x4001EE6")]
	[FieldOffset(Offset = "0x1B8")]
	public SoundDefinition[] warmupMusics;

	// Token: 0x040025DF RID: 9695
	[Token(Token = "0x4001EE7")]
	[FieldOffset(Offset = "0x1C0")]
	public SoundDefinition[] lossMusics;

	// Token: 0x040025E0 RID: 9696
	[Token(Token = "0x4001EE8")]
	[FieldOffset(Offset = "0x1C8")]
	public SoundDefinition[] winMusics;

	// Token: 0x040025E1 RID: 9697
	[Token(Token = "0x4001EE9")]
	[FieldOffset(Offset = "0x1D0")]
	[NonSerialized]
	private float warmupStartTime;

	// Token: 0x040025E2 RID: 9698
	[Token(Token = "0x4001EEA")]
	[FieldOffset(Offset = "0x1D4")]
	[NonSerialized]
	private float matchStartTime;

	// Token: 0x040025E3 RID: 9699
	[Token(Token = "0x4001EEB")]
	[FieldOffset(Offset = "0x1D8")]
	[NonSerialized]
	private float matchEndTime;

	// Token: 0x040025E4 RID: 9700
	[Token(Token = "0x4001EEC")]
	[FieldOffset(Offset = "0x1E0")]
	public string[] gameModeTags;

	// Token: 0x040025E5 RID: 9701
	[Token(Token = "0x4001EED")]
	[FieldOffset(Offset = "0x1E8")]
	public bool permanent;

	// Token: 0x040025E6 RID: 9702
	[Token(Token = "0x4001EEE")]
	[FieldOffset(Offset = "0x1E9")]
	public bool limitTeamAuths;

	// Token: 0x040025E7 RID: 9703
	[Token(Token = "0x4001EEF")]
	[FieldOffset(Offset = "0x8")]
	public static BaseGameMode clActiveGameMode;

	// Token: 0x040025E8 RID: 9704
	[Token(Token = "0x4001EF0")]
	[FieldOffset(Offset = "0x10")]
	public static List<BaseGameMode> clGameModeManifest;

	// Token: 0x040025E9 RID: 9705
	[Token(Token = "0x4001EF1")]
	[FieldOffset(Offset = "0x1F0")]
	public PlayerInventoryProperties[] loadouts;

	// Token: 0x040025EA RID: 9706
	[Token(Token = "0x4001EF2")]
	[FieldOffset(Offset = "0x1F8")]
	public BaseGameMode.GameModeTeam[] teams;

	// Token: 0x040025EB RID: 9707
	[Token(Token = "0x4001EF3")]
	[FieldOffset(Offset = "0x200")]
	private bool wasInWarmup;

	// Token: 0x040025EC RID: 9708
	[Token(Token = "0x4001EF4")]
	[FieldOffset(Offset = "0x201")]
	private bool wasMatchOver;

	// Token: 0x040025ED RID: 9709
	[Token(Token = "0x4001EF5")]
	[FieldOffset(Offset = "0x202")]
	private bool wasMatchActive;

	// Token: 0x020005FF RID: 1535
	[Token(Token = "0x2000BB8")]
	[Serializable]
	public class GameModeTeam
	{
		// Token: 0x06002AD8 RID: 10968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6E")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public GameModeTeam()
		{
		}

		// Token: 0x040025EE RID: 9710
		[Token(Token = "0x4004402")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040025EF RID: 9711
		[Token(Token = "0x4004403")]
		[FieldOffset(Offset = "0x18")]
		public PlayerInventoryProperties[] teamloadouts;
	}
}
