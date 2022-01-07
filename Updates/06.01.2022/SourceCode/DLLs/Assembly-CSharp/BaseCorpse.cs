using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000480 RID: 1152
[Token(Token = "0x2000353")]
public class BaseCorpse : BaseCombatEntity
{
	// Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0x884B90", Offset = "0x883990", VA = "0x180884B90", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D2C")]
	[Address(RVA = "0x885060", Offset = "0x883E60", VA = "0x180885060", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D2D")]
	[Address(RVA = "0x885260", Offset = "0x884060", VA = "0x180885260", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x0600237A RID: 9082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D2E")]
	[Address(RVA = "0x885840", Offset = "0x884640", VA = "0x180885840", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D2F")]
	[Address(RVA = "0x8859A0", Offset = "0x8847A0", VA = "0x1808859A0")]
	private Rigidbody SetupRigidBody()
	{
		return null;
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x885470", Offset = "0x884270", VA = "0x180885470", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x885380", Offset = "0x884180", VA = "0x180885380")]
	private void Load(Corpse corpse)
	{
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D32")]
	[Address(RVA = "0x885590", Offset = "0x884390", VA = "0x180885590", Slot = "115")]
	public override void OnAttacked(HitInfo info)
	{
	}

	// Token: 0x0600237F RID: 9087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x884B60", Offset = "0x883960", VA = "0x180884B60", Slot = "121")]
	public override string Categorize()
	{
		return null;
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06002380 RID: 9088 RVA: 0x0000FE88 File Offset: 0x0000E088
	[Token(Token = "0x17000279")]
	public override global::BaseEntity.TraitFlag Traits
	{
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x885B10", Offset = "0x884910", VA = "0x180885B10", Slot = "86")]
		get
		{
			return global::BaseEntity.TraitFlag.None;
		}
	}

	// Token: 0x06002381 RID: 9089 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
	[Token(Token = "0x6001D35")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "127")]
	public override bool ShouldInheritNetworkGroup()
	{
		return default(bool);
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D36")]
	[Address(RVA = "0x2EF040", Offset = "0x2EDE40", VA = "0x1802EF040")]
	public BaseCorpse()
	{
	}

	// Token: 0x04001E01 RID: 7681
	[Token(Token = "0x4001887")]
	[FieldOffset(Offset = "0x238")]
	public GameObjectRef prefabRagdoll;

	// Token: 0x04001E02 RID: 7682
	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0x240")]
	public global::BaseEntity parentEnt;

	// Token: 0x04001E03 RID: 7683
	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0x248")]
	[NonSerialized]
	internal ResourceDispenser resourceDispenser;

	// Token: 0x04001E04 RID: 7684
	[Token(Token = "0x400188A")]
	[FieldOffset(Offset = "0x250")]
	internal GameObject ragdollObject;
}
