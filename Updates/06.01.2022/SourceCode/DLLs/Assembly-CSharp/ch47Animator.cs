using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000242 RID: 578
[Token(Token = "0x2000186")]
public class ch47Animator : MonoBehaviour
{
	// Token: 0x06001859 RID: 6233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0xAB44D0", Offset = "0xAB32D0", VA = "0x180AB44D0")]
	private void Start()
	{
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x8D9460", Offset = "0x8D8260", VA = "0x1808D9460")]
	public void SetDropDoorOpen(bool isOpen)
	{
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001301")]
	[Address(RVA = "0xAB4530", Offset = "0xAB3330", VA = "0x180AB4530")]
	private void Update()
	{
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001302")]
	[Address(RVA = "0xAB4360", Offset = "0xAB3160", VA = "0x180AB4360")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001303")]
	[Address(RVA = "0xAB4280", Offset = "0xAB3080", VA = "0x180AB4280")]
	private void EnableBlurredRotorBlades(bool enabled)
	{
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001304")]
	[Address(RVA = "0xAB46A0", Offset = "0xAB34A0", VA = "0x180AB46A0")]
	public ch47Animator()
	{
	}

	// Token: 0x04001266 RID: 4710
	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	// Token: 0x04001267 RID: 4711
	[Token(Token = "0x4000EF3")]
	[FieldOffset(Offset = "0x20")]
	public bool bottomDoorOpen;

	// Token: 0x04001268 RID: 4712
	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x21")]
	public bool landingGearDown;

	// Token: 0x04001269 RID: 4713
	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0x22")]
	public bool leftDoorOpen;

	// Token: 0x0400126A RID: 4714
	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x23")]
	public bool rightDoorOpen;

	// Token: 0x0400126B RID: 4715
	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x24")]
	public bool rearDoorOpen;

	// Token: 0x0400126C RID: 4716
	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x25")]
	public bool rearDoorExtensionOpen;

	// Token: 0x0400126D RID: 4717
	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x28")]
	public Transform rearRotorBlade;

	// Token: 0x0400126E RID: 4718
	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x30")]
	public Transform frontRotorBlade;

	// Token: 0x0400126F RID: 4719
	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x38")]
	public float rotorBladeSpeed;

	// Token: 0x04001270 RID: 4720
	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x3C")]
	public float wheelTurnSpeed;

	// Token: 0x04001271 RID: 4721
	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x40")]
	public float wheelTurnAngle;

	// Token: 0x04001272 RID: 4722
	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x48")]
	public SkinnedMeshRenderer[] blurredRotorBlades;

	// Token: 0x04001273 RID: 4723
	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x50")]
	public SkinnedMeshRenderer[] RotorBlades;

	// Token: 0x04001274 RID: 4724
	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x58")]
	private bool blurredRotorBladesEnabled;

	// Token: 0x04001275 RID: 4725
	[Token(Token = "0x4000F01")]
	[FieldOffset(Offset = "0x5C")]
	public float blurSpeedThreshold;
}
