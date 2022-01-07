using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000037")]
public class BaseFishNPC : BaseNpc, IAIAttack, IAISenses
{
	// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x8940C0", Offset = "0x892EC0", VA = "0x1808940C0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000609 RID: 1545 RVA: 0x000030A8 File Offset: 0x000012A8
	[Token(Token = "0x17000026")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x8944F0", Offset = "0x8932F0", VA = "0x1808944F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x8943C0", Offset = "0x8931C0", VA = "0x1808943C0")]
	[Attribute(Name = "Menu", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	[Attribute(Name = "Description", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	[Attribute(Name = "ShowIf", RVA = "0x6CDE0", Offset = "0x6C1E0")]
	public void MenuDesignAI(BasePlayer ply)
	{
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x893FC0", Offset = "0x892DC0", VA = "0x180893FC0")]
	public bool CanDesignAI(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x894490", Offset = "0x893290", VA = "0x180894490")]
	public BaseFishNPC()
	{
	}

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x368")]
	private Option __menuOption_MenuDesignAI;

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x3C0")]
	protected BaseAIBrain<BaseFishNPC> brain;
}
