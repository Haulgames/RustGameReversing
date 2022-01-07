using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Rust;

// Token: 0x0200005D RID: 93
[Token(Token = "0x200003D")]
public class BasePet : NPCPlayer
{
	// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x2FFEB0", Offset = "0x2FECB0", VA = "0x1802FFEB0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x1700003D")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x300340", Offset = "0x2FF140", VA = "0x180300340", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600068C RID: 1676 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600068D RID: 1677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700003E")]
	public BaseAIBrain<BasePet> Brain
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x300330", Offset = "0x2FF130", VA = "0x180300330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x300400", Offset = "0x2FF200", VA = "0x180300400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x300290", Offset = "0x2FF090", VA = "0x180300290", Slot = "142")]
	public override float StartHealth()
	{
		return 0f;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x300290", Offset = "0x2FF090", VA = "0x180300290", Slot = "143")]
	public override float StartMaxHealth()
	{
		return 0f;
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x3001B0", Offset = "0x2FEFB0", VA = "0x1803001B0", Slot = "110")]
	public override float MaxHealth()
	{
		return 0f;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x3001C0", Offset = "0x2FEFC0", VA = "0x1803001C0")]
	[Attribute(Name = "Menu", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	[Attribute(Name = "Description", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	[Attribute(Name = "ShowIf", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	public void MenuDesignAI(BasePlayer ply)
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x2FFDB0", Offset = "0x2FEBB0", VA = "0x1802FFDB0")]
	public bool CanDesignAI(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x300300", Offset = "0x2FF100", VA = "0x180300300")]
	public BasePet()
	{
	}

	// Token: 0x0400030F RID: 783
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x7C8")]
	private Option __menuOption_MenuDesignAI;

	// Token: 0x04000310 RID: 784
	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x0")]
	[ServerVar]
	public static bool queuedMovementsAllowed;

	// Token: 0x04000311 RID: 785
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x1")]
	[ServerVar]
	public static bool onlyQueueBaseNavMovements;

	// Token: 0x04000312 RID: 786
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x4")]
	[ServerVar]
	[Attribute(Name = "HelpAttribute", RVA = "0xA9EE0", Offset = "0xA92E0")]
	public static float movementupdatebudgetms;

	// Token: 0x04000313 RID: 787
	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x820")]
	public float BaseAttackRate;

	// Token: 0x04000314 RID: 788
	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x824")]
	public float BaseAttackDamge;

	// Token: 0x04000315 RID: 789
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x828")]
	public DamageType AttackDamageType;

	// Token: 0x04000316 RID: 790
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x830")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseAIBrain<BasePet> <Brain>k__BackingField;

	// Token: 0x04000317 RID: 791
	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x838")]
	public GameObjectRef mapMarkerPrefab;

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x840")]
	private BaseEntity _mapMarkerInstance;
}
