using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000576 RID: 1398
[Token(Token = "0x200040F")]
public class CH47PathFinder : BasePathFinder
{
	// Token: 0x06002837 RID: 10295 RVA: 0x00011958 File Offset: 0x0000FB58
	[Token(Token = "0x600219B")]
	[Address(RVA = "0x646C20", Offset = "0x645A20", VA = "0x180646C20", Slot = "4")]
	public override Vector3 GetRandomPatrolPoint()
	{
		return default(Vector3);
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219C")]
	[Address(RVA = "0x647600", Offset = "0x646400", VA = "0x180647600")]
	private MonumentInfo GetRandomValidMonumentInfo()
	{
		return null;
	}

	// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600219D")]
	[Address(RVA = "0x6476F0", Offset = "0x6464F0", VA = "0x1806476F0")]
	public CH47PathFinder()
	{
	}

	// Token: 0x0400236B RID: 9067
	[Token(Token = "0x4001CEC")]
	[FieldOffset(Offset = "0x20")]
	public List<Vector3> visitedPatrolPoints;
}
