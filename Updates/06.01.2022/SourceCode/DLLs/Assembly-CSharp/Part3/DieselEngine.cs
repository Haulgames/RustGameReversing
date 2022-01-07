using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000050")]
public class DieselEngine : StorageContainer
{
	// Token: 0x060009BF RID: 2495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000567")]
	[Address(RVA = "0xB71960", Offset = "0xB70760", VA = "0x180B71960", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00005778 File Offset: 0x00003978
	[Token(Token = "0x17000096")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xB72620", Offset = "0xB71420", VA = "0x180B72620", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x6000569")]
	[Address(RVA = "0xB72180", Offset = "0xB70F80", VA = "0x180B72180", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056A")]
	[Address(RVA = "0xB71FA0", Offset = "0xB70DA0", VA = "0x180B71FA0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x000057A8 File Offset: 0x000039A8
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x456C50", Offset = "0x455A50", VA = "0x180456C50")]
	public bool HasFuel()
	{
		return default(bool);
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x000057C0 File Offset: 0x000039C0
	[Token(Token = "0x600056C")]
	[Address(RVA = "0xB723C0", Offset = "0xB711C0", VA = "0x180B723C0", Slot = "150")]
	public override bool ShouldShowLootMenus()
	{
		return default(bool);
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x66D6D0", Offset = "0x66C4D0", VA = "0x18066D6D0", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056E")]
	[Address(RVA = "0xB72270", Offset = "0xB71070", VA = "0x180B72270")]
	public void Rumble()
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056F")]
	[Address(RVA = "0xB72090", Offset = "0xB70E90", VA = "0x180B72090")]
	[Attribute(Name = "Menu", RVA = "0xC6790", Offset = "0xC5B90")]
	[Attribute(Name = "Description", RVA = "0xC6790", Offset = "0xC5B90")]
	[Attribute(Name = "Icon", RVA = "0xC6790", Offset = "0xC5B90")]
	[Attribute(Name = "ShowIf", RVA = "0xC6790", Offset = "0xC5B90")]
	public void Menu_EngineStartup(BasePlayer player)
	{
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x000057D8 File Offset: 0x000039D8
	[Token(Token = "0x6000570")]
	[Address(RVA = "0xB72000", Offset = "0xB70E00", VA = "0x180B72000")]
	public bool Menu_EngineStartup_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0xC6CD0", Offset = "0xC60D0")]
	[Attribute(Name = "Description", RVA = "0xC6CD0", Offset = "0xC60D0")]
	[Attribute(Name = "Icon", RVA = "0xC6CD0", Offset = "0xC60D0")]
	[Attribute(Name = "ShowIf", RVA = "0xC6CD0", Offset = "0xC60D0")]
	public void Menu_NoFuel(BasePlayer player)
	{
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x6000572")]
	[Address(RVA = "0xB720E0", Offset = "0xB70EE0", VA = "0x180B720E0")]
	public bool Menu_NoFuel_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000573")]
	[Address(RVA = "0xB725C0", Offset = "0xB713C0", VA = "0x180B725C0")]
	public DieselEngine()
	{
	}

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x3C8")]
	private Option __menuOption_Menu_EngineStartup;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x420")]
	private Option __menuOption_Menu_NoFuel;

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x478")]
	public GameObjectRef rumbleEffect;

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x480")]
	public Transform rumbleOrigin;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x4000440")]
	public const BaseEntity.Flags Flag_HasFuel = BaseEntity.Flags.Reserved3;

	// Token: 0x0400052E RID: 1326
	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x488")]
	public float runningTimePerFuelUnit;

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x48C")]
	private float cachedFuelTime;

	// Token: 0x04000530 RID: 1328
	[Token(Token = "0x4000443")]
	private const float rumbleMaxDistSq = 100f;
}
