using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000043")]
public class BearTrap : BaseTrap
{
	// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x457B60", Offset = "0x456960", VA = "0x180457B60", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00004E60 File Offset: 0x00003060
	[Token(Token = "0x1700007B")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x458090", Offset = "0x456E90", VA = "0x180458090", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00004E78 File Offset: 0x00003078
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x457F90", Offset = "0x456D90", VA = "0x180457F90", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00004E90 File Offset: 0x00003090
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x457A30", Offset = "0x456830", VA = "0x180457A30")]
	public bool Armed()
	{
		return default(bool);
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x457E60", Offset = "0x456C60", VA = "0x180457E60", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00004EA8 File Offset: 0x000030A8
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x457A40", Offset = "0x456840", VA = "0x180457A40", Slot = "133")]
	public override bool CanPickup(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x4579F0", Offset = "0x4567F0", VA = "0x1804579F0")]
	[Attribute(Name = "Menu", RVA = "0xBD9F0", Offset = "0xBCDF0")]
	[Attribute(Name = "Description", RVA = "0xBD9F0", Offset = "0xBCDF0")]
	[Attribute(Name = "Icon", RVA = "0xBD9F0", Offset = "0xBCDF0")]
	[Attribute(Name = "ShowIf", RVA = "0xBD9F0", Offset = "0xBCDF0")]
	public void Arm_Beartrap(BasePlayer player)
	{
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00004EC0 File Offset: 0x000030C0
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x457F70", Offset = "0x456D70", VA = "0x180457F70")]
	public bool Menu_Arm_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x457AA0", Offset = "0x4568A0", VA = "0x180457AA0", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x457EC0", Offset = "0x456CC0", VA = "0x180457EC0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x458080", Offset = "0x456E80", VA = "0x180458080")]
	public BearTrap()
	{
	}

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x250")]
	private Option __menuOption_Arm_Beartrap;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x2A8")]
	protected Animator animator;

	// Token: 0x040004AB RID: 1195
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x2B0")]
	private bool initialized;
}
