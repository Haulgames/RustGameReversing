using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000048")]
public class CCTV_RC : PoweredRemoteControlEntity
{
	// Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x6442F0", Offset = "0x6430F0", VA = "0x1806442F0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600093F RID: 2367 RVA: 0x000052C8 File Offset: 0x000034C8
	[Token(Token = "0x1700008A")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x644BE0", Offset = "0x6439E0", VA = "0x180644BE0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x000052E0 File Offset: 0x000034E0
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x6447B0", Offset = "0x6435B0", VA = "0x1806447B0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x6442E0", Offset = "0x6430E0", VA = "0x1806442E0", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x6448A0", Offset = "0x6436A0", VA = "0x1806448A0")]
	public void UpdateRotation(float delta)
	{
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x644670", Offset = "0x643470", VA = "0x180644670", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x6442B0", Offset = "0x6430B0", VA = "0x1806442B0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x644AF0", Offset = "0x6438F0", VA = "0x180644AF0")]
	public void Update()
	{
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x644770", Offset = "0x643570", VA = "0x180644770")]
	[Attribute(Name = "Menu", RVA = "0xC2D10", Offset = "0xC2110")]
	[Attribute(Name = "Description", RVA = "0xC2D10", Offset = "0xC2110")]
	[Attribute(Name = "Icon", RVA = "0xC2D10", Offset = "0xC2110")]
	[Attribute(Name = "ShowIf", RVA = "0xC2D10", Offset = "0xC2110")]
	public void Menu_SetDir(global::BasePlayer player)
	{
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00005310 File Offset: 0x00003510
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x6446E0", Offset = "0x6434E0", VA = "0x1806446E0")]
	public bool Menu_SetDir_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x644B30", Offset = "0x643930", VA = "0x180644B30")]
	public CCTV_RC()
	{
	}

	// Token: 0x040004E6 RID: 1254
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x2E0")]
	private Option __menuOption_Menu_SetDir;

	// Token: 0x040004E7 RID: 1255
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x338")]
	public Transform pivotOrigin;

	// Token: 0x040004E8 RID: 1256
	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x340")]
	public Transform yaw;

	// Token: 0x040004E9 RID: 1257
	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x348")]
	public Transform pitch;

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x350")]
	public Vector2 pitchClamp;

	// Token: 0x040004EB RID: 1259
	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x358")]
	public Vector2 yawClamp;

	// Token: 0x040004EC RID: 1260
	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x360")]
	public float turnSpeed;

	// Token: 0x040004ED RID: 1261
	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x364")]
	public float serverLerpSpeed;

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x368")]
	public float clientLerpSpeed;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x36C")]
	private float pitchAmount;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x370")]
	private float yawAmount;

	// Token: 0x040004F1 RID: 1265
	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x374")]
	public bool hasPTZ;

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x4000405")]
	public const global::BaseEntity.Flags Flag_HasViewer = global::BaseEntity.Flags.Reserved5;
}
