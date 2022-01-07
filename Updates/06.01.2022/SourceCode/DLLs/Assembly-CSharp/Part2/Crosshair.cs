using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200098D RID: 2445
[Token(Token = "0x20006DA")]
public class Crosshair : MonoBehaviour
{
	// Token: 0x060039FE RID: 14846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x6DAAB0", Offset = "0x6D98B0", VA = "0x1806DAAB0")]
	private void Start()
	{
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x6DA490", Offset = "0x6D9290", VA = "0x1806DA490")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x00017910 File Offset: 0x00015B10
	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x6DA510", Offset = "0x6D9310", VA = "0x1806DA510")]
	private bool ShouldShowCrosshair()
	{
		return default(bool);
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public Crosshair()
	{
	}

	// Token: 0x040036A8 RID: 13992
	[Token(Token = "0x40029DD")]
	[FieldOffset(Offset = "0x0")]
	public static bool Enabled;

	// Token: 0x040036A9 RID: 13993
	[Token(Token = "0x40029DE")]
	[FieldOffset(Offset = "0x18")]
	public Image Image;

	// Token: 0x040036AA RID: 13994
	[Token(Token = "0x40029DF")]
	[FieldOffset(Offset = "0x20")]
	internal RectTransform rectTransform;
}
