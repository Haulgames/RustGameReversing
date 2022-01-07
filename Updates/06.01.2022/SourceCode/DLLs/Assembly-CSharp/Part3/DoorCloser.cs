using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x0200008B RID: 139
[Token(Token = "0x2000052")]
public class DoorCloser : BaseEntity
{
	// Token: 0x060009E7 RID: 2535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x979830", Offset = "0x978630", VA = "0x180979830", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000058F8 File Offset: 0x00003AF8
	[Token(Token = "0x17000098")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x979E70", Offset = "0x978C70", VA = "0x180979E70", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00005910 File Offset: 0x00003B10
	[Token(Token = "0x6000591")]
	[Address(RVA = "0x979D20", Offset = "0x978B20", VA = "0x180979D20", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x00005928 File Offset: 0x00003B28
	[Token(Token = "0x6000592")]
	[Address(RVA = "0x2F7A50", Offset = "0x2F6850", VA = "0x1802F7A50", Slot = "112")]
	public override float BoundsPadding()
	{
		return 0f;
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000593")]
	[Address(RVA = "0x9797A0", Offset = "0x9785A0", VA = "0x1809797A0")]
	public Door GetDoor()
	{
		return null;
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x979CE0", Offset = "0x978AE0", VA = "0x180979CE0")]
	[Attribute(Name = "Menu", RVA = "0xC90F0", Offset = "0xC84F0")]
	[Attribute(Name = "Description", RVA = "0xC90F0", Offset = "0xC84F0")]
	[Attribute(Name = "Icon", RVA = "0xC90F0", Offset = "0xC84F0")]
	[Attribute(Name = "ShowIf", RVA = "0xC90F0", Offset = "0xC84F0")]
	public void Menu_Remove(BasePlayer player)
	{
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00005940 File Offset: 0x00003B40
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x979B40", Offset = "0x978940", VA = "0x180979B40")]
	public bool Menu_Remove_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x979E10", Offset = "0x978C10", VA = "0x180979E10")]
	public DoorCloser()
	{
	}

	// Token: 0x04000543 RID: 1347
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x160")]
	private Option __menuOption_Menu_Remove;

	// Token: 0x04000544 RID: 1348
	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x1B8")]
	[Attribute(Name = "ItemSelector", RVA = "0x8D9E0", Offset = "0x8CDE0")]
	public ItemDefinition itemType;

	// Token: 0x04000545 RID: 1349
	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x1C0")]
	public float delay;
}
