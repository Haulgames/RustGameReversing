using System;
using Il2CppDummyDll;

// Token: 0x02000565 RID: 1381
[Token(Token = "0x2000401")]
public class BaseVehicleMountPoint : BaseMountable
{
	// Token: 0x060027EC RID: 10220 RVA: 0x00011778 File Offset: 0x0000F978
	[Token(Token = "0x6002152")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "146")]
	public override bool DirectlyMountable()
	{
		return default(bool);
	}

	// Token: 0x060027ED RID: 10221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002153")]
	[Address(RVA = "0x9A9270", Offset = "0x9A8070", VA = "0x1809A9270", Slot = "167")]
	public override BaseVehicle VehicleParent()
	{
		return null;
	}

	// Token: 0x060027EE RID: 10222 RVA: 0x00011790 File Offset: 0x0000F990
	[Token(Token = "0x6002154")]
	[Address(RVA = "0x9A91C0", Offset = "0x9A7FC0", VA = "0x1809A91C0", Slot = "108")]
	public override bool BlocksWaterFor(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x000117A8 File Offset: 0x0000F9A8
	[Token(Token = "0x6002155")]
	[Address(RVA = "0x9A93E0", Offset = "0x9A81E0", VA = "0x1809A93E0", Slot = "155")]
	public override float WaterFactorForPlayer(BasePlayer player)
	{
		return 0f;
	}

	// Token: 0x060027F0 RID: 10224 RVA: 0x000117C0 File Offset: 0x0000F9C0
	[Token(Token = "0x6002156")]
	[Address(RVA = "0x9A9120", Offset = "0x9A7F20", VA = "0x1809A9120", Slot = "107")]
	public override float AirFactor()
	{
		return 0f;
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002157")]
	[Address(RVA = "0x6AF0E0", Offset = "0x6ADEE0", VA = "0x1806AF0E0")]
	public BaseVehicleMountPoint()
	{
	}
}
