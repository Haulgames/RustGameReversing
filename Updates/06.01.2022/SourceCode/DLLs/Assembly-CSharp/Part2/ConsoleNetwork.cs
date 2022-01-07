using System;
using Il2CppDummyDll;
using Network;

// Token: 0x0200042B RID: 1067
[Token(Token = "0x2000307")]
public static class ConsoleNetwork
{
	// Token: 0x060021FE RID: 8702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x6C5730", Offset = "0x6C4530", VA = "0x1806C5730")]
	internal static void Init()
	{
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
	[Token(Token = "0x6001BBD")]
	[Address(RVA = "0x6C54F0", Offset = "0x6C42F0", VA = "0x1806C54F0")]
	public static bool ClientRunOnServer(string strCommand)
	{
		return default(bool);
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0x6C58C0", Offset = "0x6C46C0", VA = "0x1806C58C0")]
	internal static void OnConsoleMessageFromServer(Message packet)
	{
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x6C57C0", Offset = "0x6C45C0", VA = "0x1806C57C0")]
	internal static void OnConsoleCommandfromServer(Message packet)
	{
	}
}
