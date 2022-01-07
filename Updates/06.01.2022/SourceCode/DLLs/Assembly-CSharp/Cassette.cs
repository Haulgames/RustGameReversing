using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200011F RID: 287
[Token(Token = "0x20000AA")]
public class Cassette : BaseEntity
{
	// Token: 0x0600114F RID: 4431 RVA: 0x0000A320 File Offset: 0x00008520
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x4D4FB0", Offset = "0x4D3DB0", VA = "0x1804D4FB0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x4D5780", Offset = "0x4D4580", VA = "0x1804D5780")]
	public static void RequestAudioLoad(byte[] data, Action<AudioClip, bool> onComplete, BaseEntity targetEntity)
	{
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x4D5BF0", Offset = "0x4D49F0", VA = "0x1804D5BF0")]
	public static void RunCassetteQueue()
	{
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x4D4990", Offset = "0x4D3790", VA = "0x1804D4990")]
	private static void LoadAudio(byte[] data, Action<AudioClip, bool> onComplete)
	{
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06001153 RID: 4435 RVA: 0x0000A338 File Offset: 0x00008538
	// (set) Token: 0x06001154 RID: 4436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700015D")]
	public uint AudioId
	{
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x4D61A0", Offset = "0x4D4FA0", VA = "0x1804D61A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x4D61F0", Offset = "0x4D4FF0", VA = "0x1804D61F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06001155 RID: 4437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015E")]
	public SoundDefinition PreloadedAudio
	{
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x4D61B0", Offset = "0x4D4FB0", VA = "0x1804D61B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x4D4C90", Offset = "0x4D3A90", VA = "0x1804D4C90", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x4D4E90", Offset = "0x4D3C90", VA = "0x1804D4E90", Slot = "81")]
	public override void OnParentChangingClient(Transform oldParent, Transform newParent)
	{
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x4D3F60", Offset = "0x4D2D60", VA = "0x1804D3F60")]
	private void ForceLoadNotify()
	{
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x4D5E20", Offset = "0x4D4C20", VA = "0x1804D5E20")]
	public void WriteNewAudio(byte[] data, Action<AudioClip> onAudioReady, ulong userSteamId)
	{
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x4D5920", Offset = "0x4D4720", VA = "0x1804D5920")]
	public void RequestFileUpdate(Action<AudioClip> onAudioReady)
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x4D3C20", Offset = "0x4D2A20", VA = "0x1804D3C20")]
	[BaseEntity.RPC_Client]
	public void Client_ReceiveAudio(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x4D3ED0", Offset = "0x4D2CD0", VA = "0x1804D3ED0")]
	[BaseEntity.RPC_Client]
	private void FailedNetworkFileRequest(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x0000A350 File Offset: 0x00008550
	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x4D4650", Offset = "0x4D3450", VA = "0x1804D4650")]
	public static bool IsOggValid(byte[] data, Cassette c)
	{
		return default(bool);
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x0000A368 File Offset: 0x00008568
	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x4D4820", Offset = "0x4D3620", VA = "0x1804D4820")]
	private static bool IsOggValid(byte[] data, float maxLength)
	{
		return default(bool);
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x0000A380 File Offset: 0x00008580
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x4D3C00", Offset = "0x4D2A00", VA = "0x1804D3C00")]
	private static float ByteToMegabyte(int byteSize)
	{
		return 0f;
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x0000A398 File Offset: 0x00008598
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x4D4010", Offset = "0x4D2E10", VA = "0x1804D4010")]
	private static double GetOggLength(byte[] t)
	{
		return 0.0;
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x4D6130", Offset = "0x4D4F30", VA = "0x1804D6130")]
	public Cassette()
	{
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x4D5D50", Offset = "0x4D4B50", VA = "0x1804D5D50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <Client_ReceiveAudio>b__32_0(AudioClip clip, bool success)
	{
	}

	// Token: 0x04000BD0 RID: 3024
	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x0")]
	private static List<Cassette.LoadRequest> loadQueue;

	// Token: 0x04000BD1 RID: 3025
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x8")]
	private static bool isLoading;

	// Token: 0x04000BD2 RID: 3026
	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x160")]
	public float MaxCassetteLength;

	// Token: 0x04000BD3 RID: 3027
	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0xC")]
	[ReplicatedVar]
	public static float MaxCassetteFileSizeMB;

	// Token: 0x04000BD4 RID: 3028
	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x164")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private uint <AudioId>k__BackingField;

	// Token: 0x04000BD5 RID: 3029
	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x168")]
	public ulong CreatorSteamId;

	// Token: 0x04000BD6 RID: 3030
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x170")]
	public PreloadedCassetteContent.PreloadType PreloadType;

	// Token: 0x04000BD7 RID: 3031
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x178")]
	public PreloadedCassetteContent PreloadContent;

	// Token: 0x04000BD8 RID: 3032
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x180")]
	public SoundDefinition InsertCassetteSfx;

	// Token: 0x04000BD9 RID: 3033
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x188")]
	public int ViewmodelIndex;

	// Token: 0x04000BDA RID: 3034
	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x190")]
	public Sprite HudSprite;

	// Token: 0x04000BDB RID: 3035
	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x198")]
	public int MaximumVoicemailSlots;

	// Token: 0x04000BDC RID: 3036
	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x19C")]
	private int preloadedAudioId;

	// Token: 0x04000BDD RID: 3037
	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x1A0")]
	private uint cachedId;

	// Token: 0x04000BDE RID: 3038
	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x1A8")]
	private AudioClip cachedClip;

	// Token: 0x04000BDF RID: 3039
	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x1B0")]
	private bool notifyOnLoad;

	// Token: 0x04000BE0 RID: 3040
	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0x1B8")]
	private Action<AudioClip> audioLoadFromServerCallback;

	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000AAD")]
	private struct LoadRequest
	{
		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4003F80")]
		[FieldOffset(Offset = "0x0")]
		public byte[] Data;

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4003F81")]
		[FieldOffset(Offset = "0x8")]
		public Action<AudioClip, bool> Callback;

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4003F82")]
		[FieldOffset(Offset = "0x10")]
		public BaseEntity ForEntity;
	}

	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000AAE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass29_0
	{
		// Token: 0x06001164 RID: 4452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass29_0()
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x4F2F80", Offset = "0x4F1D80", VA = "0x1804F2F80")]
		internal void <WriteNewAudio>b__0(AudioClip clip, bool success)
		{
		}

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4003F83")]
		[FieldOffset(Offset = "0x10")]
		public Cassette <>4__this;

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4003F84")]
		[FieldOffset(Offset = "0x18")]
		public Action<AudioClip> onAudioReady;
	}

	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000AAF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x4F3070", Offset = "0x4F1E70", VA = "0x1804F3070")]
		internal void <RequestFileUpdate>b__0(AudioClip clip, bool success)
		{
		}

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4003F85")]
		[FieldOffset(Offset = "0x10")]
		public Cassette <>4__this;

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4003F86")]
		[FieldOffset(Offset = "0x18")]
		public byte[] data;

		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4003F87")]
		[FieldOffset(Offset = "0x20")]
		public Action<AudioClip> onAudioReady;
	}
}
