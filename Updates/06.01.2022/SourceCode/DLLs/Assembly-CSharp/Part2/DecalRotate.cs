using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000371 RID: 881
[Token(Token = "0x2000274")]
public class DecalRotate : DecalComponent
{
	// Token: 0x06001DFF RID: 7679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x8BBED0", Offset = "0x8BACD0", VA = "0x1808BBED0", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001835")]
	[Address(RVA = "0x8BBFB0", Offset = "0x8BADB0", VA = "0x1808BBFB0")]
	public DecalRotate()
	{
	}

	// Token: 0x040018FD RID: 6397
	[Token(Token = "0x4001451")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "MinMaxAttribute", RVA = "0xB2B40", Offset = "0xB1F40")]
	public MinMax range;
}
