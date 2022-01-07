using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A6 RID: 1958
[Token(Token = "0x20005AE")]
public class DecorOffset : DecorComponent
{
	// Token: 0x06003102 RID: 12546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295E")]
	[Address(RVA = "0x8BDCC0", Offset = "0x8BCAC0", VA = "0x1808BDCC0", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x06003103 RID: 12547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295F")]
	[Address(RVA = "0x8BDDF0", Offset = "0x8BCBF0", VA = "0x1808BDDF0")]
	public DecorOffset()
	{
	}

	// Token: 0x04002DD9 RID: 11737
	[Token(Token = "0x4002431")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 MinOffset;

	// Token: 0x04002DDA RID: 11738
	[Token(Token = "0x4002432")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 MaxOffset;
}
