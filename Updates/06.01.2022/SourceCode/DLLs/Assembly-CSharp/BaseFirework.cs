using System;
using Il2CppDummyDll;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200000F")]
public class BaseFirework : BaseCombatEntity, IIgniteable
{
	// Token: 0x0600006D RID: 109 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x88C7D0", Offset = "0x88B5D0", VA = "0x18088C7D0")]
	public bool IsLit()
	{
		return default(bool);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x893F80", Offset = "0x892D80", VA = "0x180893F80")]
	public bool IsExhausted()
	{
		return default(bool);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x893F40", Offset = "0x892D40", VA = "0x180893F40", Slot = "133")]
	public override bool CanPickup(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x893F90", Offset = "0x892D90", VA = "0x180893F90")]
	public BaseFirework()
	{
	}

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x238")]
	public float fuseLength;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x23C")]
	public float activityLength;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x400003A")]
	public const BaseEntity.Flags Flag_Spent = BaseEntity.Flags.Reserved8;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x240")]
	public float corpseDuration;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x244")]
	public bool limitActiveCount;
}
