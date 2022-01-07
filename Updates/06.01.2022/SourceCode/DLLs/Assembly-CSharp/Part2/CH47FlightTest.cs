using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000240 RID: 576
[Token(Token = "0x2000185")]
public class CH47FlightTest : MonoBehaviour
{
	// Token: 0x06001851 RID: 6225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x6451E0", Offset = "0x643FE0", VA = "0x1806451E0")]
	public void Awake()
	{
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x0000CA80 File Offset: 0x0000AC80
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x6460E0", Offset = "0x644EE0", VA = "0x1806460E0")]
	public CH47FlightTest.HelicopterInputState_t GetHelicopterInputState()
	{
		return default(CH47FlightTest.HelicopterInputState_t);
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x0000CA98 File Offset: 0x0000AC98
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x645A80", Offset = "0x644880", VA = "0x180645A80")]
	public CH47FlightTest.HelicopterInputState_t GetAIInputState()
	{
		return default(CH47FlightTest.HelicopterInputState_t);
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x646220", Offset = "0x645020", VA = "0x180646220")]
	public float GetIdealAltitude()
	{
		return 0f;
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x645240", Offset = "0x644040", VA = "0x180645240")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x646260", Offset = "0x645060", VA = "0x180646260")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x646650", Offset = "0x645450", VA = "0x180646650")]
	public CH47FlightTest()
	{
	}

	// Token: 0x04001257 RID: 4695
	[Token(Token = "0x4000EE7")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody rigidBody;

	// Token: 0x04001258 RID: 4696
	[Token(Token = "0x4000EE8")]
	[FieldOffset(Offset = "0x20")]
	public float engineThrustMax;

	// Token: 0x04001259 RID: 4697
	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 torqueScale;

	// Token: 0x0400125A RID: 4698
	[Token(Token = "0x4000EEA")]
	[FieldOffset(Offset = "0x30")]
	public Transform com;

	// Token: 0x0400125B RID: 4699
	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0x38")]
	public Transform[] GroundPoints;

	// Token: 0x0400125C RID: 4700
	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0x40")]
	public Transform[] GroundEffects;

	// Token: 0x0400125D RID: 4701
	[Token(Token = "0x4000EED")]
	[FieldOffset(Offset = "0x48")]
	public float currentThrottle;

	// Token: 0x0400125E RID: 4702
	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x4C")]
	public float avgThrust;

	// Token: 0x0400125F RID: 4703
	[Token(Token = "0x4000EEF")]
	[FieldOffset(Offset = "0x50")]
	public float liftDotMax;

	// Token: 0x04001260 RID: 4704
	[Token(Token = "0x4000EF0")]
	[FieldOffset(Offset = "0x58")]
	public Transform AIMoveTarget;

	// Token: 0x04001261 RID: 4705
	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0x0")]
	private static float altitudeTolerance;

	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000AF0")]
	public struct HelicopterInputState_t
	{
		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4004086")]
		[FieldOffset(Offset = "0x0")]
		public float throttle;

		// Token: 0x04001263 RID: 4707
		[Token(Token = "0x4004087")]
		[FieldOffset(Offset = "0x4")]
		public float roll;

		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4004088")]
		[FieldOffset(Offset = "0x8")]
		public float yaw;

		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4004089")]
		[FieldOffset(Offset = "0xC")]
		public float pitch;
	}
}
