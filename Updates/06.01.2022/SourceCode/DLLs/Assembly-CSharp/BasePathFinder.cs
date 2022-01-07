using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A2 RID: 674
[Token(Token = "0x20001DC")]
public class BasePathFinder
{
	// Token: 0x060019CC RID: 6604 RVA: 0x0000D080 File Offset: 0x0000B280
	[Token(Token = "0x6001464")]
	[Address(RVA = "0x2FEAE0", Offset = "0x2FD8E0", VA = "0x1802FEAE0", Slot = "4")]
	public virtual Vector3 GetRandomPatrolPoint()
	{
		return default(Vector3);
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001465")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "5")]
	public virtual AIMovePoint GetBestRoamPoint(Vector3 anchorPos, Vector3 currentPos, Vector3 currentDirection, float anchorClampDistance, float lookupMaxRange = 20f)
	{
		return null;
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001466")]
	[Address(RVA = "0x2FE880", Offset = "0x2FD680", VA = "0x1802FE880")]
	public void DebugDraw()
	{
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x0000D098 File Offset: 0x0000B298
	[Token(Token = "0x6001467")]
	[Address(RVA = "0x2FEB50", Offset = "0x2FD950", VA = "0x1802FEB50", Slot = "6")]
	public virtual Vector3 GetRandomPositionAround(Vector3 position, float minDistFrom = 0f, float maxDistFrom = 2f)
	{
		return default(Vector3);
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
	[Token(Token = "0x6001468")]
	[Address(RVA = "0x2FE9F0", Offset = "0x2FD7F0", VA = "0x1802FE9F0")]
	public static Vector3 GetPointOnCircle(Vector3 center, float radius, float degrees)
	{
		return default(Vector3);
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001469")]
	[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
	public BasePathFinder()
	{
	}

	// Token: 0x04001455 RID: 5205
	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3[] preferedTopologySamples;

	// Token: 0x04001456 RID: 5206
	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3[] topologySamples;

	// Token: 0x04001457 RID: 5207
	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 chosenPosition;

	// Token: 0x04001458 RID: 5208
	[Token(Token = "0x40010C2")]
	private const float halfPI = 0.017453292f;
}
