using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200090F RID: 2319
[Token(Token = "0x2000687")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xC2860", Offset = "0xC1C60")]
public class BuildingGrade : ScriptableObject
{
	// Token: 0x06003830 RID: 14384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F5A")]
	[Address(RVA = "0x484650", Offset = "0x483450", VA = "0x180484650")]
	public BuildingGrade()
	{
	}

	// Token: 0x040034A2 RID: 13474
	[Token(Token = "0x40028A6")]
	[FieldOffset(Offset = "0x18")]
	public BuildingGrade.Enum type;

	// Token: 0x040034A3 RID: 13475
	[Token(Token = "0x40028A7")]
	[FieldOffset(Offset = "0x1C")]
	public float baseHealth;

	// Token: 0x040034A4 RID: 13476
	[Token(Token = "0x40028A8")]
	[FieldOffset(Offset = "0x20")]
	public List<ItemAmount> baseCost;

	// Token: 0x040034A5 RID: 13477
	[Token(Token = "0x40028A9")]
	[FieldOffset(Offset = "0x28")]
	public PhysicMaterial physicMaterial;

	// Token: 0x040034A6 RID: 13478
	[Token(Token = "0x40028AA")]
	[FieldOffset(Offset = "0x30")]
	public ProtectionProperties damageProtecton;

	// Token: 0x040034A7 RID: 13479
	[Token(Token = "0x40028AB")]
	[FieldOffset(Offset = "0x38")]
	public BaseEntity.Menu.Option upgradeMenu;

	// Token: 0x02000910 RID: 2320
	[Token(Token = "0x2000CB3")]
	public enum Enum
	{
		// Token: 0x040034A9 RID: 13481
		[Token(Token = "0x40048EF")]
		None = -1,
		// Token: 0x040034AA RID: 13482
		[Token(Token = "0x40048F0")]
		Twigs,
		// Token: 0x040034AB RID: 13483
		[Token(Token = "0x40048F1")]
		Wood,
		// Token: 0x040034AC RID: 13484
		[Token(Token = "0x40048F2")]
		Stone,
		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40048F3")]
		Metal,
		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40048F4")]
		TopTier,
		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40048F5")]
		Count
	}
}
