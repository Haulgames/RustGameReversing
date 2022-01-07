using System;
using Il2CppDummyDll;

// Token: 0x020004A4 RID: 1188
[Token(Token = "0x2000371")]
public class EntityFlag_ToggleNotify : EntityFlag_Toggle
{
	// Token: 0x06002457 RID: 9303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0x84F940", Offset = "0x84E740", VA = "0x18084F940", Slot = "13")]
	protected override void OnStateToggled(bool state)
	{
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DFC")]
	[Address(RVA = "0x84FB00", Offset = "0x84E900", VA = "0x18084FB00")]
	public EntityFlag_ToggleNotify()
	{
	}

	// Token: 0x04001E9A RID: 7834
	[Token(Token = "0x4001912")]
	[FieldOffset(Offset = "0x40")]
	public bool UseEntityParent;
}
