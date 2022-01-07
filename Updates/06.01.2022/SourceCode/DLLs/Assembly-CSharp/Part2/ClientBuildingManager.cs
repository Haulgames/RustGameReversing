using System;
using Il2CppDummyDll;

// Token: 0x020005CA RID: 1482
[Token(Token = "0x2000456")]
public class ClientBuildingManager : BuildingManager
{
	// Token: 0x06002989 RID: 10633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x4E0110", Offset = "0x4DEF10", VA = "0x1804E0110")]
	public void Cycle()
	{
	}

	// Token: 0x0600298A RID: 10634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x4E00A0", Offset = "0x4DEEA0", VA = "0x1804E00A0", Slot = "4")]
	protected override BuildingManager.Building CreateBuilding(uint id)
	{
		return null;
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022BE")]
	[Address(RVA = "0x4E0230", Offset = "0x4DF030", VA = "0x1804E0230", Slot = "5")]
	protected override void DisposeBuilding(ref BuildingManager.Building building)
	{
	}

	// Token: 0x0600298C RID: 10636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x4E0290", Offset = "0x4DF090", VA = "0x1804E0290")]
	public ClientBuildingManager()
	{
	}
}
