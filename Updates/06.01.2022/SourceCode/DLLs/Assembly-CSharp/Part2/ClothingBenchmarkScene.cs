using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class ClothingBenchmarkScene : BenchmarkScene
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x49C230", Offset = "0x49B030", VA = "0x18049C230", Slot = "7")]
	public override void StartBenchmark()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x49BED0", Offset = "0x49ACD0", VA = "0x18049BED0", Slot = "8")]
	public override void BenchmarkUpdate()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x49C770", Offset = "0x49B570", VA = "0x18049C770", Slot = "9")]
	public override void StopBenchmark()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x49C8E0", Offset = "0x49B6E0", VA = "0x18049C8E0")]
	public ClothingBenchmarkScene()
	{
	}

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x40")]
	public GameObjectRef PlayerModelPrefab;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x48")]
	public bool ChangeClothingEveryFrame;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x50")]
	protected List<PlayerModel> PlayerModels;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x58")]
	protected ItemModWearable[] Wearables;

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000A42")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004794")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004795")]
		[Address(RVA = "0x4B0270", Offset = "0x4AF070", VA = "0x1804B0270")]
		internal ItemModWearable <StartBenchmark>b__4_0(ItemDefinition x)
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6004796")]
		[Address(RVA = "0x4B02C0", Offset = "0x4AF0C0", VA = "0x1804B02C0")]
		internal bool <StartBenchmark>b__4_1(ItemModWearable x)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6004797")]
		[Address(RVA = "0x4B0320", Offset = "0x4AF120", VA = "0x1804B0320")]
		internal Guid <StartBenchmark>b__4_2(ItemModWearable x)
		{
			return default(Guid);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6004798")]
		[Address(RVA = "0x4B0210", Offset = "0x4AF010", VA = "0x1804B0210")]
		internal Guid <BenchmarkUpdate>b__5_0(ItemModWearable x)
		{
			return default(Guid);
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4003D45")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ClothingBenchmarkScene.<>c <>9;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4003D46")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ItemDefinition, ItemModWearable> <>9__4_0;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x4003D47")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ItemModWearable, bool> <>9__4_1;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x4003D48")]
		[FieldOffset(Offset = "0x18")]
		public static Func<ItemModWearable, Guid> <>9__4_2;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x4003D49")]
		[FieldOffset(Offset = "0x20")]
		public static Func<ItemModWearable, Guid> <>9__5_0;
	}
}
