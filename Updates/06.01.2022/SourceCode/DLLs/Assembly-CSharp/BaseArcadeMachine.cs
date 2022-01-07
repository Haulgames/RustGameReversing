using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200004A RID: 74
[Token(Token = "0x2000034")]
public class BaseArcadeMachine : global::BaseVehicle
{
	// Token: 0x060005BD RID: 1469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x847CD0", Offset = "0x846AD0", VA = "0x180847CD0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060005BE RID: 1470 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x17000020")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x84A300", Offset = "0x849100", VA = "0x18084A300", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x848530", Offset = "0x847330", VA = "0x180848530", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x8480D0", Offset = "0x846ED0", VA = "0x1808480D0", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x84A230", Offset = "0x849030", VA = "0x18084A230", Slot = "170")]
	public override void UpdatePlayerModel(global::BasePlayer player)
	{
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x849FA0", Offset = "0x848DA0", VA = "0x180849FA0")]
	public void SpawnGame()
	{
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x8480C0", Offset = "0x846EC0", VA = "0x1808480C0", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x847270", Offset = "0x846070", VA = "0x180847270")]
	[global::BaseEntity.RPC_Client]
	public void BeginHosting(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x8476D0", Offset = "0x8464D0", VA = "0x1808476D0")]
	[global::BaseEntity.RPC_Client]
	public void EndHosting(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x8484A0", Offset = "0x8472A0", VA = "0x1808484A0")]
	[global::BaseEntity.RPC_Client]
	public void NoHost(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x847B90", Offset = "0x846990", VA = "0x180847B90")]
	[global::BaseEntity.RPC_Client]
	public void GetEntityMessage(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x847420", Offset = "0x846220", VA = "0x180847420", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x8477C0", Offset = "0x8465C0", VA = "0x1808477C0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x847980", Offset = "0x846780", VA = "0x180847980")]
	public void GameVisibilityChanged(bool isVisible)
	{
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x847430", Offset = "0x846230", VA = "0x180847430")]
	[global::BaseEntity.RPC_Client]
	public void DestroyEntity(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x847FE0", Offset = "0x846DE0", VA = "0x180847FE0")]
	[global::BaseEntity.RPC_Client]
	public void GetSnapshotFromServer(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x849EE0", Offset = "0x848CE0", VA = "0x180849EE0")]
	public void SendSnapshotToServer()
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x847600", Offset = "0x846400", VA = "0x180847600")]
	public void DoClientInput()
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x847540", Offset = "0x846340", VA = "0x180847540", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x849D60", Offset = "0x848B60", VA = "0x180849D60", Slot = "190")]
	public virtual void PlayerClientInput(InputState inputState)
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x849E90", Offset = "0x848C90", VA = "0x180849E90")]
	public void SendDestroyMessage(uint entityID)
	{
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "181")]
	public override bool MountMenuVisible(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x848460", Offset = "0x847260", VA = "0x180848460")]
	[Attribute(Name = "Menu", RVA = "0xA44C0", Offset = "0xA38C0")]
	[Attribute(Name = "Description", RVA = "0xA44C0", Offset = "0xA38C0")]
	[Attribute(Name = "Icon", RVA = "0xA44C0", Offset = "0xA38C0")]
	[Attribute(Name = "ShowIf", RVA = "0xA44C0", Offset = "0xA38C0")]
	public void Menu_Play(global::BasePlayer player)
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x848350", Offset = "0x847150", VA = "0x180848350")]
	public bool Menu_PlayGame_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "188")]
	protected override bool CanPushNow(global::BasePlayer pusher)
	{
		return default(bool);
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x84A240", Offset = "0x849040", VA = "0x18084A240")]
	public BaseArcadeMachine()
	{
	}

	// Token: 0x04000261 RID: 609
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_Play;

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x400")]
	public BaseArcadeGame arcadeGamePrefab;

	// Token: 0x04000263 RID: 611
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x408")]
	public BaseArcadeGame activeGame;

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x410")]
	public ArcadeNetworkTrigger networkTrigger;

	// Token: 0x04000265 RID: 613
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x418")]
	public float broadcastRadius;

	// Token: 0x04000266 RID: 614
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x420")]
	public Transform gameScreen;

	// Token: 0x04000267 RID: 615
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x428")]
	public RawImage RTImage;

	// Token: 0x04000268 RID: 616
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x430")]
	public Transform leftJoystick;

	// Token: 0x04000269 RID: 617
	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x438")]
	public Transform rightJoystick;

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x440")]
	public SoundPlayer musicPlayer;

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x400020D")]
	public const global::BaseEntity.Flags Flag_P1 = global::BaseEntity.Flags.Reserved7;

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400020E")]
	public const global::BaseEntity.Flags Flag_P2 = global::BaseEntity.Flags.Reserved8;

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x448")]
	public List<BaseArcadeMachine.ScoreEntry> scores;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x4000210")]
	private const int inputFrameRate = 60;

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x4000211")]
	private const int snapshotFrameRate = 15;

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x450")]
	private Vector3 arcadeWorldOffset;

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x45C")]
	private bool clientScreeenActive;

	// Token: 0x0200004B RID: 75
	[Token(Token = "0x2000A58")]
	public class ScoreEntry
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public ScoreEntry()
		{
		}

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4003DA3")]
		[FieldOffset(Offset = "0x10")]
		public ulong playerID;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4003DA4")]
		[FieldOffset(Offset = "0x18")]
		public int score;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4003DA5")]
		[FieldOffset(Offset = "0x20")]
		public string displayName;
	}
}
