using System;
using Il2CppDummyDll;
using UnityEngine.AI;

// Token: 0x020005C8 RID: 1480
[Token(Token = "0x2000455")]
public abstract class BuildingManager
{
	// Token: 0x06002972 RID: 10610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x63D670", Offset = "0x63C470", VA = "0x18063D670")]
	public BuildingManager.Building GetBuilding(uint buildingID)
	{
		return null;
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x63D4D0", Offset = "0x63C2D0", VA = "0x18063D4D0")]
	public void Add(DecayEntity ent)
	{
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x63D6E0", Offset = "0x63C4E0", VA = "0x18063D6E0")]
	public void Remove(DecayEntity ent)
	{
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x63D620", Offset = "0x63C420", VA = "0x18063D620")]
	public void Clear()
	{
	}

	// Token: 0x06002976 RID: 10614
	[Token(Token = "0x60022B8")]
	protected abstract BuildingManager.Building CreateBuilding(uint id);

	// Token: 0x06002977 RID: 10615
	[Token(Token = "0x60022B9")]
	protected abstract void DisposeBuilding(ref BuildingManager.Building building);

	// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x63D930", Offset = "0x63C730", VA = "0x18063D930")]
	protected BuildingManager()
	{
	}

	// Token: 0x040024E4 RID: 9444
	[Token(Token = "0x4001E2D")]
	[FieldOffset(Offset = "0x0")]
	public static ClientBuildingManager client;

	// Token: 0x040024E5 RID: 9445
	[Token(Token = "0x4001E2E")]
	[FieldOffset(Offset = "0x10")]
	protected ListHashSet<DecayEntity> decayEntities;

	// Token: 0x040024E6 RID: 9446
	[Token(Token = "0x4001E2F")]
	[FieldOffset(Offset = "0x18")]
	protected ListDictionary<uint, BuildingManager.Building> buildingDictionary;

	// Token: 0x020005C9 RID: 1481
	[Token(Token = "0x2000BA6")]
	public class Building
	{
		// Token: 0x0600297A RID: 10618 RVA: 0x00011FB8 File Offset: 0x000101B8
		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x640930", Offset = "0x63F730", VA = "0x180640930")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x640710", Offset = "0x63F510", VA = "0x180640710")]
		public BuildingPrivlidge GetDominatingBuildingPrivilege()
		{
			return null;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00011FD0 File Offset: 0x000101D0
		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0x640890", Offset = "0x63F690", VA = "0x180640890")]
		public bool HasBuildingPrivileges()
		{
			return default(bool);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x640840", Offset = "0x63F640", VA = "0x180640840")]
		public bool HasBuildingBlocks()
		{
			return default(bool);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x6408E0", Offset = "0x63F6E0", VA = "0x1806408E0")]
		public bool HasDecayEntities()
		{
			return default(bool);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3F")]
		[Address(RVA = "0x6402F0", Offset = "0x63F0F0", VA = "0x1806402F0")]
		public void AddBuildingPrivilege(BuildingPrivlidge ent)
		{
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E40")]
		[Address(RVA = "0x640A80", Offset = "0x63F880", VA = "0x180640A80")]
		public void RemoveBuildingPrivilege(BuildingPrivlidge ent)
		{
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E41")]
		[Address(RVA = "0x640250", Offset = "0x63F050", VA = "0x180640250")]
		public void AddBuildingBlock(BuildingBlock ent)
		{
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E42")]
		[Address(RVA = "0x6409F0", Offset = "0x63F7F0", VA = "0x1806409F0")]
		public void RemoveBuildingBlock(BuildingBlock ent)
		{
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E43")]
		[Address(RVA = "0x640390", Offset = "0x63F190", VA = "0x180640390")]
		public void AddDecayEntity(DecayEntity ent)
		{
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E44")]
		[Address(RVA = "0x640B10", Offset = "0x63F910", VA = "0x180640B10")]
		public void RemoveDecayEntity(DecayEntity ent)
		{
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x640430", Offset = "0x63F230", VA = "0x180640430")]
		public void Add(DecayEntity ent)
		{
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x640BA0", Offset = "0x63F9A0", VA = "0x180640BA0")]
		public void Remove(DecayEntity ent)
		{
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x640690", Offset = "0x63F490", VA = "0x180640690")]
		public void Dirty()
		{
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x640DA0", Offset = "0x63FBA0", VA = "0x180640DA0")]
		public Building()
		{
		}

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40043C1")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40043C2")]
		[FieldOffset(Offset = "0x18")]
		public ListHashSet<BuildingPrivlidge> buildingPrivileges;

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40043C3")]
		[FieldOffset(Offset = "0x20")]
		public ListHashSet<BuildingBlock> buildingBlocks;

		// Token: 0x040024EA RID: 9450
		[Token(Token = "0x40043C4")]
		[FieldOffset(Offset = "0x28")]
		public ListHashSet<DecayEntity> decayEntities;

		// Token: 0x040024EB RID: 9451
		[Token(Token = "0x40043C5")]
		[FieldOffset(Offset = "0x30")]
		public NavMeshObstacle buildingNavMeshObstacle;

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40043C6")]
		[FieldOffset(Offset = "0x38")]
		public ListHashSet<NavMeshObstacle> navmeshCarvers;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40043C7")]
		[FieldOffset(Offset = "0x40")]
		public bool isNavMeshCarvingDirty;

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40043C8")]
		[FieldOffset(Offset = "0x41")]
		public bool isNavMeshCarveOptimized;
	}
}
