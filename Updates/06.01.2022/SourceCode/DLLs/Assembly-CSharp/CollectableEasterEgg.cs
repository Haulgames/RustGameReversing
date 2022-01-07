using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000083 RID: 131
[Token(Token = "0x200004A")]
public class CollectableEasterEgg : global::BaseEntity
{
	// Token: 0x0600095C RID: 2396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x49EBF0", Offset = "0x49D9F0", VA = "0x18049EBF0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600095D RID: 2397 RVA: 0x000053D0 File Offset: 0x000035D0
	[Token(Token = "0x1700008C")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x49F260", Offset = "0x49E060", VA = "0x18049F260", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x49EFA0", Offset = "0x49DDA0", VA = "0x18049EFA0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000507")]
	[Address(RVA = "0x49EB00", Offset = "0x49D900", VA = "0x18049EB00")]
	public void BasketPickup()
	{
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x49EBB0", Offset = "0x49D9B0", VA = "0x18049EBB0")]
	public void DelayedPickup()
	{
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x49EB70", Offset = "0x49D970", VA = "0x18049EB70", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050A")]
	[Address(RVA = "0x49F090", Offset = "0x49DE90", VA = "0x18049F090")]
	public void Update()
	{
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050B")]
	[Address(RVA = "0x49EF60", Offset = "0x49DD60", VA = "0x18049EF60")]
	[Attribute(Name = "Menu", RVA = "0xC3E50", Offset = "0xC3250")]
	[Attribute(Name = "Description", RVA = "0xC3E50", Offset = "0xC3250")]
	[Attribute(Name = "Icon", RVA = "0xC3E50", Offset = "0xC3250")]
	[Attribute(Name = "ShowIf", RVA = "0xC3E50", Offset = "0xC3250")]
	public void Menu_Pickup(global::BasePlayer player)
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050C")]
	[Address(RVA = "0x49EF20", Offset = "0x49DD20", VA = "0x18049EF20")]
	public void Menu_Pickup_Start()
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00005400 File Offset: 0x00003600
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10")]
	public bool Menu_PickupDud_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050E")]
	[Address(RVA = "0x49F1F0", Offset = "0x49DFF0", VA = "0x18049F1F0")]
	public CollectableEasterEgg()
	{
	}

	// Token: 0x04000500 RID: 1280
	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x160")]
	private Option __menuOption_Menu_Pickup;

	// Token: 0x04000501 RID: 1281
	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x1B8")]
	public Transform artwork;

	// Token: 0x04000502 RID: 1282
	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x1C0")]
	public float bounceRange;

	// Token: 0x04000503 RID: 1283
	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x1C4")]
	public float bounceSpeed;

	// Token: 0x04000504 RID: 1284
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x1C8")]
	public GameObjectRef pickupEffect;

	// Token: 0x04000505 RID: 1285
	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x1D0")]
	public ItemDefinition itemToGive;

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x1D8")]
	private float randOffset;
}
