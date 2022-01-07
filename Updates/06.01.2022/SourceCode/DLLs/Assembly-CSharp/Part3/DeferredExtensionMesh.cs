using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008D5 RID: 2261
[Token(Token = "0x200065E")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xB9B90", Offset = "0xB8F90")]
public class DeferredExtensionMesh : MonoBehaviour
{
	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x060036D6 RID: 14038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000400")]
	private MaterialPropertyBlock block
	{
		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x8C3D40", Offset = "0x8C2B40", VA = "0x1808C3D40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x060036D7 RID: 14039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000401")]
	private Renderer renderer
	{
		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x8C3DB0", Offset = "0x8C2BB0", VA = "0x1808C3DB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E20")]
	[Address(RVA = "0x8C37F0", Offset = "0x8C25F0", VA = "0x1808C37F0")]
	private void OnEnable()
	{
	}

	// Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E21")]
	[Address(RVA = "0x8C36C0", Offset = "0x8C24C0", VA = "0x1808C36C0")]
	private void OnDisable()
	{
	}

	// Token: 0x060036DA RID: 14042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E22")]
	[Address(RVA = "0x8C3BB0", Offset = "0x8C29B0", VA = "0x1808C3BB0")]
	public void UpdatePropertyBlock()
	{
	}

	// Token: 0x060036DB RID: 14043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E23")]
	[Address(RVA = "0x8C35E0", Offset = "0x8C23E0", VA = "0x1808C35E0")]
	private void OnBecameVisible()
	{
	}

	// Token: 0x060036DC RID: 14044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E24")]
	[Address(RVA = "0x8C3510", Offset = "0x8C2310", VA = "0x1808C3510")]
	private void OnBecameInvisible()
	{
	}

	// Token: 0x060036DD RID: 14045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E25")]
	[Address(RVA = "0x8C34C0", Offset = "0x8C22C0", VA = "0x1808C34C0")]
	private void CleanupMaterials()
	{
	}

	// Token: 0x060036DE RID: 14046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E26")]
	[Address(RVA = "0x8C39F0", Offset = "0x8C27F0", VA = "0x1808C39F0")]
	private void PrepareMaterials(Material[] mats)
	{
	}

	// Token: 0x060036DF RID: 14047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E27")]
	[Address(RVA = "0x8C3350", Offset = "0x8C2150", VA = "0x1808C3350")]
	public void AddToCommandBuffer(CommandBuffer cb)
	{
	}

	// Token: 0x060036E0 RID: 14048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E28")]
	[Address(RVA = "0x8C3CD0", Offset = "0x8C2AD0", VA = "0x1808C3CD0")]
	public DeferredExtensionMesh()
	{
	}

	// Token: 0x04003341 RID: 13121
	[Token(Token = "0x4002789")]
	[FieldOffset(Offset = "0x18")]
	public SubsurfaceProfile subsurfaceProfile;

	// Token: 0x04003342 RID: 13122
	[Token(Token = "0x400278A")]
	[FieldOffset(Offset = "0x20")]
	private bool isVisible;

	// Token: 0x04003343 RID: 13123
	[Token(Token = "0x400278B")]
	[FieldOffset(Offset = "0x28")]
	private List<DeferredExtensionMesh.MaterialLink> materialLinks;

	// Token: 0x04003344 RID: 13124
	[Token(Token = "0x400278C")]
	[FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock _block;

	// Token: 0x04003345 RID: 13125
	[Token(Token = "0x400278D")]
	[FieldOffset(Offset = "0x38")]
	private Renderer _renderer;

	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x2000CA2")]
	public struct MaterialLink
	{
		// Token: 0x060036E1 RID: 14049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502D")]
		[Address(RVA = "0xF4710", Offset = "0xF3B10", VA = "0x1800F4710")]
		public MaterialLink(Material material, int submeshIndex, int passIndex)
		{
		}

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x40048AA")]
		[FieldOffset(Offset = "0x0")]
		public Material material;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x40048AB")]
		[FieldOffset(Offset = "0x8")]
		public int submeshIndex;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x40048AC")]
		[FieldOffset(Offset = "0xC")]
		public int passIndex;
	}
}
