using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B21 RID: 2849
[Token(Token = "0x20007F1")]
public class DragMeCustomParent : DragMe
{
	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x0600428C RID: 17036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000470")]
	protected override Canvas TopCanvas
	{
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x97AE90", Offset = "0x979C90", VA = "0x18097AE90", Slot = "9")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600428D RID: 17037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600381F")]
	[Address(RVA = "0x97ACA0", Offset = "0x979AA0", VA = "0x18097ACA0", Slot = "8")]
	protected override GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo)
	{
		return null;
	}

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x0600428E RID: 17038 RVA: 0x00018E70 File Offset: 0x00017070
	[Token(Token = "0x17000471")]
	public override bool CancelOnDrop
	{
		[Token(Token = "0x6003820")]
		[Address(RVA = "0x94F200", Offset = "0x94E000", VA = "0x18094F200", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600428F RID: 17039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003821")]
	[Address(RVA = "0x97AE40", Offset = "0x979C40", VA = "0x18097AE40")]
	public DragMeCustomParent()
	{
	}

	// Token: 0x04003FB9 RID: 16313
	[Token(Token = "0x4003131")]
	[FieldOffset(Offset = "0x20")]
	public Canvas OverrideCanvas;

	// Token: 0x04003FBA RID: 16314
	[Token(Token = "0x4003132")]
	[FieldOffset(Offset = "0x28")]
	public bool ShouldCancelOnDrop;
}
