using System;
using Il2CppDummyDll;
using ProtoBuf;
using Rust.UI;
using UnityEngine;

// Token: 0x0200099B RID: 2459
[Token(Token = "0x20006E7")]
public class DemoShotEntry : MonoBehaviour, IDraggable
{
	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06003A35 RID: 14901 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000427")]
	public DemoShot CurrentShot
	{
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x326940", Offset = "0x325740", VA = "0x180326940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x442C90", Offset = "0x441A90", VA = "0x180442C90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06003A37 RID: 14903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003105")]
	[Address(RVA = "0x8CC120", Offset = "0x8CAF20", VA = "0x1808CC120")]
	public void Populate(DemoShot shot, string folder)
	{
	}

	// Token: 0x06003A38 RID: 14904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003106")]
	[Address(RVA = "0x8CBE30", Offset = "0x8CAC30", VA = "0x1808CBE30")]
	public void OnClicked()
	{
	}

	// Token: 0x06003A39 RID: 14905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003107")]
	[Address(RVA = "0x8CC180", Offset = "0x8CAF80", VA = "0x1808CC180")]
	public void StopShot()
	{
	}

	// Token: 0x06003A3A RID: 14906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003108")]
	[Address(RVA = "0x8CBC80", Offset = "0x8CAA80", VA = "0x1808CBC80")]
	public void OnClickedDelete()
	{
	}

	// Token: 0x06003A3B RID: 14907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003109")]
	[Address(RVA = "0x8CC220", Offset = "0x8CB020", VA = "0x1808CC220")]
	public void TogglePlayingRoot(bool state)
	{
	}

	// Token: 0x06003A3C RID: 14908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600310A")]
	[Address(RVA = "0x8CC0F0", Offset = "0x8CAEF0", VA = "0x1808CC0F0")]
	public void PopulateRename()
	{
	}

	// Token: 0x06003A3D RID: 14909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600310B")]
	[Address(RVA = "0x8CBBB0", Offset = "0x8CA9B0", VA = "0x1808CBBB0")]
	public void ApplyRename()
	{
	}

	// Token: 0x06003A3E RID: 14910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600310C")]
	[Address(RVA = "0x326940", Offset = "0x325740", VA = "0x180326940", Slot = "4")]
	public object GetDragData()
	{
		return null;
	}

	// Token: 0x06003A3F RID: 14911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600310D")]
	[Address(RVA = "0x8CBC50", Offset = "0x8CAA50", VA = "0x1808CBC50", Slot = "5")]
	public string GetDragType()
	{
		return null;
	}

	// Token: 0x06003A40 RID: 14912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600310E")]
	[Address(RVA = "0x2F9830", Offset = "0x2F8630", VA = "0x1802F9830", Slot = "6")]
	public Sprite GetDragSprite()
	{
		return null;
	}

	// Token: 0x06003A41 RID: 14913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600310F")]
	[Address(RVA = "0x8CBE90", Offset = "0x8CAC90", VA = "0x1808CBE90")]
	public void OnDroppedValue(object data)
	{
	}

	// Token: 0x06003A42 RID: 14914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003110")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DemoShotEntry()
	{
	}

	// Token: 0x040036C7 RID: 14023
	[Token(Token = "0x40029FA")]
	[FieldOffset(Offset = "0x18")]
	public RustButton PlayButton;

	// Token: 0x040036C8 RID: 14024
	[Token(Token = "0x40029FB")]
	[FieldOffset(Offset = "0x20")]
	public Sprite DragSprite;

	// Token: 0x040036C9 RID: 14025
	[Token(Token = "0x40029FC")]
	[FieldOffset(Offset = "0x28")]
	public RustInput RenameInput;

	// Token: 0x040036CA RID: 14026
	[Token(Token = "0x40029FD")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private DemoShot <CurrentShot>k__BackingField;
}
