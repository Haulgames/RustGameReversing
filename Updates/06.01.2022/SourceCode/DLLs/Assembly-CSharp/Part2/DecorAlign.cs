using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A3 RID: 1955
[Token(Token = "0x20005AC")]
public class DecorAlign : DecorComponent
{
	// Token: 0x060030FE RID: 12542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295A")]
	[Address(RVA = "0x8BCBF0", Offset = "0x8BB9F0", VA = "0x1808BCBF0", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x060030FF RID: 12543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295B")]
	[Address(RVA = "0x8BD4E0", Offset = "0x8BC2E0", VA = "0x1808BD4E0")]
	public DecorAlign()
	{
	}

	// Token: 0x04002DD0 RID: 11728
	[Token(Token = "0x400242C")]
	[FieldOffset(Offset = "0xA0")]
	public float NormalAlignment;

	// Token: 0x04002DD1 RID: 11729
	[Token(Token = "0x400242D")]
	[FieldOffset(Offset = "0xA4")]
	public float GradientAlignment;

	// Token: 0x04002DD2 RID: 11730
	[Token(Token = "0x400242E")]
	[FieldOffset(Offset = "0xA8")]
	public Vector3 SlopeOffset;

	// Token: 0x04002DD3 RID: 11731
	[Token(Token = "0x400242F")]
	[FieldOffset(Offset = "0xB4")]
	public Vector3 SlopeScale;
}
