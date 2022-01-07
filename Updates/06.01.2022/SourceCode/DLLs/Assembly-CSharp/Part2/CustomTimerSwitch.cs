using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000086 RID: 134
[Token(Token = "0x200004D")]
public class CustomTimerSwitch : TimerSwitch
{
	// Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x6DCF30", Offset = "0x6DBD30", VA = "0x1806DCF30", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000985 RID: 2437 RVA: 0x00005598 File Offset: 0x00003798
	[Token(Token = "0x17000090")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x6DD740", Offset = "0x6DC540", VA = "0x1806DD740", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x000055B0 File Offset: 0x000037B0
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x6DD490", Offset = "0x6DC290", VA = "0x1806DD490", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x000055C8 File Offset: 0x000037C8
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x6DCE90", Offset = "0x6DBC90", VA = "0x1806DCE90")]
	public bool CanPlayerAdmin(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x6DD580", Offset = "0x6DC380", VA = "0x1806DD580")]
	public void SendNewTime(float seconds)
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x6DD280", Offset = "0x6DC080", VA = "0x1806DD280")]
	[Attribute(Name = "Menu", RVA = "0xC51F0", Offset = "0xC45F0")]
	[Attribute(Name = "Description", RVA = "0xC51F0", Offset = "0xC45F0")]
	[Attribute(Name = "Icon", RVA = "0xC51F0", Offset = "0xC45F0")]
	[Attribute(Name = "ShowIf", RVA = "0xC51F0", Offset = "0xC45F0")]
	public void Menu_SetTime(BasePlayer player)
	{
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x000055E0 File Offset: 0x000037E0
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x6DD240", Offset = "0x6DC040", VA = "0x1806DD240")]
	public bool Menu_SetTime_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x6DD730", Offset = "0x6DC530", VA = "0x1806DD730")]
	public CustomTimerSwitch()
	{
	}

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x2D8")]
	private Option __menuOption_Menu_SetTime;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x330")]
	public GameObjectRef timerPanelPrefab;
}
