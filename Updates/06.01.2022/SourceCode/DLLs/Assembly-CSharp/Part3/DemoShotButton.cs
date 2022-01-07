using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine.EventSystems;

// Token: 0x0200099A RID: 2458
[Token(Token = "0x20006E6")]
public class DemoShotButton : RustButton, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x06003A31 RID: 14897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030FF")]
	[Address(RVA = "0x8CBB70", Offset = "0x8CA970", VA = "0x1808CBB70", Slot = "42")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06003A32 RID: 14898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003100")]
	[Address(RVA = "0x8CBB90", Offset = "0x8CA990", VA = "0x1808CBB90", Slot = "43")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x06003A33 RID: 14899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003101")]
	[Address(RVA = "0x8CBB50", Offset = "0x8CA950", VA = "0x1808CBB50", Slot = "44")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06003A34 RID: 14900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003102")]
	[Address(RVA = "0x642CF0", Offset = "0x641AF0", VA = "0x180642CF0")]
	public DemoShotButton()
	{
	}

	// Token: 0x040036C6 RID: 14022
	[Token(Token = "0x40029F9")]
	[FieldOffset(Offset = "0x98")]
	public bool FireEventOnClicked;
}
