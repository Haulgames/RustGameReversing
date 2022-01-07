using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DA RID: 1498
[Token(Token = "0x200045E")]
public abstract class DeployVolume : PrefabAttribute
{
	// Token: 0x060029DE RID: 10718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002308")]
	[Address(RVA = "0xB62D80", Offset = "0xB61B80", VA = "0x180B62D80", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x060029DF RID: 10719
	[Token(Token = "0x6002309")]
	protected abstract bool Check(Vector3 position, Quaternion rotation, int mask = -1);

	// Token: 0x060029E0 RID: 10720
	[Token(Token = "0x600230A")]
	protected abstract bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1);

	// Token: 0x060029E1 RID: 10721 RVA: 0x00012258 File Offset: 0x00010458
	[Token(Token = "0x600230B")]
	[Address(RVA = "0xB62CB0", Offset = "0xB61AB0", VA = "0x180B62CB0")]
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029E2 RID: 10722 RVA: 0x00012270 File Offset: 0x00010470
	[Token(Token = "0x600230C")]
	[Address(RVA = "0xB62B80", Offset = "0xB61980", VA = "0x180B62B80")]
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, OBB test, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029E3 RID: 10723 RVA: 0x00012288 File Offset: 0x00010488
	[Token(Token = "0x600230D")]
	[Address(RVA = "0xB62A70", Offset = "0xB61870", VA = "0x180B62A70")]
	public static bool CheckSphere(Vector3 pos, float radius, int layerMask, DeployVolume volume)
	{
		return default(bool);
	}

	// Token: 0x060029E4 RID: 10724 RVA: 0x000122A0 File Offset: 0x000104A0
	[Token(Token = "0x600230E")]
	[Address(RVA = "0xB62600", Offset = "0xB61400", VA = "0x180B62600")]
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, DeployVolume volume)
	{
		return default(bool);
	}

	// Token: 0x060029E5 RID: 10725 RVA: 0x000122B8 File Offset: 0x000104B8
	[Token(Token = "0x600230F")]
	[Address(RVA = "0xB62950", Offset = "0xB61750", VA = "0x180B62950")]
	public static bool CheckOBB(OBB obb, int layerMask, DeployVolume volume)
	{
		return default(bool);
	}

	// Token: 0x060029E6 RID: 10726 RVA: 0x000122D0 File Offset: 0x000104D0
	[Token(Token = "0x6002310")]
	[Address(RVA = "0xB62500", Offset = "0xB61300", VA = "0x180B62500")]
	public static bool CheckBounds(Bounds bounds, int layerMask, DeployVolume volume)
	{
		return default(bool);
	}

	// Token: 0x060029E7 RID: 10727 RVA: 0x000122E8 File Offset: 0x000104E8
	[Token(Token = "0x6002311")]
	[Address(RVA = "0xB62730", Offset = "0xB61530", VA = "0x180B62730")]
	private static bool CheckFlags(List<Collider> list, DeployVolume volume)
	{
		return default(bool);
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002312")]
	[Address(RVA = "0xB62DE0", Offset = "0xB61BE0", VA = "0x180B62DE0")]
	protected DeployVolume()
	{
	}

	// Token: 0x04002536 RID: 9526
	[Token(Token = "0x4001E62")]
	[FieldOffset(Offset = "0x98")]
	public LayerMask layers;

	// Token: 0x04002537 RID: 9527
	[Token(Token = "0x4001E63")]
	[FieldOffset(Offset = "0x9C")]
	[InspectorFlags]
	public ColliderInfo.Flags ignore;

	// Token: 0x04002538 RID: 9528
	[Token(Token = "0x4001E64")]
	[FieldOffset(Offset = "0xA0")]
	public DeployVolume.EntityMode entityMode;

	// Token: 0x04002539 RID: 9529
	[Token(Token = "0x4001E65")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x766E0", Offset = "0x75AE0")]
	public BaseEntity[] entityList;

	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x2000BAF")]
	public enum EntityMode
	{
		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x40043DF")]
		ExcludeList,
		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x40043E0")]
		IncludeList
	}
}
