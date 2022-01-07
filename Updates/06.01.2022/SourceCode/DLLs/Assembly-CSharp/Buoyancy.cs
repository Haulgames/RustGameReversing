using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000569 RID: 1385
[Token(Token = "0x2000404")]
public class Buoyancy : ListComponent<Buoyancy>, IServerComponent
{
	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06002807 RID: 10247 RVA: 0x00011898 File Offset: 0x0000FA98
	// (set) Token: 0x06002808 RID: 10248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E8")]
	public float timeOutOfWater
	{
		[Token(Token = "0x600216C")]
		[Address(RVA = "0x2F97A0", Offset = "0x2F85A0", VA = "0x1802F97A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600216D")]
		[Address(RVA = "0x2F98A0", Offset = "0x2F86A0", VA = "0x1802F98A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600216E")]
	[Address(RVA = "0x641410", Offset = "0x640210", VA = "0x180641410")]
	public Buoyancy()
	{
	}

	// Token: 0x04002331 RID: 9009
	[Token(Token = "0x4001CB6")]
	[FieldOffset(Offset = "0x18")]
	public BuoyancyPoint[] points;

	// Token: 0x04002332 RID: 9010
	[Token(Token = "0x4001CB7")]
	[FieldOffset(Offset = "0x20")]
	public GameObjectRef[] waterImpacts;

	// Token: 0x04002333 RID: 9011
	[Token(Token = "0x4001CB8")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody rigidBody;

	// Token: 0x04002334 RID: 9012
	[Token(Token = "0x4001CB9")]
	[FieldOffset(Offset = "0x30")]
	public float buoyancyScale;

	// Token: 0x04002335 RID: 9013
	[Token(Token = "0x4001CBA")]
	[FieldOffset(Offset = "0x34")]
	public bool doEffects;

	// Token: 0x04002336 RID: 9014
	[Token(Token = "0x4001CBB")]
	[FieldOffset(Offset = "0x38")]
	public float flowMovementScale;

	// Token: 0x04002337 RID: 9015
	[Token(Token = "0x4001CBC")]
	[FieldOffset(Offset = "0x3C")]
	public float requiredSubmergedFraction;

	// Token: 0x04002338 RID: 9016
	[Token(Token = "0x4001CBD")]
	[FieldOffset(Offset = "0x40")]
	public bool useUnderwaterDrag;

	// Token: 0x04002339 RID: 9017
	[Token(Token = "0x4001CBE")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0x7E3C0", Offset = "0x7D7C0")]
	public float underwaterDrag;

	// Token: 0x0400233A RID: 9018
	[Token(Token = "0x4001CBF")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <timeOutOfWater>k__BackingField;

	// Token: 0x0400233B RID: 9019
	[Token(Token = "0x4001CC0")]
	[FieldOffset(Offset = "0x50")]
	public Action<bool> SubmergedChanged;

	// Token: 0x0400233C RID: 9020
	[Token(Token = "0x4001CC1")]
	[FieldOffset(Offset = "0x58")]
	public BaseEntity forEntity;

	// Token: 0x0400233D RID: 9021
	[Token(Token = "0x4001CC2")]
	[FieldOffset(Offset = "0x60")]
	[NonSerialized]
	public float submergedFraction;
}
