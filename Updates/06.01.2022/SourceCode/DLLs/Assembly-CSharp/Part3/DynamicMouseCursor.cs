using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020009D7 RID: 2519
[Token(Token = "0x200070E")]
public class DynamicMouseCursor : MonoBehaviour
{
	// Token: 0x06003BB2 RID: 15282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600325B")]
	[Address(RVA = "0x981230", Offset = "0x980030", VA = "0x180981230")]
	private void LateUpdate()
	{
	}

	// Token: 0x06003BB3 RID: 15283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600325C")]
	[Address(RVA = "0x981390", Offset = "0x980190", VA = "0x180981390")]
	private void UpdateCursor(Texture2D cursor, Vector2 offs)
	{
	}

	// Token: 0x06003BB4 RID: 15284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600325D")]
	[Address(RVA = "0x980F90", Offset = "0x97FD90", VA = "0x180980F90")]
	private GameObject CurrentlyHoveredItem()
	{
		return null;
	}

	// Token: 0x06003BB5 RID: 15285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600325E")]
	[Address(RVA = "0x981440", Offset = "0x980240", VA = "0x180981440")]
	public DynamicMouseCursor()
	{
	}

	// Token: 0x0400389D RID: 14493
	[Token(Token = "0x4002B82")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D RegularCursor;

	// Token: 0x0400389E RID: 14494
	[Token(Token = "0x4002B83")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 RegularCursorPos;

	// Token: 0x0400389F RID: 14495
	[Token(Token = "0x4002B84")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D HoverCursor;

	// Token: 0x040038A0 RID: 14496
	[Token(Token = "0x4002B85")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 HoverCursorPos;

	// Token: 0x040038A1 RID: 14497
	[Token(Token = "0x4002B86")]
	[FieldOffset(Offset = "0x38")]
	private Texture2D current;

	// Token: 0x040038A2 RID: 14498
	[Token(Token = "0x4002B87")]
	[FieldOffset(Offset = "0x40")]
	private PointerEventData pointer;

	// Token: 0x040038A3 RID: 14499
	[Token(Token = "0x4002B88")]
	[FieldOffset(Offset = "0x48")]
	private List<RaycastResult> results;
}
