using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020004C5 RID: 1221
[Token(Token = "0x200038C")]
public class EntityFuelSystem
{
	// Token: 0x060024AF RID: 9391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E46")]
	[Address(RVA = "0x850080", Offset = "0x84EE80", VA = "0x180850080")]
	public EntityFuelSystem(bool isServer, GameObjectRef fuelStoragePrefab, List<BaseEntity> children, bool editorGiveFreeFuel = true)
	{
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x000103E0 File Offset: 0x0000E5E0
	[Token(Token = "0x6001E47")]
	[Address(RVA = "0x84FF20", Offset = "0x84ED20", VA = "0x18084FF20")]
	public bool IsInFuelInteractionRange(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E48")]
	[Address(RVA = "0x84FE90", Offset = "0x84EC90", VA = "0x18084FE90")]
	private StorageContainer GetFuelContainer()
	{
		return null;
	}

	// Token: 0x04001EF0 RID: 7920
	[Token(Token = "0x4001949")]
	[FieldOffset(Offset = "0x10")]
	private readonly bool isServer;

	// Token: 0x04001EF1 RID: 7921
	[Token(Token = "0x400194A")]
	[FieldOffset(Offset = "0x11")]
	private readonly bool editorGiveFreeFuel;

	// Token: 0x04001EF2 RID: 7922
	[Token(Token = "0x400194B")]
	[FieldOffset(Offset = "0x14")]
	private readonly uint fuelStorageID;

	// Token: 0x04001EF3 RID: 7923
	[Token(Token = "0x400194C")]
	[FieldOffset(Offset = "0x18")]
	public EntityRef<StorageContainer> fuelStorageInstance;
}
