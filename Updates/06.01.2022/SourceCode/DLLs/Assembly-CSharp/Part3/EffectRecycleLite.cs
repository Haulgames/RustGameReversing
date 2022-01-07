using System;
using Il2CppDummyDll;

// Token: 0x020005EA RID: 1514
[Token(Token = "0x200046B")]
public class EffectRecycleLite : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying
{
	// Token: 0x06002A1A RID: 10778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002344")]
	[Address(RVA = "0x987DC0", Offset = "0x986BC0", VA = "0x180987DC0")]
	protected void Awake()
	{
	}

	// Token: 0x06002A1B RID: 10779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002345")]
	[Address(RVA = "0x987E40", Offset = "0x986C40", VA = "0x180987E40")]
	protected void OnEnable()
	{
	}

	// Token: 0x06002A1C RID: 10780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002346")]
	[Address(RVA = "0x987F60", Offset = "0x986D60", VA = "0x180987F60", Slot = "8")]
	public void Recycle()
	{
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002347")]
	[Address(RVA = "0x987EC0", Offset = "0x986CC0", VA = "0x180987EC0", Slot = "9")]
	public void OnParentDestroying()
	{
	}

	// Token: 0x06002A1E RID: 10782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002348")]
	[Address(RVA = "0x50C980", Offset = "0x50B780", VA = "0x18050C980")]
	public EffectRecycleLite()
	{
	}

	// Token: 0x04002561 RID: 9569
	[Token(Token = "0x4001E83")]
	private const float lifeTime = 60f;

	// Token: 0x04002562 RID: 9570
	[Token(Token = "0x4001E84")]
	[FieldOffset(Offset = "0x20")]
	private Action recycleAction;
}
