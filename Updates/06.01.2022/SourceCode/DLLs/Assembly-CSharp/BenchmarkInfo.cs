using System;
using System.Text;
using Il2CppDummyDll;
using TMPro;

// Token: 0x0200033D RID: 829
[Token(Token = "0x200024F")]
public class BenchmarkInfo : SingletonComponent<BenchmarkInfo>
{
	// Token: 0x06001CEB RID: 7403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001744")]
	[Address(RVA = "0x4582C0", Offset = "0x4570C0", VA = "0x1804582C0")]
	private void Start()
	{
	}

	// Token: 0x06001CEC RID: 7404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001745")]
	[Address(RVA = "0x458BB0", Offset = "0x4579B0", VA = "0x180458BB0")]
	private void Update()
	{
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001746")]
	[Address(RVA = "0x459060", Offset = "0x457E60", VA = "0x180459060")]
	public BenchmarkInfo()
	{
	}

	// Token: 0x04001808 RID: 6152
	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x0")]
	public static string BenchmarkTitle;

	// Token: 0x04001809 RID: 6153
	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x8")]
	public static string BenchmarkSubtitle;

	// Token: 0x0400180A RID: 6154
	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI PerformanceText;

	// Token: 0x0400180B RID: 6155
	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI SystemInfoText;

	// Token: 0x0400180C RID: 6156
	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x28")]
	private StringBuilder sb;

	// Token: 0x0400180D RID: 6157
	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x30")]
	private RealTimeSince timeSinceUpdated;
}
