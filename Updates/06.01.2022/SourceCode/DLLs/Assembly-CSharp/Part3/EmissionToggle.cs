using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000412 RID: 1042
[Token(Token = "0x20002EE")]
public class EmissionToggle : MonoBehaviour, IClientComponent
{
	// Token: 0x06002199 RID: 8601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x990DB0", Offset = "0x98FBB0", VA = "0x180990DB0")]
	public void OnEnable()
	{
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x990B50", Offset = "0x98F950", VA = "0x180990B50")]
	private void Init()
	{
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B59")]
	[Address(RVA = "0x990DC0", Offset = "0x98FBC0", VA = "0x180990DC0")]
	public void SetEmissionEnabled(bool on)
	{
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x990F80", Offset = "0x98FD80", VA = "0x180990F80")]
	public EmissionToggle()
	{
	}

	// Token: 0x04001C34 RID: 7220
	[Token(Token = "0x40016E7")]
	[FieldOffset(Offset = "0x18")]
	private Color emissionColor;

	// Token: 0x04001C35 RID: 7221
	[Token(Token = "0x40016E8")]
	[FieldOffset(Offset = "0x28")]
	public Renderer[] targetRenderers;

	// Token: 0x04001C36 RID: 7222
	[Token(Token = "0x40016E9")]
	[FieldOffset(Offset = "0x30")]
	public int materialIndex;

	// Token: 0x04001C37 RID: 7223
	[Token(Token = "0x40016EA")]
	[FieldOffset(Offset = "0x34")]
	private bool inited;

	// Token: 0x04001C38 RID: 7224
	[Token(Token = "0x40016EB")]
	[FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock block;

	// Token: 0x04001C39 RID: 7225
	[Token(Token = "0x40016EC")]
	[FieldOffset(Offset = "0x8")]
	private static int emissionColorID;
}
