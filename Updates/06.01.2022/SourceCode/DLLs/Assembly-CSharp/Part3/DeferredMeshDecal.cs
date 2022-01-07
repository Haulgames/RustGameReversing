using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008DC RID: 2268
[Token(Token = "0x2000663")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBA0A0", Offset = "0xB94A0")]
public class DeferredMeshDecal : MonoBehaviour, IClientComponent
{
	// Token: 0x060036FA RID: 14074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E40")]
	[Address(RVA = "0x8C7D30", Offset = "0x8C6B30", VA = "0x1808C7D30")]
	private void OnEnable()
	{
	}

	// Token: 0x060036FB RID: 14075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E41")]
	[Address(RVA = "0x8C7C30", Offset = "0x8C6A30", VA = "0x1808C7C30")]
	private void OnDisable()
	{
	}

	// Token: 0x060036FC RID: 14076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E42")]
	[Address(RVA = "0x8C7B50", Offset = "0x8C6950", VA = "0x1808C7B50")]
	private void OnBecameVisible()
	{
	}

	// Token: 0x060036FD RID: 14077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E43")]
	[Address(RVA = "0x8C7A80", Offset = "0x8C6880", VA = "0x1808C7A80")]
	private void OnBecameInvisible()
	{
	}

	// Token: 0x060036FE RID: 14078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E44")]
	[Address(RVA = "0x8C77C0", Offset = "0x8C65C0", VA = "0x1808C77C0")]
	private void CleanupLinks()
	{
	}

	// Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E45")]
	[Address(RVA = "0x8C7E40", Offset = "0x8C6C40", VA = "0x1808C7E40")]
	private void PrepareLinks(Material[] mats)
	{
	}

	// Token: 0x06003700 RID: 14080 RVA: 0x00016E78 File Offset: 0x00015078
	[Token(Token = "0x6002E46")]
	[Address(RVA = "0x8C7980", Offset = "0x8C6780", VA = "0x1808C7980")]
	public bool IsLinkedToMaterial(Material mat)
	{
		return default(bool);
	}

	// Token: 0x06003701 RID: 14081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E47")]
	[Address(RVA = "0x8C76E0", Offset = "0x8C64E0", VA = "0x1808C76E0")]
	public void AddToCommandBuffer(CommandBuffer cb)
	{
	}

	// Token: 0x06003702 RID: 14082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002E48")]
	[Address(RVA = "0x326940", Offset = "0x325740", VA = "0x180326940")]
	public List<DeferredMeshDecal.InstanceData> GetInstanceData()
	{
		return null;
	}

	// Token: 0x06003703 RID: 14083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x8C8110", Offset = "0x8C6F10", VA = "0x1808C8110")]
	public DeferredMeshDecal()
	{
	}

	// Token: 0x04003355 RID: 13141
	[Token(Token = "0x4002798")]
	[FieldOffset(Offset = "0x18")]
	private bool isVisible;

	// Token: 0x04003356 RID: 13142
	[Token(Token = "0x4002799")]
	[FieldOffset(Offset = "0x20")]
	private Renderer renderer;

	// Token: 0x04003357 RID: 13143
	[Token(Token = "0x400279A")]
	[FieldOffset(Offset = "0x28")]
	private List<DeferredMeshDecal.MaterialLink> materialLinks;

	// Token: 0x04003358 RID: 13144
	[Token(Token = "0x400279B")]
	[FieldOffset(Offset = "0x30")]
	private List<DeferredMeshDecal.InstanceData> instanceData;

	// Token: 0x020008DD RID: 2269
	[Token(Token = "0x2000CA4")]
	public class MaterialReplacement
	{
		// Token: 0x06003704 RID: 14084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502F")]
		[Address(RVA = "0x8D5E30", Offset = "0x8D4C30", VA = "0x1808D5E30")]
		private MaterialReplacement(Material reference)
		{
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005030")]
		[Address(RVA = "0x8D5A90", Offset = "0x8D4890", VA = "0x1808D5A90")]
		public static DeferredMeshDecal.MaterialReplacement Allocate(Material reference)
		{
			return null;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005031")]
		[Address(RVA = "0x8D5CE0", Offset = "0x8D4AE0", VA = "0x1808D5CE0")]
		public void Release()
		{
		}

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x40048AF")]
		[FieldOffset(Offset = "0x10")]
		public Material reference;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x40048B0")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x40048B1")]
		[FieldOffset(Offset = "0x20")]
		private int refCount;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x40048B2")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Material, DeferredMeshDecal.MaterialReplacement> pool;
	}

	// Token: 0x020008DE RID: 2270
	[Token(Token = "0x2000CA5")]
	public struct MaterialLink
	{
		// Token: 0x06003708 RID: 14088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005033")]
		[Address(RVA = "0xF5090", Offset = "0xF4490", VA = "0x1800F5090")]
		public MaterialLink(DeferredMeshDecal.MaterialReplacement replacement, int submeshIndex)
		{
		}

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x40048B3")]
		[FieldOffset(Offset = "0x0")]
		public DeferredMeshDecal.MaterialReplacement replacement;

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x40048B4")]
		[FieldOffset(Offset = "0x8")]
		public int submeshIndex;
	}

	// Token: 0x020008DF RID: 2271
	[Token(Token = "0x2000CA6")]
	public class InstanceData
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076A")]
		public Material Material
		{
			[Token(Token = "0x6005034")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076B")]
		public Mesh Mesh
		{
			[Token(Token = "0x6005035")]
			[Address(RVA = "0x2F9830", Offset = "0x2F8630", VA = "0x1802F9830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x00016E90 File Offset: 0x00015090
		[Token(Token = "0x1700076C")]
		public int SubmeshIndex
		{
			[Token(Token = "0x6005036")]
			[Address(RVA = "0x679AC0", Offset = "0x6788C0", VA = "0x180679AC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x00016EA8 File Offset: 0x000150A8
		[Token(Token = "0x1700076D")]
		public Matrix4x4 LocalToWorld
		{
			[Token(Token = "0x6005037")]
			[Address(RVA = "0x8D5A40", Offset = "0x8D4840", VA = "0x1808D5A40")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x8D57F0", Offset = "0x8D45F0", VA = "0x1808D57F0")]
		public InstanceData(Renderer renderer, Material material, int submeshIndex)
		{
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00016EC0 File Offset: 0x000150C0
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x8D5770", Offset = "0x8D4570", VA = "0x1808D5770")]
		private int GenerateHashCode()
		{
			return 0;
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00016ED8 File Offset: 0x000150D8
		[Token(Token = "0x600503A")]
		[Address(RVA = "0x8D5650", Offset = "0x8D4450", VA = "0x1808D5650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00016EF0 File Offset: 0x000150F0
		[Token(Token = "0x600503B")]
		[Address(RVA = "0x56E6A0", Offset = "0x56D4A0", VA = "0x18056E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x40048B5")]
		[FieldOffset(Offset = "0x10")]
		private Transform transform;

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x40048B6")]
		[FieldOffset(Offset = "0x18")]
		private Material material;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x40048B7")]
		[FieldOffset(Offset = "0x20")]
		private Mesh mesh;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x40048B8")]
		[FieldOffset(Offset = "0x28")]
		private int submeshIndex;

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x40048B9")]
		[FieldOffset(Offset = "0x2C")]
		private int hash;
	}
}
