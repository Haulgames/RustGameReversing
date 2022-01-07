using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000410 RID: 1040
[Token(Token = "0x20002EC")]
public class EffectScaleWithCameraDistance : MonoBehaviour, IEffect
{
	// Token: 0x06002193 RID: 8595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x9887A0", Offset = "0x9875A0", VA = "0x1809887A0", Slot = "5")]
	public virtual void SetupEffect(Effect effect)
	{
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x988C30", Offset = "0x987A30", VA = "0x180988C30")]
	public EffectScaleWithCameraDistance()
	{
	}

	// Token: 0x04001C28 RID: 7208
	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0x18")]
	public float minScale;

	// Token: 0x04001C29 RID: 7209
	[Token(Token = "0x40016DC")]
	[FieldOffset(Offset = "0x1C")]
	public float maxScale;

	// Token: 0x04001C2A RID: 7210
	[Token(Token = "0x40016DD")]
	[FieldOffset(Offset = "0x20")]
	public float scaleStartDistance;

	// Token: 0x04001C2B RID: 7211
	[Token(Token = "0x40016DE")]
	[FieldOffset(Offset = "0x24")]
	public float scaleEndDistance;

	// Token: 0x04001C2C RID: 7212
	[Token(Token = "0x40016DF")]
	[FieldOffset(Offset = "0x0")]
	[ClientVar]
	public static bool on;
}
