using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x02000433 RID: 1075
[Token(Token = "0x200030D")]
public static class AIDesigns
{
	// Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x812E20", Offset = "0x811C20", VA = "0x180812E20")]
	public static ProtoBuf.AIDesign GetByNameOrInstance(string designName, ProtoBuf.AIDesign entityDesign)
	{
		return null;
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0x813110", Offset = "0x811F10", VA = "0x180813110")]
	public static void RefreshCache(string designName, ProtoBuf.AIDesign design)
	{
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x812EE0", Offset = "0x811CE0", VA = "0x180812EE0")]
	private static ProtoBuf.AIDesign GetByName(string designName)
	{
		return null;
	}

	// Token: 0x04001CD7 RID: 7383
	[Token(Token = "0x400177F")]
	public const string DesignFolderPath = "cfg/ai/";

	// Token: 0x04001CD8 RID: 7384
	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x18A0")]
	private static Dictionary<string, ProtoBuf.AIDesign> designs;
}
