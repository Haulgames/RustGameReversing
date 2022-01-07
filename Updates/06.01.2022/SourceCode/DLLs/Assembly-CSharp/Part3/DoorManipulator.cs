using System;
using Il2CppDummyDll;

// Token: 0x020005AA RID: 1450
[Token(Token = "0x200043C")]
public class DoorManipulator : IOEntity
{
	// Token: 0x06002902 RID: 10498 RVA: 0x00011DC0 File Offset: 0x0000FFC0
	[Token(Token = "0x6002263")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "158")]
	public virtual bool PairWithLockedDoors()
	{
		return default(bool);
	}

	// Token: 0x06002903 RID: 10499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002264")]
	[Address(RVA = "0x97A6C0", Offset = "0x9794C0", VA = "0x18097A6C0")]
	public DoorManipulator()
	{
	}

	// Token: 0x0400248F RID: 9359
	[Token(Token = "0x4001DEF")]
	[FieldOffset(Offset = "0x268")]
	public EntityRef entityRef;

	// Token: 0x04002490 RID: 9360
	[Token(Token = "0x4001DF0")]
	[FieldOffset(Offset = "0x278")]
	public Door targetDoor;

	// Token: 0x04002491 RID: 9361
	[Token(Token = "0x4001DF1")]
	[FieldOffset(Offset = "0x280")]
	public DoorManipulator.DoorEffect powerAction;

	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x2000BA1")]
	public enum DoorEffect
	{
		// Token: 0x04002493 RID: 9363
		[Token(Token = "0x40043AB")]
		Close,
		// Token: 0x04002494 RID: 9364
		[Token(Token = "0x40043AC")]
		Open,
		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x40043AD")]
		Toggle
	}
}
