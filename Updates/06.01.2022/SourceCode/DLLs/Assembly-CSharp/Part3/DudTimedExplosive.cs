using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200008D RID: 141
[Token(Token = "0x2000054")]
public class DudTimedExplosive : TimedExplosive, IIgniteable, ISplashable
{
	// Token: 0x060009F8 RID: 2552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x97E450", Offset = "0x97D250", VA = "0x18097E450", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00005988 File Offset: 0x00003B88
	[Token(Token = "0x1700009C")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x97EC10", Offset = "0x97DA10", VA = "0x18097EC10", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x000059A0 File Offset: 0x00003BA0
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x97E860", Offset = "0x97D660", VA = "0x18097E860", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x000059B8 File Offset: 0x00003BB8
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x457A30", Offset = "0x456830", VA = "0x180457A30")]
	private bool IsWickBurning()
	{
		return default(bool);
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x97E750", Offset = "0x97D550", VA = "0x18097E750", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x97E950", Offset = "0x97D750", VA = "0x18097E950")]
	public void Update()
	{
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x97E820", Offset = "0x97D620", VA = "0x18097E820")]
	[Attribute(Name = "Menu", RVA = "0xC96B0", Offset = "0xC8AB0")]
	[Attribute(Name = "Description", RVA = "0xC96B0", Offset = "0xC8AB0")]
	[Attribute(Name = "Icon", RVA = "0xC96B0", Offset = "0xC8AB0")]
	[Attribute(Name = "ShowIf", RVA = "0xC96B0", Offset = "0xC8AB0")]
	public void Menu_Pickup(BasePlayer player)
	{
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x000059D0 File Offset: 0x00003BD0
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x457F70", Offset = "0x456D70", VA = "0x180457F70")]
	public bool Menu_PickupDud_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x97EBF0", Offset = "0x97D9F0", VA = "0x18097EBF0")]
	public DudTimedExplosive()
	{
	}

	// Token: 0x0400054C RID: 1356
	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x1B0")]
	private Option __menuOption_Menu_Pickup;

	// Token: 0x0400054D RID: 1357
	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x208")]
	public GameObjectRef fizzleEffect;

	// Token: 0x0400054E RID: 1358
	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x210")]
	public GameObject wickSpark;

	// Token: 0x0400054F RID: 1359
	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x218")]
	public AudioSource wickSound;

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x220")]
	public float dudChance;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x228")]
	[Attribute(Name = "ItemSelector", RVA = "0x8D9E0", Offset = "0x8CDE0")]
	public ItemDefinition itemToGive;

	// Token: 0x04000552 RID: 1362
	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x230")]
	[NonSerialized]
	private float explodeTime;
}
