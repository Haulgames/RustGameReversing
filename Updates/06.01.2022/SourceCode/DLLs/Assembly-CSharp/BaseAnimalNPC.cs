using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000033")]
public class BaseAnimalNPC : BaseNpc, IAIAttack, IAITirednessAbove, IAISleep, IAIHungerAbove, IAISenses
{
	// Token: 0x060005B8 RID: 1464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x8450C0", Offset = "0x843EC0", VA = "0x1808450C0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x1700001F")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x845500", Offset = "0x844300", VA = "0x180845500", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x8453C0", Offset = "0x8441C0", VA = "0x1808453C0")]
	[Attribute(Name = "Menu", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	[Attribute(Name = "Description", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	[Attribute(Name = "ShowIf", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	public void MenuDesignAI(BasePlayer ply)
	{
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x844FC0", Offset = "0x843DC0", VA = "0x180844FC0")]
	public bool CanDesignAI(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x845490", Offset = "0x844290", VA = "0x180845490")]
	public BaseAnimalNPC()
	{
	}

	// Token: 0x0400025E RID: 606
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x368")]
	private Option __menuOption_MenuDesignAI;

	// Token: 0x0400025F RID: 607
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x3C0")]
	public string deathStatName;

	// Token: 0x04000260 RID: 608
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x3C8")]
	protected BaseAIBrain<BaseAnimalNPC> brain;
}
