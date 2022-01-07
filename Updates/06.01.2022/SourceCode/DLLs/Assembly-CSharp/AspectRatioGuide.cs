using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200097B RID: 2427
[Token(Token = "0x20006CD")]
public class AspectRatioGuide : MonoBehaviour
{
	// Token: 0x06003995 RID: 14741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003079")]
	[Address(RVA = "0x8385B0", Offset = "0x8373B0", VA = "0x1808385B0")]
	private void Populate()
	{
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600307A")]
	[Address(RVA = "0x8385A0", Offset = "0x8373A0", VA = "0x1808385A0")]
	public void Awake()
	{
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600307B")]
	[Address(RVA = "0x8385A0", Offset = "0x8373A0", VA = "0x1808385A0")]
	public void Update()
	{
	}

	// Token: 0x06003998 RID: 14744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600307C")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AspectRatioGuide()
	{
	}

	// Token: 0x0400365B RID: 13915
	[Token(Token = "0x40029A0")]
	[FieldOffset(Offset = "0x18")]
	public AspectRatioFitter aspectRatioFitter;

	// Token: 0x0400365C RID: 13916
	[Token(Token = "0x40029A1")]
	[FieldOffset(Offset = "0x20")]
	public RustText label;

	// Token: 0x0400365D RID: 13917
	[Token(Token = "0x40029A2")]
	[FieldOffset(Offset = "0x28")]
	public float aspect;

	// Token: 0x0400365E RID: 13918
	[Token(Token = "0x40029A3")]
	[FieldOffset(Offset = "0x2C")]
	public float ratio;
}
