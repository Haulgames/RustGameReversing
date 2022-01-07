using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008E0 RID: 2272
[Token(Token = "0x2000664")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBB5B0", Offset = "0xBA9B0")]
public class DeferredMeshDecalRenderer : MonoBehaviour
{
	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x06003711 RID: 14097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000407")]
	public Camera TargetCamera
	{
		[Token(Token = "0x6002E4A")]
		[Address(RVA = "0x8C7640", Offset = "0x8C6440", VA = "0x1808C7640")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003712 RID: 14098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4B")]
	[Address(RVA = "0x8C6FE0", Offset = "0x8C5DE0", VA = "0x1808C6FE0")]
	public static void Register(DeferredMeshDecal decal)
	{
	}

	// Token: 0x06003713 RID: 14099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4C")]
	[Address(RVA = "0x8C7060", Offset = "0x8C5E60", VA = "0x1808C7060")]
	public static void Unregister(DeferredMeshDecal decal)
	{
	}

	// Token: 0x06003714 RID: 14100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4D")]
	[Address(RVA = "0x8C6E20", Offset = "0x8C5C20", VA = "0x1808C6E20")]
	private void OnEnable()
	{
	}

	// Token: 0x06003715 RID: 14101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4E")]
	[Address(RVA = "0x8C6D90", Offset = "0x8C5B90", VA = "0x1808C6D90")]
	private void OnDisable()
	{
	}

	// Token: 0x06003716 RID: 14102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4F")]
	[Address(RVA = "0x8C64E0", Offset = "0x8C52E0", VA = "0x1808C64E0")]
	private void CreateCommandBuffer()
	{
	}

	// Token: 0x06003717 RID: 14103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E50")]
	[Address(RVA = "0x8C6320", Offset = "0x8C5120", VA = "0x1808C6320")]
	private void CleanupCommandBuffer()
	{
	}

	// Token: 0x06003718 RID: 14104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E51")]
	[Address(RVA = "0x8C6590", Offset = "0x8C5390", VA = "0x1808C6590")]
	private void CreateMaterials()
	{
	}

	// Token: 0x06003719 RID: 14105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E52")]
	[Address(RVA = "0x8C6430", Offset = "0x8C5230", VA = "0x1808C6430")]
	private void CleanupMaterials()
	{
	}

	// Token: 0x0600371A RID: 14106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x8C60E0", Offset = "0x8C4EE0", VA = "0x1808C60E0")]
	public static void BecameVisible(DeferredMeshDecal decal)
	{
	}

	// Token: 0x0600371B RID: 14107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E54")]
	[Address(RVA = "0x8C6060", Offset = "0x8C4E60", VA = "0x1808C6060")]
	public static void BecameInvisible(DeferredMeshDecal decal)
	{
	}

	// Token: 0x0600371C RID: 14108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x8C6160", Offset = "0x8C4F60", VA = "0x1808C6160")]
	private void CleanupBatches()
	{
	}

	// Token: 0x0600371D RID: 14109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E56")]
	[Address(RVA = "0x8C70E0", Offset = "0x8C5EE0", VA = "0x1808C70E0")]
	private void UpdateBatches()
	{
	}

	// Token: 0x0600371E RID: 14110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x8C6630", Offset = "0x8C5430", VA = "0x1808C6630")]
	public void FillCommandBuffer(CommandBuffer cb)
	{
	}

	// Token: 0x0600371F RID: 14111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x8C6F50", Offset = "0x8C5D50", VA = "0x1808C6F50")]
	private void OnPreRender()
	{
	}

	// Token: 0x06003720 RID: 14112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x8C75E0", Offset = "0x8C63E0", VA = "0x1808C75E0")]
	public DeferredMeshDecalRenderer()
	{
	}

	// Token: 0x04003364 RID: 13156
	[Token(Token = "0x400279C")]
	[FieldOffset(Offset = "0x18")]
	private Camera targetCamera;

	// Token: 0x04003365 RID: 13157
	[Token(Token = "0x400279D")]
	private const string commandBufferName = "DeferredMeshDecals";

	// Token: 0x04003366 RID: 13158
	[Token(Token = "0x400279E")]
	[FieldOffset(Offset = "0x20")]
	private CameraEvent commandBufferEvent;

	// Token: 0x04003367 RID: 13159
	[Token(Token = "0x400279F")]
	[FieldOffset(Offset = "0x28")]
	private CommandBuffer commandBuffer;

	// Token: 0x04003368 RID: 13160
	[Token(Token = "0x40027A0")]
	[FieldOffset(Offset = "0x30")]
	private RenderTargetIdentifier[] targets;

	// Token: 0x04003369 RID: 13161
	[Token(Token = "0x40027A1")]
	[FieldOffset(Offset = "0x38")]
	private Material multiCopyMat;

	// Token: 0x0400336A RID: 13162
	[Token(Token = "0x40027A2")]
	[FieldOffset(Offset = "0x40")]
	private MaterialPropertyBlock block;

	// Token: 0x0400336B RID: 13163
	[Token(Token = "0x40027A3")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<DeferredMeshDecal> registered;

	// Token: 0x0400336C RID: 13164
	[Token(Token = "0x40027A4")]
	[FieldOffset(Offset = "0x8")]
	private static HashSet<DeferredMeshDecal> visible;

	// Token: 0x0400336D RID: 13165
	[Token(Token = "0x40027A5")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<DeferredMeshDecal.InstanceData, SimpleList<Matrix4x4>> batches;
}
