using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Facepunch;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005C2 RID: 1474
[Token(Token = "0x2000453")]
public class Bootstrap : SingletonComponent<Bootstrap>
{
	// Token: 0x17000343 RID: 835
	// (get) Token: 0x06002937 RID: 10551 RVA: 0x00011EC8 File Offset: 0x000100C8
	[Token(Token = "0x17000308")]
	public static bool needsSetup
	{
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x4653C0", Offset = "0x4641C0", VA = "0x1804653C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x06002938 RID: 10552 RVA: 0x00011EE0 File Offset: 0x000100E0
	[Token(Token = "0x17000309")]
	public static bool isPresent
	{
		[Token(Token = "0x6002299")]
		[Address(RVA = "0x465320", Offset = "0x464120", VA = "0x180465320")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229A")]
	[Address(RVA = "0x464B70", Offset = "0x463970", VA = "0x180464B70")]
	public static void RunDefaults()
	{
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229B")]
	[Address(RVA = "0x463F00", Offset = "0x462D00", VA = "0x180463F00")]
	public static void Init_Tier0()
	{
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229C")]
	[Address(RVA = "0x463A20", Offset = "0x462820", VA = "0x180463A20")]
	public static void Init_Systems()
	{
	}

	// Token: 0x0600293C RID: 10556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229D")]
	[Address(RVA = "0x4638E0", Offset = "0x4626E0", VA = "0x1804638E0")]
	public static void Init_Config()
	{
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229E")]
	[Address(RVA = "0x464AC0", Offset = "0x4638C0", VA = "0x180464AC0")]
	public static void NetworkInitRaknet()
	{
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229F")]
	[Address(RVA = "0x464B10", Offset = "0x463910", VA = "0x180464B10")]
	public static void NetworkInitSteamworks(bool enableSteamDatagramRelay)
	{
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A0")]
	[Address(RVA = "0x464FD0", Offset = "0x463DD0", VA = "0x180464FD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x70210", Offset = "0x6F610")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A1")]
	[Address(RVA = "0x4648D0", Offset = "0x4636D0", VA = "0x1804648D0")]
	public static GameObject LoadEngineUI()
	{
		return null;
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A2")]
	[Address(RVA = "0x464950", Offset = "0x463750", VA = "0x180464950")]
	public static GameObject LoadGameUI()
	{
		return null;
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x4649D0", Offset = "0x4637D0", VA = "0x1804649D0")]
	public static GameObject LoadMenuUI()
	{
		return null;
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x464790", Offset = "0x463590", VA = "0x180464790")]
	private static GameObject InstantiatePrefabPersistent(string path)
	{
		return null;
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x465130", Offset = "0x463F30", VA = "0x180465130")]
	public static void ToggleUIHack()
	{
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x464CC0", Offset = "0x463AC0", VA = "0x180464CC0")]
	public static void SetUIVisible(bool visible)
	{
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x4637F0", Offset = "0x4625F0", VA = "0x1804637F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x70340", Offset = "0x6F740")]
	private IEnumerator ClientStartup()
	{
		return null;
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A8")]
	[Address(RVA = "0x465190", Offset = "0x463F90", VA = "0x180465190")]
	protected void Update()
	{
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x465040", Offset = "0x463E40", VA = "0x180465040")]
	private void StartupShared()
	{
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x465050", Offset = "0x463E50", VA = "0x180465050")]
	public void ThrowError(string error)
	{
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x463860", Offset = "0x462660", VA = "0x180463860")]
	public void ExitGame()
	{
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x464A50", Offset = "0x463850", VA = "0x180464A50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x70470", Offset = "0x6F870")]
	public static IEnumerator LoadingUpdate(string str)
	{
		return null;
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x465210", Offset = "0x464010", VA = "0x180465210")]
	public static void WriteToLog(string str)
	{
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x4652B0", Offset = "0x4640B0", VA = "0x1804652B0")]
	public Bootstrap()
	{
	}

	// Token: 0x040024C5 RID: 9413
	[Token(Token = "0x4001E21")]
	[FieldOffset(Offset = "0x0")]
	internal static bool bootstrapInitRun;

	// Token: 0x040024C6 RID: 9414
	[Token(Token = "0x4001E22")]
	[FieldOffset(Offset = "0x1")]
	public static bool isErrored;

	// Token: 0x040024C7 RID: 9415
	[Token(Token = "0x4001E23")]
	[FieldOffset(Offset = "0x18")]
	public string messageString;

	// Token: 0x040024C8 RID: 9416
	[Token(Token = "0x4001E24")]
	[FieldOffset(Offset = "0x20")]
	public CanvasGroup BootstrapUiCanvas;

	// Token: 0x040024C9 RID: 9417
	[Token(Token = "0x4001E25")]
	[FieldOffset(Offset = "0x28")]
	public GameObject errorPanel;

	// Token: 0x040024CA RID: 9418
	[Token(Token = "0x4001E26")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI errorText;

	// Token: 0x040024CB RID: 9419
	[Token(Token = "0x4001E27")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI statusText;

	// Token: 0x040024CC RID: 9420
	[Token(Token = "0x4001E28")]
	[FieldOffset(Offset = "0x40")]
	private TimeSince timeSinceVisible;

	// Token: 0x040024CD RID: 9421
	[Token(Token = "0x4001E29")]
	[FieldOffset(Offset = "0x8")]
	private static GameObject _engineUi;

	// Token: 0x040024CE RID: 9422
	[Token(Token = "0x4001E2A")]
	[FieldOffset(Offset = "0x10")]
	private static GameObject _gameUi;

	// Token: 0x040024CF RID: 9423
	[Token(Token = "0x4001E2B")]
	[FieldOffset(Offset = "0x18")]
	private static GameObject _menuUi;

	// Token: 0x040024D0 RID: 9424
	[Token(Token = "0x4001E2C")]
	[FieldOffset(Offset = "0x20")]
	private static string lastWrittenValue;

	// Token: 0x020005C3 RID: 1475
	[Token(Token = "0x2000BA2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x4766D0", Offset = "0x4754D0", VA = "0x1804766D0")]
		internal GameObject <Init_Tier0>b__13_0(string str)
		{
			return null;
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x476750", Offset = "0x475550", VA = "0x180476750")]
		internal void <Init_Tier0>b__13_1()
		{
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x6004E1F")]
		[Address(RVA = "0x476760", Offset = "0x475560", VA = "0x180476760")]
		internal bool <Init_Tier0>b__13_2()
		{
			return default(bool);
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00011F10 File Offset: 0x00010110
		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x476680", Offset = "0x475480", VA = "0x180476680")]
		internal int <Init_Systems>b__14_0()
		{
			return 0;
		}

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40043AE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Bootstrap.<>c <>9;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40043AF")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, GameObject> <>9__13_0;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40043B0")]
		[FieldOffset(Offset = "0x10")]
		public static Action <>9__13_1;

		// Token: 0x040024D4 RID: 9428
		[Token(Token = "0x40043B1")]
		[FieldOffset(Offset = "0x18")]
		public static Func<bool> <>9__13_2;

		// Token: 0x040024D5 RID: 9429
		[Token(Token = "0x40043B2")]
		[FieldOffset(Offset = "0x20")]
		public static Func<int> <>9__14_0;
	}

	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x2000BA3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <Start>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002955 RID: 10581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E21")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <Start>d__18(int <>1__state)
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0x4763D0", Offset = "0x4751D0", VA = "0x1804763D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00011F28 File Offset: 0x00010128
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x475120", Offset = "0x473F20", VA = "0x180475120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x476590", Offset = "0x475390", VA = "0x180476590")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x4765E0", Offset = "0x4753E0", VA = "0x1804765E0")]
		private void <>m__Finally2()
		{
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E26")]
		[Address(RVA = "0x476630", Offset = "0x475430", VA = "0x180476630")]
		private void <>m__Finally3()
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000726")]
		private object Current
		{
			[Token(Token = "0x6004E27")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E28")]
		[Address(RVA = "0x476380", Offset = "0x475180", VA = "0x180476380", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000727")]
		private object Current
		{
			[Token(Token = "0x6004E29")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040024D6 RID: 9430
		[Token(Token = "0x40043B3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040024D7 RID: 9431
		[Token(Token = "0x40043B4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040024D8 RID: 9432
		[Token(Token = "0x40043B5")]
		[FieldOffset(Offset = "0x20")]
		public Bootstrap <>4__this;

		// Token: 0x040024D9 RID: 9433
		[Token(Token = "0x40043B6")]
		[FieldOffset(Offset = "0x28")]
		private BenchmarkTimer <timer>5__2;

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40043B7")]
		[FieldOffset(Offset = "0x30")]
		private AssetBundleBackend <newBackend>5__3;

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40043B8")]
		[FieldOffset(Offset = "0x38")]
		private BenchmarkTimer <>7__wrap3;
	}

	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x2000BA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <ClientStartup>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600295E RID: 10590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2A")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <ClientStartup>d__28(int <>1__state)
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0x472250", Offset = "0x471050", VA = "0x180472250", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00011F40 File Offset: 0x00010140
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x470A80", Offset = "0x46F880", VA = "0x180470A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x472410", Offset = "0x471210", VA = "0x180472410")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0x472460", Offset = "0x471260", VA = "0x180472460")]
		private void <>m__Finally2()
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x4724B0", Offset = "0x4712B0", VA = "0x1804724B0")]
		private void <>m__Finally3()
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x472500", Offset = "0x471300", VA = "0x180472500")]
		private void <>m__Finally4()
		{
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000728")]
		private object Current
		{
			[Token(Token = "0x6004E31")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x472200", Offset = "0x471000", VA = "0x180472200", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000729")]
		private object Current
		{
			[Token(Token = "0x6004E33")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40043B9")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040024DD RID: 9437
		[Token(Token = "0x40043BA")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40043BB")]
		[FieldOffset(Offset = "0x20")]
		public Bootstrap <>4__this;

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40043BC")]
		[FieldOffset(Offset = "0x28")]
		private BenchmarkTimer <>7__wrap1;

		// Token: 0x040024E0 RID: 9440
		[Token(Token = "0x40043BD")]
		[FieldOffset(Offset = "0x30")]
		private AsyncOperation <op>5__3;
	}

	// Token: 0x020005C6 RID: 1478
	[Token(Token = "0x2000BA5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <LoadingUpdate>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E34")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <LoadingUpdate>d__33(int <>1__state)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E35")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00011F58 File Offset: 0x00010158
		[Token(Token = "0x6004E36")]
		[Address(RVA = "0x472550", Offset = "0x471350", VA = "0x180472550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072A")]
		private object Current
		{
			[Token(Token = "0x6004E37")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E38")]
		[Address(RVA = "0x472700", Offset = "0x471500", VA = "0x180472700", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072B")]
		private object Current
		{
			[Token(Token = "0x6004E39")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040024E1 RID: 9441
		[Token(Token = "0x40043BE")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040024E2 RID: 9442
		[Token(Token = "0x40043BF")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40043C0")]
		[FieldOffset(Offset = "0x20")]
		public string str;
	}
}
