using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A7 RID: 1959
[Token(Token = "0x20005AF")]
public class DecorRotate : DecorComponent
{
	// Token: 0x06003104 RID: 12548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002960")]
	[Address(RVA = "0x8BEC90", Offset = "0x8BDA90", VA = "0x1808BEC90", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x06003105 RID: 12549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002961")]
	[Address(RVA = "0x8BEE20", Offset = "0x8BDC20", VA = "0x1808BEE20")]
	public DecorRotate()
	{
	}

	// Token: 0x04002DDB RID: 11739
	[Token(Token = "0x4002433")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 MinRotation;

	// Token: 0x04002DDC RID: 11740
	[Token(Token = "0x4002434")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 MaxRotation;
}
