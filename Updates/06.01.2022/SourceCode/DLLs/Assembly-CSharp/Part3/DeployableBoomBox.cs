using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000087 RID: 135
[Token(Token = "0x200004E")]
public class DeployableBoomBox : ContainerIOEntity, ICassettePlayer, IAudioConnectionSource
{
	// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000534")]
	[Address(RVA = "0xB631B0", Offset = "0xB61FB0", VA = "0x180B631B0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x0600098D RID: 2445 RVA: 0x000055F8 File Offset: 0x000037F8
	[Token(Token = "0x17000091")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000535")]
		[Address(RVA = "0xB651D0", Offset = "0xB63FD0", VA = "0x180B651D0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00005610 File Offset: 0x00003810
	[Token(Token = "0x6000536")]
	[Address(RVA = "0xB63C20", Offset = "0xB62A20", VA = "0x180B63C20", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000092")]
	public BaseEntity ToBaseEntity
	{
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x3212A0", Offset = "0x3200A0", VA = "0x1803212A0", Slot = "164")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000538")]
	[Address(RVA = "0xB647B0", Offset = "0xB635B0", VA = "0x180B647B0")]
	[Attribute(Name = "Menu", RVA = "0xC5560", Offset = "0xC4960")]
	[Attribute(Name = "Description", RVA = "0xC5560", Offset = "0xC4960")]
	[Attribute(Name = "Icon", RVA = "0xC5560", Offset = "0xC4960")]
	[Attribute(Name = "ShowIf", RVA = "0xC5560", Offset = "0xC4960")]
	public void Play(BasePlayer forPlayer)
	{
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000539")]
	[Address(RVA = "0xB64F60", Offset = "0xB63D60", VA = "0x180B64F60")]
	[Attribute(Name = "Menu", RVA = "0xC5880", Offset = "0xC4C80")]
	[Attribute(Name = "Description", RVA = "0xC5880", Offset = "0xC4C80")]
	[Attribute(Name = "Icon", RVA = "0xC5880", Offset = "0xC4C80")]
	[Attribute(Name = "ShowIf", RVA = "0xC5880", Offset = "0xC4C80")]
	public void Stop(BasePlayer forPlayer)
	{
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00005628 File Offset: 0x00003828
	[Token(Token = "0x600053A")]
	[Address(RVA = "0xB62EB0", Offset = "0xB61CB0", VA = "0x180B62EB0")]
	private bool CanStop(BasePlayer forPlayer)
	{
		return default(bool);
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00005640 File Offset: 0x00003840
	[Token(Token = "0x600053B")]
	[Address(RVA = "0xB62E80", Offset = "0xB61C80", VA = "0x180B62E80")]
	private bool CanStart(BasePlayer forPlayer)
	{
		return default(bool);
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053C")]
	[Address(RVA = "0xB62EE0", Offset = "0xB61CE0", VA = "0x180B62EE0")]
	[Attribute(Name = "Menu", RVA = "0xC5BB0", Offset = "0xC4FB0")]
	[Attribute(Name = "Description", RVA = "0xC5BB0", Offset = "0xC4FB0")]
	[Attribute(Name = "Icon", RVA = "0xC5BB0", Offset = "0xC4FB0")]
	[Attribute(Name = "ShowIf", RVA = "0xC5BB0", Offset = "0xC4FB0")]
	public void ChangeRadioSettings(BasePlayer player)
	{
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00005658 File Offset: 0x00003858
	[Token(Token = "0x600053D")]
	[Address(RVA = "0xB62E50", Offset = "0xB61C50", VA = "0x180B62E50")]
	private bool CanChangeRadioSettings(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053E")]
	[Address(RVA = "0xB63B50", Offset = "0xB62950", VA = "0x180B63B50", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053F")]
	[Address(RVA = "0xB62F60", Offset = "0xB61D60", VA = "0x180B62F60")]
	[BaseEntity.RPC_Client]
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000540")]
	[Address(RVA = "0xB62FA0", Offset = "0xB61DA0", VA = "0x180B62FA0")]
	[BaseEntity.RPC_Client]
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000541")]
	[Address(RVA = "0xB63BE0", Offset = "0xB629E0", VA = "0x180B63BE0")]
	[BaseEntity.RPC_Client]
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000542")]
	[Address(RVA = "0xB64F90", Offset = "0xB63D90", VA = "0x180B64F90")]
	public void WaitForShoutcastLoad()
	{
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000543")]
	[Address(RVA = "0xB62F10", Offset = "0xB61D10", VA = "0x180B62F10")]
	public void ClearConnectedPositions()
	{
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000544")]
	[Address(RVA = "0xB647E0", Offset = "0xB635E0", VA = "0x180B647E0")]
	public void SetAudioClipOnAttachedSpeakers(IOEntity entity, AudioClip clip, float time, int depth, [Optional] ShoutcastStreamer streamer)
	{
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00005670 File Offset: 0x00003870
	[Token(Token = "0x6000545")]
	[Address(RVA = "0xB639B0", Offset = "0xB627B0", VA = "0x180B639B0")]
	private bool IsPositionValidForSpeaker(Vector3 pos)
	{
		return default(bool);
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000546")]
	[Address(RVA = "0xB64C20", Offset = "0xB63A20", VA = "0x180B64C20", Slot = "167")]
	public void SpeakerConnected(ConnectedSpeaker speaker)
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000547")]
	[Address(RVA = "0xB64E80", Offset = "0xB63C80", VA = "0x180B64E80", Slot = "168")]
	public void SpeakerDisconnected(ConnectedSpeaker repeater)
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000548")]
	[Address(RVA = "0xB63990", Offset = "0xB62790", VA = "0x180B63990", Slot = "169")]
	public AudioSource GetSource()
	{
		return null;
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00005688 File Offset: 0x00003888
	[Token(Token = "0x17000093")]
	public float VolumeVisualisationMultiplier
	{
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2F7A50", Offset = "0x2F6850", VA = "0x1802F7A50", Slot = "170")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054A")]
	[Address(RVA = "0xB63BB0", Offset = "0xB629B0", VA = "0x180B63BB0", Slot = "165")]
	public void OnLoadedWithCassette(Cassette c)
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054B")]
	[Address(RVA = "0xB63B20", Offset = "0xB62920", VA = "0x180B63B20", Slot = "166")]
	public void OnCensorRecordingsChanged()
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x600054C")]
	[Address(RVA = "0xB62FF0", Offset = "0xB61DF0", VA = "0x180B62FF0")]
	public float GetClosestDistance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x000056B8 File Offset: 0x000038B8
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "171")]
	public float GetFakeInput()
	{
		return 0f;
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054E")]
	[Address(RVA = "0xB646E0", Offset = "0xB634E0", VA = "0x180B646E0")]
	public void OnStreamChangedByCensorSetting(bool connectingToStream)
	{
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x717AB0", Offset = "0x7168B0", VA = "0x180717AB0", Slot = "130")]
	public override bool DisplayHealthInfo(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x3212A0", Offset = "0x3200A0", VA = "0x1803212A0", Slot = "172")]
	public IOEntity ToEntity()
	{
		return null;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x000056E8 File Offset: 0x000038E8
	[Token(Token = "0x6000551")]
	[Address(RVA = "0xB62FE0", Offset = "0xB61DE0", VA = "0x180B62FE0", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000552")]
	[Address(RVA = "0xB63AC0", Offset = "0xB628C0", VA = "0x180B63AC0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000553")]
	[Address(RVA = "0xB65150", Offset = "0xB63F50", VA = "0x180B65150")]
	public DeployableBoomBox()
	{
	}

	// Token: 0x04000519 RID: 1305
	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private Option __menuOption_ChangeRadioSettings;

	// Token: 0x0400051A RID: 1306
	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	private Option __menuOption_Play;

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	private Option __menuOption_Stop;

	// Token: 0x0400051C RID: 1308
	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
	public BoomBox BoxController;

	// Token: 0x0400051D RID: 1309
	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
	public int PowerUsageWhilePlaying;

	// Token: 0x0400051E RID: 1310
	[Token(Token = "0x4000431")]
	public const int MaxBacktrackHopsClient = 30;

	// Token: 0x0400051F RID: 1311
	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
	public bool IsStatic;

	// Token: 0x04000520 RID: 1312
	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
	private List<Vector3> connectedPositions;
}
