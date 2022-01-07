using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000574 RID: 1396
[Token(Token = "0x200040D")]
public class CH47HelicopterAIController : CH47Helicopter
{
	// Token: 0x0600282C RID: 10284 RVA: 0x00011928 File Offset: 0x0000FB28
	[Token(Token = "0x6002190")]
	[Address(RVA = "0x646660", Offset = "0x645460", VA = "0x180646660", Slot = "181")]
	public override bool MountMenuVisible(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002191")]
	[Address(RVA = "0x46CB10", Offset = "0x46B910", VA = "0x18046CB10", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002192")]
	[Address(RVA = "0x646700", Offset = "0x645500", VA = "0x180646700")]
	public CH47HelicopterAIController()
	{
	}

	// Token: 0x0400235D RID: 9053
	[Token(Token = "0x4001CDE")]
	[FieldOffset(Offset = "0x4C8")]
	public GameObjectRef scientistPrefab;

	// Token: 0x0400235E RID: 9054
	[Token(Token = "0x4001CDF")]
	[FieldOffset(Offset = "0x4D0")]
	public GameObjectRef dismountablePrefab;

	// Token: 0x0400235F RID: 9055
	[Token(Token = "0x4001CE0")]
	[FieldOffset(Offset = "0x4D8")]
	public GameObjectRef weakDismountablePrefab;

	// Token: 0x04002360 RID: 9056
	[Token(Token = "0x4001CE1")]
	[FieldOffset(Offset = "0x4E0")]
	public float maxTiltAngle;

	// Token: 0x04002361 RID: 9057
	[Token(Token = "0x4001CE2")]
	[FieldOffset(Offset = "0x4E4")]
	public float AiAltitudeForce;

	// Token: 0x04002362 RID: 9058
	[Token(Token = "0x4001CE3")]
	[FieldOffset(Offset = "0x4E8")]
	public GameObjectRef lockedCratePrefab;

	// Token: 0x04002363 RID: 9059
	[Token(Token = "0x4001CE4")]
	public const BaseEntity.Flags Flag_Damaged = BaseEntity.Flags.Reserved7;

	// Token: 0x04002364 RID: 9060
	[Token(Token = "0x4001CE5")]
	public const BaseEntity.Flags Flag_NearDeath = BaseEntity.Flags.OnFire;

	// Token: 0x04002365 RID: 9061
	[Token(Token = "0x4001CE6")]
	public const BaseEntity.Flags Flag_DropDoorOpen = BaseEntity.Flags.Reserved8;

	// Token: 0x04002366 RID: 9062
	[Token(Token = "0x4001CE7")]
	[FieldOffset(Offset = "0x4F0")]
	public GameObject triggerHurt;

	// Token: 0x04002367 RID: 9063
	[Token(Token = "0x4001CE8")]
	[FieldOffset(Offset = "0x4F8")]
	public Vector3 landingTarget;
}
