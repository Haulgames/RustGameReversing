using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000088 RID: 136
[Token(Token = "0x200004F")]
public class DeployedRecorder : StorageContainer, ICassettePlayer
{
	// Token: 0x060009AC RID: 2476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000554")]
	[Address(RVA = "0xB658A0", Offset = "0xB646A0", VA = "0x180B658A0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x060009AD RID: 2477 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x17000094")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000555")]
		[Address(RVA = "0xB66DB0", Offset = "0xB65BB0", VA = "0x180B66DB0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00005718 File Offset: 0x00003918
	[Token(Token = "0x6000556")]
	[Address(RVA = "0xB66130", Offset = "0xB64F30", VA = "0x180B66130", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000095")]
	public global::BaseEntity ToBaseEntity
	{
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x3212A0", Offset = "0x3200A0", VA = "0x1803212A0", Slot = "152")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000558")]
	[Address(RVA = "0xB65680", Offset = "0xB64480", VA = "0x180B65680", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000559")]
	[Address(RVA = "0xB66A40", Offset = "0xB65840", VA = "0x180B66A40")]
	[Attribute(Name = "Menu", RVA = "0xC5560", Offset = "0xC4960")]
	[Attribute(Name = "Description", RVA = "0xC5560", Offset = "0xC4960")]
	[Attribute(Name = "Icon", RVA = "0xC5560", Offset = "0xC4960")]
	[Attribute(Name = "ShowIf", RVA = "0xC5560", Offset = "0xC4960")]
	public void Play(global::BasePlayer forPlayer)
	{
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055A")]
	[Address(RVA = "0xB66B50", Offset = "0xB65950", VA = "0x180B66B50")]
	[Attribute(Name = "Menu", RVA = "0xC5880", Offset = "0xC4C80")]
	[Attribute(Name = "Description", RVA = "0xC5880", Offset = "0xC4C80")]
	[Attribute(Name = "Icon", RVA = "0xC5880", Offset = "0xC4C80")]
	[Attribute(Name = "ShowIf", RVA = "0xC5880", Offset = "0xC4C80")]
	public void Stop(global::BasePlayer forPlayer)
	{
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00005730 File Offset: 0x00003930
	[Token(Token = "0x600055B")]
	[Address(RVA = "0xB655F0", Offset = "0xB643F0", VA = "0x180B655F0")]
	private bool CanStop(global::BasePlayer forPlayer)
	{
		return default(bool);
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00005748 File Offset: 0x00003948
	[Token(Token = "0x600055C")]
	[Address(RVA = "0xB65560", Offset = "0xB64360", VA = "0x180B65560")]
	private bool CanStart(global::BasePlayer forPlayer)
	{
		return default(bool);
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00005760 File Offset: 0x00003960
	[Token(Token = "0x600055D")]
	[Address(RVA = "0xB65E00", Offset = "0xB64C00", VA = "0x180B65E00")]
	private bool HasTape()
	{
		return default(bool);
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055E")]
	[Address(RVA = "0xB66C00", Offset = "0xB65A00", VA = "0x180B66C00")]
	private void UpdateAudioClip(AudioClip clip)
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055F")]
	[Address(RVA = "0xB66C70", Offset = "0xB65A70", VA = "0x180B66C70")]
	private void UpdateCassetteMesh()
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000560")]
	[Address(RVA = "0xB656A0", Offset = "0xB644A0", VA = "0x180B656A0")]
	[global::BaseEntity.RPC_Client]
	public void Client_OnCassetteInserted(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000561")]
	[Address(RVA = "0xB65840", Offset = "0xB64640", VA = "0x180B65840")]
	[global::BaseEntity.RPC_Client]
	public void Client_OnCassetteRemoved(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000562")]
	[Address(RVA = "0xB65F20", Offset = "0xB64D20", VA = "0x180B65F20", Slot = "80")]
	public override void OnFlagsChanged(global::BaseEntity.Flags old, global::BaseEntity.Flags next)
	{
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000563")]
	[Address(RVA = "0xB66090", Offset = "0xB64E90", VA = "0x180B66090", Slot = "153")]
	public void OnLoadedWithCassette(global::Cassette c)
	{
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000564")]
	[Address(RVA = "0xB65E60", Offset = "0xB64C60", VA = "0x180B65E60", Slot = "154")]
	public void OnCensorRecordingsChanged()
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000565")]
	[Address(RVA = "0xB66AF0", Offset = "0xB658F0", VA = "0x180B66AF0", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000566")]
	[Address(RVA = "0xB66D50", Offset = "0xB65B50", VA = "0x180B66D50")]
	public DeployedRecorder()
	{
	}

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x3C8")]
	private Option __menuOption_Play;

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x420")]
	private Option __menuOption_Stop;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x478")]
	public AudioSource SoundSource;

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x480")]
	public ItemDefinition[] ValidCassettes;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x488")]
	public SoundDefinition PlaySfx;

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x490")]
	public SoundDefinition StopSfx;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x498")]
	public SwapKeycard TapeSwapper;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x4A0")]
	private global::Cassette cachedCassette;
}
