using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000267 RID: 615
[Token(Token = "0x20001A9")]
public class AIInformationCell
{
	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06001907 RID: 6407 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
	[Token(Token = "0x17000196")]
	public int X
	{
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x56E730", Offset = "0x56D530", VA = "0x18056E730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06001908 RID: 6408 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
	[Token(Token = "0x17000197")]
	public int Z
	{
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x56E740", Offset = "0x56D540", VA = "0x18056E740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x814040", Offset = "0x812E40", VA = "0x180814040")]
	public AIInformationCell(Bounds bounds, GameObject root, int x, int z)
	{
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x813C20", Offset = "0x812A20", VA = "0x180813C20")]
	public void DebugDraw(Color color, bool points, float scale = 1f)
	{
	}

	// Token: 0x04001346 RID: 4934
	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x10")]
	public Bounds BoundingBox;

	// Token: 0x04001347 RID: 4935
	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x28")]
	public List<AIInformationCell> NeighbourCells;

	// Token: 0x04001348 RID: 4936
	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x30")]
	public AIInformationCellContents<AIMovePoint> MovePoints;

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x38")]
	public AIInformationCellContents<AICoverPoint> CoverPoints;

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private readonly int <X>k__BackingField;

	// Token: 0x0400134B RID: 4939
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private readonly int <Z>k__BackingField;
}
