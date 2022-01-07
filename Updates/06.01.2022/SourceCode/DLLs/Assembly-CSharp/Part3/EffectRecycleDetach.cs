using System;
using Il2CppDummyDll;

// Token: 0x020005E9 RID: 1513
[Token(Token = "0x200046A")]
public class EffectRecycleDetach : BaseMonoBehaviour, IClientComponent, IEffectRecycle, IOnParentDestroying
{
	// Token: 0x06002A15 RID: 10773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600233F")]
	[Address(RVA = "0x987AF0", Offset = "0x9868F0", VA = "0x180987AF0")]
	protected void Awake()
	{
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002340")]
	[Address(RVA = "0x987D20", Offset = "0x986B20", VA = "0x180987D20", Slot = "6")]
	public void Recycle()
	{
	}

	// Token: 0x06002A17 RID: 10775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002341")]
	[Address(RVA = "0x987B70", Offset = "0x986970", VA = "0x180987B70")]
	private void DetachFromParent()
	{
	}

	// Token: 0x06002A18 RID: 10776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002342")]
	[Address(RVA = "0x987C40", Offset = "0x986A40", VA = "0x180987C40", Slot = "7")]
	public void OnParentDestroying()
	{
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002343")]
	[Address(RVA = "0x987DB0", Offset = "0x986BB0", VA = "0x180987DB0")]
	public EffectRecycleDetach()
	{
	}

	// Token: 0x0400255F RID: 9567
	[Token(Token = "0x4001E81")]
	[FieldOffset(Offset = "0x18")]
	public float recycleTime;

	// Token: 0x04002560 RID: 9568
	[Token(Token = "0x4001E82")]
	[FieldOffset(Offset = "0x20")]
	private Action recycleAction;
}
