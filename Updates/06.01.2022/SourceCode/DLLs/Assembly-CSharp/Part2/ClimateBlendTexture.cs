using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B76 RID: 2934
[Token(Token = "0x2000835")]
public class ClimateBlendTexture : ProcessedTexture
{
	// Token: 0x060043DF RID: 17375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003947")]
	[Address(RVA = "0x49AD30", Offset = "0x499B30", VA = "0x18049AD30")]
	public ClimateBlendTexture(int width, int height, bool linear = true)
	{
	}

	// Token: 0x060043E0 RID: 17376 RVA: 0x00019320 File Offset: 0x00017520
	[Token(Token = "0x6003948")]
	[Address(RVA = "0x49ACA0", Offset = "0x499AA0", VA = "0x18049ACA0")]
	public bool CheckLostData()
	{
		return default(bool);
	}

	// Token: 0x060043E1 RID: 17377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003949")]
	[Address(RVA = "0x49AAE0", Offset = "0x4998E0", VA = "0x18049AAE0")]
	public void Blend(Texture srcLut1, Texture dstLut1, float lerpLut1, Texture srcLut2, Texture dstLut2, float lerpLut2, float lerp, ClimateBlendTexture prevLut, float time)
	{
	}

	// Token: 0x060043E2 RID: 17378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600394A")]
	[Address(RVA = "0x49ACF0", Offset = "0x499AF0", VA = "0x18049ACF0")]
	public static void Swap(ref ClimateBlendTexture a, ref ClimateBlendTexture b)
	{
	}
}
