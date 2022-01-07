using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x0200099C RID: 2460
[Token(Token = "0x20006E8")]
public class DemoShotListFolderWidget : MonoBehaviour
{
	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x06003A43 RID: 14915 RVA: 0x00017958 File Offset: 0x00015B58
	// (set) Token: 0x06003A44 RID: 14916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000428")]
	public bool CurrentState
	{
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x2FB980", Offset = "0x2FA780", VA = "0x1802FB980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x2FBB70", Offset = "0x2FA970", VA = "0x1802FBB70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x06003A45 RID: 14917 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A46 RID: 14918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000429")]
	public string cachedFolderName
	{
		[Token(Token = "0x6003113")]
		[Address(RVA = "0x6B25A0", Offset = "0x6B13A0", VA = "0x1806B25A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003114")]
		[Address(RVA = "0x8CDD50", Offset = "0x8CCB50", VA = "0x1808CDD50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06003A47 RID: 14919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003115")]
	[Address(RVA = "0x8CDAD0", Offset = "0x8CC8D0", VA = "0x1808CDAD0")]
	public void Populate(string folderName, bool state)
	{
	}

	// Token: 0x06003A48 RID: 14920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003116")]
	[Address(RVA = "0x8CDBF0", Offset = "0x8CC9F0", VA = "0x1808CDBF0")]
	public void ToggleState()
	{
	}

	// Token: 0x06003A49 RID: 14921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003117")]
	[Address(RVA = "0x8CDC00", Offset = "0x8CCA00", VA = "0x1808CDC00")]
	public void ToggleState(bool state)
	{
	}

	// Token: 0x06003A4A RID: 14922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003118")]
	[Address(RVA = "0x8CD480", Offset = "0x8CC280", VA = "0x1808CD480")]
	public void AddChild(DemoShotEntry shot)
	{
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003119")]
	[Address(RVA = "0x8CDCB0", Offset = "0x8CCAB0", VA = "0x1808CDCB0")]
	private void UpdateCountText()
	{
	}

	// Token: 0x06003A4C RID: 14924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600311A")]
	[Address(RVA = "0x8CD7E0", Offset = "0x8CC5E0", VA = "0x1808CD7E0")]
	public void OnDroppedValue(object data)
	{
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600311B")]
	[Address(RVA = "0x8CDA30", Offset = "0x8CC830", VA = "0x1808CDA30")]
	public void OnRightClick()
	{
	}

	// Token: 0x06003A4E RID: 14926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600311C")]
	[Address(RVA = "0x8CD4D0", Offset = "0x8CC2D0", VA = "0x1808CD4D0")]
	public void OnClickedDeleteFolder()
	{
	}

	// Token: 0x06003A4F RID: 14927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600311D")]
	[Address(RVA = "0x8CD620", Offset = "0x8CC420", VA = "0x1808CD620")]
	public void OnClickedRenameFolder()
	{
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600311E")]
	[Address(RVA = "0x8CDD40", Offset = "0x8CCB40", VA = "0x1808CDD40")]
	public DemoShotListFolderWidget()
	{
	}

	// Token: 0x040036CB RID: 14027
	[Token(Token = "0x40029FE")]
	[FieldOffset(Offset = "0x18")]
	public RustButton FolderName;

	// Token: 0x040036CC RID: 14028
	[Token(Token = "0x40029FF")]
	[FieldOffset(Offset = "0x20")]
	public Transform ChildRoot;

	// Token: 0x040036CD RID: 14029
	[Token(Token = "0x4002A00")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UpArrow;

	// Token: 0x040036CE RID: 14030
	[Token(Token = "0x4002A01")]
	[FieldOffset(Offset = "0x30")]
	public GameObject DownArrow;

	// Token: 0x040036CF RID: 14031
	[Token(Token = "0x4002A02")]
	[FieldOffset(Offset = "0x38")]
	public RustText CountText;

	// Token: 0x040036D0 RID: 14032
	[Token(Token = "0x4002A03")]
	[FieldOffset(Offset = "0x40")]
	public GameObject OpenRoot;

	// Token: 0x040036D1 RID: 14033
	[Token(Token = "0x4002A04")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ModifyRoot;

	// Token: 0x040036D2 RID: 14034
	[Token(Token = "0x4002A05")]
	[FieldOffset(Offset = "0x50")]
	public RustInput FolderRenameInput;

	// Token: 0x040036D3 RID: 14035
	[Token(Token = "0x4002A06")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <CurrentState>k__BackingField;

	// Token: 0x040036D4 RID: 14036
	[Token(Token = "0x4002A07")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private string <cachedFolderName>k__BackingField;
}
