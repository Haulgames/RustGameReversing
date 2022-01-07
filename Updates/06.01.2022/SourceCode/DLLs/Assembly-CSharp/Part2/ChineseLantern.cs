using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x020001DD RID: 477
[Token(Token = "0x200012F")]
public class ChineseLantern : BaseFuelLightSource
{
	// Token: 0x06001683 RID: 5763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001143")]
	[Address(RVA = "0x4DB670", Offset = "0x4DA470", VA = "0x1804DB670", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x4DB6B0", Offset = "0x4DA4B0", VA = "0x1804DB6B0")]
	public void Update()
	{
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x4DBA80", Offset = "0x4DA880", VA = "0x1804DBA80")]
	public ChineseLantern()
	{
	}

	// Token: 0x04001048 RID: 4168
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x4E0")]
	public Transform pivotRotator;

	// Token: 0x04001049 RID: 4169
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x4E8")]
	public float swaySpeed;

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x4000D13")]
	[FieldOffset(Offset = "0x4EC")]
	public float swayDistance;

	// Token: 0x0400104B RID: 4171
	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x4F0")]
	public float lerpSpeed;

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x4000D15")]
	[FieldOffset(Offset = "0x4F4")]
	private float lookupIndex;
}
