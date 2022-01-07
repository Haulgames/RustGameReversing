using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200051D RID: 1309
[Token(Token = "0x20003CC")]
public abstract class BaseModifiers<T> : EntityComponent<T> where T : BaseCombatEntity
{
	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x060025E5 RID: 9701 RVA: 0x00010A58 File Offset: 0x0000EC58
	[Token(Token = "0x170002A8")]
	public int ActiveModifierCoount
	{
		[Token(Token = "0x6001F66")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F67")]
	public void Add(List<ModifierDefintion> modDefs)
	{
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F68")]
	protected void Add(ModifierDefintion def)
	{
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F69")]
	protected void Add(Modifier modifier)
	{
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x00010A70 File Offset: 0x0000EC70
	[Token(Token = "0x6001F6A")]
	private bool CanAdd(Modifier modifier)
	{
		return default(bool);
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x00010A88 File Offset: 0x0000EC88
	[Token(Token = "0x6001F6B")]
	private int GetMaxModifiersForSourceType(Modifier.ModifierSource source)
	{
		return 0;
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x00010AA0 File Offset: 0x0000ECA0
	[Token(Token = "0x6001F6C")]
	private int GetTypeSourceCount(Modifier.ModifierType type, Modifier.ModifierSource source)
	{
		return 0;
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F6D")]
	private Modifier GetShortestLifeModifier(Modifier.ModifierType type, Modifier.ModifierSource source)
	{
		return null;
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F6E")]
	private void Remove(Modifier modifier)
	{
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F6F")]
	public void RemoveAll()
	{
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x00010AB8 File Offset: 0x0000ECB8
	[Token(Token = "0x6001F70")]
	public float GetValue(Modifier.ModifierType type, float defaultValue = 0f)
	{
		return 0f;
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x00010AD0 File Offset: 0x0000ECD0
	[Token(Token = "0x6001F71")]
	public float GetVariableValue(Modifier.ModifierType type, float defaultValue)
	{
		return 0f;
	}

	// Token: 0x060025F1 RID: 9713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F72")]
	public void SetVariableValue(Modifier.ModifierType type, float value)
	{
	}

	// Token: 0x060025F2 RID: 9714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F73")]
	public void RemoveVariable(Modifier.ModifierType type)
	{
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F74")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x060025F4 RID: 9716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F75")]
	protected void SetDirty(bool flag)
	{
	}

	// Token: 0x060025F5 RID: 9717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F76")]
	protected BaseModifiers()
	{
	}

	// Token: 0x040020EA RID: 8426
	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0x0")]
	public List<Modifier> All;

	// Token: 0x040020EB RID: 8427
	[Token(Token = "0x4001ACB")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<Modifier.ModifierType, float> totalValues;

	// Token: 0x040020EC RID: 8428
	[Token(Token = "0x4001ACC")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<Modifier.ModifierType, float> modifierVariables;

	// Token: 0x040020ED RID: 8429
	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0x0")]
	protected T owner;

	// Token: 0x040020EE RID: 8430
	[Token(Token = "0x4001ACE")]
	[FieldOffset(Offset = "0x0")]
	protected bool dirty;
}
