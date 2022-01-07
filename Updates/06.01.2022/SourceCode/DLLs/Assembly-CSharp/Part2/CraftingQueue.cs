using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A19 RID: 2585
[Token(Token = "0x2000743")]
public class CraftingQueue : SingletonComponent<CraftingQueue>
{
	// Token: 0x06003CFD RID: 15613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338F")]
	[Address(RVA = "0x6D8810", Offset = "0x6D7610", VA = "0x1806D8810", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003390")]
	[Address(RVA = "0x6D8890", Offset = "0x6D7690", VA = "0x1806D8890")]
	public void ClearCraftingQueue()
	{
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003391")]
	[Address(RVA = "0x6D9790", Offset = "0x6D8590", VA = "0x1806D9790")]
	internal static void TaskStarted(int taskid, float time)
	{
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x00017F10 File Offset: 0x00016110
	[Token(Token = "0x6003392")]
	[Address(RVA = "0x6D89B0", Offset = "0x6D77B0", VA = "0x1806D89B0")]
	internal static int Count(ItemBlueprint bp)
	{
		return 0;
	}

	// Token: 0x06003D01 RID: 15617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003393")]
	[Address(RVA = "0x6D8B50", Offset = "0x6D7950", VA = "0x1806D8B50")]
	internal static void TaskAdd(int taskid, int itemid, int amount, int skinid)
	{
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003394")]
	[Address(RVA = "0x6D9330", Offset = "0x6D8130", VA = "0x1806D9330")]
	internal static void TaskFinished(int taskid, bool success, int amountleft)
	{
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003395")]
	[Address(RVA = "0x6D8F10", Offset = "0x6D7D10", VA = "0x1806D8F10")]
	internal static void TaskFastTracked(int taskid)
	{
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003396")]
	[Address(RVA = "0x6D9A80", Offset = "0x6D8880", VA = "0x1806D9A80")]
	public void UpdateVisibility()
	{
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003397")]
	[Address(RVA = "0x6D8AC0", Offset = "0x6D78C0", VA = "0x1806D8AC0")]
	public CraftingQueueIcon GetActive()
	{
		return null;
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003398")]
	[Address(RVA = "0x6D9B70", Offset = "0x6D8970", VA = "0x1806D9B70")]
	public CraftingQueue()
	{
	}

	// Token: 0x04003A29 RID: 14889
	[Token(Token = "0x4002CF1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject queueContainer;

	// Token: 0x04003A2A RID: 14890
	[Token(Token = "0x4002CF2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject queueItemPrefab;

	// Token: 0x04003A2B RID: 14891
	[Token(Token = "0x4002CF3")]
	[FieldOffset(Offset = "0x28")]
	private ScrollRect scrollRect;

	// Token: 0x04003A2C RID: 14892
	[Token(Token = "0x4002CF4")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, int> CraftingItems;

	// Token: 0x04003A2D RID: 14893
	[Token(Token = "0x4002CF5")]
	[FieldOffset(Offset = "0x8")]
	public static bool isCrafting;

	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000CFF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06003D08 RID: 15624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E3")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x00017F28 File Offset: 0x00016128
		[Token(Token = "0x60050E4")]
		[Address(RVA = "0x6E0030", Offset = "0x6DEE30", VA = "0x1806E0030")]
		internal bool <TaskStarted>b__0(CraftingQueueIcon x)
		{
			return default(bool);
		}

		// Token: 0x04003A2E RID: 14894
		[Token(Token = "0x4004A22")]
		[FieldOffset(Offset = "0x10")]
		public int taskid;

		// Token: 0x04003A2F RID: 14895
		[Token(Token = "0x4004A23")]
		[FieldOffset(Offset = "0x18")]
		public Func<CraftingQueueIcon, bool> <>9__0;
	}

	// Token: 0x02000A1B RID: 2587
	[Token(Token = "0x2000D00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x06003D0A RID: 15626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E5")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x00017F40 File Offset: 0x00016140
		[Token(Token = "0x60050E6")]
		[Address(RVA = "0x6E0030", Offset = "0x6DEE30", VA = "0x1806E0030")]
		internal bool <TaskFinished>b__0(CraftingQueueIcon x)
		{
			return default(bool);
		}

		// Token: 0x04003A30 RID: 14896
		[Token(Token = "0x4004A24")]
		[FieldOffset(Offset = "0x10")]
		public int taskid;

		// Token: 0x04003A31 RID: 14897
		[Token(Token = "0x4004A25")]
		[FieldOffset(Offset = "0x18")]
		public Func<CraftingQueueIcon, bool> <>9__0;
	}

	// Token: 0x02000A1C RID: 2588
	[Token(Token = "0x2000D01")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06003D0C RID: 15628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E7")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x00017F58 File Offset: 0x00016158
		[Token(Token = "0x60050E8")]
		[Address(RVA = "0x6E0030", Offset = "0x6DEE30", VA = "0x1806E0030")]
		internal bool <TaskFastTracked>b__0(CraftingQueueIcon x)
		{
			return default(bool);
		}

		// Token: 0x04003A32 RID: 14898
		[Token(Token = "0x4004A26")]
		[FieldOffset(Offset = "0x10")]
		public int taskid;

		// Token: 0x04003A33 RID: 14899
		[Token(Token = "0x4004A27")]
		[FieldOffset(Offset = "0x18")]
		public Func<CraftingQueueIcon, bool> <>9__0;
	}
}
