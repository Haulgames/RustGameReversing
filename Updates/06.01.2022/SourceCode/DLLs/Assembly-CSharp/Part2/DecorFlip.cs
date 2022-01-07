using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A4 RID: 1956
[Token(Token = "0x20005AD")]
public class DecorFlip : DecorComponent
{
	// Token: 0x06003100 RID: 12544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295C")]
	[Address(RVA = "0x8BDA80", Offset = "0x8BC880", VA = "0x1808BDA80", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295D")]
	[Address(RVA = "0x8BDC60", Offset = "0x8BCA60", VA = "0x1808BDC60")]
	public DecorFlip()
	{
	}

	// Token: 0x04002DD4 RID: 11732
	[Token(Token = "0x4002430")]
	[FieldOffset(Offset = "0xA0")]
	public DecorFlip.AxisType FlipAxis;

	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x2000C26")]
	public enum AxisType
	{
		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x40046A2")]
		X,
		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x40046A3")]
		Y,
		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x40046A4")]
		Z
	}
}
