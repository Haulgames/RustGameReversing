using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B41 RID: 2881
[Token(Token = "0x200080B")]
public class DistanceFlareLOD : FacepunchBehaviour, ILOD, IClientComponent
{
	// Token: 0x0600430B RID: 17163 RVA: 0x00019068 File Offset: 0x00017268
	[Token(Token = "0x6003893")]
	[Address(RVA = "0xB77300", Offset = "0xB76100", VA = "0x180B77300")]
	private float GetDistance()
	{
		return 0f;
	}

	// Token: 0x0600430C RID: 17164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003894")]
	[Address(RVA = "0xB76DC0", Offset = "0xB75BC0", VA = "0x180B76DC0")]
	protected void Awake()
	{
	}

	// Token: 0x0600430D RID: 17165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003895")]
	[Address(RVA = "0xB77450", Offset = "0xB76250", VA = "0x180B77450")]
	protected void OnEnable()
	{
	}

	// Token: 0x0600430E RID: 17166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003896")]
	[Address(RVA = "0xB77380", Offset = "0xB76180", VA = "0x180B77380")]
	protected void OnDisable()
	{
	}

	// Token: 0x0600430F RID: 17167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003897")]
	[Address(RVA = "0xB776C0", Offset = "0xB764C0", VA = "0x180B776C0")]
	private void UpdateMaterialPropertyBlock()
	{
	}

	// Token: 0x06004310 RID: 17168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003898")]
	[Address(RVA = "0xB776A0", Offset = "0xB764A0", VA = "0x180B776A0")]
	private void ToggleFlare(bool state)
	{
	}

	// Token: 0x06004311 RID: 17169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003899")]
	[Address(RVA = "0xB77160", Offset = "0xB75F60", VA = "0x180B77160")]
	private void FadingToggle()
	{
	}

	// Token: 0x06004312 RID: 17170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389A")]
	[Address(RVA = "0xB77580", Offset = "0xB76380", VA = "0x180B77580")]
	public void SetFlareActive(bool lightOn)
	{
	}

	// Token: 0x06004313 RID: 17171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389B")]
	[Address(RVA = "0xB77690", Offset = "0xB76490", VA = "0x180B77690")]
	public void SetFlareIntensity(float intensity)
	{
	}

	// Token: 0x06004314 RID: 17172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389C")]
	[Address(RVA = "0xB774F0", Offset = "0xB762F0", VA = "0x180B774F0", Slot = "5")]
	public void RefreshLOD()
	{
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389D")]
	[Address(RVA = "0xB76FD0", Offset = "0xB75DD0", VA = "0x180B76FD0", Slot = "4")]
	public void ChangeLOD()
	{
	}

	// Token: 0x06004316 RID: 17174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389E")]
	[Address(RVA = "0xB77840", Offset = "0xB76640", VA = "0x180B77840")]
	public DistanceFlareLOD()
	{
	}

	// Token: 0x04004030 RID: 16432
	[Token(Token = "0x400317D")]
	[FieldOffset(Offset = "0x18")]
	public bool isDynamic;

	// Token: 0x04004031 RID: 16433
	[Token(Token = "0x400317E")]
	[FieldOffset(Offset = "0x1C")]
	public float minEnabledDistance;

	// Token: 0x04004032 RID: 16434
	[Token(Token = "0x400317F")]
	[FieldOffset(Offset = "0x20")]
	public float maxEnabledDistance;

	// Token: 0x04004033 RID: 16435
	[Token(Token = "0x4003180")]
	[FieldOffset(Offset = "0x24")]
	public bool toggleFade;

	// Token: 0x04004034 RID: 16436
	[Token(Token = "0x4003181")]
	[FieldOffset(Offset = "0x28")]
	public float toggleFadeDuration;

	// Token: 0x04004035 RID: 16437
	[Token(Token = "0x4003182")]
	[FieldOffset(Offset = "0x30")]
	private LODCell cell;

	// Token: 0x04004036 RID: 16438
	[Token(Token = "0x4003183")]
	[FieldOffset(Offset = "0x38")]
	private Renderer flareRenderer;

	// Token: 0x04004037 RID: 16439
	[Token(Token = "0x4003184")]
	[FieldOffset(Offset = "0x40")]
	private float flareIntensity;

	// Token: 0x04004038 RID: 16440
	[Token(Token = "0x4003185")]
	[FieldOffset(Offset = "0x44")]
	private float fadeIntensity;

	// Token: 0x04004039 RID: 16441
	[Token(Token = "0x4003186")]
	[FieldOffset(Offset = "0x48")]
	private Color startColor;

	// Token: 0x0400403A RID: 16442
	[Token(Token = "0x4003187")]
	[FieldOffset(Offset = "0x0")]
	private static int emissionColorID;

	// Token: 0x0400403B RID: 16443
	[Token(Token = "0x4003188")]
	[FieldOffset(Offset = "0x8")]
	private static MaterialPropertyBlock block;

	// Token: 0x0400403C RID: 16444
	[Token(Token = "0x4003189")]
	[FieldOffset(Offset = "0x58")]
	private LODEnvironmentMode EnvironmentMode;

	// Token: 0x0400403D RID: 16445
	[Token(Token = "0x400318A")]
	[FieldOffset(Offset = "0x5C")]
	private float fadeStartTime;

	// Token: 0x0400403E RID: 16446
	[Token(Token = "0x400318B")]
	[FieldOffset(Offset = "0x60")]
	private float fadeEndTime;

	// Token: 0x0400403F RID: 16447
	[Token(Token = "0x400318C")]
	[FieldOffset(Offset = "0x64")]
	private bool fadeToState;

	// Token: 0x04004040 RID: 16448
	[Token(Token = "0x400318D")]
	[FieldOffset(Offset = "0x65")]
	private bool queuedState;
}
