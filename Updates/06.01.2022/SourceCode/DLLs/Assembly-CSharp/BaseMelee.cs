using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using Rust;
using UnityEngine;

// Token: 0x02000109 RID: 265
[Token(Token = "0x20000A0")]
public class BaseMelee : AttackEntity
{
	// Token: 0x0600102F RID: 4143 RVA: 0x000097F8 File Offset: 0x000079F8
	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0x2F3040", Offset = "0x2F1E40", VA = "0x1802F3040", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00009810 File Offset: 0x00007A10
	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x2F2A90", Offset = "0x2F1890", VA = "0x1802F2A90", Slot = "156")]
	public override Vector3 GetInheritedVelocity(BasePlayer player)
	{
		return default(Vector3);
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x2F2260", Offset = "0x2F1060", VA = "0x1802F2260")]
	internal void DoThrow()
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x2F1C20", Offset = "0x2F0A20", VA = "0x1802F1C20")]
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity)
	{
		return null;
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x2F2A00", Offset = "0x2F1800", VA = "0x1802F2A00", Slot = "157")]
	public override void GetAttackStats(HitInfo info)
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x2F1DD0", Offset = "0x2F0BD0", VA = "0x1802F1DD0", Slot = "159")]
	public virtual void DoAttackShared(HitInfo info)
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x2F2C60", Offset = "0x2F1A60", VA = "0x1802F2C60", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06001036 RID: 4150 RVA: 0x00009828 File Offset: 0x00007A28
	[Token(Token = "0x17000153")]
	protected virtual bool CanAttack
	{
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06001037 RID: 4151 RVA: 0x00009840 File Offset: 0x00007A40
	[Token(Token = "0x17000154")]
	protected virtual bool CanThrow
	{
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "161")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "162")]
	public virtual void ClientAttack()
	{
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x2F2C40", Offset = "0x2F1A40", VA = "0x1802F2C40", Slot = "142")]
	public override void OnHolstered()
	{
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x2F31F0", Offset = "0x2F1FF0", VA = "0x1802F31F0", Slot = "163")]
	protected virtual void ProcessAttack(HitTest hit)
	{
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x2F2020", Offset = "0x2F0E20", VA = "0x1802F2020", Slot = "164")]
	protected virtual void DoAttack()
	{
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x2F2970", Offset = "0x2F1770", VA = "0x1802F2970", Slot = "165")]
	public virtual void DoViewmodelImpact(HitTest test)
	{
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x2F3130", Offset = "0x2F1F30", VA = "0x1802F3130", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x2F3530", Offset = "0x2F2330", VA = "0x1802F3530", Slot = "151")]
	public override void ProcessSpectatorViewmodel(ViewModel vm)
	{
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x2F3480", Offset = "0x2F2280", VA = "0x1802F3480", Slot = "152")]
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x2F2A60", Offset = "0x2F1860", VA = "0x1802F2A60")]
	public ResourceDispenser.GatherPropertyEntry GetGatherInfoFromIndex(ResourceDispenser.GatherType index)
	{
		return null;
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00009858 File Offset: 0x00007A58
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "166")]
	public virtual bool CanHit(HitTest info)
	{
		return default(bool);
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00009870 File Offset: 0x00007A70
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x2F35E0", Offset = "0x2F23E0", VA = "0x1802F35E0")]
	public float TotalDamage()
	{
		return 0f;
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00009888 File Offset: 0x00007A88
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "153")]
	public override bool CanBeUsedInWater()
	{
		return default(bool);
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x2F2AE0", Offset = "0x2F18E0", VA = "0x1802F2AE0")]
	public string GetStrikeEffectPath(string materialName)
	{
		return null;
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x2F3740", Offset = "0x2F2540", VA = "0x1802F3740")]
	public BaseMelee()
	{
	}

	// Token: 0x04000A70 RID: 2672
	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x278")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x87E50", Offset = "0x87250")]
	public bool canThrowAsProjectile;

	// Token: 0x04000A71 RID: 2673
	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x279")]
	public bool canAiHearIt;

	// Token: 0x04000A72 RID: 2674
	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0x27A")]
	public bool onlyThrowAsProjectile;

	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0x280")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x87FE0", Offset = "0x873E0")]
	public DamageProperties damageProperties;

	// Token: 0x04000A74 RID: 2676
	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0x288")]
	public List<DamageTypeEntry> damageTypes;

	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x400088C")]
	[FieldOffset(Offset = "0x290")]
	public float maxDistance;

	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0x294")]
	public float attackRadius;

	// Token: 0x04000A77 RID: 2679
	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0x298")]
	public bool isAutomatic;

	// Token: 0x04000A78 RID: 2680
	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x299")]
	public bool blockSprintOnAttack;

	// Token: 0x04000A79 RID: 2681
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x2A0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x880D0", Offset = "0x874D0")]
	public GameObjectRef strikeFX;

	// Token: 0x04000A7A RID: 2682
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x2A8")]
	public bool useStandardHitEffects;

	// Token: 0x04000A7B RID: 2683
	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x2AC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x881A0", Offset = "0x875A0")]
	public float aiStrikeDelay;

	// Token: 0x04000A7C RID: 2684
	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObjectRef swingEffect;

	// Token: 0x04000A7D RID: 2685
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x2B8")]
	public List<BaseMelee.MaterialFX> materialStrikeFX;

	// Token: 0x04000A7E RID: 2686
	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x2C0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x883B0", Offset = "0x877B0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x883B0", Offset = "0x877B0")]
	public float heartStress;

	// Token: 0x04000A7F RID: 2687
	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x2C8")]
	public ResourceDispenser.GatherProperties gathering;

	// Token: 0x04000A80 RID: 2688
	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x2D0")]
	[NonSerialized]
	private bool throwReady;

	// Token: 0x0200010A RID: 266
	[Token(Token = "0x2000AA3")]
	[Serializable]
	public class MaterialFX
	{
		// Token: 0x06001046 RID: 4166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public MaterialFX()
		{
		}

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4003F1C")]
		[FieldOffset(Offset = "0x10")]
		public string materialName;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4003F1D")]
		[FieldOffset(Offset = "0x18")]
		public GameObjectRef fx;
	}
}
