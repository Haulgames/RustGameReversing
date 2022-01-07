using System;
using Il2CppDummyDll;

// Token: 0x02000209 RID: 521
[Token(Token = "0x2000158")]
public class DeliveryDrone : Drone
{
	// Token: 0x06001774 RID: 6004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x8C8A20", Offset = "0x8C7820", VA = "0x1808C8A20")]
	public DeliveryDrone()
	{
	}

	// Token: 0x0400113C RID: 4412
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x318")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x9ED90", Offset = "0x9E190")]
	public float stateTimeout;

	// Token: 0x0400113D RID: 4413
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x31C")]
	public float targetPositionTolerance;

	// Token: 0x0400113E RID: 4414
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x320")]
	public float preferredCruiseHeight;

	// Token: 0x0400113F RID: 4415
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x324")]
	public float preferredHeightAboveObstacle;

	// Token: 0x04001140 RID: 4416
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x328")]
	public float marginAbovePreferredHeight;

	// Token: 0x04001141 RID: 4417
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x32C")]
	public float obstacleHeightLockDuration;

	// Token: 0x04001142 RID: 4418
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x330")]
	public int pickUpDelayInTicks;

	// Token: 0x04001143 RID: 4419
	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x338")]
	public DeliveryDroneConfig config;

	// Token: 0x04001144 RID: 4420
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x340")]
	public GameObjectRef mapMarkerPrefab;
}
