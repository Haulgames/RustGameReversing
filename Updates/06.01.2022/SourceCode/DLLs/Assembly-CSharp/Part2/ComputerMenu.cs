using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000198 RID: 408
[Token(Token = "0x20000F7")]
public class ComputerMenu : UIDialog
{
	// Token: 0x06001542 RID: 5442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x4A6510", Offset = "0x4A5310", VA = "0x1804A6510", Slot = "10")]
	public virtual void InitMenu(BaseEntity computer)
	{
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x0000BDA8 File Offset: 0x00009FA8
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "11")]
	public virtual bool WantsEyeOverride()
	{
		return default(bool);
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "12")]
	public virtual Transform GetCameraOverrideTransform()
	{
		return null;
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x0000BDC0 File Offset: 0x00009FC0
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "13")]
	public virtual BasePlayer.CameraMode GetCameraMode()
	{
		return BasePlayer.CameraMode.FirstPerson;
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "14")]
	public virtual void BookmarkPressed(RCBookmarkEntry entry)
	{
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001023")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "15")]
	public virtual void DisconnectPressed(RCBookmarkEntry entry)
	{
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "16")]
	public virtual void DeletePressed(RCBookmarkEntry entry)
	{
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x0000BDD8 File Offset: 0x00009FD8
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "17")]
	public virtual bool IsControlling(string identifier)
	{
		return default(bool);
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x4A63A0", Offset = "0x4A51A0", VA = "0x1804A63A0")]
	public void ClearBookmarkEntries()
	{
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x4A6540", Offset = "0x4A5340", VA = "0x1804A6540")]
	public void UpdateBookmarks()
	{
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x4A6890", Offset = "0x4A5690", VA = "0x1804A6890")]
	public ComputerMenu()
	{
	}

	// Token: 0x04000EEC RID: 3820
	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform bookmarkContainer;

	// Token: 0x04000EED RID: 3821
	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject bookmarkPrefab;

	// Token: 0x04000EEE RID: 3822
	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x40")]
	public List<RCBookmarkEntry> activeEntries;

	// Token: 0x04000EEF RID: 3823
	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public EntityRef ownerComputer;
}
