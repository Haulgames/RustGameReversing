using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000030")]
public abstract class AppIOEntity : IOEntity
{
	// Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x832D40", Offset = "0x831B40", VA = "0x180832D40", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000554 RID: 1364 RVA: 0x000028C8 File Offset: 0x00000AC8
	[Token(Token = "0x17000011")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x833310", Offset = "0x832110", VA = "0x180833310", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x000028E0 File Offset: 0x00000AE0
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x8331C0", Offset = "0x831FC0", VA = "0x1808331C0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x8330E0", Offset = "0x831EE0", VA = "0x1808330E0")]
	[Attribute(Name = "Menu", RVA = "0x9F9F0", Offset = "0x9EDF0")]
	[Attribute(Name = "Description", RVA = "0x9F9F0", Offset = "0x9EDF0")]
	[Attribute(Name = "Icon", RVA = "0x9F9F0", Offset = "0x9EDF0")]
	[Attribute(Name = "ShowIf", RVA = "0x9F9F0", Offset = "0x9EDF0")]
	public void Menu_Pair(BasePlayer player)
	{
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x833120", Offset = "0x831F20", VA = "0x180833120")]
	public bool Menu_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x8332B0", Offset = "0x8320B0", VA = "0x1808332B0")]
	protected AppIOEntity()
	{
	}

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x268")]
	private Option __menuOption_Menu_Pair;
}
