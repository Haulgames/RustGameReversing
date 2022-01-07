using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000299 RID: 665
[Token(Token = "0x20001D3")]
public class DynamicNavMesh : SingletonComponent<DynamicNavMesh>, IServerComponent
{
	// Token: 0x060019C1 RID: 6593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001459")]
	[Address(RVA = "0x9814B0", Offset = "0x9802B0", VA = "0x1809814B0")]
	public DynamicNavMesh()
	{
	}

	// Token: 0x04001418 RID: 5144
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x18")]
	public int NavMeshAgentTypeIndex;

	// Token: 0x04001419 RID: 5145
	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xA4980", Offset = "0xA3D80")]
	public string DefaultAreaName;

	// Token: 0x0400141A RID: 5146
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x28")]
	public int AsyncTerrainNavMeshBakeCellSize;

	// Token: 0x0400141B RID: 5147
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x2C")]
	public int AsyncTerrainNavMeshBakeCellHeight;

	// Token: 0x0400141C RID: 5148
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x30")]
	public Bounds Bounds;

	// Token: 0x0400141D RID: 5149
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x48")]
	public NavMeshData NavMeshData;

	// Token: 0x0400141E RID: 5150
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x50")]
	public NavMeshDataInstance NavMeshDataInstance;

	// Token: 0x0400141F RID: 5151
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x54")]
	public LayerMask LayerMask;

	// Token: 0x04001420 RID: 5152
	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x58")]
	public NavMeshCollectGeometry NavMeshCollectGeometry;
}
