using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008C0 RID: 2240
[Token(Token = "0x2000650")]
[ExecuteInEditMode]
public class AdaptMeshToTerrain : MonoBehaviour
{
	// Token: 0x06003656 RID: 13910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x81D250", Offset = "0x81C050", VA = "0x18081D250")]
	private void CheckInitialize()
	{
	}

	// Token: 0x06003657 RID: 13911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x81D230", Offset = "0x81C030", VA = "0x18081D230")]
	private void Awake()
	{
	}

	// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x81E160", Offset = "0x81CF60", VA = "0x18081E160")]
	private void OnEnable()
	{
	}

	// Token: 0x06003659 RID: 13913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x81E020", Offset = "0x81CE20", VA = "0x18081E020")]
	private void OnDisable()
	{
	}

	// Token: 0x0600365A RID: 13914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x81E2A0", Offset = "0x81D0A0", VA = "0x18081E2A0")]
	private void SetMaterialPropertyBlock()
	{
	}

	// Token: 0x0600365B RID: 13915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x81DE50", Offset = "0x81CC50", VA = "0x18081DE50")]
	private void DestroyMeshes()
	{
	}

	// Token: 0x0600365C RID: 13916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x81D2E0", Offset = "0x81C0E0", VA = "0x18081D2E0")]
	private void CheckReferenceMeshes()
	{
	}

	// Token: 0x0600365D RID: 13917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x81B990", Offset = "0x81A790", VA = "0x18081B990")]
	public void Adapt()
	{
	}

	// Token: 0x0600365E RID: 13918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x81D8A0", Offset = "0x81C6A0", VA = "0x18081D8A0")]
	private Mesh CreatePlaneMesh(int resolution)
	{
		return null;
	}

	// Token: 0x0600365F RID: 13919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x81E430", Offset = "0x81D230", VA = "0x18081E430")]
	public AdaptMeshToTerrain()
	{
	}

	// Token: 0x040032C7 RID: 12999
	[Token(Token = "0x4002722")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask LayerMask;

	// Token: 0x040032C8 RID: 13000
	[Token(Token = "0x4002723")]
	[FieldOffset(Offset = "0x1C")]
	public float RayHeight;

	// Token: 0x040032C9 RID: 13001
	[Token(Token = "0x4002724")]
	[FieldOffset(Offset = "0x20")]
	public float RayMaxDistance;

	// Token: 0x040032CA RID: 13002
	[Token(Token = "0x4002725")]
	[FieldOffset(Offset = "0x24")]
	public float MinDisplacement;

	// Token: 0x040032CB RID: 13003
	[Token(Token = "0x4002726")]
	[FieldOffset(Offset = "0x28")]
	public float MaxDisplacement;

	// Token: 0x040032CC RID: 13004
	[Token(Token = "0x4002727")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xB8B70", Offset = "0xB7F70")]
	public int PlaneResolution;

	// Token: 0x040032CD RID: 13005
	[Token(Token = "0x4002728")]
	private const int LODCount = 3;

	// Token: 0x040032CE RID: 13006
	[Token(Token = "0x4002729")]
	[FieldOffset(Offset = "0x30")]
	private MeshFilter meshFilter;

	// Token: 0x040032CF RID: 13007
	[Token(Token = "0x400272A")]
	[FieldOffset(Offset = "0x38")]
	private MeshRenderer meshRenderer;

	// Token: 0x040032D0 RID: 13008
	[Token(Token = "0x400272B")]
	[FieldOffset(Offset = "0x40")]
	private MeshCollider meshCollider;

	// Token: 0x040032D1 RID: 13009
	[Token(Token = "0x400272C")]
	[FieldOffset(Offset = "0x48")]
	private MeshLOD meshLOD;

	// Token: 0x040032D2 RID: 13010
	[Token(Token = "0x400272D")]
	[FieldOffset(Offset = "0x50")]
	private Mesh[] meshes;

	// Token: 0x040032D3 RID: 13011
	[Token(Token = "0x400272E")]
	[FieldOffset(Offset = "0x58")]
	private Mesh colliderMesh;

	// Token: 0x040032D4 RID: 13012
	[Token(Token = "0x400272F")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, Mesh> referenceMeshes;

	// Token: 0x040032D5 RID: 13013
	[Token(Token = "0x4002730")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock block;
}
