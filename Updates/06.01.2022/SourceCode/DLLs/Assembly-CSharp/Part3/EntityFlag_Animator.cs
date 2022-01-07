using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A0 RID: 1184
[Token(Token = "0x200036E")]
public class EntityFlag_Animator : EntityFlag_Toggle
{
	// Token: 0x170002BB RID: 699
	// (get) Token: 0x0600244C RID: 9292 RVA: 0x00010290 File Offset: 0x0000E490
	[Token(Token = "0x17000288")]
	private int ParamHash
	{
		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0x84F8D0", Offset = "0x84E6D0", VA = "0x18084F8D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x84F6D0", Offset = "0x84E4D0", VA = "0x18084F6D0", Slot = "13")]
	protected override void OnStateToggled(bool state)
	{
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x84F880", Offset = "0x84E680", VA = "0x18084F880")]
	public EntityFlag_Animator()
	{
	}

	// Token: 0x04001E83 RID: 7811
	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x40")]
	public Animator TargetAnimator;

	// Token: 0x04001E84 RID: 7812
	[Token(Token = "0x4001901")]
	[FieldOffset(Offset = "0x48")]
	public string ParamName;

	// Token: 0x04001E85 RID: 7813
	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x50")]
	public EntityFlag_Animator.AnimatorMode AnimationMode;

	// Token: 0x04001E86 RID: 7814
	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x54")]
	public float FloatOnState;

	// Token: 0x04001E87 RID: 7815
	[Token(Token = "0x4001904")]
	[FieldOffset(Offset = "0x58")]
	public float FloatOffState;

	// Token: 0x04001E88 RID: 7816
	[Token(Token = "0x4001905")]
	[FieldOffset(Offset = "0x5C")]
	public int IntegerOnState;

	// Token: 0x04001E89 RID: 7817
	[Token(Token = "0x4001906")]
	[FieldOffset(Offset = "0x60")]
	public int IntegerOffState;

	// Token: 0x04001E8A RID: 7818
	[Token(Token = "0x4001907")]
	[FieldOffset(Offset = "0x64")]
	private int cachedHash;

	// Token: 0x04001E8B RID: 7819
	[Token(Token = "0x4001908")]
	[FieldOffset(Offset = "0x68")]
	private bool cachedState;

	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x2000B67")]
	public enum AnimatorMode
	{
		// Token: 0x04001E8D RID: 7821
		[Token(Token = "0x400429A")]
		Bool,
		// Token: 0x04001E8E RID: 7822
		[Token(Token = "0x400429B")]
		Float,
		// Token: 0x04001E8F RID: 7823
		[Token(Token = "0x400429C")]
		Trigger,
		// Token: 0x04001E90 RID: 7824
		[Token(Token = "0x400429D")]
		Integer
	}
}
