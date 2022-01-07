using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000B22 RID: 2850
[Token(Token = "0x20007F2")]
public class DropMe : MonoBehaviour, IDropHandler, IEventSystemHandler
{
	// Token: 0x06004290 RID: 17040 RVA: 0x00018E88 File Offset: 0x00017088
	[Token(Token = "0x6003822")]
	[Address(RVA = "0x97CFA0", Offset = "0x97BDA0", VA = "0x18097CFA0")]
	public bool Accepts(DragMe drag)
	{
		return default(bool);
	}

	// Token: 0x06004291 RID: 17041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003823")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void StopHighlight()
	{
	}

	// Token: 0x06004292 RID: 17042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003824")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void StartHighlight()
	{
	}

	// Token: 0x06004293 RID: 17043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003825")]
	[Address(RVA = "0x97D220", Offset = "0x97C020", VA = "0x18097D220", Slot = "5")]
	public virtual void OnDrop(PointerEventData eventData)
	{
	}

	// Token: 0x06004294 RID: 17044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003826")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DropMe()
	{
	}

	// Token: 0x04003FBB RID: 16315
	[Token(Token = "0x4003133")]
	[FieldOffset(Offset = "0x18")]
	public string[] droppableTypes;
}
