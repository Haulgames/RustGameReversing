using System;
using Il2CppDummyDll;

// Token: 0x0200043B RID: 1083
[Token(Token = "0x2000315")]
public class AIMemoryBank<T>
{
	// Token: 0x06002231 RID: 8753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE5")]
	public AIMemoryBank(MemoryBankType type, int slots)
	{
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE6")]
	public void Init(MemoryBankType type, int slots)
	{
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE7")]
	public void Set(T item, int index)
	{
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE8")]
	public T Get(int index)
	{
		return null;
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x0000F750 File Offset: 0x0000D950
	[Token(Token = "0x6001BE9")]
	public float GetTimeSinceSet(int index)
	{
		return 0f;
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BEA")]
	public void Remove(int index)
	{
	}

	// Token: 0x04001D0C RID: 7436
	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0x0")]
	private MemoryBankType type;

	// Token: 0x04001D0D RID: 7437
	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0x0")]
	private T[] slots;

	// Token: 0x04001D0E RID: 7438
	[Token(Token = "0x40017B6")]
	[FieldOffset(Offset = "0x0")]
	private float[] slotSetTimestamps;

	// Token: 0x04001D0F RID: 7439
	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0x0")]
	private int slotCount;
}
