using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x0200008F RID: 143
[Token(Token = "0x2000056")]
public class ElectricSwitch : IOEntity
{
	// Token: 0x06000A09 RID: 2569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x98B4A0", Offset = "0x98A2A0", VA = "0x18098B4A0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00005A30 File Offset: 0x00003C30
	[Token(Token = "0x1700009E")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x98BBB0", Offset = "0x98A9B0", VA = "0x18098BBB0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00005A48 File Offset: 0x00003C48
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x98BA60", Offset = "0x98A860", VA = "0x18098BA60", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00005A60 File Offset: 0x00003C60
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x53F9B0", Offset = "0x53E7B0", VA = "0x18053F9B0", Slot = "147")]
	public override bool WantsPower()
	{
		return default(bool);
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x98BA10", Offset = "0x98A810", VA = "0x18098BA10")]
	[Attribute(Name = "Menu", RVA = "0x74300", Offset = "0x73700")]
	[Attribute(Name = "Description", RVA = "0x74300", Offset = "0x73700")]
	[Attribute(Name = "Icon", RVA = "0x74300", Offset = "0x73700")]
	[Attribute(Name = "ShowIf", RVA = "0x74300", Offset = "0x73700")]
	public void Menu_TurnOn(BasePlayer player)
	{
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00005A78 File Offset: 0x00003C78
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x53F9C0", Offset = "0x53E7C0", VA = "0x18053F9C0")]
	public bool Menu_TurnOn_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x98B9C0", Offset = "0x98A7C0", VA = "0x18098B9C0")]
	[Attribute(Name = "Menu", RVA = "0x74540", Offset = "0x73940")]
	[Attribute(Name = "Description", RVA = "0x74540", Offset = "0x73940")]
	[Attribute(Name = "Icon", RVA = "0x74540", Offset = "0x73940")]
	[Attribute(Name = "ShowIf", RVA = "0x74540", Offset = "0x73940")]
	public void Menu_TurnOff(BasePlayer player)
	{
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00005A90 File Offset: 0x00003C90
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x53F9B0", Offset = "0x53E7B0", VA = "0x18053F9B0")]
	public bool Menu_TurnOff_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x98BB50", Offset = "0x98A950", VA = "0x18098BB50")]
	public ElectricSwitch()
	{
	}

	// Token: 0x04000556 RID: 1366
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x268")]
	private Option __menuOption_Menu_TurnOff;

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x2C0")]
	private Option __menuOption_Menu_TurnOn;
}
