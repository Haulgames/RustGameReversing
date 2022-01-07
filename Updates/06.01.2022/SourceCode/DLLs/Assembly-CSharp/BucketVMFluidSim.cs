using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000403 RID: 1027
[Token(Token = "0x20002E2")]
public class BucketVMFluidSim : MonoBehaviour
{
	// Token: 0x06002152 RID: 8530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x46BCE0", Offset = "0x46AAE0", VA = "0x18046BCE0")]
	private void Start()
	{
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x46BCC0", Offset = "0x46AAC0", VA = "0x18046BCC0")]
	private void SetFillingFromWorld(bool isFilling)
	{
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x46BD60", Offset = "0x46AB60", VA = "0x18046BD60")]
	private void UpdateWaterLevel(float newLevel)
	{
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x46C000", Offset = "0x46AE00", VA = "0x18046C000")]
	private void Update()
	{
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x46B660", Offset = "0x46A460", VA = "0x18046B660")]
	private void CalculateTurbulence()
	{
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	private void DoWaterTipping()
	{
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x46B5D0", Offset = "0x46A3D0", VA = "0x18046B5D0")]
	public void AddWater(float waterAmount)
	{
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x46BAC0", Offset = "0x46A8C0", VA = "0x18046BAC0")]
	private void DisableWaterSpillEffects()
	{
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B25")]
	[Address(RVA = "0x46BD70", Offset = "0x46AB70", VA = "0x18046BD70")]
	private void UpdateWaterLine()
	{
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x0000F618 File Offset: 0x0000D818
	[Token(Token = "0x6001B26")]
	[Address(RVA = "0x46C070", Offset = "0x46AE70", VA = "0x18046C070")]
	private float fsel(float c, float x, float y)
	{
		return 0f;
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x0000F630 File Offset: 0x0000D830
	[Token(Token = "0x6001B27")]
	[Address(RVA = "0x46BBE0", Offset = "0x46A9E0", VA = "0x18046BBE0")]
	private float RemapValClamped(float val, float A, float B, float C, float D)
	{
		return 0f;
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BucketVMFluidSim()
	{
	}

	// Token: 0x04001C03 RID: 7171
	[Token(Token = "0x40016BA")]
	[FieldOffset(Offset = "0x18")]
	public Animator waterbucketAnim;

	// Token: 0x04001C04 RID: 7172
	[Token(Token = "0x40016BB")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem waterPour;

	// Token: 0x04001C05 RID: 7173
	[Token(Token = "0x40016BC")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem waterTurbulence;

	// Token: 0x04001C06 RID: 7174
	[Token(Token = "0x40016BD")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem waterFill;

	// Token: 0x04001C07 RID: 7175
	[Token(Token = "0x40016BE")]
	[FieldOffset(Offset = "0x38")]
	public float waterLevel;

	// Token: 0x04001C08 RID: 7176
	[Token(Token = "0x40016BF")]
	[FieldOffset(Offset = "0x3C")]
	public float targetWaterLevel;

	// Token: 0x04001C09 RID: 7177
	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource waterSpill;

	// Token: 0x04001C0A RID: 7178
	[Token(Token = "0x40016C1")]
	[FieldOffset(Offset = "0x48")]
	private float PlayerEyePitch;

	// Token: 0x04001C0B RID: 7179
	[Token(Token = "0x40016C2")]
	[FieldOffset(Offset = "0x4C")]
	private float turb_forward;

	// Token: 0x04001C0C RID: 7180
	[Token(Token = "0x40016C3")]
	[FieldOffset(Offset = "0x50")]
	private float turb_side;

	// Token: 0x04001C0D RID: 7181
	[Token(Token = "0x40016C4")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 lastPosition;

	// Token: 0x04001C0E RID: 7182
	[Token(Token = "0x40016C5")]
	[FieldOffset(Offset = "0x60")]
	protected Vector3 groundSpeedLast;

	// Token: 0x04001C0F RID: 7183
	[Token(Token = "0x40016C6")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 lastAngle;

	// Token: 0x04001C10 RID: 7184
	[Token(Token = "0x40016C7")]
	[FieldOffset(Offset = "0x78")]
	protected Vector3 vecAngleSpeedLast;

	// Token: 0x04001C11 RID: 7185
	[Token(Token = "0x40016C8")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 initialPosition;
}
