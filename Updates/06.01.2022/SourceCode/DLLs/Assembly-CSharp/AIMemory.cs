using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000436 RID: 1078
[Token(Token = "0x2000310")]
public class AIMemory
{
	// Token: 0x06002230 RID: 8752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x815520", Offset = "0x814320", VA = "0x180815520")]
	public AIMemory()
	{
	}

	// Token: 0x04001CFB RID: 7419
	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x10")]
	public AIMemoryBank<BaseEntity> Entity;

	// Token: 0x04001CFC RID: 7420
	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x18")]
	public AIMemoryBank<Vector3> Position;

	// Token: 0x04001CFD RID: 7421
	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x20")]
	public AIMemoryBank<AIPoint> AIPoint;
}
