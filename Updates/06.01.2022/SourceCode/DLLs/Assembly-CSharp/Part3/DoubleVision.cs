using System;
using Il2CppDummyDll;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x0200075F RID: 1887
[Token(Token = "0x2000585")]
[Attribute(Name = "PostProcessAttribute", RVA = "0x91F60", Offset = "0x91360")]
[Serializable]
public class DoubleVision : PostProcessEffectSettings
{
	// Token: 0x06002FD4 RID: 12244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002869")]
	[Address(RVA = "0x97ABB0", Offset = "0x9799B0", VA = "0x18097ABB0")]
	public DoubleVision()
	{
	}

	// Token: 0x04002C90 RID: 11408
	[Token(Token = "0x400237E")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public Vector2Parameter displace;

	// Token: 0x04002C91 RID: 11409
	[Token(Token = "0x400237F")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public FloatParameter amount;
}
