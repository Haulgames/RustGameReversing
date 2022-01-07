using System;
using System.Collections.Generic;
using System.Linq;
using Facepunch;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A87 RID: 2695
[Token(Token = "0x200078E")]
public class Demos : SingletonComponent<Demos>, VirtualScroll.IDataSource
{
	// Token: 0x06003F88 RID: 16264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CB")]
	[Address(RVA = "0x8D4260", Offset = "0x8D3060", VA = "0x1808D4260", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06003F89 RID: 16265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CC")]
	[Address(RVA = "0x8D4430", Offset = "0x8D3230", VA = "0x1808D4430")]
	private void DeselectItem()
	{
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CD")]
	[Address(RVA = "0x8D4EA0", Offset = "0x8D3CA0", VA = "0x1808D4EA0")]
	private void Populate()
	{
	}

	// Token: 0x06003F8B RID: 16267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CE")]
	[Address(RVA = "0x8D5170", Offset = "0x8D3F70", VA = "0x1808D5170")]
	private void Rebuild()
	{
	}

	// Token: 0x06003F8C RID: 16268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CF")]
	[Address(RVA = "0x8D4E10", Offset = "0x8D3C10", VA = "0x1808D4E10")]
	public void OrderBy(string strBy)
	{
	}

	// Token: 0x06003F8D RID: 16269 RVA: 0x000186A8 File Offset: 0x000168A8
	[Token(Token = "0x60035D0")]
	[Address(RVA = "0x8D44E0", Offset = "0x8D32E0", VA = "0x1808D44E0", Slot = "8")]
	public int GetItemCount()
	{
		return 0;
	}

	// Token: 0x06003F8E RID: 16270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D1")]
	[Address(RVA = "0x8D5210", Offset = "0x8D4010", VA = "0x1808D5210", Slot = "9")]
	public void SetItemData(int i, GameObject obj)
	{
	}

	// Token: 0x06003F8F RID: 16271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60035D2")]
	[Address(RVA = "0x8D4520", Offset = "0x8D3320", VA = "0x1808D4520")]
	private IOrderedEnumerable<Demos.DemoInfo> GetSortedInfo()
	{
		return null;
	}

	// Token: 0x06003F90 RID: 16272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D3")]
	[Address(RVA = "0x8D4BB0", Offset = "0x8D39B0", VA = "0x1808D4BB0")]
	public void OnItemClicked(DemoItem item)
	{
	}

	// Token: 0x06003F91 RID: 16273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D4")]
	[Address(RVA = "0x8D4B30", Offset = "0x8D3930", VA = "0x1808D4B30")]
	public void OnDeleteItem()
	{
	}

	// Token: 0x06003F92 RID: 16274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D5")]
	[Address(RVA = "0x8D4280", Offset = "0x8D3080", VA = "0x1808D4280")]
	public void DeleteItem()
	{
	}

	// Token: 0x06003F93 RID: 16275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D6")]
	[Address(RVA = "0x8D4D00", Offset = "0x8D3B00", VA = "0x1808D4D00")]
	public void OnPlayItem()
	{
	}

	// Token: 0x06003F94 RID: 16276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D7")]
	[Address(RVA = "0x8D4DD0", Offset = "0x8D3BD0", VA = "0x1808D4DD0")]
	public void OpenDemosFolder()
	{
	}

	// Token: 0x06003F95 RID: 16277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D8")]
	[Address(RVA = "0x8D5200", Offset = "0x8D4000", VA = "0x1808D5200")]
	public void Refresh()
	{
	}

	// Token: 0x06003F96 RID: 16278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D9")]
	[Address(RVA = "0x8D5580", Offset = "0x8D4380", VA = "0x1808D5580")]
	public Demos()
	{
	}

	// Token: 0x04003CE8 RID: 15592
	[Token(Token = "0x4002F28")]
	[FieldOffset(Offset = "0x18")]
	public VirtualScroll virtualScroll;

	// Token: 0x04003CE9 RID: 15593
	[Token(Token = "0x4002F29")]
	[FieldOffset(Offset = "0x20")]
	public GameObject deletePopup;

	// Token: 0x04003CEA RID: 15594
	[Token(Token = "0x4002F2A")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<Demos.DemoInfo> _demoInfo;

	// Token: 0x04003CEB RID: 15595
	[Token(Token = "0x4002F2B")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<Demos.DemoInfo> _sortedDemoInfo;

	// Token: 0x04003CEC RID: 15596
	[Token(Token = "0x4002F2C")]
	[FieldOffset(Offset = "0x38")]
	private DemoItem _selectedItem;

	// Token: 0x04003CED RID: 15597
	[Token(Token = "0x4002F2D")]
	[FieldOffset(Offset = "0x40")]
	private string sortOrder;

	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000D22")]
	private struct DemoInfo
	{
		// Token: 0x06003F97 RID: 16279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005132")]
		[Address(RVA = "0xF84E0", Offset = "0xF78E0", VA = "0x1800F84E0")]
		public DemoInfo(string path, string name, DateTime date, TimeSpan length)
		{
		}

		// Token: 0x04003CEE RID: 15598
		[Token(Token = "0x4004AAA")]
		[FieldOffset(Offset = "0x0")]
		public string path;

		// Token: 0x04003CEF RID: 15599
		[Token(Token = "0x4004AAB")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x04003CF0 RID: 15600
		[Token(Token = "0x4004AAC")]
		[FieldOffset(Offset = "0x10")]
		public DateTime date;

		// Token: 0x04003CF1 RID: 15601
		[Token(Token = "0x4004AAD")]
		[FieldOffset(Offset = "0x18")]
		public TimeSpan length;
	}

	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000D23")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003F99 RID: 16281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005134")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005135")]
		[Address(RVA = "0xB7A900", Offset = "0xB79700", VA = "0x180B7A900")]
		internal string <GetSortedInfo>b__14_0(Demos.DemoInfo x)
		{
			return null;
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005136")]
		[Address(RVA = "0xB7A900", Offset = "0xB79700", VA = "0x180B7A900")]
		internal string <GetSortedInfo>b__14_1(Demos.DemoInfo x)
		{
			return null;
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x000186C0 File Offset: 0x000168C0
		[Token(Token = "0x6005137")]
		[Address(RVA = "0xB7A920", Offset = "0xB79720", VA = "0x180B7A920")]
		internal DateTime <GetSortedInfo>b__14_2(Demos.DemoInfo x)
		{
			return default(DateTime);
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x000186D8 File Offset: 0x000168D8
		[Token(Token = "0x6005138")]
		[Address(RVA = "0xB7A920", Offset = "0xB79720", VA = "0x180B7A920")]
		internal DateTime <GetSortedInfo>b__14_3(Demos.DemoInfo x)
		{
			return default(DateTime);
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x000186F0 File Offset: 0x000168F0
		[Token(Token = "0x6005139")]
		[Address(RVA = "0xB7A940", Offset = "0xB79740", VA = "0x180B7A940")]
		internal TimeSpan <GetSortedInfo>b__14_4(Demos.DemoInfo x)
		{
			return default(TimeSpan);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00018708 File Offset: 0x00016908
		[Token(Token = "0x600513A")]
		[Address(RVA = "0xB7A940", Offset = "0xB79740", VA = "0x180B7A940")]
		internal TimeSpan <GetSortedInfo>b__14_5(Demos.DemoInfo x)
		{
			return default(TimeSpan);
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513B")]
		[Address(RVA = "0xB7A900", Offset = "0xB79700", VA = "0x180B7A900")]
		internal string <GetSortedInfo>b__14_6(Demos.DemoInfo x)
		{
			return null;
		}

		// Token: 0x04003CF2 RID: 15602
		[Token(Token = "0x4004AAE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Demos.<>c <>9;

		// Token: 0x04003CF3 RID: 15603
		[Token(Token = "0x4004AAF")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Demos.DemoInfo, string> <>9__14_0;

		// Token: 0x04003CF4 RID: 15604
		[Token(Token = "0x4004AB0")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Demos.DemoInfo, string> <>9__14_1;

		// Token: 0x04003CF5 RID: 15605
		[Token(Token = "0x4004AB1")]
		[FieldOffset(Offset = "0x18")]
		public static Func<Demos.DemoInfo, DateTime> <>9__14_2;

		// Token: 0x04003CF6 RID: 15606
		[Token(Token = "0x4004AB2")]
		[FieldOffset(Offset = "0x20")]
		public static Func<Demos.DemoInfo, DateTime> <>9__14_3;

		// Token: 0x04003CF7 RID: 15607
		[Token(Token = "0x4004AB3")]
		[FieldOffset(Offset = "0x28")]
		public static Func<Demos.DemoInfo, TimeSpan> <>9__14_4;

		// Token: 0x04003CF8 RID: 15608
		[Token(Token = "0x4004AB4")]
		[FieldOffset(Offset = "0x30")]
		public static Func<Demos.DemoInfo, TimeSpan> <>9__14_5;

		// Token: 0x04003CF9 RID: 15609
		[Token(Token = "0x4004AB5")]
		[FieldOffset(Offset = "0x38")]
		public static Func<Demos.DemoInfo, string> <>9__14_6;
	}

	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000D24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06003FA1 RID: 16289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513C")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00018720 File Offset: 0x00016920
		[Token(Token = "0x600513D")]
		[Address(RVA = "0xB7AAB0", Offset = "0xB798B0", VA = "0x180B7AAB0")]
		internal bool <DeleteItem>b__0(Demos.DemoInfo x)
		{
			return default(bool);
		}

		// Token: 0x04003CFA RID: 15610
		[Token(Token = "0x4004AB6")]
		[FieldOffset(Offset = "0x10")]
		public Demos.DemoInfo demoInfo;
	}
}
