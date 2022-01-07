using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007B3 RID: 1971
[Token(Token = "0x20005BA")]
public class DungeonBaseLink : MonoBehaviour
{
	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x06003137 RID: 12599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000383")]
	internal List<DungeonBaseSocket> Sockets
	{
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x97FCC0", Offset = "0x97EAC0", VA = "0x18097FCC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x06003138 RID: 12600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000384")]
	internal List<DungeonVolume> Volumes
	{
		[Token(Token = "0x600298E")]
		[Address(RVA = "0x97FD50", Offset = "0x97EB50", VA = "0x18097FD50")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003139 RID: 12601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600298F")]
	[Address(RVA = "0x97FAE0", Offset = "0x97E8E0", VA = "0x18097FAE0")]
	protected void Start()
	{
	}

	// Token: 0x0600313A RID: 12602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002990")]
	[Address(RVA = "0x97FCA0", Offset = "0x97EAA0", VA = "0x18097FCA0")]
	public DungeonBaseLink()
	{
	}

	// Token: 0x04002E04 RID: 11780
	[Token(Token = "0x4002458")]
	[FieldOffset(Offset = "0x18")]
	public DungeonBaseLinkType Type;

	// Token: 0x04002E05 RID: 11781
	[Token(Token = "0x4002459")]
	[FieldOffset(Offset = "0x1C")]
	public int Cost;

	// Token: 0x04002E06 RID: 11782
	[Token(Token = "0x400245A")]
	[FieldOffset(Offset = "0x20")]
	public int MaxFloor;

	// Token: 0x04002E07 RID: 11783
	[Token(Token = "0x400245B")]
	[FieldOffset(Offset = "0x24")]
	public int MaxCountLocal;

	// Token: 0x04002E08 RID: 11784
	[Token(Token = "0x400245C")]
	[FieldOffset(Offset = "0x28")]
	public int MaxCountGlobal;

	// Token: 0x04002E09 RID: 11785
	[Token(Token = "0x400245D")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x9C590", Offset = "0x9B990")]
	public int MaxCountIdentifier;

	// Token: 0x04002E0A RID: 11786
	[Token(Token = "0x400245E")]
	[FieldOffset(Offset = "0x30")]
	internal DungeonBaseInfo Dungeon;

	// Token: 0x04002E0B RID: 11787
	[Token(Token = "0x400245F")]
	[FieldOffset(Offset = "0x38")]
	public MeshRenderer[] MapRenderers;

	// Token: 0x04002E0C RID: 11788
	[Token(Token = "0x4002460")]
	[FieldOffset(Offset = "0x40")]
	private List<DungeonBaseSocket> sockets;

	// Token: 0x04002E0D RID: 11789
	[Token(Token = "0x4002461")]
	[FieldOffset(Offset = "0x48")]
	private List<DungeonVolume> volumes;
}
