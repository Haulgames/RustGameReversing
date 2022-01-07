using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D2 RID: 978
[Token(Token = "0x20002BC")]
[Attribute(Name = "Factory", RVA = "0x916D0", Offset = "0x90AD0")]
public class DiagnosticsConSys : ConsoleSystem
{
	// Token: 0x06002085 RID: 8325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0xB6CE80", Offset = "0xB6BC80", VA = "0x180B6CE80")]
	private static void DumpAnimators(string targetFolder)
	{
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0xB6DFA0", Offset = "0xB6CDA0", VA = "0x180B6DFA0")]
	private static void DumpEntities(string targetFolder)
	{
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0xB6FA30", Offset = "0xB6E830", VA = "0x180B6FA30")]
	private static void DumpLODGroups(string targetFolder)
	{
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0xB6F5C0", Offset = "0xB6E3C0", VA = "0x180B6F5C0")]
	private static void DumpLODGroupTotals(string targetFolder)
	{
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A80")]
	[Address(RVA = "0xB6FA40", Offset = "0xB6E840", VA = "0x180B6FA40")]
	private static void DumpNetwork(string targetFolder)
	{
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A81")]
	[Address(RVA = "0xB6FBC0", Offset = "0xB6E9C0", VA = "0x180B6FBC0")]
	private static void DumpObjects(string targetFolder)
	{
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A82")]
	[Address(RVA = "0xB70530", Offset = "0xB6F330", VA = "0x180B70530")]
	private static void DumpPhysics(string targetFolder)
	{
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A83")]
	[Address(RVA = "0xB711B0", Offset = "0xB6FFB0", VA = "0x180B711B0")]
	private static void DumpTotals(string targetFolder)
	{
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A84")]
	[Address(RVA = "0xB6D8E0", Offset = "0xB6C6E0", VA = "0x180B6D8E0")]
	private static void DumpColliders(string targetFolder)
	{
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A85")]
	[Address(RVA = "0xB70560", Offset = "0xB6F360", VA = "0x180B70560")]
	private static void DumpRigidBodies(string targetFolder)
	{
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A86")]
	[Address(RVA = "0xB6E9B0", Offset = "0xB6D7B0", VA = "0x180B6E9B0")]
	private static void DumpGameObjects(string targetFolder)
	{
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A87")]
	[Address(RVA = "0xB6E6C0", Offset = "0xB6D4C0", VA = "0x180B6E6C0")]
	private static void DumpGameObjectRecursive(StringBuilder str, Transform tx, int indent, bool includeComponents = false)
	{
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A88")]
	[Address(RVA = "0xB71630", Offset = "0xB70430", VA = "0x180B71630")]
	[ServerVar]
	[ClientVar]
	public static void dump(ConsoleSystem.Arg args)
	{
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A89")]
	[Address(RVA = "0xB71150", Offset = "0xB6FF50", VA = "0x180B71150")]
	private static void DumpSystemInformation(string targetFolder)
	{
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0xB715C0", Offset = "0xB703C0", VA = "0x180B715C0")]
	private static void WriteTextToFile(string file, string text)
	{
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0xB715D0", Offset = "0xB703D0", VA = "0x180B715D0")]
	public DiagnosticsConSys()
	{
	}

	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x2000B4B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002096 RID: 8342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D88")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D89")]
		[Address(RVA = "0xB7A1C0", Offset = "0xB78FC0", VA = "0x180B7A1C0")]
		internal string <DumpAnimators>b__0_0(Animator x)
		{
			return null;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0xB7A210", Offset = "0xB79010", VA = "0x180B7A210")]
		internal int <DumpAnimators>b__0_1(IGrouping<string, Animator> x)
		{
			return 0;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0xB7A250", Offset = "0xB79050", VA = "0x180B7A250")]
		internal string <DumpAnimators>b__0_2(Animator x)
		{
			return null;
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x6004D8C")]
		[Address(RVA = "0xB7A2D0", Offset = "0xB790D0", VA = "0x180B7A2D0")]
		internal int <DumpAnimators>b__0_3(IGrouping<string, Animator> x)
		{
			return 0;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0xB7A3C0", Offset = "0xB791C0", VA = "0x180B7A3C0")]
		internal uint <DumpEntities>b__1_0(BaseNetworkable x)
		{
			return 0U;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0xB7A3E0", Offset = "0xB791E0", VA = "0x180B7A3E0")]
		internal int <DumpEntities>b__1_1(IGrouping<uint, BaseNetworkable> x)
		{
			return 0;
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8F")]
		[Address(RVA = "0xB7A640", Offset = "0xB79440", VA = "0x180B7A640")]
		internal string <DumpLODGroupTotals>b__3_0(LODGroup x)
		{
			return null;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6004D90")]
		[Address(RVA = "0xB7A690", Offset = "0xB79490", VA = "0x180B7A690")]
		internal int <DumpLODGroupTotals>b__3_1(IGrouping<string, LODGroup> x)
		{
			return 0;
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D91")]
		[Address(RVA = "0xB7A6D0", Offset = "0xB794D0", VA = "0x180B7A6D0")]
		internal Type <DumpObjects>b__5_0(UnityEngine.Object x)
		{
			return null;
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6004D92")]
		[Address(RVA = "0xB7A6F0", Offset = "0xB794F0", VA = "0x180B7A6F0")]
		internal int <DumpObjects>b__5_1(IGrouping<Type, UnityEngine.Object> x)
		{
			return 0;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6004D93")]
		[Address(RVA = "0xB7A730", Offset = "0xB79530", VA = "0x180B7A730")]
		internal bool <DumpObjects>b__5_2(UnityEngine.Object x)
		{
			return default(bool);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D94")]
		[Address(RVA = "0xB7A6D0", Offset = "0xB794D0", VA = "0x180B7A6D0")]
		internal Type <DumpObjects>b__5_3(UnityEngine.Object x)
		{
			return null;
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6004D95")]
		[Address(RVA = "0xB7A7B0", Offset = "0xB795B0", VA = "0x180B7A7B0")]
		internal int <DumpObjects>b__5_4(IGrouping<Type, UnityEngine.Object> x)
		{
			return 0;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0000F318 File Offset: 0x0000D518
		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x9FFAA0", Offset = "0x9FE8A0", VA = "0x1809FFAA0")]
		internal bool <DumpTotals>b__7_0(Collider x)
		{
			return default(bool);
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D97")]
		[Address(RVA = "0xB7A310", Offset = "0xB79110", VA = "0x180B7A310")]
		internal string <DumpColliders>b__8_0(Collider x)
		{
			return null;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x6004D98")]
		[Address(RVA = "0xB7A360", Offset = "0xB79160", VA = "0x180B7A360")]
		internal int <DumpColliders>b__8_1(IGrouping<string, Collider> x)
		{
			return 0;
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0000F348 File Offset: 0x0000D548
		[Token(Token = "0x6004D99")]
		[Address(RVA = "0xB7A3A0", Offset = "0xB791A0", VA = "0x180B7A3A0")]
		internal bool <DumpColliders>b__8_2(Collider x)
		{
			return default(bool);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x6004D9A")]
		[Address(RVA = "0x9FFAA0", Offset = "0x9FE8A0", VA = "0x1809FFAA0")]
		internal bool <DumpColliders>b__8_3(Collider x)
		{
			return default(bool);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9B")]
		[Address(RVA = "0xB7A7F0", Offset = "0xB795F0", VA = "0x180B7A7F0")]
		internal string <DumpRigidBodies>b__9_0(Rigidbody x)
		{
			return null;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x6004D9C")]
		[Address(RVA = "0xB7A840", Offset = "0xB79640", VA = "0x180B7A840")]
		internal int <DumpRigidBodies>b__9_1(IGrouping<string, Rigidbody> x)
		{
			return 0;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0xB7A880", Offset = "0xB79680", VA = "0x180B7A880")]
		internal bool <DumpRigidBodies>b__9_2(Rigidbody x)
		{
			return default(bool);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0xB7A8B0", Offset = "0xB796B0", VA = "0x180B7A8B0")]
		internal bool <DumpRigidBodies>b__9_3(Rigidbody x)
		{
			return default(bool);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x6004D9F")]
		[Address(RVA = "0xB7A8D0", Offset = "0xB796D0", VA = "0x180B7A8D0")]
		internal bool <DumpRigidBodies>b__9_4(Rigidbody x)
		{
			return default(bool);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA0")]
		[Address(RVA = "0x8D8EA0", Offset = "0x8D7CA0", VA = "0x1808D8EA0")]
		internal string <DumpGameObjects>b__10_0(Transform x)
		{
			return null;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x6004DA1")]
		[Address(RVA = "0xB7A420", Offset = "0xB79220", VA = "0x180B7A420")]
		internal int <DumpGameObjects>b__10_1(IGrouping<string, Transform> x)
		{
			return 0;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA2")]
		[Address(RVA = "0x8D8EA0", Offset = "0x8D7CA0", VA = "0x1808D8EA0")]
		internal string <DumpGameObjects>b__10_2(Transform x)
		{
			return null;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x6004DA3")]
		[Address(RVA = "0xB7A460", Offset = "0xB79260", VA = "0x180B7A460")]
		internal KeyValuePair<Transform, int> <DumpGameObjects>b__10_3(IGrouping<string, Transform> x)
		{
			return default(KeyValuePair<Transform, int>);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0xB7A5F0", Offset = "0xB793F0", VA = "0x180B7A5F0")]
		internal int <DumpGameObjects>b__10_5(Transform y)
		{
			return 0;
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x6004DA5")]
		[Address(RVA = "0xB7A5B0", Offset = "0xB793B0", VA = "0x180B7A5B0")]
		internal int <DumpGameObjects>b__10_4(KeyValuePair<Transform, int> x)
		{
			return 0;
		}

		// Token: 0x04001B5F RID: 7007
		[Token(Token = "0x4004214")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DiagnosticsConSys.<>c <>9;

		// Token: 0x04001B60 RID: 7008
		[Token(Token = "0x4004215")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Animator, string> <>9__0_0;

		// Token: 0x04001B61 RID: 7009
		[Token(Token = "0x4004216")]
		[FieldOffset(Offset = "0x10")]
		public static Func<IGrouping<string, Animator>, int> <>9__0_1;

		// Token: 0x04001B62 RID: 7010
		[Token(Token = "0x4004217")]
		[FieldOffset(Offset = "0x18")]
		public static Func<Animator, string> <>9__0_2;

		// Token: 0x04001B63 RID: 7011
		[Token(Token = "0x4004218")]
		[FieldOffset(Offset = "0x20")]
		public static Func<IGrouping<string, Animator>, int> <>9__0_3;

		// Token: 0x04001B64 RID: 7012
		[Token(Token = "0x4004219")]
		[FieldOffset(Offset = "0x28")]
		public static Func<BaseNetworkable, uint> <>9__1_0;

		// Token: 0x04001B65 RID: 7013
		[Token(Token = "0x400421A")]
		[FieldOffset(Offset = "0x30")]
		public static Func<IGrouping<uint, BaseNetworkable>, int> <>9__1_1;

		// Token: 0x04001B66 RID: 7014
		[Token(Token = "0x400421B")]
		[FieldOffset(Offset = "0x38")]
		public static Func<LODGroup, string> <>9__3_0;

		// Token: 0x04001B67 RID: 7015
		[Token(Token = "0x400421C")]
		[FieldOffset(Offset = "0x40")]
		public static Func<IGrouping<string, LODGroup>, int> <>9__3_1;

		// Token: 0x04001B68 RID: 7016
		[Token(Token = "0x400421D")]
		[FieldOffset(Offset = "0x48")]
		public static Func<UnityEngine.Object, Type> <>9__5_0;

		// Token: 0x04001B69 RID: 7017
		[Token(Token = "0x400421E")]
		[FieldOffset(Offset = "0x50")]
		public static Func<IGrouping<Type, UnityEngine.Object>, int> <>9__5_1;

		// Token: 0x04001B6A RID: 7018
		[Token(Token = "0x400421F")]
		[FieldOffset(Offset = "0x58")]
		public static Func<UnityEngine.Object, bool> <>9__5_2;

		// Token: 0x04001B6B RID: 7019
		[Token(Token = "0x4004220")]
		[FieldOffset(Offset = "0x60")]
		public static Func<UnityEngine.Object, Type> <>9__5_3;

		// Token: 0x04001B6C RID: 7020
		[Token(Token = "0x4004221")]
		[FieldOffset(Offset = "0x68")]
		public static Func<IGrouping<Type, UnityEngine.Object>, int> <>9__5_4;

		// Token: 0x04001B6D RID: 7021
		[Token(Token = "0x4004222")]
		[FieldOffset(Offset = "0x70")]
		public static Func<Collider, bool> <>9__7_0;

		// Token: 0x04001B6E RID: 7022
		[Token(Token = "0x4004223")]
		[FieldOffset(Offset = "0x78")]
		public static Func<Collider, string> <>9__8_0;

		// Token: 0x04001B6F RID: 7023
		[Token(Token = "0x4004224")]
		[FieldOffset(Offset = "0x80")]
		public static Func<IGrouping<string, Collider>, int> <>9__8_1;

		// Token: 0x04001B70 RID: 7024
		[Token(Token = "0x4004225")]
		[FieldOffset(Offset = "0x88")]
		public static Func<Collider, bool> <>9__8_2;

		// Token: 0x04001B71 RID: 7025
		[Token(Token = "0x4004226")]
		[FieldOffset(Offset = "0x90")]
		public static Func<Collider, bool> <>9__8_3;

		// Token: 0x04001B72 RID: 7026
		[Token(Token = "0x4004227")]
		[FieldOffset(Offset = "0x98")]
		public static Func<Rigidbody, string> <>9__9_0;

		// Token: 0x04001B73 RID: 7027
		[Token(Token = "0x4004228")]
		[FieldOffset(Offset = "0xA0")]
		public static Func<IGrouping<string, Rigidbody>, int> <>9__9_1;

		// Token: 0x04001B74 RID: 7028
		[Token(Token = "0x4004229")]
		[FieldOffset(Offset = "0xA8")]
		public static Func<Rigidbody, bool> <>9__9_2;

		// Token: 0x04001B75 RID: 7029
		[Token(Token = "0x400422A")]
		[FieldOffset(Offset = "0xB0")]
		public static Func<Rigidbody, bool> <>9__9_3;

		// Token: 0x04001B76 RID: 7030
		[Token(Token = "0x400422B")]
		[FieldOffset(Offset = "0xB8")]
		public static Func<Rigidbody, bool> <>9__9_4;

		// Token: 0x04001B77 RID: 7031
		[Token(Token = "0x400422C")]
		[FieldOffset(Offset = "0xC0")]
		public static Func<Transform, string> <>9__10_0;

		// Token: 0x04001B78 RID: 7032
		[Token(Token = "0x400422D")]
		[FieldOffset(Offset = "0xC8")]
		public static Func<IGrouping<string, Transform>, int> <>9__10_1;

		// Token: 0x04001B79 RID: 7033
		[Token(Token = "0x400422E")]
		[FieldOffset(Offset = "0xD0")]
		public static Func<Transform, string> <>9__10_2;

		// Token: 0x04001B7A RID: 7034
		[Token(Token = "0x400422F")]
		[FieldOffset(Offset = "0xD8")]
		public static Func<Transform, int> <>9__10_5;

		// Token: 0x04001B7B RID: 7035
		[Token(Token = "0x4004230")]
		[FieldOffset(Offset = "0xE0")]
		public static Func<IGrouping<string, Transform>, KeyValuePair<Transform, int>> <>9__10_3;

		// Token: 0x04001B7C RID: 7036
		[Token(Token = "0x4004231")]
		[FieldOffset(Offset = "0xE8")]
		public static Func<KeyValuePair<Transform, int>, int> <>9__10_4;
	}
}
