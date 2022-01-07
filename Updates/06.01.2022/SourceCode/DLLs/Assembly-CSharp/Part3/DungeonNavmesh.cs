using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000298 RID: 664
[Token(Token = "0x20001D2")]
public class DungeonNavmesh : FacepunchBehaviour, IServerComponent
{
	// Token: 0x060019BF RID: 6591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001457")]
	[Address(RVA = "0x9808F0", Offset = "0x97F6F0", VA = "0x1809808F0")]
	public DungeonNavmesh()
	{
	}

	// Token: 0x0400140F RID: 5135
	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x18")]
	public int NavMeshAgentTypeIndex;

	// Token: 0x04001410 RID: 5136
	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xA4980", Offset = "0xA3D80")]
	public string DefaultAreaName;

	// Token: 0x04001411 RID: 5137
	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x28")]
	public float NavmeshResolutionModifier;

	// Token: 0x04001412 RID: 5138
	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xA4A30", Offset = "0xA3E30")]
	public Bounds Bounds;

	// Token: 0x04001413 RID: 5139
	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x48")]
	public NavMeshData NavMeshData;

	// Token: 0x04001414 RID: 5140
	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x50")]
	public NavMeshDataInstance NavMeshDataInstance;

	// Token: 0x04001415 RID: 5141
	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x54")]
	public LayerMask LayerMask;

	// Token: 0x04001416 RID: 5142
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x58")]
	public NavMeshCollectGeometry NavMeshCollectGeometry;

	// Token: 0x04001417 RID: 5143
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x0")]
	public static List<DungeonNavmesh> Instances;
}
