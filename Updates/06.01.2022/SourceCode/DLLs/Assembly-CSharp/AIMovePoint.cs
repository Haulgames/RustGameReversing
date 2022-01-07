using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026C RID: 620
[Token(Token = "0x20001AE")]
public class AIMovePoint : AIPoint
{
	// Token: 0x06001920 RID: 6432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x816430", Offset = "0x815230", VA = "0x180816430")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x816100", Offset = "0x814F00", VA = "0x180816100")]
	public void DrawLookAtPoints()
	{
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x8160E0", Offset = "0x814EE0", VA = "0x1808160E0")]
	public void Clear()
	{
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x816040", Offset = "0x814E40", VA = "0x180816040")]
	public void AddLookAtPoint(Transform transform)
	{
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x0000CD20 File Offset: 0x0000AF20
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x8163F0", Offset = "0x8151F0", VA = "0x1808163F0")]
	public bool HasLookAtPoints()
	{
		return default(bool);
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x816380", Offset = "0x815180", VA = "0x180816380")]
	public Transform GetRandomLookAtPoint()
	{
		return null;
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x8164E0", Offset = "0x8152E0", VA = "0x1808164E0")]
	public AIMovePoint()
	{
	}

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x20")]
	public ListDictionary<AIMovePoint, float> distances;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x28")]
	public ListDictionary<AICoverPoint, float> distancesToCover;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x30")]
	public float radius;

	// Token: 0x04001369 RID: 4969
	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x34")]
	public float WaitTime;

	// Token: 0x0400136A RID: 4970
	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> LookAtPoints;

	// Token: 0x0200026D RID: 621
	[Token(Token = "0x2000AF3")]
	public class DistTo
	{
		// Token: 0x06001927 RID: 6439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDE")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public DistTo()
		{
		}

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x400408C")]
		[FieldOffset(Offset = "0x10")]
		public float distance;

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x400408D")]
		[FieldOffset(Offset = "0x18")]
		public AIMovePoint target;
	}
}
