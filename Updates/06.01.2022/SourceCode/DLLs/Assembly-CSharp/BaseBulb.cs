using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000222 RID: 546
[Token(Token = "0x200016F")]
public class BaseBulb : MonoBehaviour
{
	// Token: 0x060017EE RID: 6126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x84AC20", Offset = "0x849A20", VA = "0x18084AC20", Slot = "4")]
	public virtual void SetOn(bool wantsOn)
	{
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x84AC30", Offset = "0x849A30", VA = "0x18084AC30", Slot = "5")]
	public virtual void SetSpacingIndex(float timeOffset, int bulbIndex)
	{
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x84AC10", Offset = "0x849A10", VA = "0x18084AC10", Slot = "6")]
	public virtual void SetBulbAnimation(AdvancedChristmasLights.AnimationType type)
	{
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x84AC40", Offset = "0x849A40", VA = "0x18084AC40")]
	private void UpdateMaterialProperties()
	{
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x84AE00", Offset = "0x849C00", VA = "0x18084AE00")]
	public BaseBulb()
	{
	}

	// Token: 0x040011D8 RID: 4568
	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x18")]
	public Renderer bulbRenderer;

	// Token: 0x040011D9 RID: 4569
	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int timeOffsetHash;

	// Token: 0x040011DA RID: 4570
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int bulbIndexHash;

	// Token: 0x040011DB RID: 4571
	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int modeHash;

	// Token: 0x040011DC RID: 4572
	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x20")]
	private AdvancedChristmasLights.AnimationType currentAnimationType;

	// Token: 0x040011DD RID: 4573
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x24")]
	private float timeOffset;

	// Token: 0x040011DE RID: 4574
	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x28")]
	private int bulbIndex;

	// Token: 0x040011DF RID: 4575
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x2C")]
	private bool isOn;

	// Token: 0x040011E0 RID: 4576
	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock materialPropertyBlock;
}
