using System;
using Il2CppDummyDll;

// Token: 0x02000974 RID: 2420
[Token(Token = "0x20006C9")]
public class AchievementGroup
{
	// Token: 0x0600396E RID: 14702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600305E")]
	[Address(RVA = "0x819FE0", Offset = "0x818DE0", VA = "0x180819FE0")]
	public AchievementGroup(string token = "", string english = "")
	{
	}

	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x0600396F RID: 14703 RVA: 0x000177A8 File Offset: 0x000159A8
	[Token(Token = "0x17000424")]
	public bool Unlocked
	{
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x81A0B0", Offset = "0x818EB0", VA = "0x18081A0B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x04003642 RID: 13890
	[Token(Token = "0x400298E")]
	[FieldOffset(Offset = "0x10")]
	public Translate.Phrase groupTitle;

	// Token: 0x04003643 RID: 13891
	[Token(Token = "0x400298F")]
	[FieldOffset(Offset = "0x0")]
	public static AchievementGroup[] All;

	// Token: 0x04003644 RID: 13892
	[Token(Token = "0x4002990")]
	[FieldOffset(Offset = "0x18")]
	public AchievementGroup.AchievementItem[] Items;

	// Token: 0x02000975 RID: 2421
	[Token(Token = "0x2000CD6")]
	public class AchievementItem
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000775")]
		public IAchievement Achievement
		{
			[Token(Token = "0x6005085")]
			[Address(RVA = "0x81A270", Offset = "0x819070", VA = "0x18081A270")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x81A1B0", Offset = "0x818FB0", VA = "0x18081A1B0")]
		public AchievementItem(string name, string phrase)
		{
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x000177C0 File Offset: 0x000159C0
		[Token(Token = "0x17000776")]
		public bool Unlocked
		{
			[Token(Token = "0x6005087")]
			[Address(RVA = "0x81A360", Offset = "0x819160", VA = "0x18081A360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04003645 RID: 13893
		[Token(Token = "0x40049A6")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04003646 RID: 13894
		[Token(Token = "0x40049A7")]
		[FieldOffset(Offset = "0x18")]
		public Translate.Phrase Phrase;
	}

	// Token: 0x02000976 RID: 2422
	[Token(Token = "0x2000CD7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003975 RID: 14709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005089")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x000177D8 File Offset: 0x000159D8
		[Token(Token = "0x600508A")]
		[Address(RVA = "0x82FDB0", Offset = "0x82EBB0", VA = "0x18082FDB0")]
		internal bool <get_Unlocked>b__6_0(AchievementGroup.AchievementItem x)
		{
			return default(bool);
		}

		// Token: 0x04003647 RID: 13895
		[Token(Token = "0x40049A8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AchievementGroup.<>c <>9;

		// Token: 0x04003648 RID: 13896
		[Token(Token = "0x40049A9")]
		[FieldOffset(Offset = "0x8")]
		public static Func<AchievementGroup.AchievementItem, bool> <>9__6_0;
	}
}
