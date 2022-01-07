using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000409 RID: 1033
[Token(Token = "0x20002E5")]
public class EffectAudioPerspectiveSwitcher : MonoBehaviour, IEffect, IPrefabPreProcess
{
	// Token: 0x06002178 RID: 8568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B36")]
	[Address(RVA = "0x984070", Offset = "0x982E70", VA = "0x180984070")]
	private BaseViewModel GetViewModel(Effect effect)
	{
		return null;
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B37")]
	[Address(RVA = "0x984710", Offset = "0x983510", VA = "0x180984710", Slot = "6")]
	public virtual void SetupEffect(Effect effect)
	{
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B38")]
	[Address(RVA = "0x984610", Offset = "0x983410", VA = "0x180984610")]
	private void MakeThirdPerson()
	{
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B39")]
	[Address(RVA = "0x9844B0", Offset = "0x9832B0", VA = "0x1809844B0")]
	private void MakeFirstPerson()
	{
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0x9846B0", Offset = "0x9834B0", VA = "0x1809846B0", Slot = "5")]
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public EffectAudioPerspectiveSwitcher()
	{
	}

	// Token: 0x04001C22 RID: 7202
	[Token(Token = "0x40016D5")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public EffectParentToWeaponBone parentToWeaponComponent;
}
