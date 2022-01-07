using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200046C RID: 1132
[Token(Token = "0x2000343")]
public class BoomBox : EntityComponent<BaseEntity>, INotifyLOD
{
	// Token: 0x060022C3 RID: 8899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x461D70", Offset = "0x460B70", VA = "0x180461D70")]
	public static void LoadStations()
	{
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x4617F0", Offset = "0x4605F0", VA = "0x1804617F0")]
	private static string GetStationData()
	{
		return null;
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x461C40", Offset = "0x460A40", VA = "0x180461C40")]
	private static bool IsStationValid(string url)
	{
		return default(bool);
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x462A90", Offset = "0x461890", VA = "0x180462A90")]
	public static void ParseServerUrlList()
	{
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x463060", Offset = "0x461E60", VA = "0x180463060")]
	public static void ResetServerValidStations()
	{
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x060022C8 RID: 8904 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060022C9 RID: 8905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000256")]
	public string CurrentRadioIp
	{
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x326940", Offset = "0x325740", VA = "0x180326940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x442C90", Offset = "0x441A90", VA = "0x180442C90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x4613A0", Offset = "0x4601A0", VA = "0x1804613A0")]
	public void ChangeRadioSettings(BasePlayer player)
	{
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x462350", Offset = "0x461150", VA = "0x180462350")]
	public void OnChangedBoomBoxSettings(string newIP)
	{
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x4610C0", Offset = "0x45FEC0", VA = "0x1804610C0")]
	public bool CanChangeRadioSettings(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x462A40", Offset = "0x461840", VA = "0x180462A40")]
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x060022CE RID: 8910 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
	[Token(Token = "0x17000257")]
	private bool IsLocalPlayer
	{
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x4635F0", Offset = "0x4623F0", VA = "0x1804635F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x461FD0", Offset = "0x460DD0", VA = "0x180461FD0")]
	public void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000258")]
	public BaseEntity BaseEntity
	{
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x4635B0", Offset = "0x4623B0", VA = "0x1804635B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000259")]
	public Cassette CurrentCassette
	{
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x2F3810", Offset = "0x2F2610", VA = "0x1802F3810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x4637E0", Offset = "0x4625E0", VA = "0x1804637E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x462E10", Offset = "0x461C10", VA = "0x180462E10")]
	public void Play(BasePlayer forPlayer)
	{
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x463280", Offset = "0x462080", VA = "0x180463280")]
	public void Stop(BasePlayer forPlayer)
	{
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
	[Token(Token = "0x6001C89")]
	[Address(RVA = "0x461300", Offset = "0x460100", VA = "0x180461300")]
	public bool CanStop(BasePlayer forPlayer)
	{
		return default(bool);
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x0000FB10 File Offset: 0x0000DD10
	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x461250", Offset = "0x460050", VA = "0x180461250")]
	public bool CanStart(BasePlayer forPlayer)
	{
		return default(bool);
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x0000FB28 File Offset: 0x0000DD28
	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x461930", Offset = "0x460730", VA = "0x180461930")]
	private bool HasTape()
	{
		return default(bool);
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x463410", Offset = "0x462210", VA = "0x180463410")]
	private void UpdateAudioClip(AudioClip clip)
	{
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x461600", Offset = "0x460400", VA = "0x180461600")]
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C8E")]
	[Address(RVA = "0x4617A0", Offset = "0x4605A0", VA = "0x1804617A0")]
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x4623C0", Offset = "0x4611C0", VA = "0x1804623C0")]
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next, [Optional] DeployableBoomBox deployable)
	{
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C90")]
	[Address(RVA = "0x462030", Offset = "0x460E30", VA = "0x180462030")]
	private void LocalPlayerRadioTick()
	{
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x462FA0", Offset = "0x461DA0", VA = "0x180462FA0")]
	public void RequestCassetteAudioUpdate()
	{
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x4629B0", Offset = "0x4617B0", VA = "0x1804629B0")]
	public void OnLoadedWithCassette(Cassette c)
	{
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x462290", Offset = "0x461090", VA = "0x180462290")]
	public void OnCensorRecordingsChanged()
	{
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x4631A0", Offset = "0x461FA0", VA = "0x1804631A0", Slot = "10")]
	public void Show()
	{
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x461990", Offset = "0x460790", VA = "0x180461990", Slot = "11")]
	public void Hide()
	{
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x0000FB40 File Offset: 0x0000DD40
	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x461B00", Offset = "0x460900", VA = "0x180461B00")]
	private bool IsPowered()
	{
		return default(bool);
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x0000FB58 File Offset: 0x0000DD58
	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x461A50", Offset = "0x460850", VA = "0x180461A50")]
	private bool IsOn()
	{
		return default(bool);
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x0000FB70 File Offset: 0x0000DD70
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x461870", Offset = "0x460670", VA = "0x180461870")]
	private bool HasFlag(BaseEntity.Flags f)
	{
		return default(bool);
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x4630D0", Offset = "0x461ED0", VA = "0x1804630D0")]
	private void SetFlag(BaseEntity.Flags f, bool state)
	{
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0000FB88 File Offset: 0x0000DD88
	[Token(Token = "0x1700025A")]
	private bool isClient
	{
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x463730", Offset = "0x462530", VA = "0x180463730")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0x463550", Offset = "0x462350", VA = "0x180463550")]
	public BoomBox()
	{
	}

	// Token: 0x04001D67 RID: 7527
	[Token(Token = "0x4001800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, string> ValidStations;

	// Token: 0x04001D68 RID: 7528
	[Token(Token = "0x4001801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<string, string> ServerValidStations;

	// Token: 0x04001D69 RID: 7529
	[Token(Token = "0x4001802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[ReplicatedVar]
	public static string ServerUrlList;

	// Token: 0x04001D6A RID: 7530
	[Token(Token = "0x4001803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string lastParsedServerList;

	// Token: 0x04001D6B RID: 7531
	[Token(Token = "0x4001804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ShoutcastStreamer ShoutcastStreamer;

	// Token: 0x04001D6C RID: 7532
	[Token(Token = "0x4001805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObjectRef RadioIpDialog;

	// Token: 0x04001D6D RID: 7533
	[Token(Token = "0x4001806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private string <CurrentRadioIp>k__BackingField;

	// Token: 0x04001D6E RID: 7534
	[Token(Token = "0x4001807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong AssignedRadioBy;

	// Token: 0x04001D6F RID: 7535
	[Token(Token = "0x4001808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource SoundSource;

	// Token: 0x04001D70 RID: 7536
	[Token(Token = "0x4001809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float ConditionLossRate;

	// Token: 0x04001D71 RID: 7537
	[Token(Token = "0x400180A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ItemDefinition[] ValidCassettes;

	// Token: 0x04001D72 RID: 7538
	[Token(Token = "0x400180B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public SoundDefinition PlaySfx;

	// Token: 0x04001D73 RID: 7539
	[Token(Token = "0x400180C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public SoundDefinition StopSfx;

	// Token: 0x04001D74 RID: 7540
	[Token(Token = "0x400180D")]
	public const BaseEntity.Flags HasCassette = BaseEntity.Flags.Reserved1;

	// Token: 0x04001D75 RID: 7541
	[Token(Token = "0x400180E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Cassette <CurrentCassette>k__BackingField;

	// Token: 0x04001D76 RID: 7542
	[Token(Token = "0x400180F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float localPlayerAchievementTime;

	// Token: 0x04001D77 RID: 7543
	[Token(Token = "0x4001810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool hasAwardedLocalPlayerAchievement;
}
