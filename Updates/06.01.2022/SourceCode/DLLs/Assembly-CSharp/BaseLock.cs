using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000055 RID: 85
[Token(Token = "0x2000039")]
public class BaseLock : BaseEntity
{
	// Token: 0x06000616 RID: 1558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2F16A0", Offset = "0x2F04A0", VA = "0x1802F16A0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x17000028")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2F1B50", Offset = "0x2F0950", VA = "0x1802F1B50", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x2F1A00", Offset = "0x2F0800", VA = "0x1802F1A00", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x2F19C0", Offset = "0x2F07C0", VA = "0x1802F19C0")]
	[Attribute(Name = "Menu", RVA = "0xA5F40", Offset = "0xA5340")]
	[Attribute(Name = "Description", RVA = "0xA5F40", Offset = "0xA5340")]
	[Attribute(Name = "Icon", RVA = "0xA5F40", Offset = "0xA5340")]
	[Attribute(Name = "ShowIf", RVA = "0xA5F40", Offset = "0xA5340")]
	public void Menu_RemoveLock(BasePlayer player)
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x2F19A0", Offset = "0x2F07A0", VA = "0x1802F19A0")]
	public bool Menu_RemoveLock_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x2F15A0", Offset = "0x2F03A0", VA = "0x1802F15A0", Slot = "66")]
	public override List<Option> GetMenuItems(BasePlayer player)
	{
		return null;
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x2F1590", Offset = "0x2F0390", VA = "0x1802F1590", Slot = "112")]
	public override float BoundsPadding()
	{
		return 0f;
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x2F1AF0", Offset = "0x2F08F0", VA = "0x1802F1AF0")]
	public BaseLock()
	{
	}

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x160")]
	private Option __menuOption_Menu_RemoveLock;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x1B8")]
	[Attribute(Name = "ItemSelector", RVA = "0x8D9E0", Offset = "0x8CDE0")]
	public ItemDefinition itemType;
}
