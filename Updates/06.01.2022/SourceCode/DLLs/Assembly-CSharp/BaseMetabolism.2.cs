using System;
using Il2CppDummyDll;

// Token: 0x020004E4 RID: 1252
[Token(Token = "0x20003A0")]
public abstract class BaseMetabolism<T> : EntityComponent<T> where T : BaseCombatEntity
{
	// Token: 0x0600254A RID: 9546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED4")]
	public virtual void Reset()
	{
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED5")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x00010830 File Offset: 0x0000EA30
	[Token(Token = "0x6001ED6")]
	public bool ShouldDie()
	{
		return default(bool);
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED7")]
	public virtual MetabolismAttribute FindAttribute(MetabolismAttribute.Type type)
	{
		return null;
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED8")]
	protected BaseMetabolism()
	{
	}

	// Token: 0x04001FBC RID: 8124
	[Token(Token = "0x40019E1")]
	[FieldOffset(Offset = "0x0")]
	protected T owner;

	// Token: 0x04001FBD RID: 8125
	[Token(Token = "0x40019E2")]
	[FieldOffset(Offset = "0x0")]
	public MetabolismAttribute calories;

	// Token: 0x04001FBE RID: 8126
	[Token(Token = "0x40019E3")]
	[FieldOffset(Offset = "0x0")]
	public MetabolismAttribute hydration;

	// Token: 0x04001FBF RID: 8127
	[Token(Token = "0x40019E4")]
	[FieldOffset(Offset = "0x0")]
	public MetabolismAttribute heartrate;
}
