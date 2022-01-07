using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000BE3 RID: 3043
[Token(Token = "0x200088A")]
[Attribute(Name = "RequireComponent", RVA = "0x85EC0", Offset = "0x852C0")]
[Attribute(Name = "RequireComponent", RVA = "0x85EC0", Offset = "0x852C0")]
[Attribute(Name = "RequireComponent", RVA = "0x85EC0", Offset = "0x852C0")]
public class CoverageQueries : MonoBehaviour
{
	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x06004638 RID: 17976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A4")]
	public static CoverageQueries Instance
	{
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x6D6540", Offset = "0x6D5340", VA = "0x1806D6540")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x06004639 RID: 17977 RVA: 0x00019F80 File Offset: 0x00018180
	[Token(Token = "0x170004A5")]
	public static bool Supported
	{
		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x6D65A0", Offset = "0x6D53A0", VA = "0x1806D65A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x0600463A RID: 17978 RVA: 0x00019F98 File Offset: 0x00018198
	// (set) Token: 0x0600463B RID: 17979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004A6")]
	public static bool DebugShow
	{
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x6D64E0", Offset = "0x6D52E0", VA = "0x1806D64E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x6D65B0", Offset = "0x6D53B0", VA = "0x1806D65B0")]
		set
		{
		}
	}

	// Token: 0x0600463C RID: 17980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B76")]
	[Address(RVA = "0x6D4260", Offset = "0x6D3060", VA = "0x1806D4260")]
	private void Awake()
	{
	}

	// Token: 0x0600463D RID: 17981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B77")]
	[Address(RVA = "0x6D4B40", Offset = "0x6D3940", VA = "0x1806D4B40")]
	private void OnEnable()
	{
	}

	// Token: 0x0600463E RID: 17982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B78")]
	[Address(RVA = "0x6D4A50", Offset = "0x6D3850", VA = "0x1806D4A50")]
	private void OnDisable()
	{
	}

	// Token: 0x0600463F RID: 17983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B79")]
	[Address(RVA = "0x6D6230", Offset = "0x6D5030", VA = "0x1806D6230")]
	private void Update()
	{
	}

	// Token: 0x06004640 RID: 17984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7A")]
	[Address(RVA = "0x6D4CD0", Offset = "0x6D3AD0", VA = "0x1806D4CD0")]
	private void OnPostRender()
	{
	}

	// Token: 0x06004641 RID: 17985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7B")]
	[Address(RVA = "0x6D58D0", Offset = "0x6D46D0", VA = "0x1806D58D0")]
	private void UpdateCollection()
	{
	}

	// Token: 0x06004642 RID: 17986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7C")]
	[Address(RVA = "0x6D4DF0", Offset = "0x6D3BF0", VA = "0x1806D4DF0")]
	private void PrepareAndDispatch()
	{
	}

	// Token: 0x06004643 RID: 17987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7D")]
	[Address(RVA = "0x6D4930", Offset = "0x6D3730", VA = "0x1806D4930")]
	private void IssueRead()
	{
	}

	// Token: 0x06004644 RID: 17988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7E")]
	[Address(RVA = "0x6D42F0", Offset = "0x6D30F0", VA = "0x1806D42F0")]
	private void FetchAndAnalyseResults()
	{
	}

	// Token: 0x06004645 RID: 17989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7F")]
	[Address(RVA = "0x6D5670", Offset = "0x6D4470", VA = "0x1806D5670")]
	public static void RegisterQuery(CoverageQueries.Query query)
	{
	}

	// Token: 0x06004646 RID: 17990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B80")]
	[Address(RVA = "0x6D5810", Offset = "0x6D4610", VA = "0x1806D5810")]
	public static void UnregisterQuery(CoverageQueries.Query query)
	{
	}

	// Token: 0x06004647 RID: 17991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B81")]
	[Address(RVA = "0x6D6170", Offset = "0x6D4F70", VA = "0x1806D6170")]
	public static void UpdateQuery(CoverageQueries.Query query)
	{
	}

	// Token: 0x06004648 RID: 17992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B82")]
	[Address(RVA = "0x6D64D0", Offset = "0x6D52D0", VA = "0x1806D64D0")]
	public CoverageQueries()
	{
	}

	// Token: 0x0400430F RID: 17167
	[Token(Token = "0x400339C")]
	[FieldOffset(Offset = "0x18")]
	public bool debug;

	// Token: 0x04004310 RID: 17168
	[Token(Token = "0x400339D")]
	[FieldOffset(Offset = "0x1C")]
	public float depthBias;

	// Token: 0x04004311 RID: 17169
	[Token(Token = "0x400339E")]
	[FieldOffset(Offset = "0x0")]
	private static List<CoverageQueries.Query> pool;

	// Token: 0x04004312 RID: 17170
	[Token(Token = "0x400339F")]
	[FieldOffset(Offset = "0x8")]
	private static List<CoverageQueries.Query> added;

	// Token: 0x04004313 RID: 17171
	[Token(Token = "0x40033A0")]
	[FieldOffset(Offset = "0x10")]
	private static List<CoverageQueries.Query> reused;

	// Token: 0x04004314 RID: 17172
	[Token(Token = "0x40033A1")]
	[FieldOffset(Offset = "0x18")]
	private static List<int> removed;

	// Token: 0x04004315 RID: 17173
	[Token(Token = "0x40033A2")]
	[FieldOffset(Offset = "0x20")]
	private static List<int> changed;

	// Token: 0x04004316 RID: 17174
	[Token(Token = "0x40033A3")]
	[FieldOffset(Offset = "0x28")]
	private static Queue<int> freed;

	// Token: 0x04004317 RID: 17175
	[Token(Token = "0x40033A4")]
	[FieldOffset(Offset = "0x30")]
	private static CoverageQueries.BufferSet buffer;

	// Token: 0x04004318 RID: 17176
	[Token(Token = "0x40033A5")]
	[FieldOffset(Offset = "0x20")]
	private Camera camera;

	// Token: 0x04004319 RID: 17177
	[Token(Token = "0x40033A6")]
	[FieldOffset(Offset = "0x28")]
	private Material coverageMat;

	// Token: 0x0400431A RID: 17178
	[Token(Token = "0x40033A7")]
	[FieldOffset(Offset = "0x38")]
	private static CoverageQueries instance;

	// Token: 0x0400431B RID: 17179
	[Token(Token = "0x40033A8")]
	[FieldOffset(Offset = "0x40")]
	private static bool _debugShow;

	// Token: 0x02000BE4 RID: 3044
	[Token(Token = "0x2000D81")]
	public class BufferSet
	{
		// Token: 0x0600464A RID: 17994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523B")]
		[Address(RVA = "0x487CA0", Offset = "0x486AA0", VA = "0x180487CA0")]
		public void Attach(Material coverageMat)
		{
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523C")]
		[Address(RVA = "0x6C5080", Offset = "0x6C3E80", VA = "0x1806C5080")]
		public void Dispose(bool data = true)
		{
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00019FB0 File Offset: 0x000181B0
		[Token(Token = "0x600523D")]
		[Address(RVA = "0x6C4C80", Offset = "0x6C3A80", VA = "0x1806C4C80")]
		public bool CheckResize(int count)
		{
			return default(bool);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523E")]
		[Address(RVA = "0x6C53F0", Offset = "0x6C41F0", VA = "0x1806C53F0")]
		public void UploadData()
		{
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523F")]
		[Address(RVA = "0x6C4F90", Offset = "0x6C3D90", VA = "0x1806C4F90")]
		public void Dispatch(int count)
		{
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005240")]
		[Address(RVA = "0x6C5360", Offset = "0x6C4160", VA = "0x1806C5360")]
		public void IssueRead()
		{
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005241")]
		[Address(RVA = "0x6C5210", Offset = "0x6C4010", VA = "0x1806C5210")]
		public void GetResults()
		{
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005242")]
		[Address(RVA = "0x6C5440", Offset = "0x6C4240", VA = "0x1806C5440")]
		public BufferSet()
		{
		}

		// Token: 0x0400431C RID: 17180
		[Token(Token = "0x4004C58")]
		[FieldOffset(Offset = "0x10")]
		public int width;

		// Token: 0x0400431D RID: 17181
		[Token(Token = "0x4004C59")]
		[FieldOffset(Offset = "0x14")]
		public int height;

		// Token: 0x0400431E RID: 17182
		[Token(Token = "0x4004C5A")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D inputTexture;

		// Token: 0x0400431F RID: 17183
		[Token(Token = "0x4004C5B")]
		[FieldOffset(Offset = "0x20")]
		public RenderTexture resultTexture;

		// Token: 0x04004320 RID: 17184
		[Token(Token = "0x4004C5C")]
		[FieldOffset(Offset = "0x28")]
		public Color[] inputData;

		// Token: 0x04004321 RID: 17185
		[Token(Token = "0x4004C5D")]
		[FieldOffset(Offset = "0x30")]
		public Color32[] resultData;

		// Token: 0x04004322 RID: 17186
		[Token(Token = "0x4004C5E")]
		[FieldOffset(Offset = "0x38")]
		private Material coverageMat;

		// Token: 0x04004323 RID: 17187
		[Token(Token = "0x4004C5F")]
		private const int MaxAsyncGPUReadbackRequests = 10;

		// Token: 0x04004324 RID: 17188
		[Token(Token = "0x4004C60")]
		[FieldOffset(Offset = "0x40")]
		private Queue<AsyncGPUReadbackRequest> asyncRequests;
	}

	// Token: 0x02000BE5 RID: 3045
	[Token(Token = "0x2000D82")]
	public enum RadiusSpace
	{
		// Token: 0x04004326 RID: 17190
		[Token(Token = "0x4004C62")]
		ScreenNormalized,
		// Token: 0x04004327 RID: 17191
		[Token(Token = "0x4004C63")]
		World
	}

	// Token: 0x02000BE6 RID: 3046
	[Token(Token = "0x2000D83")]
	public class Query
	{
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06004652 RID: 18002 RVA: 0x00019FC8 File Offset: 0x000181C8
		[Token(Token = "0x170007B4")]
		public bool IsRegistered
		{
			[Token(Token = "0x6005243")]
			[Address(RVA = "0x6DF670", Offset = "0x6DE470", VA = "0x1806DF670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005244")]
		[Address(RVA = "0x6DF300", Offset = "0x6DE100", VA = "0x1806DF300")]
		private void Reset()
		{
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005245")]
		[Address(RVA = "0x6DF5A0", Offset = "0x6DE3A0", VA = "0x1806DF5A0")]
		public Query()
		{
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005246")]
		[Address(RVA = "0x6DF5E0", Offset = "0x6DE3E0", VA = "0x1806DF5E0")]
		public Query(Vector3 position, CoverageQueries.RadiusSpace radiusSpace, float radius, int sampleCount, float smoothingSpeed = 15f)
		{
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005247")]
		[Address(RVA = "0x6DF2A0", Offset = "0x6DE0A0", VA = "0x1806DF2A0")]
		public void Register()
		{
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005248")]
		[Address(RVA = "0x6DF510", Offset = "0x6DE310", VA = "0x1806DF510")]
		public void Update(Vector3 position, float radius)
		{
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005249")]
		[Address(RVA = "0x6DF430", Offset = "0x6DE230", VA = "0x1806DF430")]
		public void UpdatePosition(Vector3 position)
		{
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524A")]
		[Address(RVA = "0x6DF4A0", Offset = "0x6DE2A0", VA = "0x1806DF4A0")]
		public void UpdateRadius(float radius)
		{
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524B")]
		[Address(RVA = "0x6DF330", Offset = "0x6DE130", VA = "0x1806DF330")]
		public void Unregister()
		{
		}

		// Token: 0x04004328 RID: 17192
		[Token(Token = "0x4004C64")]
		[FieldOffset(Offset = "0x10")]
		public CoverageQueries.Query.Input input;

		// Token: 0x04004329 RID: 17193
		[Token(Token = "0x4004C65")]
		[FieldOffset(Offset = "0x2C")]
		public CoverageQueries.Query.Internal intern;

		// Token: 0x0400432A RID: 17194
		[Token(Token = "0x4004C66")]
		[FieldOffset(Offset = "0x30")]
		public CoverageQueries.Query.Result result;

		// Token: 0x02000BE7 RID: 3047
		[Token(Token = "0x2000E77")]
		public struct Input
		{
			// Token: 0x0400432B RID: 17195
			[Token(Token = "0x4005042")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x0400432C RID: 17196
			[Token(Token = "0x4005043")]
			[FieldOffset(Offset = "0xC")]
			public CoverageQueries.RadiusSpace radiusSpace;

			// Token: 0x0400432D RID: 17197
			[Token(Token = "0x4005044")]
			[FieldOffset(Offset = "0x10")]
			public float radius;

			// Token: 0x0400432E RID: 17198
			[Token(Token = "0x4005045")]
			[FieldOffset(Offset = "0x14")]
			public int sampleCount;

			// Token: 0x0400432F RID: 17199
			[Token(Token = "0x4005046")]
			[FieldOffset(Offset = "0x18")]
			public float smoothingSpeed;
		}

		// Token: 0x02000BE8 RID: 3048
		[Token(Token = "0x2000E78")]
		public struct Internal
		{
			// Token: 0x0600465B RID: 18011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005419")]
			[Address(RVA = "0xF0E60", Offset = "0xF0260", VA = "0x1800F0E60")]
			public void Reset()
			{
			}

			// Token: 0x04004330 RID: 17200
			[Token(Token = "0x4005047")]
			[FieldOffset(Offset = "0x0")]
			public int id;
		}

		// Token: 0x02000BE9 RID: 3049
		[Token(Token = "0x2000E79")]
		public struct Result
		{
			// Token: 0x0600465C RID: 18012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600541A")]
			[Address(RVA = "0xF0E70", Offset = "0xF0270", VA = "0x1800F0E70")]
			public void Reset()
			{
			}

			// Token: 0x04004331 RID: 17201
			[Token(Token = "0x4005048")]
			[FieldOffset(Offset = "0x0")]
			public int passed;

			// Token: 0x04004332 RID: 17202
			[Token(Token = "0x4005049")]
			[FieldOffset(Offset = "0x4")]
			public float coverage;

			// Token: 0x04004333 RID: 17203
			[Token(Token = "0x400504A")]
			[FieldOffset(Offset = "0x8")]
			public float smoothCoverage;

			// Token: 0x04004334 RID: 17204
			[Token(Token = "0x400504B")]
			[FieldOffset(Offset = "0xC")]
			public float weightedCoverage;

			// Token: 0x04004335 RID: 17205
			[Token(Token = "0x400504C")]
			[FieldOffset(Offset = "0x10")]
			public float weightedSmoothCoverage;

			// Token: 0x04004336 RID: 17206
			[Token(Token = "0x400504D")]
			[FieldOffset(Offset = "0x14")]
			public bool originOccluded;

			// Token: 0x04004337 RID: 17207
			[Token(Token = "0x400504E")]
			[FieldOffset(Offset = "0x18")]
			public int frame;

			// Token: 0x04004338 RID: 17208
			[Token(Token = "0x400504F")]
			[FieldOffset(Offset = "0x1C")]
			public float originVisibility;

			// Token: 0x04004339 RID: 17209
			[Token(Token = "0x4005050")]
			[FieldOffset(Offset = "0x20")]
			public float originSmoothVisibility;
		}
	}
}
