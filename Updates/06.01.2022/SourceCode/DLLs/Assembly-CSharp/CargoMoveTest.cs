using System;
using Il2CppDummyDll;

// Token: 0x02000026 RID: 38
[Token(Token = "0x200001A")]
public class CargoMoveTest : FacepunchBehaviour
{
	// Token: 0x060000C2 RID: 194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x655830", Offset = "0x654630", VA = "0x180655830")]
	private void Awake()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x6558A0", Offset = "0x6546A0", VA = "0x1806558A0")]
	public void FindInitialNode()
	{
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x6565D0", Offset = "0x6553D0", VA = "0x1806565D0")]
	private void Update()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x655FC0", Offset = "0x654DC0", VA = "0x180655FC0")]
	public void UpdateMovement()
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x655A80", Offset = "0x654880", VA = "0x180655A80")]
	public int GetClosestNodeToUs()
	{
		return 0;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x655C60", Offset = "0x654A60", VA = "0x180655C60")]
	public void OnDrawGizmosSelected()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x6565E0", Offset = "0x6553E0", VA = "0x1806565E0")]
	public CargoMoveTest()
	{
	}

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x18")]
	public int targetNodeIndex;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x1C")]
	private float currentThrottle;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x20")]
	private float turnScale;
}
