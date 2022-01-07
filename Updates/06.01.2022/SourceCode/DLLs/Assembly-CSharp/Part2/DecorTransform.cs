using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007AC RID: 1964
[Token(Token = "0x20005B4")]
public class DecorTransform : DecorComponent
{
	// Token: 0x06003110 RID: 12560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600296C")]
	[Address(RVA = "0x8BFF50", Offset = "0x8BED50", VA = "0x1808BFF50", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x06003111 RID: 12561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600296D")]
	[Address(RVA = "0x8C0170", Offset = "0x8BEF70", VA = "0x1808C0170")]
	public DecorTransform()
	{
	}

	// Token: 0x04002DDF RID: 11743
	[Token(Token = "0x4002437")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 Position;

	// Token: 0x04002DE0 RID: 11744
	[Token(Token = "0x4002438")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 Rotation;

	// Token: 0x04002DE1 RID: 11745
	[Token(Token = "0x4002439")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 Scale;
}
