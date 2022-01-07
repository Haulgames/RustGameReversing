using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B66 RID: 2918
[Token(Token = "0x2000826")]
public static class BoundsEx
{
	// Token: 0x060043B4 RID: 17332 RVA: 0x00019200 File Offset: 0x00017400
	[Token(Token = "0x600391F")]
	[Address(RVA = "0x467070", Offset = "0x465E70", VA = "0x180467070")]
	public static Bounds XZ3D(this Bounds bounds)
	{
		return default(Bounds);
	}

	// Token: 0x060043B5 RID: 17333 RVA: 0x00019218 File Offset: 0x00017418
	[Token(Token = "0x6003920")]
	[Address(RVA = "0x466DD0", Offset = "0x465BD0", VA = "0x180466DD0")]
	public static Bounds Transform(this Bounds bounds, Matrix4x4 matrix)
	{
		return default(Bounds);
	}

	// Token: 0x060043B6 RID: 17334 RVA: 0x00019230 File Offset: 0x00017430
	[Token(Token = "0x6003921")]
	[Address(RVA = "0x466070", Offset = "0x464E70", VA = "0x180466070")]
	public static Rect ToScreenRect(this Bounds b, Camera cam)
	{
		return default(Rect);
	}

	// Token: 0x060043B7 RID: 17335 RVA: 0x00019248 File Offset: 0x00017448
	[Token(Token = "0x6003922")]
	[Address(RVA = "0x465F70", Offset = "0x464D70", VA = "0x180465F70")]
	public static Rect ToCanvasRect(this Bounds b, RectTransform target, Camera cam)
	{
		return default(Rect);
	}

	// Token: 0x040040CC RID: 16588
	[Token(Token = "0x40031ED")]
	[FieldOffset(Offset = "0x29CE5B0")]
	private static Vector3[] pts;
}
