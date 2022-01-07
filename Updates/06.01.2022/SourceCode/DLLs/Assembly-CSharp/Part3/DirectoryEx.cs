using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000B68 RID: 2920
[Token(Token = "0x2000828")]
public static class DirectoryEx
{
	// Token: 0x060043BB RID: 17339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003926")]
	[Address(RVA = "0xB73000", Offset = "0xB71E00", VA = "0x180B73000")]
	public static void Backup(DirectoryInfo parent, params string[] names)
	{
	}

	// Token: 0x060043BC RID: 17340 RVA: 0x00019290 File Offset: 0x00017490
	[Token(Token = "0x6003927")]
	[Address(RVA = "0xB73760", Offset = "0xB72560", VA = "0x180B73760")]
	public static bool MoveToSafe(this DirectoryInfo parent, string target, int retries = 10)
	{
		return default(bool);
	}

	// Token: 0x060043BD RID: 17341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003928")]
	[Address(RVA = "0xB73130", Offset = "0xB71F30", VA = "0x180B73130")]
	public static void Backup(params string[] names)
	{
	}

	// Token: 0x060043BE RID: 17342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003929")]
	[Address(RVA = "0xB736D0", Offset = "0xB724D0", VA = "0x180B736D0")]
	public static void CopyAll(string sourceDirectory, string targetDirectory)
	{
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600392A")]
	[Address(RVA = "0xB73370", Offset = "0xB72170", VA = "0x180B73370")]
	public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
	{
	}
}
