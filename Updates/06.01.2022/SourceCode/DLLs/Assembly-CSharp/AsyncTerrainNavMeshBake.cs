using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x0200079B RID: 1947
[Token(Token = "0x20005A7")]
public class AsyncTerrainNavMeshBake : CustomYieldInstruction
{
	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x060030A2 RID: 12450 RVA: 0x00014D90 File Offset: 0x00012F90
	[Token(Token = "0x17000370")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6002909")]
		[Address(RVA = "0x839B60", Offset = "0x838960", VA = "0x180839B60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x060030A3 RID: 12451 RVA: 0x00014DA8 File Offset: 0x00012FA8
	[Token(Token = "0x17000371")]
	public bool isDone
	{
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x839B50", Offset = "0x838950", VA = "0x180839B50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060030A4 RID: 12452 RVA: 0x00014DC0 File Offset: 0x00012FC0
	[Token(Token = "0x600290B")]
	[Address(RVA = "0x838ED0", Offset = "0x837CD0", VA = "0x180838ED0")]
	public NavMeshBuildSource CreateNavMeshBuildSource()
	{
		return default(NavMeshBuildSource);
	}

	// Token: 0x060030A5 RID: 12453 RVA: 0x00014DD8 File Offset: 0x00012FD8
	[Token(Token = "0x600290C")]
	[Address(RVA = "0x8391E0", Offset = "0x837FE0", VA = "0x1808391E0")]
	public NavMeshBuildSource CreateNavMeshBuildSource(int area)
	{
		return default(NavMeshBuildSource);
	}

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x060030A6 RID: 12454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000372")]
	public Mesh mesh
	{
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x839B70", Offset = "0x838970", VA = "0x180839B70")]
		get
		{
			return null;
		}
	}

	// Token: 0x060030A7 RID: 12455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600290E")]
	[Address(RVA = "0x839970", Offset = "0x838770", VA = "0x180839970")]
	public AsyncTerrainNavMeshBake(Vector3 pivot, int width, int height, bool normal, bool alpha)
	{
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600290F")]
	[Address(RVA = "0x839280", Offset = "0x838080", VA = "0x180839280")]
	private void DoWork()
	{
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002910")]
	[Address(RVA = "0x8398B0", Offset = "0x8386B0", VA = "0x1808398B0")]
	private void Invoke()
	{
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002911")]
	[Address(RVA = "0x838E90", Offset = "0x837C90", VA = "0x180838E90")]
	private void Callback(IAsyncResult result)
	{
	}

	// Token: 0x04002DAC RID: 11692
	[Token(Token = "0x4002412")]
	[FieldOffset(Offset = "0x10")]
	private List<int> indices;

	// Token: 0x04002DAD RID: 11693
	[Token(Token = "0x4002413")]
	[FieldOffset(Offset = "0x18")]
	private List<Vector3> vertices;

	// Token: 0x04002DAE RID: 11694
	[Token(Token = "0x4002414")]
	[FieldOffset(Offset = "0x20")]
	private List<Vector3> normals;

	// Token: 0x04002DAF RID: 11695
	[Token(Token = "0x4002415")]
	[FieldOffset(Offset = "0x28")]
	private List<int> triangles;

	// Token: 0x04002DB0 RID: 11696
	[Token(Token = "0x4002416")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 pivot;

	// Token: 0x04002DB1 RID: 11697
	[Token(Token = "0x4002417")]
	[FieldOffset(Offset = "0x3C")]
	private int width;

	// Token: 0x04002DB2 RID: 11698
	[Token(Token = "0x4002418")]
	[FieldOffset(Offset = "0x40")]
	private int height;

	// Token: 0x04002DB3 RID: 11699
	[Token(Token = "0x4002419")]
	[FieldOffset(Offset = "0x44")]
	private bool normal;

	// Token: 0x04002DB4 RID: 11700
	[Token(Token = "0x400241A")]
	[FieldOffset(Offset = "0x45")]
	private bool alpha;

	// Token: 0x04002DB5 RID: 11701
	[Token(Token = "0x400241B")]
	[FieldOffset(Offset = "0x48")]
	private Action worker;
}
