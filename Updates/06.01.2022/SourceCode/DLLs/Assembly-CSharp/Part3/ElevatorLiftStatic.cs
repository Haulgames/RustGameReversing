using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;

// Token: 0x02000091 RID: 145
[Token(Token = "0x2000058")]
public class ElevatorLiftStatic : ElevatorLift
{
	// Token: 0x06000A25 RID: 2597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x98D1E0", Offset = "0x98BFE0", VA = "0x18098D1E0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00005B50 File Offset: 0x00003D50
	[Token(Token = "0x170000A1")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x98D800", Offset = "0x98C600", VA = "0x18098D800", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x98D790", Offset = "0x98C590", VA = "0x18098D790")]
	[Attribute(Name = "Menu", RVA = "0xCAC20", Offset = "0xCA020")]
	[Attribute(Name = "Description", RVA = "0xCAC20", Offset = "0xCA020")]
	[Attribute(Name = "Icon", RVA = "0xCAC20", Offset = "0xCA020")]
	[Attribute(Name = "ShowIf", RVA = "0xCAC20", Offset = "0xCA020")]
	public new void Menu_RaiseElevatorToTop(BasePlayer p)
	{
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x98D740", Offset = "0x98C540", VA = "0x18098D740")]
	[Attribute(Name = "Menu", RVA = "0xCAEB0", Offset = "0xCA2B0")]
	[Attribute(Name = "Description", RVA = "0xCAEB0", Offset = "0xCA2B0")]
	[Attribute(Name = "Icon", RVA = "0xCAEB0", Offset = "0xCA2B0")]
	[Attribute(Name = "ShowIf", RVA = "0xCAEB0", Offset = "0xCA2B0")]
	public new void Menu_LowerElevatorToFloor(BasePlayer p)
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00005B68 File Offset: 0x00003D68
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "144")]
	protected override bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "145")]
	protected override bool Menu_LowerElevator_ShowIf_Base(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x98D7E0", Offset = "0x98C5E0", VA = "0x18098D7E0")]
	public ElevatorLiftStatic()
	{
	}

	// Token: 0x0400056D RID: 1389
	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x408")]
	private Option __menuOption_Menu_LowerElevatorToFloor;

	// Token: 0x0400056E RID: 1390
	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x460")]
	private Option __menuOption_Menu_RaiseElevatorToTop;
}
