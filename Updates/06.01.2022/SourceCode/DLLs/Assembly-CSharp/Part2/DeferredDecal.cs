using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008CB RID: 2251
[Token(Token = "0x2000656")]
[ExecuteInEditMode]
public class DeferredDecal : MonoBehaviour
{
	// Token: 0x1700047A RID: 1146
	// (get) Token: 0x0600369E RID: 13982 RVA: 0x00016D28 File Offset: 0x00014F28
	[Token(Token = "0x170003FB")]
	public Matrix4x4 matrix
	{
		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x8C3230", Offset = "0x8C2030", VA = "0x1808C3230")]
		get
		{
			return default(Matrix4x4);
		}
	}

	// Token: 0x0600369F RID: 13983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x8C31D0", Offset = "0x8C1FD0", VA = "0x1808C31D0")]
	protected void OnEnable()
	{
	}

	// Token: 0x060036A0 RID: 13984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x8C3170", Offset = "0x8C1F70", VA = "0x1808C3170")]
	protected void OnDisable()
	{
	}

	// Token: 0x060036A1 RID: 13985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DeferredDecal()
	{
	}

	// Token: 0x040032FA RID: 13050
	[Token(Token = "0x400274E")]
	[FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	// Token: 0x040032FB RID: 13051
	[Token(Token = "0x400274F")]
	[FieldOffset(Offset = "0x20")]
	public Material material;

	// Token: 0x040032FC RID: 13052
	[Token(Token = "0x4002750")]
	[FieldOffset(Offset = "0x28")]
	public DeferredDecalQueue queue;

	// Token: 0x040032FD RID: 13053
	[Token(Token = "0x4002751")]
	[FieldOffset(Offset = "0x2C")]
	private bool cached;

	// Token: 0x040032FE RID: 13054
	[Token(Token = "0x4002752")]
	[FieldOffset(Offset = "0x30")]
	private Matrix4x4 localToWorldMatrix;
}
