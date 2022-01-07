using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200040F RID: 1039
[Token(Token = "0x20002EB")]
public class EffectParentToWeaponBone : BaseMonoBehaviour, IEffect
{
	// Token: 0x0600218D RID: 8589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x9879E0", Offset = "0x9867E0", VA = "0x1809879E0", Slot = "7")]
	public virtual void SetupEffect(Effect effect)
	{
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x987460", Offset = "0x986260", VA = "0x180987460")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x0000F678 File Offset: 0x0000D878
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x987170", Offset = "0x985F70", VA = "0x180987170")]
	private bool ApplyToViewModel()
	{
		return default(bool);
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x9876B0", Offset = "0x9864B0", VA = "0x1809876B0")]
	private void PositionOnObject(GameObject wm)
	{
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x987430", Offset = "0x986230", VA = "0x180987430")]
	public void ClearParent()
	{
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public EffectParentToWeaponBone()
	{
	}

	// Token: 0x04001C24 RID: 7204
	[Token(Token = "0x40016D7")]
	[FieldOffset(Offset = "0x18")]
	public string boneName;

	// Token: 0x04001C25 RID: 7205
	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0x20")]
	public bool singleFrame;

	// Token: 0x04001C26 RID: 7206
	[Token(Token = "0x40016D9")]
	[FieldOffset(Offset = "0x21")]
	private bool isFirstPerson;

	// Token: 0x04001C27 RID: 7207
	[Token(Token = "0x40016DA")]
	[FieldOffset(Offset = "0x28")]
	private Transform bone;
}
