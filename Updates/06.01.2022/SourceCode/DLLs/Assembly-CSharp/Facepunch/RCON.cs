using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Facepunch.Rcon;
using Il2CppDummyDll;
using UnityEngine;

namespace Facepunch
{
	// Token: 0x02000DD9 RID: 3545
	[Token(Token = "0x20009F7")]
	public class RCon
	{
		// Token: 0x06005164 RID: 20836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x862F80", Offset = "0x861D80", VA = "0x180862F80")]
		public static void Initialize()
		{
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x863E00", Offset = "0x862C00", VA = "0x180863E00")]
		public static void Shutdown()
		{
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x862D30", Offset = "0x861B30", VA = "0x180862D30")]
		public static void Broadcast(RCon.LogType type, object obj)
		{
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x863F50", Offset = "0x862D50", VA = "0x180863F50")]
		public static void Update()
		{
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x862C10", Offset = "0x861A10", VA = "0x180862C10")]
		public static void BanIP(IPAddress addr, float seconds)
		{
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x8635E0", Offset = "0x8623E0", VA = "0x1808635E0")]
		public static bool IsBanned(IPAddress addr)
		{
			return default(bool);
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x8636D0", Offset = "0x8624D0", VA = "0x1808636D0")]
		private static void OnCommand(RCon.Command cmd)
		{
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x863B40", Offset = "0x862940", VA = "0x180863B40")]
		private static void OnMessage(string message, string stacktrace, UnityEngine.LogType type)
		{
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public RCon()
		{
		}

		// Token: 0x04004D24 RID: 19748
		[Token(Token = "0x4003B4D")]
		[FieldOffset(Offset = "0x0")]
		public static string Password;

		// Token: 0x04004D25 RID: 19749
		[Token(Token = "0x4003B4E")]
		[FieldOffset(Offset = "0x8")]
		[ServerVar]
		public static int Port;

		// Token: 0x04004D26 RID: 19750
		[Token(Token = "0x4003B4F")]
		[FieldOffset(Offset = "0x10")]
		[ServerVar]
		public static string Ip;

		// Token: 0x04004D27 RID: 19751
		[Token(Token = "0x4003B50")]
		[FieldOffset(Offset = "0x18")]
		[ServerVar]
		public static bool Web;

		// Token: 0x04004D28 RID: 19752
		[Token(Token = "0x4003B51")]
		[FieldOffset(Offset = "0x19")]
		[ServerVar]
		public static bool Print;

		// Token: 0x04004D29 RID: 19753
		[Token(Token = "0x4003B52")]
		[FieldOffset(Offset = "0x20")]
		internal static RCon.RConListener listener;

		// Token: 0x04004D2A RID: 19754
		[Token(Token = "0x4003B53")]
		[FieldOffset(Offset = "0x28")]
		internal static Listener listenerNew;

		// Token: 0x04004D2B RID: 19755
		[Token(Token = "0x4003B54")]
		[FieldOffset(Offset = "0x30")]
		private static Queue<RCon.Command> Commands;

		// Token: 0x04004D2C RID: 19756
		[Token(Token = "0x4003B55")]
		[FieldOffset(Offset = "0x38")]
		private static float lastRunTime;

		// Token: 0x04004D2D RID: 19757
		[Token(Token = "0x4003B56")]
		[FieldOffset(Offset = "0x40")]
		internal static List<RCon.BannedAddresses> bannedAddresses;

		// Token: 0x04004D2E RID: 19758
		[Token(Token = "0x4003B57")]
		[FieldOffset(Offset = "0x48")]
		private static int responseIdentifier;

		// Token: 0x04004D2F RID: 19759
		[Token(Token = "0x4003B58")]
		[FieldOffset(Offset = "0x4C")]
		private static int responseConnection;

		// Token: 0x04004D30 RID: 19760
		[Token(Token = "0x4003B59")]
		[FieldOffset(Offset = "0x50")]
		private static bool isInput;

		// Token: 0x04004D31 RID: 19761
		[Token(Token = "0x4003B5A")]
		[FieldOffset(Offset = "0x54")]
		internal static int SERVERDATA_AUTH;

		// Token: 0x04004D32 RID: 19762
		[Token(Token = "0x4003B5B")]
		[FieldOffset(Offset = "0x58")]
		internal static int SERVERDATA_EXECCOMMAND;

		// Token: 0x04004D33 RID: 19763
		[Token(Token = "0x4003B5C")]
		[FieldOffset(Offset = "0x5C")]
		internal static int SERVERDATA_AUTH_RESPONSE;

		// Token: 0x04004D34 RID: 19764
		[Token(Token = "0x4003B5D")]
		[FieldOffset(Offset = "0x60")]
		internal static int SERVERDATA_RESPONSE_VALUE;

		// Token: 0x04004D35 RID: 19765
		[Token(Token = "0x4003B5E")]
		[FieldOffset(Offset = "0x64")]
		internal static int SERVERDATA_CONSOLE_LOG;

		// Token: 0x04004D36 RID: 19766
		[Token(Token = "0x4003B5F")]
		[FieldOffset(Offset = "0x68")]
		internal static int SERVERDATA_SWITCH_UTF8;

		// Token: 0x02000DDA RID: 3546
		[Token(Token = "0x2000E07")]
		public struct Command
		{
			// Token: 0x04004D37 RID: 19767
			[Token(Token = "0x4004EAD")]
			[FieldOffset(Offset = "0x0")]
			public IPAddress Ip;

			// Token: 0x04004D38 RID: 19768
			[Token(Token = "0x4004EAE")]
			[FieldOffset(Offset = "0x8")]
			public int ConnectionId;

			// Token: 0x04004D39 RID: 19769
			[Token(Token = "0x4004EAF")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04004D3A RID: 19770
			[Token(Token = "0x4004EB0")]
			[FieldOffset(Offset = "0x18")]
			public string Message;

			// Token: 0x04004D3B RID: 19771
			[Token(Token = "0x4004EB1")]
			[FieldOffset(Offset = "0x20")]
			public int Identifier;
		}

		// Token: 0x02000DDB RID: 3547
		[Token(Token = "0x2000E08")]
		public enum LogType
		{
			// Token: 0x04004D3D RID: 19773
			[Token(Token = "0x4004EB3")]
			Generic,
			// Token: 0x04004D3E RID: 19774
			[Token(Token = "0x4004EB4")]
			Error,
			// Token: 0x04004D3F RID: 19775
			[Token(Token = "0x4004EB5")]
			Warning,
			// Token: 0x04004D40 RID: 19776
			[Token(Token = "0x4004EB6")]
			Chat,
			// Token: 0x04004D41 RID: 19777
			[Token(Token = "0x4004EB7")]
			Report
		}

		// Token: 0x02000DDC RID: 3548
		[Token(Token = "0x2000E09")]
		public struct Response
		{
			// Token: 0x04004D42 RID: 19778
			[Token(Token = "0x4004EB8")]
			[FieldOffset(Offset = "0x0")]
			public string Message;

			// Token: 0x04004D43 RID: 19779
			[Token(Token = "0x4004EB9")]
			[FieldOffset(Offset = "0x8")]
			public int Identifier;

			// Token: 0x04004D44 RID: 19780
			[Token(Token = "0x4004EBA")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "JsonConverterAttribute", RVA = "0x91040", Offset = "0x90440")]
			public RCon.LogType Type;

			// Token: 0x04004D45 RID: 19781
			[Token(Token = "0x4004EBB")]
			[FieldOffset(Offset = "0x10")]
			public string Stacktrace;
		}

		// Token: 0x02000DDD RID: 3549
		[Token(Token = "0x2000E0A")]
		internal struct BannedAddresses
		{
			// Token: 0x04004D46 RID: 19782
			[Token(Token = "0x4004EBC")]
			[FieldOffset(Offset = "0x0")]
			public IPAddress addr;

			// Token: 0x04004D47 RID: 19783
			[Token(Token = "0x4004EBD")]
			[FieldOffset(Offset = "0x8")]
			public float banTime;
		}

		// Token: 0x02000DDE RID: 3550
		[Token(Token = "0x2000E0B")]
		internal class RConClient
		{
			// Token: 0x0600516E RID: 20846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005365")]
			[Address(RVA = "0x7C4940", Offset = "0x7C3740", VA = "0x1807C4940")]
			internal RConClient(Socket cl)
			{
			}

			// Token: 0x0600516F RID: 20847 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
			[Token(Token = "0x6005366")]
			[Address(RVA = "0x7C40D0", Offset = "0x7C2ED0", VA = "0x1807C40D0")]
			internal bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x06005170 RID: 20848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005367")]
			[Address(RVA = "0x7C46D0", Offset = "0x7C34D0", VA = "0x1807C46D0")]
			internal void Update()
			{
			}

			// Token: 0x06005171 RID: 20849 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
			[Token(Token = "0x6005368")]
			[Address(RVA = "0x7C3A70", Offset = "0x7C2870", VA = "0x1807C3A70")]
			internal bool HandleMessage(int type, string msg)
			{
				return default(bool);
			}

			// Token: 0x06005172 RID: 20850 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
			[Token(Token = "0x6005369")]
			[Address(RVA = "0x7C36D0", Offset = "0x7C24D0", VA = "0x1807C36D0")]
			internal bool HandleMessage_UnAuthed(int type, string msg)
			{
				return default(bool);
			}

			// Token: 0x06005173 RID: 20851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600536A")]
			[Address(RVA = "0x7C40E0", Offset = "0x7C2EE0", VA = "0x1807C40E0")]
			private void Output_OnMessage(string message, string stacktrace, UnityEngine.LogType type)
			{
			}

			// Token: 0x06005174 RID: 20852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600536B")]
			[Address(RVA = "0x7C4340", Offset = "0x7C3140", VA = "0x1807C4340")]
			internal void Reply(int id, int type, string msg)
			{
			}

			// Token: 0x06005175 RID: 20853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600536C")]
			[Address(RVA = "0x7C35C0", Offset = "0x7C23C0", VA = "0x1807C35C0")]
			internal void Close(string strReasn)
			{
			}

			// Token: 0x06005176 RID: 20854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600536D")]
			[Address(RVA = "0x7C41E0", Offset = "0x7C2FE0", VA = "0x1807C41E0")]
			internal string ReadNullTerminatedString(BinaryReader read)
			{
				return null;
			}

			// Token: 0x04004D48 RID: 19784
			[Token(Token = "0x4004EBE")]
			[FieldOffset(Offset = "0x10")]
			private Socket socket;

			// Token: 0x04004D49 RID: 19785
			[Token(Token = "0x4004EBF")]
			[FieldOffset(Offset = "0x18")]
			private bool isAuthorised;

			// Token: 0x04004D4A RID: 19786
			[Token(Token = "0x4004EC0")]
			[FieldOffset(Offset = "0x20")]
			private string connectionName;

			// Token: 0x04004D4B RID: 19787
			[Token(Token = "0x4004EC1")]
			[FieldOffset(Offset = "0x28")]
			private int lastMessageID;

			// Token: 0x04004D4C RID: 19788
			[Token(Token = "0x4004EC2")]
			[FieldOffset(Offset = "0x2C")]
			private bool runningConsoleCommand;

			// Token: 0x04004D4D RID: 19789
			[Token(Token = "0x4004EC3")]
			[FieldOffset(Offset = "0x2D")]
			private bool utf8Mode;
		}

		// Token: 0x02000DDF RID: 3551
		[Token(Token = "0x2000E0C")]
		internal class RConListener
		{
			// Token: 0x06005177 RID: 20855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600536E")]
			[Address(RVA = "0x7C4F80", Offset = "0x7C3D80", VA = "0x1807C4F80")]
			internal RConListener()
			{
			}

			// Token: 0x06005178 RID: 20856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600536F")]
			[Address(RVA = "0x7C4E30", Offset = "0x7C3C30", VA = "0x1807C4E30")]
			internal void Shutdown()
			{
			}

			// Token: 0x06005179 RID: 20857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005370")]
			[Address(RVA = "0x7C49E0", Offset = "0x7C37E0", VA = "0x1807C49E0")]
			internal void Cycle()
			{
			}

			// Token: 0x0600517A RID: 20858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005371")]
			[Address(RVA = "0x7C4B10", Offset = "0x7C3910", VA = "0x1807C4B10")]
			private void ProcessConnections()
			{
			}

			// Token: 0x0600517B RID: 20859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005372")]
			[Address(RVA = "0x7C4E70", Offset = "0x7C3C70", VA = "0x1807C4E70")]
			private void UpdateClients()
			{
			}

			// Token: 0x0600517C RID: 20860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005373")]
			[Address(RVA = "0x7C4D30", Offset = "0x7C3B30", VA = "0x1807C4D30")]
			private void RemoveDeadClients()
			{
			}

			// Token: 0x04004D4E RID: 19790
			[Token(Token = "0x4004EC4")]
			[FieldOffset(Offset = "0x10")]
			private TcpListener server;

			// Token: 0x04004D4F RID: 19791
			[Token(Token = "0x4004EC5")]
			[FieldOffset(Offset = "0x18")]
			private List<RCon.RConClient> clients;

			// Token: 0x02000DE0 RID: 3552
			[Token(Token = "0x2000E7A")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600517E RID: 20862 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600541C")]
				[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
				public <>c()
				{
				}

				// Token: 0x0600517F RID: 20863 RVA: 0x0001E708 File Offset: 0x0001C908
				[Token(Token = "0x600541D")]
				[Address(RVA = "0x7C6B30", Offset = "0x7C5930", VA = "0x1807C6B30")]
				internal bool <RemoveDeadClients>b__7_0(RCon.RConClient x)
				{
					return default(bool);
				}

				// Token: 0x04004D50 RID: 19792
				[Token(Token = "0x4005051")]
				[FieldOffset(Offset = "0x0")]
				public static readonly RCon.RConListener.<>c <>9;

				// Token: 0x04004D51 RID: 19793
				[Token(Token = "0x4005052")]
				[FieldOffset(Offset = "0x8")]
				public static Predicate<RCon.RConClient> <>9__7_0;
			}
		}

		// Token: 0x02000DE1 RID: 3553
		[Token(Token = "0x2000E0D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005181 RID: 20865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005375")]
			[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
			public <>c()
			{
			}

			// Token: 0x06005182 RID: 20866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005376")]
			[Address(RVA = "0x7C6910", Offset = "0x7C5710", VA = "0x1807C6910")]
			internal void <Initialize>b__11_0(IPAddress ip, int id, string msg)
			{
			}

			// Token: 0x06005183 RID: 20867 RVA: 0x0001E720 File Offset: 0x0001C920
			[Token(Token = "0x6005377")]
			[Address(RVA = "0x7C6B90", Offset = "0x7C5990", VA = "0x1807C6B90")]
			internal bool <Update>b__15_0(RCon.BannedAddresses x)
			{
				return default(bool);
			}

			// Token: 0x04004D52 RID: 19794
			[Token(Token = "0x4004EC6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RCon.<>c <>9;

			// Token: 0x04004D53 RID: 19795
			[Token(Token = "0x4004EC7")]
			[FieldOffset(Offset = "0x8")]
			public static Action<IPAddress, int, string> <>9__11_0;

			// Token: 0x04004D54 RID: 19796
			[Token(Token = "0x4004EC8")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<RCon.BannedAddresses> <>9__15_0;
		}

		// Token: 0x02000DE2 RID: 3554
		[Token(Token = "0x2000E0E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06005184 RID: 20868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005378")]
			[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06005185 RID: 20869 RVA: 0x0001E738 File Offset: 0x0001C938
			[Token(Token = "0x6005379")]
			[Address(RVA = "0x7C6C30", Offset = "0x7C5A30", VA = "0x1807C6C30")]
			internal bool <BanIP>b__0(RCon.BannedAddresses x)
			{
				return default(bool);
			}

			// Token: 0x04004D55 RID: 19797
			[Token(Token = "0x4004EC9")]
			[FieldOffset(Offset = "0x10")]
			public IPAddress addr;
		}

		// Token: 0x02000DE3 RID: 3555
		[Token(Token = "0x2000E0F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06005186 RID: 20870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600537A")]
			[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06005187 RID: 20871 RVA: 0x0001E750 File Offset: 0x0001C950
			[Token(Token = "0x600537B")]
			[Address(RVA = "0x7C6C40", Offset = "0x7C5A40", VA = "0x1807C6C40")]
			internal bool <IsBanned>b__0(RCon.BannedAddresses x)
			{
				return default(bool);
			}

			// Token: 0x04004D56 RID: 19798
			[Token(Token = "0x4004ECA")]
			[FieldOffset(Offset = "0x10")]
			public IPAddress addr;
		}
	}
}
