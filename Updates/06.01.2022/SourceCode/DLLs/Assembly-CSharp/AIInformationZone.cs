using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x0200026B RID: 619
[Token(Token = "0x20001AD")]
public class AIInformationZone : BaseMonoBehaviour, IServerComponent
{
	// Token: 0x0600191E RID: 6430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x815420", Offset = "0x814220", VA = "0x180815420")]
	public AIInformationZone()
	{
	}

	// Token: 0x0400135A RID: 4954
	[Token(Token = "0x4000FE4")]
	[FieldOffset(Offset = "0x18")]
	public bool ShouldSleepAI;

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x19")]
	public bool Virtual;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x1A")]
	public bool UseCalculatedCoverDistances;

	// Token: 0x0400135D RID: 4957
	[Token(Token = "0x4000FE7")]
	[FieldOffset(Offset = "0x0")]
	public static List<AIInformationZone> zones;

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x20")]
	public List<AICoverPoint> coverPoints;

	// Token: 0x0400135F RID: 4959
	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x28")]
	public List<AIMovePoint> movePoints;

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4000FEA")]
	[FieldOffset(Offset = "0x30")]
	private AICoverPoint[] coverPointArray;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4000FEB")]
	[FieldOffset(Offset = "0x38")]
	private AIMovePoint[] movePointArray;

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4000FEC")]
	[FieldOffset(Offset = "0x40")]
	public List<NavMeshLink> navMeshLinks;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x48")]
	public List<AIMovePointPath> paths;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x50")]
	public Bounds bounds;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x68")]
	private AIInformationGrid grid;
}
