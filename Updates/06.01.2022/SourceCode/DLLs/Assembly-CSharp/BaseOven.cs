using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x0200005B RID: 91
[Token(Token = "0x200003C")]
public class BaseOven : StorageContainer, ISplashable
{
	// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x2FDF40", Offset = "0x2FCD40", VA = "0x1802FDF40", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000682 RID: 1666 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x1700003C")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2FE720", Offset = "0x2FD520", VA = "0x1802FE720", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x2FE4B0", Offset = "0x2FD2B0", VA = "0x1802FE4B0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00003630 File Offset: 0x00001830
	[Token(Token = "0x6000256")]
	[Address(RVA = "0x2FE490", Offset = "0x2FD290", VA = "0x1802FE490", Slot = "85")]
	public override bool HasSlot(BaseEntity.Slot slot)
	{
		return default(bool);
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x2FE670", Offset = "0x2FD470", VA = "0x1802FE670")]
	[Attribute(Name = "Menu", RVA = "0xA9CD0", Offset = "0xA90D0")]
	[Attribute(Name = "ShowIf", RVA = "0xA9CD0", Offset = "0xA90D0")]
	public void SwitchOn(BasePlayer player)
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x2FE630", Offset = "0x2FD430", VA = "0x1802FE630", Slot = "152")]
	protected virtual bool SwitchOn_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2FE5E0", Offset = "0x2FD3E0", VA = "0x1802FE5E0")]
	[Attribute(Name = "Menu", RVA = "0xA9DB0", Offset = "0xA91B0")]
	[Attribute(Name = "ShowIf", RVA = "0xA9DB0", Offset = "0xA91B0")]
	public void SwitchOff(BasePlayer player)
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x2FE5A0", Offset = "0x2FD3A0", VA = "0x1802FE5A0", Slot = "153")]
	protected virtual bool SwitchOff_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x2FE6C0", Offset = "0x2FD4C0", VA = "0x1802FE6C0")]
	public BaseOven()
	{
	}

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x3C8")]
	private Option __menuOption_SwitchOff;

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x420")]
	private Option __menuOption_SwitchOn;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x478")]
	public BaseOven.TemperatureType temperature;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x480")]
	public BaseEntity.Menu.Option switchOnMenu;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x4A0")]
	public BaseEntity.Menu.Option switchOffMenu;

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x4C0")]
	public ItemAmount[] startupContents;

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x4C8")]
	public bool allowByproductCreation;

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x4D0")]
	public ItemDefinition fuelType;

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x4D8")]
	public bool canModFire;

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x4D9")]
	public bool disabledBySplash;

	// Token: 0x0200005C RID: 92
	[Token(Token = "0x2000A61")]
	public enum TemperatureType
	{
		// Token: 0x0400030A RID: 778
		[Token(Token = "0x4003DCC")]
		Normal,
		// Token: 0x0400030B RID: 779
		[Token(Token = "0x4003DCD")]
		Warming,
		// Token: 0x0400030C RID: 780
		[Token(Token = "0x4003DCE")]
		Cooking,
		// Token: 0x0400030D RID: 781
		[Token(Token = "0x4003DCF")]
		Smelting,
		// Token: 0x0400030E RID: 782
		[Token(Token = "0x4003DD0")]
		Fractioning
	}
}
