using System;
using Il2CppDummyDll;

// Token: 0x0200036F RID: 879
[Token(Token = "0x2000272")]
public class DecalRecycle : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying
{
	// Token: 0x06001DF8 RID: 7672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600182D")]
	[Address(RVA = "0x8BBB60", Offset = "0x8BA960", VA = "0x1808BBB60")]
	protected void Awake()
	{
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600182E")]
	[Address(RVA = "0x8BBBE0", Offset = "0x8BA9E0", VA = "0x1808BBBE0", Slot = "10")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600182F")]
	[Address(RVA = "0x8BBE40", Offset = "0x8BAC40", VA = "0x1808BBE40", Slot = "8")]
	public void Recycle()
	{
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001830")]
	[Address(RVA = "0x8BBE10", Offset = "0x8BAC10", VA = "0x1808BBE10", Slot = "9")]
	public void OnParentDestroying()
	{
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001831")]
	[Address(RVA = "0x8BB470", Offset = "0x8BA270", VA = "0x1808BB470")]
	public DecalRecycle()
	{
	}

	// Token: 0x040018FB RID: 6395
	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0x20")]
	public float LifeTime;

	// Token: 0x040018FC RID: 6396
	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0x28")]
	private Action recycleAction;
}
