using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000133 RID: 307
[Token(Token = "0x20000B5")]
public class EasterBasket : AttackEntity
{
	// Token: 0x0600120B RID: 4619 RVA: 0x0000A728 File Offset: 0x00008928
	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0x983D10", Offset = "0x982B10", VA = "0x180983D10", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x0000A740 File Offset: 0x00008940
	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x9831F0", Offset = "0x981FF0", VA = "0x1809831F0", Slot = "156")]
	public override Vector3 GetInheritedVelocity(BasePlayer player)
	{
		return default(Vector3);
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x983100", Offset = "0x981F00", VA = "0x180983100")]
	public Item GetAmmo()
	{
		return null;
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x0000A758 File Offset: 0x00008958
	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x983240", Offset = "0x982040", VA = "0x180983240")]
	public bool HasAmmo()
	{
		return default(bool);
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x983260", Offset = "0x982060", VA = "0x180983260")]
	public void LaunchProjectile()
	{
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x983E00", Offset = "0x982C00", VA = "0x180983E00", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x983520", Offset = "0x982320", VA = "0x180983520", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D32")]
	[Address(RVA = "0x984010", Offset = "0x982E10", VA = "0x180984010")]
	public EasterBasket()
	{
	}

	// Token: 0x04000C54 RID: 3156
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x278")]
	public GameObjectRef eggProjectile;

	// Token: 0x04000C55 RID: 3157
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x280")]
	public ItemDefinition ammoType;

	// Token: 0x04000C56 RID: 3158
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x288")]
	public int lastCollectedIndex;

	// Token: 0x04000C57 RID: 3159
	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x28C")]
	private bool aiming;

	// Token: 0x04000C58 RID: 3160
	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x290")]
	private float nextAmmoCheckTime;

	// Token: 0x04000C59 RID: 3161
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x294")]
	private bool didHaveAmmo;
}
