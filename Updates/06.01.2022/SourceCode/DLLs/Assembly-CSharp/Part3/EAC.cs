using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using EasyAntiCheat.Client;
using Il2CppDummyDll;
using Network;

// Token: 0x0200037A RID: 890
[Token(Token = "0x200027B")]
public static class EAC
{
	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06001E47 RID: 7751 RVA: 0x0000E730 File Offset: 0x0000C930
	[Token(Token = "0x1700020A")]
	private static bool IsEacEnabled
	{
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x9829C0", Offset = "0x9817C0", VA = "0x1809829C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0000E748 File Offset: 0x0000C948
	[Token(Token = "0x1700020B")]
	public static bool IsEncryptionSupported
	{
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x9829E0", Offset = "0x9817E0", VA = "0x1809829E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001878")]
	[Address(RVA = "0x981E20", Offset = "0x980C20", VA = "0x180981E20")]
	public static void Encrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset)
	{
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001879")]
	[Address(RVA = "0x981A30", Offset = "0x980830", VA = "0x180981A30")]
	public static void Decrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset)
	{
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187A")]
	[Address(RVA = "0x9821C0", Offset = "0x980FC0", VA = "0x1809821C0")]
	private static void OnLaunchProgress(object sender, LoadProgressEventArgs eventArgs)
	{
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187B")]
	[Address(RVA = "0x982020", Offset = "0x980E20", VA = "0x180982020")]
	private static void OnLaunchCompleted(object sender, LoadCompletedEventArgs eventArgs)
	{
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187C")]
	[Address(RVA = "0x9823C0", Offset = "0x9811C0", VA = "0x1809823C0")]
	private static void OnStateChanged(object sender, StateChangedEventArgs eventArgs)
	{
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187D")]
	[Address(RVA = "0x982730", Offset = "0x981530", VA = "0x180982730")]
	private static void SendToServer(byte[] message, int messageLength)
	{
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600187E")]
	[Address(RVA = "0x981C40", Offset = "0x980A40", VA = "0x180981C40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xB4F80", Offset = "0xB4380")]
	public static IEnumerator DoStartup()
	{
		return null;
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187F")]
	[Address(RVA = "0x981B80", Offset = "0x980980", VA = "0x180981B80")]
	public static void DoShutdown()
	{
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001880")]
	[Address(RVA = "0x981C90", Offset = "0x980A90", VA = "0x180981C90")]
	public static void DoUpdate()
	{
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001881")]
	[Address(RVA = "0x981F60", Offset = "0x980D60", VA = "0x180981F60")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xB63B0", Offset = "0xB57B0")]
	public static Task OnJoinServer()
	{
		return null;
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001882")]
	[Address(RVA = "0x982270", Offset = "0x981070", VA = "0x180982270")]
	public static void OnLeaveServer()
	{
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001883")]
	[Address(RVA = "0x9822F0", Offset = "0x9810F0", VA = "0x1809822F0")]
	public static void OnMessageReceived(Message message)
	{
	}

	// Token: 0x0400191C RID: 6428
	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x0")]
	public static bool isLoading;

	// Token: 0x0400191D RID: 6429
	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x8")]
	public static string lastError;

	// Token: 0x0400191E RID: 6430
	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x10")]
	private static byte[] _lastTicket;

	// Token: 0x0200037B RID: 891
	[Token(Token = "0x2000B34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <DoStartup>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001E56 RID: 7766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4F")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <DoStartup>d__12(int <>1__state)
		{
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D50")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x993750", Offset = "0x992550", VA = "0x180993750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070F")]
		private object Current
		{
			[Token(Token = "0x6004D52")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D53")]
		[Address(RVA = "0x993A90", Offset = "0x992890", VA = "0x180993A90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000710")]
		private object Current
		{
			[Token(Token = "0x6004D54")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x40041CE")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x40041CF")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
