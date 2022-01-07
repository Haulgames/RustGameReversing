using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005A5 RID: 1445
[Token(Token = "0x2000437")]
public class DroppedItem : WorldItem
{
	// Token: 0x060028F8 RID: 10488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002259")]
	[Address(RVA = "0x97DEC0", Offset = "0x97CCC0", VA = "0x18097DEC0", Slot = "30")]
	public override void PostInitShared()
	{
	}

	// Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225A")]
	[Address(RVA = "0x97DDE0", Offset = "0x97CBE0", VA = "0x18097DDE0", Slot = "83")]
	public override void OnSignal(BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x060028FA RID: 10490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225B")]
	[Address(RVA = "0x97DC90", Offset = "0x97CA90", VA = "0x18097DC90")]
	private void EnableCollider()
	{
	}

	// Token: 0x060028FB RID: 10491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225C")]
	[Address(RVA = "0x97DD20", Offset = "0x97CB20", VA = "0x18097DD20", Slot = "81")]
	public override void OnParentChangingClient(Transform oldParent, Transform newParent)
	{
	}

	// Token: 0x060028FC RID: 10492 RVA: 0x00011D90 File Offset: 0x0000FF90
	[Token(Token = "0x600225D")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "127")]
	public override bool ShouldInheritNetworkGroup()
	{
		return default(bool);
	}

	// Token: 0x060028FD RID: 10493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225E")]
	[Address(RVA = "0x97E440", Offset = "0x97D240", VA = "0x18097E440")]
	public DroppedItem()
	{
	}

	// Token: 0x060028FE RID: 10494 RVA: 0x00011DA8 File Offset: 0x0000FFA8
	[Token(Token = "0x600225F")]
	[Address(RVA = "0x97E410", Offset = "0x97D210", VA = "0x18097E410")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <PostInitShared>b__2_0(ItemSkinDirectory.Skin x)
	{
		return default(bool);
	}

	// Token: 0x04002488 RID: 9352
	[Token(Token = "0x4001DE8")]
	[FieldOffset(Offset = "0x170")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x6E7C0", Offset = "0x6DBC0")]
	public GameObject itemModel;

	// Token: 0x04002489 RID: 9353
	[Token(Token = "0x4001DE9")]
	[FieldOffset(Offset = "0x178")]
	private Collider childCollider;
}
