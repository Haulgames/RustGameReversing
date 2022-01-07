using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A1D RID: 2589
[Token(Token = "0x2000744")]
public class CraftingQueueIcon : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
{
	// Token: 0x06003D0E RID: 15630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600339A")]
	[Address(RVA = "0x6D7DD0", Offset = "0x6D6BD0", VA = "0x1806D7DD0")]
	private void Awake()
	{
	}

	// Token: 0x06003D0F RID: 15631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600339B")]
	[Address(RVA = "0x6D86F0", Offset = "0x6D74F0", VA = "0x1806D86F0")]
	private void Update()
	{
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06003D10 RID: 15632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000444")]
	public string timeLeftString
	{
		[Token(Token = "0x600339C")]
		[Address(RVA = "0x6D8780", Offset = "0x6D7580", VA = "0x1806D8780")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600339D")]
	[Address(RVA = "0x6D8650", Offset = "0x6D7450", VA = "0x1806D8650")]
	internal void OnTaskStart(float endTime)
	{
	}

	// Token: 0x06003D12 RID: 15634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600339E")]
	[Address(RVA = "0x6D8690", Offset = "0x6D7490", VA = "0x1806D8690")]
	internal void ResetEndTime()
	{
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600339F")]
	[Address(RVA = "0x6D8040", Offset = "0x6D6E40", VA = "0x1806D8040")]
	internal void Finished(bool success, int amountleft)
	{
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x6D8160", Offset = "0x6D6F60", VA = "0x1806D8160")]
	internal void Init(int taskid, int itemid, int amount, int skinid, ScrollRect scrollRect)
	{
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x6D7E20", Offset = "0x6D6C20", VA = "0x1806D7E20")]
	private void Cancel()
	{
	}

	// Token: 0x06003D16 RID: 15638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x6D7F30", Offset = "0x6D6D30", VA = "0x1806D7F30")]
	private void FastTrack()
	{
	}

	// Token: 0x06003D17 RID: 15639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A3")]
	[Address(RVA = "0x6D82D0", Offset = "0x6D70D0", VA = "0x1806D82D0")]
	public void MoveIconToFront()
	{
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x6D83B0", Offset = "0x6D71B0", VA = "0x1806D83B0", Slot = "8")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06003D19 RID: 15641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x6D83E0", Offset = "0x6D71E0", VA = "0x1806D83E0", Slot = "9")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06003D1A RID: 15642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x6D8410", Offset = "0x6D7210", VA = "0x1806D8410", Slot = "4")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x06003D1B RID: 15643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A7")]
	[Address(RVA = "0x6D8350", Offset = "0x6D7150", VA = "0x1806D8350", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06003D1C RID: 15644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A8")]
	[Address(RVA = "0x6D8320", Offset = "0x6D7120", VA = "0x1806D8320", Slot = "6")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06003D1D RID: 15645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x6D8380", Offset = "0x6D7180", VA = "0x1806D8380", Slot = "7")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06003D1E RID: 15646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033AA")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CraftingQueueIcon()
	{
	}

	// Token: 0x04003A34 RID: 14900
	[Token(Token = "0x4002CF6")]
	[FieldOffset(Offset = "0x18")]
	public CanvasGroup canvasGroup;

	// Token: 0x04003A35 RID: 14901
	[Token(Token = "0x4002CF7")]
	[FieldOffset(Offset = "0x20")]
	public Image icon;

	// Token: 0x04003A36 RID: 14902
	[Token(Token = "0x4002CF8")]
	[FieldOffset(Offset = "0x28")]
	public Image iconCancel;

	// Token: 0x04003A37 RID: 14903
	[Token(Token = "0x4002CF9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject timeLeft;

	// Token: 0x04003A38 RID: 14904
	[Token(Token = "0x4002CFA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject craftingCount;

	// Token: 0x04003A39 RID: 14905
	[Token(Token = "0x4002CFB")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public int taskid;

	// Token: 0x04003A3A RID: 14906
	[Token(Token = "0x4002CFC")]
	[FieldOffset(Offset = "0x44")]
	[NonSerialized]
	public float endTime;

	// Token: 0x04003A3B RID: 14907
	[Token(Token = "0x4002CFD")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public ItemDefinition item;

	// Token: 0x04003A3C RID: 14908
	[Token(Token = "0x4002CFE")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public int amount;

	// Token: 0x04003A3D RID: 14909
	[Token(Token = "0x4002CFF")]
	[FieldOffset(Offset = "0x58")]
	private ScrollRect scrollRect;

	// Token: 0x04003A3E RID: 14910
	[Token(Token = "0x4002D00")]
	[FieldOffset(Offset = "0x60")]
	private bool pointerOverButton;
}
