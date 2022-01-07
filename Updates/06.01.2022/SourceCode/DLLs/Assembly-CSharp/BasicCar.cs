using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000567 RID: 1383
[Token(Token = "0x2000403")]
public class BasicCar : global::BaseVehicle
{
	// Token: 0x060027F7 RID: 10231 RVA: 0x00011808 File Offset: 0x0000FA08
	[Token(Token = "0x600215D")]
	[Address(RVA = "0x456C60", Offset = "0x455A60", VA = "0x180456C60", Slot = "111")]
	public override float MaxVelocity()
	{
		return 0f;
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x00011820 File Offset: 0x0000FA20
	[Token(Token = "0x600215E")]
	[Address(RVA = "0x456390", Offset = "0x455190", VA = "0x180456390", Slot = "153")]
	public override Vector3 EyePositionForPlayer(global::BasePlayer player, Quaternion viewRot)
	{
		return default(Vector3);
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600215F")]
	[Address(RVA = "0x4562B0", Offset = "0x4550B0", VA = "0x1804562B0", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x060027FA RID: 10234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002160")]
	[Address(RVA = "0x456C70", Offset = "0x455A70", VA = "0x180456C70", Slot = "59")]
	public override void SetNetworkPosition(Vector3 vPos)
	{
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002161")]
	[Address(RVA = "0x456040", Offset = "0x454E40", VA = "0x180456040", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002162")]
	[Address(RVA = "0x457660", Offset = "0x456460", VA = "0x180457660")]
	public void Update()
	{
	}

	// Token: 0x060027FD RID: 10237 RVA: 0x00011838 File Offset: 0x0000FA38
	[Token(Token = "0x6002163")]
	[Address(RVA = "0x456460", Offset = "0x455260", VA = "0x180456460")]
	private float GetShockHeightDelta(WheelCollider wheel, int i)
	{
		return 0f;
	}

	// Token: 0x060027FE RID: 10238 RVA: 0x00011850 File Offset: 0x0000FA50
	[Token(Token = "0x6002164")]
	[Address(RVA = "0x456250", Offset = "0x455050", VA = "0x180456250")]
	private float ClientSteering()
	{
		return 0f;
	}

	// Token: 0x060027FF RID: 10239 RVA: 0x00011868 File Offset: 0x0000FA68
	[Token(Token = "0x6002165")]
	[Address(RVA = "0x456C50", Offset = "0x455A50", VA = "0x180456C50")]
	public bool IsBreaking()
	{
		return default(bool);
	}

	// Token: 0x06002800 RID: 10240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002166")]
	[Address(RVA = "0x4570B0", Offset = "0x455EB0", VA = "0x1804570B0")]
	private void UpdateTireAnimation()
	{
	}

	// Token: 0x06002801 RID: 10241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002167")]
	[Address(RVA = "0x456AC0", Offset = "0x4558C0", VA = "0x180456AC0")]
	public void InitializeClientsideEffects()
	{
	}

	// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002168")]
	[Address(RVA = "0x456CE0", Offset = "0x455AE0", VA = "0x180456CE0")]
	public void ShutdownClientsideEffects()
	{
	}

	// Token: 0x06002803 RID: 10243 RVA: 0x00011880 File Offset: 0x0000FA80
	[Token(Token = "0x6002169")]
	[Address(RVA = "0x4396F0", Offset = "0x4384F0", VA = "0x1804396F0")]
	public bool IsEngineOn()
	{
		return default(bool);
	}

	// Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600216A")]
	[Address(RVA = "0x456DB0", Offset = "0x455BB0", VA = "0x180456DB0")]
	public void UpdateSounds()
	{
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600216B")]
	[Address(RVA = "0x4576C0", Offset = "0x4564C0", VA = "0x1804576C0")]
	public BasicCar()
	{
	}

	// Token: 0x04002310 RID: 8976
	[Token(Token = "0x4001C9C")]
	[FieldOffset(Offset = "0x3A8")]
	public BasicCar.VehicleWheel[] wheels;

	// Token: 0x04002311 RID: 8977
	[Token(Token = "0x4001C9D")]
	[FieldOffset(Offset = "0x3B0")]
	public float brakePedal;

	// Token: 0x04002312 RID: 8978
	[Token(Token = "0x4001C9E")]
	[FieldOffset(Offset = "0x3B4")]
	public float gasPedal;

	// Token: 0x04002313 RID: 8979
	[Token(Token = "0x4001C9F")]
	[FieldOffset(Offset = "0x3B8")]
	public float steering;

	// Token: 0x04002314 RID: 8980
	[Token(Token = "0x4001CA0")]
	[FieldOffset(Offset = "0x3C0")]
	public Transform centerOfMass;

	// Token: 0x04002315 RID: 8981
	[Token(Token = "0x4001CA1")]
	[FieldOffset(Offset = "0x3C8")]
	public Transform steeringWheel;

	// Token: 0x04002316 RID: 8982
	[Token(Token = "0x4001CA2")]
	[FieldOffset(Offset = "0x3D0")]
	public float motorForceConstant;

	// Token: 0x04002317 RID: 8983
	[Token(Token = "0x4001CA3")]
	[FieldOffset(Offset = "0x3D4")]
	public float brakeForceConstant;

	// Token: 0x04002318 RID: 8984
	[Token(Token = "0x4001CA4")]
	[FieldOffset(Offset = "0x3D8")]
	public float GasLerpTime;

	// Token: 0x04002319 RID: 8985
	[Token(Token = "0x4001CA5")]
	[FieldOffset(Offset = "0x3DC")]
	public float SteeringLerpTime;

	// Token: 0x0400231A RID: 8986
	[Token(Token = "0x4001CA6")]
	[FieldOffset(Offset = "0x3E0")]
	public Transform driverEye;

	// Token: 0x0400231B RID: 8987
	[Token(Token = "0x4001CA7")]
	[FieldOffset(Offset = "0x3E8")]
	public GameObjectRef chairRef;

	// Token: 0x0400231C RID: 8988
	[Token(Token = "0x4001CA8")]
	[FieldOffset(Offset = "0x3F0")]
	public Transform chairAnchorTest;

	// Token: 0x0400231D RID: 8989
	[Token(Token = "0x4001CA9")]
	[FieldOffset(Offset = "0x3F8")]
	public SoundPlayer idleLoopPlayer;

	// Token: 0x0400231E RID: 8990
	[Token(Token = "0x4001CAA")]
	[FieldOffset(Offset = "0x400")]
	public Transform engineOffset;

	// Token: 0x0400231F RID: 8991
	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0x408")]
	public SoundDefinition engineSoundDef;

	// Token: 0x04002320 RID: 8992
	[Token(Token = "0x4001CAC")]
	[FieldOffset(Offset = "0x410")]
	private SedanWheelSmoke wheelSmoke;

	// Token: 0x04002321 RID: 8993
	[Token(Token = "0x4001CAD")]
	[FieldOffset(Offset = "0x418")]
	private float shockRestingPosY;

	// Token: 0x04002322 RID: 8994
	[Token(Token = "0x4001CAE")]
	[FieldOffset(Offset = "0x41C")]
	private float shockDistance;

	// Token: 0x04002323 RID: 8995
	[Token(Token = "0x4001CAF")]
	[FieldOffset(Offset = "0x420")]
	private float traceDistanceNeutralPoint;

	// Token: 0x04002324 RID: 8996
	[Token(Token = "0x4001CB0")]
	[FieldOffset(Offset = "0x424")]
	private int cachedMask;

	// Token: 0x04002325 RID: 8997
	[Token(Token = "0x4001CB1")]
	private const float wheelSpinConstant = 120f;

	// Token: 0x04002326 RID: 8998
	[Token(Token = "0x4001CB2")]
	[FieldOffset(Offset = "0x428")]
	private AverageVelocity averageVelocity;

	// Token: 0x04002327 RID: 8999
	[Token(Token = "0x4001CB3")]
	[FieldOffset(Offset = "0x430")]
	private Sound engineSoundLoop;

	// Token: 0x04002328 RID: 9000
	[Token(Token = "0x4001CB4")]
	[FieldOffset(Offset = "0x438")]
	private SoundModulation.Modulator engineSoundVolume;

	// Token: 0x04002329 RID: 9001
	[Token(Token = "0x4001CB5")]
	[FieldOffset(Offset = "0x440")]
	private SoundModulation.Modulator engineSoundPitch;

	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x2000B97")]
	[Serializable]
	public class VehicleWheel
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E16")]
		[Address(RVA = "0x476930", Offset = "0x475730", VA = "0x180476930")]
		public VehicleWheel()
		{
		}

		// Token: 0x0400232A RID: 9002
		[Token(Token = "0x400437E")]
		[FieldOffset(Offset = "0x10")]
		public Transform shock;

		// Token: 0x0400232B RID: 9003
		[Token(Token = "0x400437F")]
		[FieldOffset(Offset = "0x18")]
		public WheelCollider wheelCollider;

		// Token: 0x0400232C RID: 9004
		[Token(Token = "0x4004380")]
		[FieldOffset(Offset = "0x20")]
		public Transform wheel;

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x4004381")]
		[FieldOffset(Offset = "0x28")]
		public Transform axle;

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x4004382")]
		[FieldOffset(Offset = "0x30")]
		public bool steerWheel;

		// Token: 0x0400232F RID: 9007
		[Token(Token = "0x4004383")]
		[FieldOffset(Offset = "0x31")]
		public bool brakeWheel;

		// Token: 0x04002330 RID: 9008
		[Token(Token = "0x4004384")]
		[FieldOffset(Offset = "0x32")]
		public bool powerWheel;
	}
}
