using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x02000342 RID: 834
[Token(Token = "0x2000254")]
public class ColdOverlay : MonoBehaviour
{
	// Token: 0x06001CFD RID: 7421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001756")]
	[Address(RVA = "0x49E6C0", Offset = "0x49D4C0", VA = "0x18049E6C0")]
	public void Awake()
	{
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001757")]
	[Address(RVA = "0x49E8B0", Offset = "0x49D6B0", VA = "0x18049E8B0")]
	protected void Update()
	{
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
	[Token(Token = "0x6001758")]
	[Address(RVA = "0x49E740", Offset = "0x49D540", VA = "0x18049E740")]
	private float GetIntensity()
	{
		return 0f;
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001759")]
	[Address(RVA = "0x479F00", Offset = "0x478D00", VA = "0x180479F00")]
	public ColdOverlay()
	{
	}

	// Token: 0x0400181D RID: 6173
	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x18")]
	public PostProcessVolume postProcessVolume;

	// Token: 0x0400181E RID: 6174
	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x20")]
	public float smoothTime;

	// Token: 0x0400181F RID: 6175
	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x24")]
	public bool preventInstantiation;

	// Token: 0x04001820 RID: 6176
	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x28")]
	private float smoothCurrent;

	// Token: 0x04001821 RID: 6177
	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x2C")]
	private float smoothVelocity;

	// Token: 0x04001822 RID: 6178
	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x30")]
	private ColorGrading colorGrading;
}
