using System;
using Il2CppDummyDll;
using UnityEngine;
using VLB;

// Token: 0x02000B39 RID: 2873
[Token(Token = "0x2000804")]
public class AmbientLightLOD : FacepunchBehaviour, ILOD, IClientComponent
{
	// Token: 0x060042E3 RID: 17123 RVA: 0x00018F90 File Offset: 0x00017190
	[Token(Token = "0x600386F")]
	[Address(RVA = "0x82A1C0", Offset = "0x828FC0", VA = "0x18082A1C0")]
	private float GetDistance()
	{
		return 0f;
	}

	// Token: 0x060042E4 RID: 17124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003870")]
	[Address(RVA = "0x829D70", Offset = "0x828B70", VA = "0x180829D70")]
	protected void Awake()
	{
	}

	// Token: 0x060042E5 RID: 17125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003871")]
	[Address(RVA = "0x82A310", Offset = "0x829110", VA = "0x18082A310")]
	protected void OnEnable()
	{
	}

	// Token: 0x060042E6 RID: 17126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003872")]
	[Address(RVA = "0x82A240", Offset = "0x829040", VA = "0x18082A240")]
	protected void OnDisable()
	{
	}

	// Token: 0x060042E7 RID: 17127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003873")]
	[Address(RVA = "0x82A5C0", Offset = "0x8293C0", VA = "0x18082A5C0")]
	private void ToggleLight(bool state)
	{
	}

	// Token: 0x060042E8 RID: 17128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003874")]
	[Address(RVA = "0x82A020", Offset = "0x828E20", VA = "0x18082A020")]
	private void FadingToggle()
	{
	}

	// Token: 0x060042E9 RID: 17129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003875")]
	[Address(RVA = "0x82A460", Offset = "0x829260", VA = "0x18082A460")]
	public void SetLightActive(bool lightOn)
	{
	}

	// Token: 0x060042EA RID: 17130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003876")]
	[Address(RVA = "0x82A5A0", Offset = "0x8293A0", VA = "0x18082A5A0")]
	public void SetTargetIntensity(float intensity, float fadeDuration = -1f)
	{
	}

	// Token: 0x060042EB RID: 17131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003877")]
	[Address(RVA = "0x82A3D0", Offset = "0x8291D0", VA = "0x18082A3D0", Slot = "5")]
	public void RefreshLOD()
	{
	}

	// Token: 0x060042EC RID: 17132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003878")]
	[Address(RVA = "0x829E60", Offset = "0x828C60", VA = "0x180829E60", Slot = "4")]
	public void ChangeLOD()
	{
	}

	// Token: 0x060042ED RID: 17133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003879")]
	[Address(RVA = "0x82A3B0", Offset = "0x8291B0", VA = "0x18082A3B0")]
	protected void OnValidate()
	{
	}

	// Token: 0x060042EE RID: 17134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387A")]
	[Address(RVA = "0x82A710", Offset = "0x829510", VA = "0x18082A710")]
	public AmbientLightLOD()
	{
	}

	// Token: 0x0400400B RID: 16395
	[Token(Token = "0x400315C")]
	[FieldOffset(Offset = "0x18")]
	public bool isDynamic;

	// Token: 0x0400400C RID: 16396
	[Token(Token = "0x400315D")]
	[FieldOffset(Offset = "0x1C")]
	public float enabledRadius;

	// Token: 0x0400400D RID: 16397
	[Token(Token = "0x400315E")]
	[FieldOffset(Offset = "0x20")]
	public bool toggleFade;

	// Token: 0x0400400E RID: 16398
	[Token(Token = "0x400315F")]
	[FieldOffset(Offset = "0x24")]
	public float toggleFadeDuration;

	// Token: 0x0400400F RID: 16399
	[Token(Token = "0x4003160")]
	[FieldOffset(Offset = "0x28")]
	private Light lightComponent;

	// Token: 0x04004010 RID: 16400
	[Token(Token = "0x4003161")]
	[FieldOffset(Offset = "0x30")]
	private LightOccludee lightOccludee;

	// Token: 0x04004011 RID: 16401
	[Token(Token = "0x4003162")]
	[FieldOffset(Offset = "0x38")]
	private LightEx lightEx;

	// Token: 0x04004012 RID: 16402
	[Token(Token = "0x4003163")]
	[FieldOffset(Offset = "0x40")]
	private VolumetricLightBeam volumetricBeam;

	// Token: 0x04004013 RID: 16403
	[Token(Token = "0x4003164")]
	[FieldOffset(Offset = "0x48")]
	private LODCell cell;

	// Token: 0x04004014 RID: 16404
	[Token(Token = "0x4003165")]
	[FieldOffset(Offset = "0x50")]
	private float targetIntensity;

	// Token: 0x04004015 RID: 16405
	[Token(Token = "0x4003166")]
	[FieldOffset(Offset = "0x54")]
	private float targetFadeDuration;

	// Token: 0x04004016 RID: 16406
	[Token(Token = "0x4003167")]
	[FieldOffset(Offset = "0x58")]
	private LODEnvironmentMode EnvironmentMode;

	// Token: 0x04004017 RID: 16407
	[Token(Token = "0x4003168")]
	[FieldOffset(Offset = "0x5C")]
	private float fadeStartTime;

	// Token: 0x04004018 RID: 16408
	[Token(Token = "0x4003169")]
	[FieldOffset(Offset = "0x60")]
	private float fadeEndTime;

	// Token: 0x04004019 RID: 16409
	[Token(Token = "0x400316A")]
	[FieldOffset(Offset = "0x64")]
	private bool fadeToState;

	// Token: 0x0400401A RID: 16410
	[Token(Token = "0x400316B")]
	[FieldOffset(Offset = "0x65")]
	private bool queuedState;
}
