using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x0200097C RID: 2428
[Token(Token = "0x20006CE")]
public class BlurManager : MonoBehaviour
{
	// Token: 0x06003999 RID: 14745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600307D")]
	[Address(RVA = "0x45F680", Offset = "0x45E480", VA = "0x18045F680")]
	public void Awake()
	{
	}

	// Token: 0x0600399A RID: 14746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600307E")]
	[Address(RVA = "0x45F750", Offset = "0x45E550", VA = "0x18045F750")]
	private void Update()
	{
	}

	// Token: 0x0600399B RID: 14747 RVA: 0x00017850 File Offset: 0x00015A50
	[Token(Token = "0x600307F")]
	[Address(RVA = "0x45F6B0", Offset = "0x45E4B0", VA = "0x18045F6B0")]
	private float GetBlurArmount()
	{
		return 0f;
	}

	// Token: 0x0600399C RID: 14748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003080")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BlurManager()
	{
	}

	// Token: 0x0400365F RID: 13919
	[Token(Token = "0x40029A4")]
	[FieldOffset(Offset = "0x18")]
	public PostProcessVolume postProcessVolume;

	// Token: 0x04003660 RID: 13920
	[Token(Token = "0x40029A5")]
	[FieldOffset(Offset = "0x20")]
	private float blurAmount;
}
