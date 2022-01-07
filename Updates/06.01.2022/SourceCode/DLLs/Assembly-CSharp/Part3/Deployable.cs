using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E1 RID: 1505
[Token(Token = "0x2000464")]
public class Deployable : PrefabAttribute
{
	// Token: 0x060029FA RID: 10746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002324")]
	[Address(RVA = "0xB653A0", Offset = "0xB641A0", VA = "0x180B653A0", Slot = "6")]
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002325")]
	[Address(RVA = "0xB65460", Offset = "0xB64260", VA = "0x180B65460", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002326")]
	[Address(RVA = "0xB654C0", Offset = "0xB642C0", VA = "0x180B654C0")]
	public Deployable()
	{
	}

	// Token: 0x04002546 RID: 9542
	[Token(Token = "0x4001E6F")]
	[FieldOffset(Offset = "0x98")]
	public Mesh guideMesh;

	// Token: 0x04002547 RID: 9543
	[Token(Token = "0x4001E70")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 guideMeshScale;

	// Token: 0x04002548 RID: 9544
	[Token(Token = "0x4001E71")]
	[FieldOffset(Offset = "0xAC")]
	public bool guideLights;

	// Token: 0x04002549 RID: 9545
	[Token(Token = "0x4001E72")]
	[FieldOffset(Offset = "0xAD")]
	public bool wantsInstanceData;

	// Token: 0x0400254A RID: 9546
	[Token(Token = "0x4001E73")]
	[FieldOffset(Offset = "0xAE")]
	public bool copyInventoryFromItem;

	// Token: 0x0400254B RID: 9547
	[Token(Token = "0x4001E74")]
	[FieldOffset(Offset = "0xAF")]
	public bool setSocketParent;

	// Token: 0x0400254C RID: 9548
	[Token(Token = "0x4001E75")]
	[FieldOffset(Offset = "0xB0")]
	public bool toSlot;

	// Token: 0x0400254D RID: 9549
	[Token(Token = "0x4001E76")]
	[FieldOffset(Offset = "0xB4")]
	public BaseEntity.Slot slot;

	// Token: 0x0400254E RID: 9550
	[Token(Token = "0x4001E77")]
	[FieldOffset(Offset = "0xB8")]
	public GameObjectRef placeEffect;

	// Token: 0x0400254F RID: 9551
	[Token(Token = "0x4001E78")]
	[FieldOffset(Offset = "0xC0")]
	[NonSerialized]
	public Bounds bounds;
}
