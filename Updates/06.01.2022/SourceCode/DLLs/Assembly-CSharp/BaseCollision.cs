using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003BF RID: 959
[Token(Token = "0x20002AF")]
public class BaseCollision : MonoBehaviour, IClientComponent
{
	// Token: 0x06002005 RID: 8197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "4")]
	public virtual void TraceTest(HitTest test, List<TraceInfo> hits)
	{
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BaseCollision()
	{
	}

	// Token: 0x04001AEF RID: 6895
	[Token(Token = "0x4001604")]
	[FieldOffset(Offset = "0x18")]
	public BaseEntity Owner;

	// Token: 0x04001AF0 RID: 6896
	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0x20")]
	public Model model;
}
