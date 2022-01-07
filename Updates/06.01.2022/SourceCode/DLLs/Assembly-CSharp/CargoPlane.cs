using System;
using Il2CppDummyDll;

// Token: 0x020005BE RID: 1470
[Token(Token = "0x200044F")]
public class CargoPlane : BaseEntity
{
	// Token: 0x06002933 RID: 10547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002294")]
	[Address(RVA = "0x6565F0", Offset = "0x6553F0", VA = "0x1806565F0")]
	public CargoPlane()
	{
	}

	// Token: 0x040024C0 RID: 9408
	[Token(Token = "0x4001E1C")]
	[FieldOffset(Offset = "0x160")]
	public GameObjectRef prefabDrop;

	// Token: 0x040024C1 RID: 9409
	[Token(Token = "0x4001E1D")]
	[FieldOffset(Offset = "0x168")]
	public SpawnFilter filter;
}
