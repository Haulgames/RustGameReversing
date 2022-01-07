using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000244 RID: 580
[Token(Token = "0x2000188")]
public class BasePath : MonoBehaviour
{
	// Token: 0x06001863 RID: 6243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void Start()
	{
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130A")]
	[Address(RVA = "0x2FEDF0", Offset = "0x2FDBF0", VA = "0x1802FEDF0")]
	private void AddChildren()
	{
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x2FF4E0", Offset = "0x2FE2E0", VA = "0x1802FF4E0")]
	private void ClearChildren()
	{
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x2FEFF0", Offset = "0x2FDDF0", VA = "0x1802FEFF0")]
	public static void AutoGenerateLinks(BasePath path)
	{
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x2FF8F0", Offset = "0x2FE6F0", VA = "0x1802FF8F0")]
	public void GetNodesNear(Vector3 point, ref List<BasePathNode> nearNodes, float dist = 10f)
	{
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130E")]
	[Address(RVA = "0x2FF630", Offset = "0x2FE430", VA = "0x1802FF630")]
	public BasePathNode GetClosestToPoint(Vector3 point)
	{
		return null;
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x2FFB90", Offset = "0x2FE990", VA = "0x1802FFB90")]
	public PathInterestNode GetRandomInterestNodeAwayFrom(Vector3 from, float dist = 10f)
	{
		return null;
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001310")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BasePath()
	{
	}

	// Token: 0x04001278 RID: 4728
	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0x18")]
	public List<BasePathNode> nodes;

	// Token: 0x04001279 RID: 4729
	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x20")]
	public List<PathInterestNode> interestZones;

	// Token: 0x0400127A RID: 4730
	[Token(Token = "0x4000F06")]
	[FieldOffset(Offset = "0x28")]
	public List<PathSpeedZone> speedZones;
}
