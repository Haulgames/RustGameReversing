using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007B7 RID: 1975
[Token(Token = "0x20005BE")]
public class DungeonBaseTransition : MonoBehaviour
{
	// Token: 0x0600313C RID: 12604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002992")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DungeonBaseTransition()
	{
	}

	// Token: 0x04002E19 RID: 11801
	[Token(Token = "0x400246D")]
	[FieldOffset(Offset = "0x18")]
	public DungeonBaseSocketType Type;

	// Token: 0x04002E1A RID: 11802
	[Token(Token = "0x400246E")]
	[FieldOffset(Offset = "0x1C")]
	public DungeonBaseLinkType Neighbour1;

	// Token: 0x04002E1B RID: 11803
	[Token(Token = "0x400246F")]
	[FieldOffset(Offset = "0x20")]
	public DungeonBaseLinkType Neighbour2;
}
