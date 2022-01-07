using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000404 RID: 1028
[Token(Token = "0x20002E3")]
public class ColdBreath : BaseMonoBehaviour
{
	// Token: 0x0600215E RID: 8542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x49E560", Offset = "0x49D360", VA = "0x18049E560")]
	protected void OnEnable()
	{
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x49E4C0", Offset = "0x49D2C0", VA = "0x18049E4C0")]
	protected void OnDisable()
	{
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x49E1C0", Offset = "0x49CFC0", VA = "0x18049E1C0")]
	private void Breathe()
	{
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public ColdBreath()
	{
	}

	// Token: 0x04001C12 RID: 7186
	[Token(Token = "0x40016C9")]
	[FieldOffset(Offset = "0x18")]
	public GameObjectRef effect;

	// Token: 0x04001C13 RID: 7187
	[Token(Token = "0x40016CA")]
	[FieldOffset(Offset = "0x20")]
	private BasePlayer player;

	// Token: 0x04001C14 RID: 7188
	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0x28")]
	private Transform jawBone;
}
