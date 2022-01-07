using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A8 RID: 1960
[Token(Token = "0x20005B0")]
public class DecorScale : DecorComponent
{
	// Token: 0x06003106 RID: 12550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002962")]
	[Address(RVA = "0x8BEF00", Offset = "0x8BDD00", VA = "0x1808BEF00", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x06003107 RID: 12551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002963")]
	[Address(RVA = "0x8BF080", Offset = "0x8BDE80", VA = "0x1808BF080")]
	public DecorScale()
	{
	}

	// Token: 0x04002DDD RID: 11741
	[Token(Token = "0x4002435")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 MinScale;

	// Token: 0x04002DDE RID: 11742
	[Token(Token = "0x4002436")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 MaxScale;
}
