using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000092 RID: 146
[Token(Token = "0x2000059")]
public class EngineSwitch : BaseEntity
{
	// Token: 0x06000A2C RID: 2604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x992A70", Offset = "0x991870", VA = "0x180992A70", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00005B98 File Offset: 0x00003D98
	[Token(Token = "0x170000A2")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x993170", Offset = "0x991F70", VA = "0x180993170", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00005BB0 File Offset: 0x00003DB0
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x993020", Offset = "0x991E20", VA = "0x180993020", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x992FA0", Offset = "0x991DA0", VA = "0x180992FA0")]
	[Attribute(Name = "Menu", RVA = "0xCB150", Offset = "0xCA550")]
	[Attribute(Name = "Description", RVA = "0xCB150", Offset = "0xCA550")]
	[Attribute(Name = "Icon", RVA = "0xCB150", Offset = "0xCA550")]
	[Attribute(Name = "ShowIf", RVA = "0xCB150", Offset = "0xCA550")]
	public void Menu_StartEngine(BasePlayer player)
	{
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00005BC8 File Offset: 0x00003DC8
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x457F70", Offset = "0x456D70", VA = "0x180457F70")]
	public bool Menu_EngineOn_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x992FE0", Offset = "0x991DE0", VA = "0x180992FE0")]
	[Attribute(Name = "Menu", RVA = "0xCB500", Offset = "0xCA900")]
	[Attribute(Name = "Description", RVA = "0xCB500", Offset = "0xCA900")]
	[Attribute(Name = "Icon", RVA = "0xCB500", Offset = "0xCA900")]
	[Attribute(Name = "ShowIf", RVA = "0xCB500", Offset = "0xCA900")]
	public void Menu_StopEngine(BasePlayer player)
	{
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x457A30", Offset = "0x456830", VA = "0x180457A30")]
	public bool Menu_EngineOff_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x993110", Offset = "0x991F10", VA = "0x180993110")]
	public EngineSwitch()
	{
	}

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x160")]
	private Option __menuOption_Menu_StartEngine;

	// Token: 0x04000570 RID: 1392
	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x1B8")]
	private Option __menuOption_Menu_StopEngine;
}
