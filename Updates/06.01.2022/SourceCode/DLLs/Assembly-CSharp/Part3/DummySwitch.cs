using System;
using Il2CppDummyDll;

// Token: 0x020005AC RID: 1452
[Token(Token = "0x200043D")]
public class DummySwitch : IOEntity
{
	// Token: 0x06002904 RID: 10500 RVA: 0x00011DD8 File Offset: 0x0000FFD8
	[Token(Token = "0x6002265")]
	[Address(RVA = "0x53F9B0", Offset = "0x53E7B0", VA = "0x18053F9B0", Slot = "147")]
	public override bool WantsPower()
	{
		return default(bool);
	}

	// Token: 0x06002905 RID: 10501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002266")]
	[Address(RVA = "0x97ECC0", Offset = "0x97DAC0", VA = "0x18097ECC0")]
	public DummySwitch()
	{
	}

	// Token: 0x04002496 RID: 9366
	[Token(Token = "0x4001DF2")]
	[FieldOffset(Offset = "0x268")]
	public string listenString;

	// Token: 0x04002497 RID: 9367
	[Token(Token = "0x4001DF3")]
	[FieldOffset(Offset = "0x270")]
	public string listenStringOff;

	// Token: 0x04002498 RID: 9368
	[Token(Token = "0x4001DF4")]
	[FieldOffset(Offset = "0x278")]
	public float duration;
}
