using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D3 RID: 1491
[Token(Token = "0x2000458")]
public class ColliderInfo : MonoBehaviour
{
	// Token: 0x060029C2 RID: 10690 RVA: 0x000121C8 File Offset: 0x000103C8
	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x49F760", Offset = "0x49E560", VA = "0x18049F760")]
	public bool HasFlag(ColliderInfo.Flags f)
	{
		return default(bool);
	}

	// Token: 0x060029C3 RID: 10691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x49F770", Offset = "0x49E570", VA = "0x18049F770")]
	public void SetFlag(ColliderInfo.Flags f, bool b)
	{
	}

	// Token: 0x060029C4 RID: 10692 RVA: 0x000121E0 File Offset: 0x000103E0
	[Token(Token = "0x60022EE")]
	[Address(RVA = "0x49F710", Offset = "0x49E510", VA = "0x18049F710")]
	public bool Filter(HitTest info)
	{
		return default(bool);
	}

	// Token: 0x060029C5 RID: 10693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x49F790", Offset = "0x49E590", VA = "0x18049F790")]
	public ColliderInfo()
	{
	}

	// Token: 0x0400251F RID: 9503
	[Token(Token = "0x4001E51")]
	public const ColliderInfo.Flags FlagsNone = (ColliderInfo.Flags)0;

	// Token: 0x04002520 RID: 9504
	[Token(Token = "0x4001E52")]
	public const ColliderInfo.Flags FlagsEverything = (ColliderInfo.Flags)(-1);

	// Token: 0x04002521 RID: 9505
	[Token(Token = "0x4001E53")]
	public const ColliderInfo.Flags FlagsDefault = ColliderInfo.Flags.Usable | ColliderInfo.Flags.Shootable | ColliderInfo.Flags.Melee | ColliderInfo.Flags.Opaque;

	// Token: 0x04002522 RID: 9506
	[Token(Token = "0x4001E54")]
	[FieldOffset(Offset = "0x18")]
	[InspectorFlags]
	public ColliderInfo.Flags flags;

	// Token: 0x020005D4 RID: 1492
	[Token(Token = "0x2000BAE")]
	[Flags]
	public enum Flags
	{
		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x40043D9")]
		Usable = 1,
		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x40043DA")]
		Shootable = 2,
		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x40043DB")]
		Melee = 4,
		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x40043DC")]
		Opaque = 8,
		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x40043DD")]
		Airflow = 16
	}
}
