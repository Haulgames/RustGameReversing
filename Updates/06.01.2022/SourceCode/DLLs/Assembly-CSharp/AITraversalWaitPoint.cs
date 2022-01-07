using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000273 RID: 627
[Token(Token = "0x20001B2")]
public class AITraversalWaitPoint : MonoBehaviour
{
	// Token: 0x06001945 RID: 6469 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x817A50", Offset = "0x816850", VA = "0x180817A50")]
	public bool Occupied()
	{
		return default(bool);
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x817A70", Offset = "0x816870", VA = "0x180817A70")]
	public void Occupy(float dur = 1f)
	{
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AITraversalWaitPoint()
	{
	}

	// Token: 0x0400137D RID: 4989
	[Token(Token = "0x4000FFF")]
	[FieldOffset(Offset = "0x18")]
	public float nextFreeTime;
}
