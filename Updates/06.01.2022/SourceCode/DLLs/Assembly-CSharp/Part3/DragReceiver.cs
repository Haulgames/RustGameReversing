using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000A25 RID: 2597
[Token(Token = "0x2000748")]
public class DragReceiver : MonoBehaviour, IDropHandler, IEventSystemHandler
{
	// Token: 0x06003D5D RID: 15709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D8")]
	[Address(RVA = "0x97BCA0", Offset = "0x97AAA0", VA = "0x18097BCA0", Slot = "4")]
	public void OnDrop(PointerEventData eventData)
	{
	}

	// Token: 0x06003D5E RID: 15710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D9")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DragReceiver()
	{
	}

	// Token: 0x04003A74 RID: 14964
	[Token(Token = "0x4002D2B")]
	[FieldOffset(Offset = "0x18")]
	public DragReceiver.TriggerEvent onEndDrag;

	// Token: 0x02000A26 RID: 2598
	[Token(Token = "0x2000D06")]
	[Serializable]
	public class TriggerEvent : UnityEvent<BaseEventData>
	{
		// Token: 0x06003D5F RID: 15711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FA")]
		[Address(RVA = "0x993400", Offset = "0x992200", VA = "0x180993400")]
		public TriggerEvent()
		{
		}
	}
}
