using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x2000134")]
public class ArcadeEntityController : BaseMonoBehaviour
{
	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
	// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000185")]
	public Vector3 heading
	{
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x834580", Offset = "0x833380", VA = "0x180834580")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x834650", Offset = "0x833450", VA = "0x180834650")]
		set
		{
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
	// (set) Token: 0x060016BA RID: 5818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000186")]
	public Vector3 positionLocal
	{
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x8345B0", Offset = "0x8333B0", VA = "0x1808345B0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x834680", Offset = "0x833480", VA = "0x180834680")]
		set
		{
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x060016BB RID: 5819 RVA: 0x0000C510 File Offset: 0x0000A710
	// (set) Token: 0x060016BC RID: 5820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000187")]
	public Vector3 positionWorld
	{
		[Token(Token = "0x600117B")]
		[Address(RVA = "0x834600", Offset = "0x833400", VA = "0x180834600")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x8346D0", Offset = "0x8334D0", VA = "0x1808346D0")]
		set
		{
		}
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117D")]
	[Address(RVA = "0x833EC0", Offset = "0x832CC0", VA = "0x180833EC0")]
	public void SetOwnerGame(BaseArcadeGame ownerGame)
	{
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117E")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "6")]
	public virtual void Initialize()
	{
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x0000C528 File Offset: 0x0000A728
	[Token(Token = "0x600117F")]
	[Address(RVA = "0x833D20", Offset = "0x832B20", VA = "0x180833D20")]
	public bool IsAuthorative()
	{
		return default(bool);
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001180")]
	[Address(RVA = "0x833D50", Offset = "0x832B50", VA = "0x180833D50")]
	public void SetAuthorative(bool wants)
	{
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001181")]
	[Address(RVA = "0x834370", Offset = "0x833170", VA = "0x180834370")]
	public void SetSprite(Sprite newSprite)
	{
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001182")]
	[Address(RVA = "0x834480", Offset = "0x833280", VA = "0x180834480", Slot = "7")]
	public virtual void Shutdown()
	{
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001183")]
	[Address(RVA = "0x8342C0", Offset = "0x8330C0", VA = "0x1808342C0")]
	public void SetPositionWorld(Vector3 newPos)
	{
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001184")]
	[Address(RVA = "0x833D60", Offset = "0x832B60", VA = "0x180833D60")]
	public void SetHeading(Vector3 heading)
	{
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001185")]
	[Address(RVA = "0x834250", Offset = "0x833050", VA = "0x180834250")]
	public void SetPositionLocal(Vector3 newPos)
	{
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001186")]
	[Address(RVA = "0x833D30", Offset = "0x832B30", VA = "0x180833D30")]
	public void OnDisable()
	{
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001187")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public ArcadeEntityController()
	{
	}

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x18")]
	public BaseArcadeGame parentGame;

	// Token: 0x04001084 RID: 4228
	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x20")]
	public ArcadeEntity arcadeEntity;

	// Token: 0x04001085 RID: 4229
	[Token(Token = "0x4000D4E")]
	[FieldOffset(Offset = "0x28")]
	public ArcadeEntity sourceEntity;

	// Token: 0x04001086 RID: 4230
	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0x30")]
	private bool authorative;
}
