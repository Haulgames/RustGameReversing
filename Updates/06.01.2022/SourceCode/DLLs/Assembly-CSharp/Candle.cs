using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x0200007B RID: 123
[Token(Token = "0x2000045")]
public class Candle : BaseCombatEntity, ISplashable, IIgniteable
{
	// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x64E0A0", Offset = "0x64CEA0", VA = "0x18064E0A0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00005070 File Offset: 0x00003270
	[Token(Token = "0x1700007D")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x64E750", Offset = "0x64D550", VA = "0x18064E750", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x64E660", Offset = "0x64D460", VA = "0x18064E660", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x64E610", Offset = "0x64D410", VA = "0x18064E610")]
	[Attribute(Name = "Menu", RVA = "0xBEE70", Offset = "0xBE270")]
	[Attribute(Name = "Description", RVA = "0xBEE70", Offset = "0xBE270")]
	[Attribute(Name = "Icon", RVA = "0xBEE70", Offset = "0xBE270")]
	[Attribute(Name = "ShowIf", RVA = "0xBEE70", Offset = "0xBE270")]
	public void Menu_Ignite(BasePlayer player)
	{
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x53F9C0", Offset = "0x53E7C0", VA = "0x18053F9C0")]
	public bool Menu_Ignite_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x64E5C0", Offset = "0x64D3C0", VA = "0x18064E5C0")]
	[Attribute(Name = "Menu", RVA = "0xBF0B0", Offset = "0xBE4B0")]
	[Attribute(Name = "Description", RVA = "0xBF0B0", Offset = "0xBE4B0")]
	[Attribute(Name = "Icon", RVA = "0xBF0B0", Offset = "0xBE4B0")]
	[Attribute(Name = "ShowIf", RVA = "0xBF0B0", Offset = "0xBE4B0")]
	public void Menu_Extinguish(BasePlayer player)
	{
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x6000499")]
	[Address(RVA = "0x53F9B0", Offset = "0x53E7B0", VA = "0x18053F9B0")]
	public bool Menu_Extinguish_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049A")]
	[Address(RVA = "0x2EF040", Offset = "0x2EDE40", VA = "0x1802EF040")]
	public Candle()
	{
	}

	// Token: 0x040004B8 RID: 1208
	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x238")]
	private Option __menuOption_Menu_Extinguish;

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x290")]
	private Option __menuOption_Menu_Ignite;
}
