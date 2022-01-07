using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x020004C2 RID: 1218
[Token(Token = "0x2000389")]
public class DecayEntity : BaseCombatEntity
{
	// Token: 0x060024A2 RID: 9378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E39")]
	[Address(RVA = "0x8BC920", Offset = "0x8BB720", VA = "0x1808BC920", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0x8BCA20", Offset = "0x8BB820", VA = "0x1808BCA20", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060024A4 RID: 9380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x8BC170", Offset = "0x8BAF70", VA = "0x1808BC170")]
	public void AttachToBuilding(uint id)
	{
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x8BC890", Offset = "0x8BB690", VA = "0x1808BC890")]
	public BuildingManager.Building GetBuilding()
	{
		return null;
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0x8BC7F0", Offset = "0x8BB5F0", VA = "0x1808BC7F0", Slot = "82")]
	public override BuildingPrivlidge GetBuildingPrivilege()
	{
		return null;
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0x8BC230", Offset = "0x8BB030", VA = "0x1808BC230")]
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts, float multiplier)
	{
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0x8BC5F0", Offset = "0x8BB3F0", VA = "0x1808BC5F0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x8BC770", Offset = "0x8BB570", VA = "0x1808BC770", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x000103C8 File Offset: 0x0000E5C8
	[Token(Token = "0x6001E41")]
	[Address(RVA = "0x8BC6E0", Offset = "0x8BB4E0", VA = "0x1808BC6E0", Slot = "130")]
	public override bool DisplayHealthInfo(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E42")]
	[Address(RVA = "0x2EF040", Offset = "0x2EDE40", VA = "0x1802EF040")]
	public DecayEntity()
	{
	}

	// Token: 0x04001EEA RID: 7914
	[Token(Token = "0x4001943")]
	[FieldOffset(Offset = "0x238")]
	public GameObjectRef debrisPrefab;

	// Token: 0x04001EEB RID: 7915
	[Token(Token = "0x4001944")]
	[FieldOffset(Offset = "0x240")]
	[NonSerialized]
	public uint buildingID;

	// Token: 0x04001EEC RID: 7916
	[Token(Token = "0x4001945")]
	[FieldOffset(Offset = "0x248")]
	private Upkeep upkeep;
}
