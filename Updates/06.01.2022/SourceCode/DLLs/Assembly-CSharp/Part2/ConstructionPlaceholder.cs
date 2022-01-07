using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FE RID: 766
[Token(Token = "0x2000217")]
[ExecuteInEditMode]
public class ConstructionPlaceholder : PrefabAttribute, IPrefabPreProcess
{
	// Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001666")]
	[Address(RVA = "0x6C7E10", Offset = "0x6C6C10", VA = "0x1806C7E10", Slot = "6")]
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001667")]
	[Address(RVA = "0x6C8010", Offset = "0x6C6E10", VA = "0x1806C8010", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001668")]
	[Address(RVA = "0x6C8070", Offset = "0x6C6E70", VA = "0x1806C8070")]
	public ConstructionPlaceholder()
	{
	}

	// Token: 0x040016F0 RID: 5872
	[Token(Token = "0x40012BF")]
	[FieldOffset(Offset = "0x98")]
	public Mesh mesh;

	// Token: 0x040016F1 RID: 5873
	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0xA0")]
	public Material material;

	// Token: 0x040016F2 RID: 5874
	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0xA8")]
	public bool renderer;

	// Token: 0x040016F3 RID: 5875
	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0xA9")]
	public bool collider;
}
