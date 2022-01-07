using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000269 RID: 617
[Token(Token = "0x20001AB")]
public class AIInformationGrid : MonoBehaviour
{
	// Token: 0x06001912 RID: 6418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x814D20", Offset = "0x813B20", VA = "0x180814D20")]
	[Attribute(Name = "ContextMenu", RVA = "0xA16A0", Offset = "0xA0AA0")]
	public void Init()
	{
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x0000CD08 File Offset: 0x0000AF08
	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x814A60", Offset = "0x813860", VA = "0x180814A60")]
	private int GetIndex(int x, int z)
	{
		return 0;
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x814390", Offset = "0x813190", VA = "0x180814390")]
	public AIInformationCell CellAt(int x, int z)
	{
		return null;
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x814A70", Offset = "0x813870", VA = "0x180814A70")]
	public AIMovePoint[] GetMovePointsInRange(Vector3 position, float maxRange, out int pointCount)
	{
		return null;
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x8147B0", Offset = "0x8135B0", VA = "0x1808147B0")]
	public AICoverPoint[] GetCoverPointsInRange(Vector3 position, float maxRange, out int pointCount)
	{
		return null;
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x8145A0", Offset = "0x8133A0", VA = "0x1808145A0")]
	public AIInformationCell[] GetCellsInRange(Vector3 position, float maxRange, out int cellCount)
	{
		return null;
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x814480", Offset = "0x813280", VA = "0x180814480")]
	public AIInformationCell GetCell(Vector3 position)
	{
		return null;
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x8143D0", Offset = "0x8131D0", VA = "0x1808143D0")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x8143D0", Offset = "0x8131D0", VA = "0x1808143D0")]
	public void DebugDraw()
	{
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x815320", Offset = "0x814120", VA = "0x180815320")]
	public AIInformationGrid()
	{
	}

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x18")]
	public int CellSize;

	// Token: 0x0400134E RID: 4942
	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x1C")]
	public Bounds BoundingBox;

	// Token: 0x0400134F RID: 4943
	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x38")]
	public AIInformationCell[] Cells;

	// Token: 0x04001350 RID: 4944
	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 origin;

	// Token: 0x04001351 RID: 4945
	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x4C")]
	private int xCellCount;

	// Token: 0x04001352 RID: 4946
	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0x50")]
	private int zCellCount;

	// Token: 0x04001353 RID: 4947
	[Token(Token = "0x4000FDD")]
	private const int maxPointResults = 2048;

	// Token: 0x04001354 RID: 4948
	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x58")]
	private AIMovePoint[] movePointResults;

	// Token: 0x04001355 RID: 4949
	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0x60")]
	private AICoverPoint[] coverPointResults;

	// Token: 0x04001356 RID: 4950
	[Token(Token = "0x4000FE0")]
	private const int maxCellResults = 512;

	// Token: 0x04001357 RID: 4951
	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0x68")]
	private AIInformationCell[] resultCells;
}
