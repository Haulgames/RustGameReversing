using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000B1F RID: 2847
[Token(Token = "0x20007EF")]
public class DragMe : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x06004280 RID: 17024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003812")]
	[Address(RVA = "0x97B510", Offset = "0x97A310", VA = "0x18097B510", Slot = "7")]
	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06004281 RID: 17025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003813")]
	[Address(RVA = "0x97AFF0", Offset = "0x979DF0", VA = "0x18097AFF0", Slot = "8")]
	protected virtual GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo)
	{
		return null;
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06004282 RID: 17026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700046E")]
	protected virtual Canvas TopCanvas
	{
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x97BC50", Offset = "0x97AA50", VA = "0x18097BC50", Slot = "9")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004283 RID: 17027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003815")]
	[Address(RVA = "0x97B980", Offset = "0x97A780", VA = "0x18097B980", Slot = "10")]
	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06004284 RID: 17028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003816")]
	[Address(RVA = "0x97BAF0", Offset = "0x97A8F0", VA = "0x18097BAF0", Slot = "11")]
	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06004285 RID: 17029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003817")]
	[Address(RVA = "0x97AF50", Offset = "0x979D50", VA = "0x18097AF50")]
	public void CancelDrag()
	{
	}

	// Token: 0x06004286 RID: 17030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003818")]
	[Address(RVA = "0x97B200", Offset = "0x97A000", VA = "0x18097B200")]
	internal DropMe FindTarget(GameObject obj)
	{
		return null;
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06004287 RID: 17031 RVA: 0x00018E58 File Offset: 0x00017058
	[Token(Token = "0x1700046F")]
	public virtual bool CancelOnDrop
	{
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06004288 RID: 17032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600381A")]
	[Address(RVA = "0x97AE40", Offset = "0x979C40", VA = "0x18097AE40")]
	public DragMe()
	{
	}

	// Token: 0x04003FB5 RID: 16309
	[Token(Token = "0x400312D")]
	[FieldOffset(Offset = "0x0")]
	public static DragMe dragging;

	// Token: 0x04003FB6 RID: 16310
	[Token(Token = "0x400312E")]
	[FieldOffset(Offset = "0x8")]
	public static GameObject dragIcon;

	// Token: 0x04003FB7 RID: 16311
	[Token(Token = "0x400312F")]
	[FieldOffset(Offset = "0x10")]
	public static object data;

	// Token: 0x04003FB8 RID: 16312
	[Token(Token = "0x4003130")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public string dragType;
}
