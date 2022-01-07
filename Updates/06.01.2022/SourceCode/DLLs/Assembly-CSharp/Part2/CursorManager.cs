using System;
using Il2CppDummyDll;

// Token: 0x0200098E RID: 2446
[Token(Token = "0x20006DB")]
public class CursorManager : SingletonComponent<CursorManager>
{
	// Token: 0x06003A03 RID: 14851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x6DC070", Offset = "0x6DAE70", VA = "0x1806DC070")]
	private void Update()
	{
	}

	// Token: 0x06003A04 RID: 14852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x6DBFF0", Offset = "0x6DADF0", VA = "0x1806DBFF0")]
	public void SwitchToGame()
	{
	}

	// Token: 0x06003A05 RID: 14853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x6DC030", Offset = "0x6DAE30", VA = "0x1806DC030")]
	private void SwitchToUI()
	{
	}

	// Token: 0x06003A06 RID: 14854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030DA")]
	[Address(RVA = "0x6DBF80", Offset = "0x6DAD80", VA = "0x1806DBF80")]
	public static void HoldOpen(bool cursorVisible = false)
	{
	}

	// Token: 0x06003A07 RID: 14855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x6DC200", Offset = "0x6DB000", VA = "0x1806DC200")]
	public CursorManager()
	{
	}

	// Token: 0x040036AB RID: 13995
	[Token(Token = "0x40029E0")]
	[FieldOffset(Offset = "0x0")]
	private static int iHoldOpen;

	// Token: 0x040036AC RID: 13996
	[Token(Token = "0x40029E1")]
	[FieldOffset(Offset = "0x4")]
	private static int iPreviousOpen;
}
