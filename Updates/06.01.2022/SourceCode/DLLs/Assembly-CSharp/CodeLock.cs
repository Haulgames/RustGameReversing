using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000049")]
public class CodeLock : BaseLock
{
	// Token: 0x06000949 RID: 2377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x49CAC0", Offset = "0x49B8C0", VA = "0x18049CAC0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600094A RID: 2378 RVA: 0x00005328 File Offset: 0x00003528
	[Token(Token = "0x1700008B")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x49E000", Offset = "0x49CE00", VA = "0x18049E000", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x49D900", Offset = "0x49C700", VA = "0x18049D900", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00005358 File Offset: 0x00003558
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x49D470", Offset = "0x49C270", VA = "0x18049D470")]
	public bool IsCodeEntryBlocked()
	{
		return default(bool);
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x49D480", Offset = "0x49C280", VA = "0x18049D480", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x49D8C0", Offset = "0x49C6C0", VA = "0x18049D8C0")]
	[Attribute(Name = "Menu", RVA = "0xC2F60", Offset = "0xC2360")]
	[Attribute(Name = "Description", RVA = "0xC2F60", Offset = "0xC2360")]
	[Attribute(Name = "Icon", RVA = "0xC2F60", Offset = "0xC2360")]
	[Attribute(Name = "ShowIf", RVA = "0xC2F60", Offset = "0xC2360")]
	public void Menu_Unlock(BasePlayer player)
	{
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00005370 File Offset: 0x00003570
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x49D880", Offset = "0x49C680", VA = "0x18049D880")]
	public bool Menu_Unlock_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x49D840", Offset = "0x49C640", VA = "0x18049D840")]
	[Attribute(Name = "Menu", RVA = "0xC32E0", Offset = "0xC26E0")]
	[Attribute(Name = "Description", RVA = "0xC32E0", Offset = "0xC26E0")]
	[Attribute(Name = "Icon", RVA = "0xC32E0", Offset = "0xC26E0")]
	[Attribute(Name = "ShowIf", RVA = "0xC32E0", Offset = "0xC26E0")]
	public void Menu_Lock(BasePlayer player)
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00005388 File Offset: 0x00003588
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x49D810", Offset = "0x49C610", VA = "0x18049D810")]
	public bool Menu_Lock_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x49D6B0", Offset = "0x49C4B0", VA = "0x18049D6B0")]
	[Attribute(Name = "Menu", RVA = "0xC35E0", Offset = "0xC29E0")]
	[Attribute(Name = "Description", RVA = "0xC35E0", Offset = "0xC29E0")]
	[Attribute(Name = "Icon", RVA = "0xC35E0", Offset = "0xC29E0")]
	[Attribute(Name = "ShowIf", RVA = "0xC35E0", Offset = "0xC29E0")]
	public void Menu_ChangeLockCode(BasePlayer player)
	{
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x000053A0 File Offset: 0x000035A0
	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x49D670", Offset = "0x49C470", VA = "0x18049D670")]
	public bool Menu_ChangeLockCode_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x49D510", Offset = "0x49C310", VA = "0x18049D510")]
	[Attribute(Name = "Menu", RVA = "0xC38A0", Offset = "0xC2CA0")]
	[Attribute(Name = "Description", RVA = "0xC38A0", Offset = "0xC2CA0")]
	[Attribute(Name = "Icon", RVA = "0xC38A0", Offset = "0xC2CA0")]
	[Attribute(Name = "ShowIf", RVA = "0xC38A0", Offset = "0xC2CA0")]
	public void Menu_ChangeGuestCode(BasePlayer player)
	{
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x000053B8 File Offset: 0x000035B8
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x49D4E0", Offset = "0x49C2E0", VA = "0x18049D4E0")]
	public bool Menu_ChangeGuestCode_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x49C970", Offset = "0x49B770", VA = "0x18049C970")]
	[BaseEntity.RPC_Client]
	private void EnterUnlockCode(BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x49DFF0", Offset = "0x49CDF0", VA = "0x18049DFF0")]
	public CodeLock()
	{
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x49DF20", Offset = "0x49CD20", VA = "0x18049DF20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <Menu_ChangeLockCode>b__23_0(string str)
	{
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x49DEC0", Offset = "0x49CCC0", VA = "0x18049DEC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <Menu_ChangeGuestCode>b__25_0(string str)
	{
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x49DE70", Offset = "0x49CC70", VA = "0x18049DE70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <EnterUnlockCode>b__27_0(string str)
	{
	}

	// Token: 0x040004F3 RID: 1267
	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x1C0")]
	private Option __menuOption_Menu_ChangeGuestCode;

	// Token: 0x040004F4 RID: 1268
	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x218")]
	private Option __menuOption_Menu_ChangeLockCode;

	// Token: 0x040004F5 RID: 1269
	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x270")]
	private Option __menuOption_Menu_Lock;

	// Token: 0x040004F6 RID: 1270
	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x2C8")]
	private Option __menuOption_Menu_Unlock;

	// Token: 0x040004F7 RID: 1271
	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x320")]
	public GameObjectRef keyEnterDialog;

	// Token: 0x040004F8 RID: 1272
	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x328")]
	public GameObjectRef effectUnlocked;

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x330")]
	public GameObjectRef effectLocked;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x338")]
	public GameObjectRef effectDenied;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x340")]
	public GameObjectRef effectCodeChanged;

	// Token: 0x040004FC RID: 1276
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x348")]
	public GameObjectRef effectShock;

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x350")]
	private bool hasCode;

	// Token: 0x040004FE RID: 1278
	[Token(Token = "0x4000411")]
	public const BaseEntity.Flags Flag_CodeEntryBlocked = BaseEntity.Flags.Reserved11;

	// Token: 0x040004FF RID: 1279
	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Translate.Phrase blockwarning;
}
