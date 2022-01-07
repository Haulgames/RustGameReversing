using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000779 RID: 1913
[Token(Token = "0x200059E")]
[Serializable]
public sealed class ByteQuadtree
{
	// Token: 0x06003002 RID: 12290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002897")]
	[Address(RVA = "0x643E00", Offset = "0x642C00", VA = "0x180643E00")]
	public void UpdateValues(byte[] baseValues)
	{
	}

	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x06003003 RID: 12291 RVA: 0x000147A8 File Offset: 0x000129A8
	[Token(Token = "0x1700036A")]
	public int Size
	{
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x451780", Offset = "0x450580", VA = "0x180451780")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x06003004 RID: 12292 RVA: 0x000147C0 File Offset: 0x000129C0
	[Token(Token = "0x1700036B")]
	public ByteQuadtree.Element Root
	{
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x6441E0", Offset = "0x642FE0", VA = "0x1806441E0")]
		get
		{
			return default(ByteQuadtree.Element);
		}
	}

	// Token: 0x06003005 RID: 12293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600289A")]
	[Address(RVA = "0x643D30", Offset = "0x642B30", VA = "0x180643D30")]
	private ByteMap CreateLevel(int level)
	{
		return null;
	}

	// Token: 0x06003006 RID: 12294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600289B")]
	[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
	public ByteQuadtree()
	{
	}

	// Token: 0x04002CE5 RID: 11493
	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int size;

	// Token: 0x04002CE6 RID: 11494
	[Token(Token = "0x40023D0")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private int levels;

	// Token: 0x04002CE7 RID: 11495
	[Token(Token = "0x40023D1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ByteMap[] values;

	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x2000C0A")]
	public struct Element
	{
		// Token: 0x06003007 RID: 12295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE5")]
		[Address(RVA = "0xEF650", Offset = "0xEEA50", VA = "0x1800EF650")]
		public Element(ByteQuadtree source, int x, int y, int level)
		{
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x000147D8 File Offset: 0x000129D8
		[Token(Token = "0x17000743")]
		public bool IsLeaf
		{
			[Token(Token = "0x6004EE6")]
			[Address(RVA = "0xEF780", Offset = "0xEEB80", VA = "0x1800EF780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x000147F0 File Offset: 0x000129F0
		[Token(Token = "0x17000744")]
		public bool IsRoot
		{
			[Token(Token = "0x6004EE7")]
			[Address(RVA = "0xEF790", Offset = "0xEEB90", VA = "0x1800EF790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x00014808 File Offset: 0x00012A08
		[Token(Token = "0x17000745")]
		public int ByteMap
		{
			[Token(Token = "0x6004EE8")]
			[Address(RVA = "0xEDEE0", Offset = "0xED2E0", VA = "0x1800EDEE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x17000746")]
		public uint Value
		{
			[Token(Token = "0x6004EE9")]
			[Address(RVA = "0xEF8D0", Offset = "0xEECD0", VA = "0x1800EF8D0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x00014838 File Offset: 0x00012A38
		[Token(Token = "0x17000747")]
		public Vector2 Coords
		{
			[Token(Token = "0x6004EEA")]
			[Address(RVA = "0xEF720", Offset = "0xEEB20", VA = "0x1800EF720")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x17000748")]
		public int Depth
		{
			[Token(Token = "0x6004EEB")]
			[Address(RVA = "0xEF760", Offset = "0xEEB60", VA = "0x1800EF760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x00014868 File Offset: 0x00012A68
		[Token(Token = "0x17000749")]
		public ByteQuadtree.Element Parent
		{
			[Token(Token = "0x6004EEC")]
			[Address(RVA = "0xEF7E0", Offset = "0xEEBE0", VA = "0x1800EF7E0")]
			get
			{
				return default(ByteQuadtree.Element);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x00014880 File Offset: 0x00012A80
		[Token(Token = "0x1700074A")]
		public ByteQuadtree.Element Child1
		{
			[Token(Token = "0x6004EED")]
			[Address(RVA = "0xEF6A0", Offset = "0xEEAA0", VA = "0x1800EF6A0")]
			get
			{
				return default(ByteQuadtree.Element);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06003010 RID: 12304 RVA: 0x00014898 File Offset: 0x00012A98
		[Token(Token = "0x1700074B")]
		public ByteQuadtree.Element Child2
		{
			[Token(Token = "0x6004EEE")]
			[Address(RVA = "0xEF6C0", Offset = "0xEEAC0", VA = "0x1800EF6C0")]
			get
			{
				return default(ByteQuadtree.Element);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x000148B0 File Offset: 0x00012AB0
		[Token(Token = "0x1700074C")]
		public ByteQuadtree.Element Child3
		{
			[Token(Token = "0x6004EEF")]
			[Address(RVA = "0xEF6E0", Offset = "0xEEAE0", VA = "0x1800EF6E0")]
			get
			{
				return default(ByteQuadtree.Element);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x000148C8 File Offset: 0x00012AC8
		[Token(Token = "0x1700074D")]
		public ByteQuadtree.Element Child4
		{
			[Token(Token = "0x6004EF0")]
			[Address(RVA = "0xEF700", Offset = "0xEEB00", VA = "0x1800EF700")]
			get
			{
				return default(ByteQuadtree.Element);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x000148E0 File Offset: 0x00012AE0
		[Token(Token = "0x1700074E")]
		public ByteQuadtree.Element MaxChild
		{
			[Token(Token = "0x6004EF1")]
			[Address(RVA = "0xEF7C0", Offset = "0xEEBC0", VA = "0x1800EF7C0")]
			get
			{
				return default(ByteQuadtree.Element);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x000148F8 File Offset: 0x00012AF8
		[Token(Token = "0x1700074F")]
		public ByteQuadtree.Element RandChild
		{
			[Token(Token = "0x6004EF2")]
			[Address(RVA = "0xEF8B0", Offset = "0xEECB0", VA = "0x1800EF8B0")]
			get
			{
				return default(ByteQuadtree.Element);
			}
		}

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4004613")]
		[FieldOffset(Offset = "0x0")]
		private ByteQuadtree source;

		// Token: 0x04002CE9 RID: 11497
		[Token(Token = "0x4004614")]
		[FieldOffset(Offset = "0x8")]
		private int x;

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4004615")]
		[FieldOffset(Offset = "0xC")]
		private int y;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4004616")]
		[FieldOffset(Offset = "0x10")]
		private int level;
	}
}
