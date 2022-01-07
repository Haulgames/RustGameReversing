using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004C RID: 76
[Token(Token = "0x2000035")]
public class BaseBoat : BaseVehicle
{
	// Token: 0x060005D8 RID: 1496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x84A480", Offset = "0x849280", VA = "0x18084A480", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x17000021")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x84AB40", Offset = "0x849940", VA = "0x18084AB40", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00002E50 File Offset: 0x00001050
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x84A970", Offset = "0x849770", VA = "0x18084A970")]
	public bool InDryDock()
	{
		return default(bool);
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00002E68 File Offset: 0x00001068
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x84A9E0", Offset = "0x8497E0", VA = "0x18084A9E0", Slot = "111")]
	public override float MaxVelocity()
	{
		return 0f;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x84A9F0", Offset = "0x8497F0", VA = "0x18084A9F0", Slot = "190")]
	[Attribute(Name = "Menu", RVA = "0xA48A0", Offset = "0xA3CA0")]
	[Attribute(Name = "Description", RVA = "0xA48A0", Offset = "0xA3CA0")]
	[Attribute(Name = "Icon", RVA = "0xA48A0", Offset = "0xA3CA0")]
	[Attribute(Name = "ShowIf", RVA = "0xA48A0", Offset = "0xA3CA0")]
	public virtual void Menu_Push(BasePlayer player)
	{
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00002E80 File Offset: 0x00001080
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x84A3C0", Offset = "0x8491C0", VA = "0x18084A3C0", Slot = "191")]
	public virtual bool EngineInWater()
	{
		return default(bool);
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00002E98 File Offset: 0x00001098
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x84AA30", Offset = "0x849830", VA = "0x18084AA30", Slot = "155")]
	public override float WaterFactorForPlayer(BasePlayer player)
	{
		return 0f;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x84A7A0", Offset = "0x8495A0", VA = "0x18084A7A0")]
	public static float GetWaterDepth(Vector3 pos)
	{
		return 0f;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x84AB20", Offset = "0x849920", VA = "0x18084AB20")]
	public BaseBoat()
	{
	}

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_Push;

	// Token: 0x04000276 RID: 630
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x400")]
	public float engineThrust;

	// Token: 0x04000277 RID: 631
	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x404")]
	public float steeringScale;

	// Token: 0x04000278 RID: 632
	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x408")]
	public float gasPedal;

	// Token: 0x04000279 RID: 633
	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x40C")]
	public float steering;

	// Token: 0x0400027A RID: 634
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x410")]
	public Transform thrustPoint;

	// Token: 0x0400027B RID: 635
	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x418")]
	public Transform centerOfMass;

	// Token: 0x0400027C RID: 636
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x420")]
	public Buoyancy buoyancy;
}
