using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B49 RID: 2889
[Token(Token = "0x2000813")]
public class DeferredAction
{
	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x06004341 RID: 17217 RVA: 0x000190C8 File Offset: 0x000172C8
	// (set) Token: 0x06004342 RID: 17218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700047B")]
	public bool Idle
	{
		[Token(Token = "0x60038C9")]
		[Address(RVA = "0x7D2BC0", Offset = "0x7D19C0", VA = "0x1807D2BC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60038CA")]
		[Address(RVA = "0x7D2C00", Offset = "0x7D1A00", VA = "0x1807D2C00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06004343 RID: 17219 RVA: 0x000190E0 File Offset: 0x000172E0
	[Token(Token = "0x1700047C")]
	public int Index
	{
		[Token(Token = "0x60038CB")]
		[Address(RVA = "0x4FFD00", Offset = "0x4FEB00", VA = "0x1804FFD00")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06004344 RID: 17220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CC")]
	[Address(RVA = "0x8C04E0", Offset = "0x8BF2E0", VA = "0x1808C04E0")]
	public DeferredAction(UnityEngine.Object sender, Action action, ActionPriority priority = ActionPriority.Medium)
	{
	}

	// Token: 0x06004345 RID: 17221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CD")]
	[Address(RVA = "0x8C0280", Offset = "0x8BF080", VA = "0x1808C0280")]
	public void Action()
	{
	}

	// Token: 0x06004346 RID: 17222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CE")]
	[Address(RVA = "0x8C0450", Offset = "0x8BF250", VA = "0x1808C0450")]
	public void Invoke()
	{
	}

	// Token: 0x06004347 RID: 17223 RVA: 0x000190F8 File Offset: 0x000172F8
	[Token(Token = "0x60038CF")]
	[Address(RVA = "0x668850", Offset = "0x667650", VA = "0x180668850")]
	public static implicit operator bool(DeferredAction obj)
	{
		return default(bool);
	}

	// Token: 0x06004348 RID: 17224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D0")]
	[Address(RVA = "0x8C0340", Offset = "0x8BF140", VA = "0x1808C0340")]
	public static void Invoke(UnityEngine.Object sender, Action action, ActionPriority priority = ActionPriority.Medium)
	{
	}

	// Token: 0x0400406B RID: 16491
	[Token(Token = "0x40031B8")]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.Object sender;

	// Token: 0x0400406C RID: 16492
	[Token(Token = "0x40031B9")]
	[FieldOffset(Offset = "0x18")]
	private Action action;

	// Token: 0x0400406D RID: 16493
	[Token(Token = "0x40031BA")]
	[FieldOffset(Offset = "0x20")]
	private ActionPriority priority;

	// Token: 0x0400406E RID: 16494
	[Token(Token = "0x40031BB")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <Idle>k__BackingField;
}
