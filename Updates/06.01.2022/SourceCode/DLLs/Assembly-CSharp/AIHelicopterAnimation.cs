using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000505 RID: 1285
[Token(Token = "0x20003B7")]
public class AIHelicopterAnimation : MonoBehaviour
{
	// Token: 0x060025A4 RID: 9636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x813BA0", Offset = "0x8129A0", VA = "0x180813BA0")]
	public AIHelicopterAnimation()
	{
	}

	// Token: 0x04002075 RID: 8309
	[Token(Token = "0x4001A65")]
	[FieldOffset(Offset = "0x18")]
	public PatrolHelicopterAI _ai;

	// Token: 0x04002076 RID: 8310
	[Token(Token = "0x4001A66")]
	[FieldOffset(Offset = "0x20")]
	public float swayAmount;

	// Token: 0x04002077 RID: 8311
	[Token(Token = "0x4001A67")]
	[FieldOffset(Offset = "0x24")]
	public float lastStrafeScalar;

	// Token: 0x04002078 RID: 8312
	[Token(Token = "0x4001A68")]
	[FieldOffset(Offset = "0x28")]
	public float lastForwardBackScalar;

	// Token: 0x04002079 RID: 8313
	[Token(Token = "0x4001A69")]
	[FieldOffset(Offset = "0x2C")]
	public float degreeMax;

	// Token: 0x0400207A RID: 8314
	[Token(Token = "0x4001A6A")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 lastPosition;

	// Token: 0x0400207B RID: 8315
	[Token(Token = "0x4001A6B")]
	[FieldOffset(Offset = "0x3C")]
	public float oldMoveSpeed;

	// Token: 0x0400207C RID: 8316
	[Token(Token = "0x4001A6C")]
	[FieldOffset(Offset = "0x40")]
	public float smoothRateOfChange;

	// Token: 0x0400207D RID: 8317
	[Token(Token = "0x4001A6D")]
	[FieldOffset(Offset = "0x44")]
	public float flareAmount;
}
