using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000778 RID: 1912
[Token(Token = "0x200059D")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x749F0", Offset = "0x73DF0")]
[Serializable]
public class ByteMap
{
	// Token: 0x06002FFD RID: 12285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002892")]
	[Address(RVA = "0x643870", Offset = "0x642670", VA = "0x180643870")]
	public ByteMap(int size, int bytes = 1)
	{
	}

	// Token: 0x06002FFE RID: 12286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002893")]
	[Address(RVA = "0x643820", Offset = "0x642620", VA = "0x180643820")]
	public ByteMap(int size, byte[] values, int bytes = 1)
	{
	}

	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x06002FFF RID: 12287 RVA: 0x00014778 File Offset: 0x00012978
	[Token(Token = "0x17000368")]
	public int Size
	{
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x451780", Offset = "0x450580", VA = "0x180451780")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x06003000 RID: 12288 RVA: 0x00014790 File Offset: 0x00012990
	// (set) Token: 0x06003001 RID: 12289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000369")]
	public uint Item
	{
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x6438F0", Offset = "0x6426F0", VA = "0x1806438F0")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6002896")]
		[Address(RVA = "0x643B00", Offset = "0x642900", VA = "0x180643B00")]
		set
		{
		}
	}

	// Token: 0x04002CE2 RID: 11490
	[Token(Token = "0x40023CC")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int size;

	// Token: 0x04002CE3 RID: 11491
	[Token(Token = "0x40023CD")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private int bytes;

	// Token: 0x04002CE4 RID: 11492
	[Token(Token = "0x40023CE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private byte[] values;
}
