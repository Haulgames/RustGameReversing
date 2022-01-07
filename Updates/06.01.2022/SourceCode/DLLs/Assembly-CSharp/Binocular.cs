using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000485 RID: 1157
[Token(Token = "0x2000358")]
public class Binocular : AttackEntity
{
	// Token: 0x0600239D RID: 9117 RVA: 0x00010008 File Offset: 0x0000E208
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x45B4C0", Offset = "0x45A2C0", VA = "0x18045B4C0")]
	public bool IsAiming()
	{
		return default(bool);
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x45B4E0", Offset = "0x45A2E0", VA = "0x18045B4E0", Slot = "139")]
	public override void OnDeploy()
	{
	}

	// Token: 0x0600239F RID: 9119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x45BA30", Offset = "0x45A830", VA = "0x18045BA30", Slot = "141")]
	public override void OnHolster()
	{
	}

	// Token: 0x060023A0 RID: 9120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D54")]
	[Address(RVA = "0x45B1D0", Offset = "0x459FD0", VA = "0x18045B1D0")]
	public void ClearOverlays()
	{
	}

	// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x45B5C0", Offset = "0x45A3C0", VA = "0x18045B5C0", Slot = "136")]
	public override void OnFrame()
	{
	}

	// Token: 0x060023A2 RID: 9122 RVA: 0x00010020 File Offset: 0x0000E220
	[Token(Token = "0x6001D56")]
	[Address(RVA = "0x45B230", Offset = "0x45A030", VA = "0x18045B230")]
	public Vector3 GetScreenPos(Vector3 oldPos)
	{
		return default(Vector3);
	}

	// Token: 0x060023A3 RID: 9123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x45BD00", Offset = "0x45AB00", VA = "0x18045BD00")]
	public void SetViewmodelVisiblity(bool visible)
	{
	}

	// Token: 0x060023A4 RID: 9124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D58")]
	[Address(RVA = "0x45BAA0", Offset = "0x45A8A0", VA = "0x18045BAA0", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x060023A5 RID: 9125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D59")]
	[Address(RVA = "0x45BE10", Offset = "0x45AC10", VA = "0x18045BE10")]
	public Binocular()
	{
	}

	// Token: 0x04001E22 RID: 7714
	[Token(Token = "0x40018A8")]
	[FieldOffset(Offset = "0x278")]
	public float[] fovs;

	// Token: 0x04001E23 RID: 7715
	[Token(Token = "0x40018A9")]
	[FieldOffset(Offset = "0x280")]
	public GameObjectRef fovChangeEffect;

	// Token: 0x04001E24 RID: 7716
	[Token(Token = "0x40018AA")]
	[FieldOffset(Offset = "0x288")]
	public float smoothSpeed;

	// Token: 0x04001E25 RID: 7717
	[Token(Token = "0x40018AB")]
	[FieldOffset(Offset = "0x28C")]
	private bool vmVisible;

	// Token: 0x04001E26 RID: 7718
	[Token(Token = "0x40018AC")]
	[FieldOffset(Offset = "0x28D")]
	private bool isAiming;

	// Token: 0x04001E27 RID: 7719
	[Token(Token = "0x40018AD")]
	[FieldOffset(Offset = "0x290")]
	private float timeAiming;

	// Token: 0x04001E28 RID: 7720
	[Token(Token = "0x40018AE")]
	[FieldOffset(Offset = "0x294")]
	private int currentFovIndex;
}
