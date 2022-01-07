using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

// Token: 0x02000011 RID: 17
[Token(Token = "0x200000C")]
public static class Benchmarking
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600004B RID: 75 RVA: 0x000021D8 File Offset: 0x000003D8
	// (set) Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000006")]
	public static bool IsBenchmarking
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x459DE0", Offset = "0x458BE0", VA = "0x180459DE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x459EA0", Offset = "0x458CA0", VA = "0x180459EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600004D RID: 77 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x17000007")]
	public static bool IsAutoBenchmark
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x459D10", Offset = "0x458B10", VA = "0x180459D10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x4596B0", Offset = "0x4584B0", VA = "0x1804596B0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x98530", Offset = "0x97930")]
	public static Task RunAsync()
	{
		return null;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x459A70", Offset = "0x458870", VA = "0x180459A70")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x98680", Offset = "0x97A80")]
	public static Task RunSingleSceneAsync(string scene)
	{
		return null;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x459790", Offset = "0x458590", VA = "0x180459790")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x98750", Offset = "0x97B50")]
	private static Task RunBenchmarkScene(string scene)
	{
		return null;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x459880", Offset = "0x458680", VA = "0x180459880")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x988B0", Offset = "0x97CB0")]
	public static Task RunBenchmarksInScene()
	{
		return null;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x4595F0", Offset = "0x4583F0", VA = "0x1804595F0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x98A30", Offset = "0x97E30")]
	private static Task Report()
	{
		return null;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x459960", Offset = "0x458760", VA = "0x180459960")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x98B00", Offset = "0x97F00")]
	private static Task RunDemoBasedBenchmark(string demoName, string benchmarkLabel = "")
	{
		return null;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x459430", Offset = "0x458230", VA = "0x180459430")]
	private static void RecordBundleSizes()
	{
	}

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private static bool <IsBenchmarking>k__BackingField;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x8")]
	public static string[] BenchmarkScenes;
}
