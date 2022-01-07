using System;
using Il2CppDummyDll;

// Token: 0x02000B32 RID: 2866
[Token(Token = "0x20007FE")]
public abstract class BaseMonoBehaviour : FacepunchBehaviour
{
	// Token: 0x060042CF RID: 17103 RVA: 0x00018ED0 File Offset: 0x000170D0
	[Token(Token = "0x600385B")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "4")]
	public virtual bool IsDebugging()
	{
		return default(bool);
	}

	// Token: 0x060042D0 RID: 17104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600385C")]
	[Address(RVA = "0x2F6330", Offset = "0x2F5130", VA = "0x1802F6330", Slot = "5")]
	public virtual string GetLogColor()
	{
		return null;
	}

	// Token: 0x060042D1 RID: 17105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385D")]
	[Address(RVA = "0x2F6950", Offset = "0x2F5750", VA = "0x1802F6950")]
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1)
	{
	}

	// Token: 0x060042D2 RID: 17106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385E")]
	[Address(RVA = "0x2F6650", Offset = "0x2F5450", VA = "0x1802F6650")]
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1, object arg2)
	{
	}

	// Token: 0x060042D3 RID: 17107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385F")]
	[Address(RVA = "0x2F6360", Offset = "0x2F5160", VA = "0x1802F6360")]
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str)
	{
	}

	// Token: 0x060042D4 RID: 17108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003860")]
	[Address(RVA = "0x2F6C50", Offset = "0x2F5A50", VA = "0x1802F6C50")]
	protected BaseMonoBehaviour()
	{
	}

	// Token: 0x02000B33 RID: 2867
	[Token(Token = "0x2000D5D")]
	public enum LogEntryType
	{
		// Token: 0x04004001 RID: 16385
		[Token(Token = "0x4004B95")]
		General,
		// Token: 0x04004002 RID: 16386
		[Token(Token = "0x4004B96")]
		Network,
		// Token: 0x04004003 RID: 16387
		[Token(Token = "0x4004B97")]
		Hierarchy,
		// Token: 0x04004004 RID: 16388
		[Token(Token = "0x4004B98")]
		Serialization
	}
}
