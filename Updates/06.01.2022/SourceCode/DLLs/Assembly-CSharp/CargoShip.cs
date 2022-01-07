using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000027 RID: 39
[Token(Token = "0x200001B")]
public class CargoShip : global::BaseEntity
{
	// Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x658380", Offset = "0x657180", VA = "0x180658380", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x6588D0", Offset = "0x6576D0", VA = "0x1806588D0")]
	public void RefreshActiveLayout()
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x658960", Offset = "0x657760", VA = "0x180658960")]
	public void Update()
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x6581D0", Offset = "0x656FD0", VA = "0x1806581D0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x658840", Offset = "0x657640", VA = "0x180658840", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x658340", Offset = "0x657140", VA = "0x180658340")]
	[global::BaseEntity.RPC_Client]
	public void DoHornSound(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x6583E0", Offset = "0x6571E0", VA = "0x1806583E0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x658B00", Offset = "0x657900", VA = "0x180658B00")]
	public CargoShip()
	{
	}

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x160")]
	public int targetNodeIndex;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x168")]
	public GameObject wakeParent;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x170")]
	public GameObjectRef scientistTurretPrefab;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x178")]
	public Transform[] scientistSpawnPoints;

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x180")]
	public List<Transform> crateSpawns;

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x188")]
	public GameObjectRef lockedCratePrefab;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x190")]
	public GameObjectRef militaryCratePrefab;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x198")]
	public GameObjectRef eliteCratePrefab;

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObjectRef junkCratePrefab;

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x1A8")]
	public Transform waterLine;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x1B0")]
	public Transform rudder;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x1B8")]
	public Transform propeller;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x1C0")]
	public GameObjectRef escapeBoatPrefab;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x1C8")]
	public Transform escapeBoatPoint;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x1D0")]
	public GameObjectRef microphonePrefab;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x1D8")]
	public Transform microphonePoint;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObjectRef speakerPrefab;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x1E8")]
	public Transform[] speakerPoints;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObject radiation;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObjectRef mapMarkerEntityPrefab;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x200")]
	public GameObject hornOrigin;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x208")]
	public SoundDefinition hornDef;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x210")]
	public CargoShipSounds cargoShipSounds;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x218")]
	public GameObject[] layouts;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x220")]
	public GameObjectRef playerTest;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x228")]
	private uint layoutChoice;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x22C")]
	private TimeSince timeSinceUpdatedSounds;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000A4")]
	private const float updateRateDistSq = 10000f;
}
