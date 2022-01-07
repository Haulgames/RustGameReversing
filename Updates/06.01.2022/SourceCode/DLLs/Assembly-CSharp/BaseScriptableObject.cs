using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B34 RID: 2868
[Token(Token = "0x20007FF")]
public class BaseScriptableObject : ScriptableObject
{
	// Token: 0x060042D5 RID: 17109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003861")]
	[Address(RVA = "0x99F560", Offset = "0x99E360", VA = "0x18099F560")]
	public string LookupFileName()
	{
		return null;
	}

	// Token: 0x060042D6 RID: 17110 RVA: 0x00018EE8 File Offset: 0x000170E8
	[Token(Token = "0x6003862")]
	[Address(RVA = "0x99F5C0", Offset = "0x99E3C0", VA = "0x18099F5C0")]
	public static bool operator ==(BaseScriptableObject a, BaseScriptableObject b)
	{
		return default(bool);
	}

	// Token: 0x060042D7 RID: 17111 RVA: 0x00018F00 File Offset: 0x00017100
	[Token(Token = "0x6003863")]
	[Address(RVA = "0x99F5E0", Offset = "0x99E3E0", VA = "0x18099F5E0")]
	public static bool operator !=(BaseScriptableObject a, BaseScriptableObject b)
	{
		return default(bool);
	}

	// Token: 0x060042D8 RID: 17112 RVA: 0x00018F18 File Offset: 0x00017118
	[Token(Token = "0x6003864")]
	[Address(RVA = "0x67F4E0", Offset = "0x67E2E0", VA = "0x18067F4E0", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x060042D9 RID: 17113 RVA: 0x00018F30 File Offset: 0x00017130
	[Token(Token = "0x6003865")]
	[Address(RVA = "0x99F480", Offset = "0x99E280", VA = "0x18099F480", Slot = "0")]
	public override bool Equals(object o)
	{
		return default(bool);
	}

	// Token: 0x060042DA RID: 17114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003866")]
	[Address(RVA = "0x484650", Offset = "0x483450", VA = "0x180484650")]
	public BaseScriptableObject()
	{
	}

	// Token: 0x04004005 RID: 16389
	[Token(Token = "0x4003156")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public uint FilenameStringId;
}
