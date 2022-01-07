using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000090 RID: 144
[Token(Token = "0x2000057")]
public class ElevatorLift : BaseCombatEntity
{
	// Token: 0x06000A12 RID: 2578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x98DAE0", Offset = "0x98C8E0", VA = "0x18098DAE0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x1700009F")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x98F010", Offset = "0x98DE10", VA = "0x18098F010", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x98E730", Offset = "0x98D530", VA = "0x18098E730", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A0")]
	private Elevator owner
	{
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x98F1E0", Offset = "0x98DFE0", VA = "0x18098F1E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x98E6E0", Offset = "0x98D4E0", VA = "0x18098E6E0")]
	[Attribute(Name = "Menu", RVA = "0xC9FC0", Offset = "0xC93C0")]
	[Attribute(Name = "Description", RVA = "0xC9FC0", Offset = "0xC93C0")]
	[Attribute(Name = "Icon", RVA = "0xC9FC0", Offset = "0xC93C0")]
	[Attribute(Name = "ShowIf", RVA = "0xC9FC0", Offset = "0xC93C0")]
	public void Menu_RaiseElevator(BasePlayer p)
	{
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x98E640", Offset = "0x98D440", VA = "0x18098E640")]
	protected bool Menu_RaiseElevator_ShowIf(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x98E630", Offset = "0x98D430", VA = "0x18098E630", Slot = "144")]
	protected virtual bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x98E5E0", Offset = "0x98D3E0", VA = "0x18098E5E0")]
	[Attribute(Name = "Menu", RVA = "0xCA310", Offset = "0xC9710")]
	[Attribute(Name = "Description", RVA = "0xCA310", Offset = "0xC9710")]
	[Attribute(Name = "Icon", RVA = "0xCA310", Offset = "0xC9710")]
	[Attribute(Name = "ShowIf", RVA = "0xCA310", Offset = "0xC9710")]
	public void Menu_RaiseElevatorToTop(BasePlayer p)
	{
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x98E590", Offset = "0x98D390", VA = "0x18098E590")]
	[Attribute(Name = "Menu", RVA = "0xCA5F0", Offset = "0xC99F0")]
	[Attribute(Name = "Description", RVA = "0xCA5F0", Offset = "0xC99F0")]
	[Attribute(Name = "Icon", RVA = "0xCA5F0", Offset = "0xC99F0")]
	[Attribute(Name = "ShowIf", RVA = "0xCA5F0", Offset = "0xC99F0")]
	public void Menu_LowerElevator(BasePlayer p)
	{
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00005B08 File Offset: 0x00003D08
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x98E4F0", Offset = "0x98D2F0", VA = "0x18098E4F0")]
	protected bool Menu_LowerElevator_ShowIf(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00005B20 File Offset: 0x00003D20
	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x98E4E0", Offset = "0x98D2E0", VA = "0x18098E4E0", Slot = "145")]
	protected virtual bool Menu_LowerElevator_ShowIf_Base(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x98E490", Offset = "0x98D290", VA = "0x18098E490")]
	[Attribute(Name = "Menu", RVA = "0xCA960", Offset = "0xC9D60")]
	[Attribute(Name = "Description", RVA = "0xCA960", Offset = "0xC9D60")]
	[Attribute(Name = "Icon", RVA = "0xCA960", Offset = "0xC9D60")]
	[Attribute(Name = "ShowIf", RVA = "0xCA960", Offset = "0xC9D60")]
	public void Menu_LowerElevatorToFloor(BasePlayer p)
	{
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00005B38 File Offset: 0x00003D38
	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x98D950", Offset = "0x98C750", VA = "0x18098D950")]
	protected bool GetLookingAtButton(BasePlayer p, out Elevator.Direction d)
	{
		return default(bool);
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x98E820", Offset = "0x98D620", VA = "0x18098E820")]
	public void PlayLiftArrivalEffect()
	{
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x98EAD0", Offset = "0x98D8D0", VA = "0x18098EAD0")]
	public void StartMovementSounds()
	{
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x98EE30", Offset = "0x98DC30", VA = "0x18098EE30")]
	public void UpdateMovementSounds()
	{
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x98EC70", Offset = "0x98DA70", VA = "0x18098EC70")]
	public void StopMovementSounds()
	{
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x98ED90", Offset = "0x98DB90", VA = "0x18098ED90")]
	public void ToggleMovementCollider(bool state)
	{
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x98D7E0", Offset = "0x98C5E0", VA = "0x18098D7E0")]
	public ElevatorLift()
	{
	}

	// Token: 0x04000558 RID: 1368
	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x238")]
	private Option __menuOption_Menu_LowerElevator;

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x290")]
	private Option __menuOption_Menu_LowerElevatorToFloor;

	// Token: 0x0400055A RID: 1370
	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x2E8")]
	private Option __menuOption_Menu_RaiseElevator;

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x340")]
	private Option __menuOption_Menu_RaiseElevatorToTop;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x398")]
	public GameObject DescendingHurtTrigger;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x3A0")]
	public GameObject MovementCollider;

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x3A8")]
	public Transform UpButtonPoint;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x3B0")]
	public Transform DownButtonPoint;

	// Token: 0x04000560 RID: 1376
	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x3B8")]
	public TriggerNotify VehicleTrigger;

	// Token: 0x04000561 RID: 1377
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x3C0")]
	public GameObjectRef LiftArrivalScreenBounce;

	// Token: 0x04000562 RID: 1378
	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x3C8")]
	public SoundDefinition liftMovementLoopDef;

	// Token: 0x04000563 RID: 1379
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x3D0")]
	public SoundDefinition liftMovementStartDef;

	// Token: 0x04000564 RID: 1380
	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x3D8")]
	public SoundDefinition liftMovementStopDef;

	// Token: 0x04000565 RID: 1381
	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x3E0")]
	public SoundDefinition liftMovementAccentSoundDef;

	// Token: 0x04000566 RID: 1382
	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x3E8")]
	public GameObjectRef liftButtonPressedEffect;

	// Token: 0x04000567 RID: 1383
	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x3F0")]
	public float movementAccentMinInterval;

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x400047B")]
	[FieldOffset(Offset = "0x3F4")]
	public float movementAccentMaxInterval;

	// Token: 0x04000569 RID: 1385
	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x3F8")]
	private Sound liftMovementLoopSound;

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0x400")]
	private float nextMovementAccent;

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x400047E")]
	private const BaseEntity.Flags PressedUp = BaseEntity.Flags.Reserved1;

	// Token: 0x0400056C RID: 1388
	[Token(Token = "0x400047F")]
	private const BaseEntity.Flags PressedDown = BaseEntity.Flags.Reserved2;
}
