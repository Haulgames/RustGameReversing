using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000246 RID: 582
[Token(Token = "0x200018A")]
public class BradleyMoveTest : MonoBehaviour
{
	// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x46A720", Offset = "0x469520", VA = "0x18046A720")]
	public void Awake()
	{
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x46A720", Offset = "0x469520", VA = "0x18046A720")]
	public void Initialize()
	{
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x46AF20", Offset = "0x469D20", VA = "0x18046AF20")]
	public void SetDestination(Vector3 dest)
	{
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x46A7B0", Offset = "0x4695B0", VA = "0x18046A7B0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x46A640", Offset = "0x469440", VA = "0x18046A640")]
	public void ApplyBrakes(float amount)
	{
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x46AE80", Offset = "0x469C80", VA = "0x18046AE80")]
	public float GetMotorTorque(bool rightSide)
	{
		return 0f;
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x46AF30", Offset = "0x469D30", VA = "0x18046AF30")]
	public void SetMotorTorque(float newThrottle, bool rightSide, float torqueAmount)
	{
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x46A5B0", Offset = "0x4693B0", VA = "0x18046A5B0")]
	public void ApplyBrakeTorque(float amount, bool rightSide)
	{
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void AdjustFriction()
	{
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x46B020", Offset = "0x469E20", VA = "0x18046B020")]
	public BradleyMoveTest()
	{
	}

	// Token: 0x0400127F RID: 4735
	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0x18")]
	public WheelCollider[] leftWheels;

	// Token: 0x04001280 RID: 4736
	[Token(Token = "0x4000F0C")]
	[FieldOffset(Offset = "0x20")]
	public WheelCollider[] rightWheels;

	// Token: 0x04001281 RID: 4737
	[Token(Token = "0x4000F0D")]
	[FieldOffset(Offset = "0x28")]
	public float moveForceMax;

	// Token: 0x04001282 RID: 4738
	[Token(Token = "0x4000F0E")]
	[FieldOffset(Offset = "0x2C")]
	public float brakeForce;

	// Token: 0x04001283 RID: 4739
	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x30")]
	public float throttle;

	// Token: 0x04001284 RID: 4740
	[Token(Token = "0x4000F10")]
	[FieldOffset(Offset = "0x34")]
	public float turnForce;

	// Token: 0x04001285 RID: 4741
	[Token(Token = "0x4000F11")]
	[FieldOffset(Offset = "0x38")]
	public float sideStiffnessMax;

	// Token: 0x04001286 RID: 4742
	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0x3C")]
	public float sideStiffnessMin;

	// Token: 0x04001287 RID: 4743
	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0x40")]
	public Transform centerOfMass;

	// Token: 0x04001288 RID: 4744
	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0x48")]
	public float turning;

	// Token: 0x04001289 RID: 4745
	[Token(Token = "0x4000F15")]
	[FieldOffset(Offset = "0x4C")]
	public bool brake;

	// Token: 0x0400128A RID: 4746
	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0x50")]
	public Rigidbody myRigidBody;

	// Token: 0x0400128B RID: 4747
	[Token(Token = "0x4000F17")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 destination;

	// Token: 0x0400128C RID: 4748
	[Token(Token = "0x4000F18")]
	[FieldOffset(Offset = "0x64")]
	public float stoppingDist;

	// Token: 0x0400128D RID: 4749
	[Token(Token = "0x4000F19")]
	[FieldOffset(Offset = "0x68")]
	public GameObject followTest;
}
