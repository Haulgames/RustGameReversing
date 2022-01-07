using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007B8 RID: 1976
[Token(Token = "0x20005BF")]
public class DungeonGridCell : MonoBehaviour
{
	// Token: 0x0600313D RID: 12605 RVA: 0x00015138 File Offset: 0x00013338
	[Token(Token = "0x6002993")]
	[Address(RVA = "0x97FEE0", Offset = "0x97ECE0", VA = "0x18097FEE0")]
	public bool ShouldAvoid(uint id)
	{
		return default(bool);
	}

	// Token: 0x0600313E RID: 12606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002994")]
	[Address(RVA = "0x97FDF0", Offset = "0x97EBF0", VA = "0x18097FDF0")]
	protected void Awake()
	{
	}

	// Token: 0x0600313F RID: 12607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002995")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DungeonGridCell()
	{
	}

	// Token: 0x04002E1C RID: 11804
	[Token(Token = "0x4002470")]
	[FieldOffset(Offset = "0x18")]
	public DungeonGridConnectionType North;

	// Token: 0x04002E1D RID: 11805
	[Token(Token = "0x4002471")]
	[FieldOffset(Offset = "0x1C")]
	public DungeonGridConnectionType South;

	// Token: 0x04002E1E RID: 11806
	[Token(Token = "0x4002472")]
	[FieldOffset(Offset = "0x20")]
	public DungeonGridConnectionType West;

	// Token: 0x04002E1F RID: 11807
	[Token(Token = "0x4002473")]
	[FieldOffset(Offset = "0x24")]
	public DungeonGridConnectionType East;

	// Token: 0x04002E20 RID: 11808
	[Token(Token = "0x4002474")]
	[FieldOffset(Offset = "0x28")]
	public DungeonGridConnectionVariant NorthVariant;

	// Token: 0x04002E21 RID: 11809
	[Token(Token = "0x4002475")]
	[FieldOffset(Offset = "0x2C")]
	public DungeonGridConnectionVariant SouthVariant;

	// Token: 0x04002E22 RID: 11810
	[Token(Token = "0x4002476")]
	[FieldOffset(Offset = "0x30")]
	public DungeonGridConnectionVariant WestVariant;

	// Token: 0x04002E23 RID: 11811
	[Token(Token = "0x4002477")]
	[FieldOffset(Offset = "0x34")]
	public DungeonGridConnectionVariant EastVariant;

	// Token: 0x04002E24 RID: 11812
	[Token(Token = "0x4002478")]
	[FieldOffset(Offset = "0x38")]
	public GameObjectRef[] AvoidNeighbours;

	// Token: 0x04002E25 RID: 11813
	[Token(Token = "0x4002479")]
	[FieldOffset(Offset = "0x40")]
	public MeshRenderer[] MapRenderers;
}
