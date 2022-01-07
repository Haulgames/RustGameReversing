using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200046A RID: 1130
[Token(Token = "0x2000342")]
public class AudioVisualisationEntityLight : AudioVisualisationEntity
{
	// Token: 0x060022B5 RID: 8885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x83DED0", Offset = "0x83CCD0", VA = "0x18083DED0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x83E9F0", Offset = "0x83D7F0", VA = "0x18083E9F0", Slot = "158")]
	protected override void UpdateVisualisation(float volume, bool force = false)
	{
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x0000FA38 File Offset: 0x0000DC38
	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x83E0A0", Offset = "0x83CEA0", VA = "0x18083E0A0")]
	private float GetCurrentSpeedValue()
	{
		return 0f;
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0x83E0E0", Offset = "0x83CEE0", VA = "0x18083E0E0")]
	private void GetCurrentVolumeRange(out float min, out float max)
	{
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0x83E490", Offset = "0x83D290", VA = "0x18083E490")]
	private void UpdateLightComponentSettings()
	{
	}

	// Token: 0x060022BA RID: 8890 RVA: 0x0000FA50 File Offset: 0x0000DC50
	[Token(Token = "0x6001C6E")]
	[Address(RVA = "0x83DFC0", Offset = "0x83CDC0", VA = "0x18083DFC0")]
	private AudioVisualisationEntityLight.LightColourSet EnumToColour(AudioVisualisationEntity.LightColour colour)
	{
		return default(AudioVisualisationEntityLight.LightColourSet);
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C6F")]
	[Address(RVA = "0x83E580", Offset = "0x83D380", VA = "0x18083E580")]
	private void UpdateRenderer(float volumeNormalised)
	{
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C70")]
	[Address(RVA = "0x83E8F0", Offset = "0x83D6F0", VA = "0x18083E8F0", Slot = "164")]
	protected override void UpdateVisualSettings()
	{
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x060022BD RID: 8893 RVA: 0x0000FA68 File Offset: 0x0000DC68
	[Token(Token = "0x17000253")]
	public override bool ShowColourOption
	{
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "159")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x060022BE RID: 8894 RVA: 0x0000FA80 File Offset: 0x0000DC80
	[Token(Token = "0x17000254")]
	public override bool ShowSpeedOption
	{
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "161")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x060022BF RID: 8895 RVA: 0x0000FA98 File Offset: 0x0000DC98
	[Token(Token = "0x17000255")]
	public override bool ShowVolumeOption
	{
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x83E130", Offset = "0x83CF30", VA = "0x18083E130", Slot = "80")]
	public override void OnFlagsChanged(global::BaseEntity.Flags old, global::BaseEntity.Flags next)
	{
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x83ECB0", Offset = "0x83DAB0", VA = "0x18083ECB0")]
	public AudioVisualisationEntityLight()
	{
	}

	// Token: 0x04001D57 RID: 7511
	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x300")]
	public Light TargetLight;

	// Token: 0x04001D58 RID: 7512
	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x308")]
	public Light SecondaryLight;

	// Token: 0x04001D59 RID: 7513
	[Token(Token = "0x40017F5")]
	[FieldOffset(Offset = "0x310")]
	public MeshRenderer[] TargetRenderer;

	// Token: 0x04001D5A RID: 7514
	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x318")]
	public AudioVisualisationEntityLight.LightColourSet RedColour;

	// Token: 0x04001D5B RID: 7515
	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x348")]
	public AudioVisualisationEntityLight.LightColourSet GreenColour;

	// Token: 0x04001D5C RID: 7516
	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x378")]
	public AudioVisualisationEntityLight.LightColourSet BlueColour;

	// Token: 0x04001D5D RID: 7517
	[Token(Token = "0x40017F9")]
	[FieldOffset(Offset = "0x3A8")]
	public AudioVisualisationEntityLight.LightColourSet YellowColour;

	// Token: 0x04001D5E RID: 7518
	[Token(Token = "0x40017FA")]
	[FieldOffset(Offset = "0x3D8")]
	public AudioVisualisationEntityLight.LightColourSet PinkColour;

	// Token: 0x04001D5F RID: 7519
	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x408")]
	public float lightMinIntensity;

	// Token: 0x04001D60 RID: 7520
	[Token(Token = "0x40017FC")]
	[FieldOffset(Offset = "0x40C")]
	public float lightMaxIntensity;

	// Token: 0x04001D61 RID: 7521
	[Token(Token = "0x40017FD")]
	[FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock block;

	// Token: 0x04001D62 RID: 7522
	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0x8")]
	private static int emissionColourId;

	// Token: 0x04001D63 RID: 7523
	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0x410")]
	private float lastVolume;

	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x2000B5D")]
	[Serializable]
	public struct LightColourSet
	{
		// Token: 0x04001D64 RID: 7524
		[Token(Token = "0x400427A")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x71990", Offset = "0x70D90")]
		public Color LightColor;

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x400427B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x71990", Offset = "0x70D90")]
		public Color SecondaryLightColour;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x400427C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ColorUsageAttribute", RVA = "0x71990", Offset = "0x70D90")]
		public Color EmissionColour;
	}
}
