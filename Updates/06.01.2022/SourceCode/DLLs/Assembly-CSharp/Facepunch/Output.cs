using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Facepunch
{
	// Token: 0x02000DD7 RID: 3543
	[Token(Token = "0x20009F6")]
	public static class Output
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600515F RID: 20831 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005160 RID: 20832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public static event Action<string, string, LogType> OnMessage
		{
			[Token(Token = "0x600456D")]
			[Address(RVA = "0x8624A0", Offset = "0x8612A0", VA = "0x1808624A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
			add
			{
			}
			[Token(Token = "0x600456E")]
			[Address(RVA = "0x862590", Offset = "0x861390", VA = "0x180862590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
			remove
			{
			}
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x861D80", Offset = "0x860B80", VA = "0x180861D80")]
		public static void Install()
		{
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x861E50", Offset = "0x860C50", VA = "0x180861E50")]
		internal static void LogHandler(string log, string stacktrace, LogType type)
		{
		}

		// Token: 0x04004D1E RID: 19742
		[Token(Token = "0x4003B4B")]
		[FieldOffset(Offset = "0x8")]
		public static bool installed;

		// Token: 0x04004D1F RID: 19743
		[Token(Token = "0x4003B4C")]
		[FieldOffset(Offset = "0x10")]
		public static List<Output.Entry> HistoryOutput;

		// Token: 0x02000DD8 RID: 3544
		[Token(Token = "0x2000E06")]
		public struct Entry
		{
			// Token: 0x04004D20 RID: 19744
			[Token(Token = "0x4004EA9")]
			[FieldOffset(Offset = "0x0")]
			public string Message;

			// Token: 0x04004D21 RID: 19745
			[Token(Token = "0x4004EAA")]
			[FieldOffset(Offset = "0x8")]
			public string Stacktrace;

			// Token: 0x04004D22 RID: 19746
			[Token(Token = "0x4004EAB")]
			[FieldOffset(Offset = "0x10")]
			public string Type;

			// Token: 0x04004D23 RID: 19747
			[Token(Token = "0x4004EAC")]
			[FieldOffset(Offset = "0x18")]
			public int Time;
		}
	}
}
