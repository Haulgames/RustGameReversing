using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000374 RID: 884
[Token(Token = "0x2000277")]
public class DemoShotRecorder : SingletonComponent<DemoShotRecorder>
{
	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06001E1A RID: 7706 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
	// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000205")]
	public RealTimeUntil CountdownEnds
	{
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x679AC0", Offset = "0x6788C0", VA = "0x180679AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(RealTimeUntil);
		}
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x844F80", Offset = "0x843D80", VA = "0x180844F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0000E610 File Offset: 0x0000C810
	[Token(Token = "0x17000206")]
	public bool IsInCountdown
	{
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x8D3BC0", Offset = "0x8D29C0", VA = "0x1808D3BC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x8D1C60", Offset = "0x8D0A60", VA = "0x1808D1C60")]
	public static void CreateNewShot(string shotName, DemoShotRecorder.RecorderSettings withSettings)
	{
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06001E1E RID: 7710 RVA: 0x0000E628 File Offset: 0x0000C828
	[Token(Token = "0x17000207")]
	public float CurrentShotTime
	{
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x8D3B30", Offset = "0x8D2930", VA = "0x1808D3B30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06001E1F RID: 7711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000208")]
	public string CurrentShotName
	{
		[Token(Token = "0x6001854")]
		[Address(RVA = "0x8D3B10", Offset = "0x8D2910", VA = "0x1808D3B10")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0000E640 File Offset: 0x0000C840
	[Token(Token = "0x17000209")]
	public float ShotStartTime
	{
		[Token(Token = "0x6001855")]
		[Address(RVA = "0x8D3BE0", Offset = "0x8D29E0", VA = "0x1808D3BE0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001856")]
	[Address(RVA = "0x8D38F0", Offset = "0x8D26F0", VA = "0x1808D38F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xB44A0", Offset = "0xB38A0")]
	private IEnumerator StartRecording(string shotName, DemoShotRecorder.RecorderSettings withSettings)
	{
		return null;
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001857")]
	[Address(RVA = "0x8D1BF0", Offset = "0x8D09F0", VA = "0x1808D1BF0")]
	public void CancelRecording()
	{
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001858")]
	[Address(RVA = "0x8D1DA0", Offset = "0x8D0BA0", VA = "0x1808D1DA0")]
	public void FinishRecording()
	{
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001859")]
	[Address(RVA = "0x8D29D0", Offset = "0x8D17D0", VA = "0x1808D29D0")]
	public static string GetShotDirectory(string demoName, bool createDirectory = false)
	{
		return null;
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600185A")]
	[Address(RVA = "0x8D2460", Offset = "0x8D1260", VA = "0x1808D2460")]
	public static string GetFilePath(string shotName, string demoName, string folderName, bool createDirectory = false)
	{
		return null;
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600185B")]
	[Address(RVA = "0x8D2550", Offset = "0x8D1350", VA = "0x1808D2550")]
	public static Dictionary<string, List<string>> GetPathsOfAllShots(string demoName)
	{
		return null;
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x0000E658 File Offset: 0x0000C858
	[Token(Token = "0x600185C")]
	[Address(RVA = "0x8D3710", Offset = "0x8D2510", VA = "0x1808D3710")]
	private static int SortWithTrailingNumber(string x, string y)
	{
		return 0;
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600185D")]
	[Address(RVA = "0x8D2AD0", Offset = "0x8D18D0", VA = "0x1808D2AD0")]
	public static string GetTrailingFolder(string path)
	{
		return null;
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600185E")]
	[Address(RVA = "0x8D39A0", Offset = "0x8D27A0", VA = "0x1808D39A0")]
	private void Update()
	{
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600185F")]
	[Address(RVA = "0x8D2D10", Offset = "0x8D1B10", VA = "0x1808D2D10")]
	private void RecordCameraState()
	{
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001860")]
	[Address(RVA = "0x8D3480", Offset = "0x8D2280", VA = "0x1808D3480")]
	private void RecordKeyframe(Vector3 value, DemoShotVectorTrack track)
	{
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001861")]
	[Address(RVA = "0x8D3280", Offset = "0x8D2080", VA = "0x1808D3280")]
	private void RecordKeyframe(float value, DemoShotFloatTrack track)
	{
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001862")]
	[Address(RVA = "0x8D2FB0", Offset = "0x8D1DB0", VA = "0x1808D2FB0")]
	private void RecordKeyframe(Quaternion value, DemoShotQuaternionTrack track)
	{
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001863")]
	[Address(RVA = "0x8D2C90", Offset = "0x8D1A90", VA = "0x1808D2C90")]
	private DemoShotVectorTrack InitialiseKeyframeVectorTrack()
	{
		return null;
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001864")]
	[Address(RVA = "0x8D2C10", Offset = "0x8D1A10", VA = "0x1808D2C10")]
	private DemoShotQuaternionTrack InitialiseKeyframeQuaternionTrack()
	{
		return null;
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001865")]
	[Address(RVA = "0x8D2B90", Offset = "0x8D1990", VA = "0x1808D2B90")]
	private DemoShotFloatTrack InitialiseKeyframeFloatTrack()
	{
		return null;
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001866")]
	[Address(RVA = "0x8D3AB0", Offset = "0x8D28B0", VA = "0x1808D3AB0")]
	public DemoShotRecorder()
	{
	}

	// Token: 0x04001903 RID: 6403
	[Token(Token = "0x4001457")]
	[FieldOffset(Offset = "0x18")]
	private DemoShot recordingShot;

	// Token: 0x04001904 RID: 6404
	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0x20")]
	private float lastKeyframe;

	// Token: 0x04001905 RID: 6405
	[Token(Token = "0x4001459")]
	[FieldOffset(Offset = "0x24")]
	private bool hasStarted;

	// Token: 0x04001906 RID: 6406
	[Token(Token = "0x400145A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private RealTimeUntil <CountdownEnds>k__BackingField;

	// Token: 0x04001907 RID: 6407
	[Token(Token = "0x400145B")]
	public const float CountdownDuration = 3f;

	// Token: 0x04001908 RID: 6408
	[Token(Token = "0x400145C")]
	[FieldOffset(Offset = "0x2C")]
	private CameraMan.CameraState startSettings;

	// Token: 0x04001909 RID: 6409
	[Token(Token = "0x400145D")]
	[FieldOffset(Offset = "0x50")]
	private DemoShotRecorder.RecorderSettings settings;

	// Token: 0x0400190A RID: 6410
	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0x0")]
	public static string lastSavedShotName;

	// Token: 0x0400190B RID: 6411
	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x68")]
	private string preRecordShotName;

	// Token: 0x0400190C RID: 6412
	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0x70")]
	private float countdownStartTime;

	// Token: 0x02000375 RID: 885
	[Token(Token = "0x2000B32")]
	public struct RecorderSettings
	{
		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x40041C2")]
		[FieldOffset(Offset = "0x0")]
		public bool Countdown;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x40041C3")]
		[FieldOffset(Offset = "0x1")]
		public bool PauseOnSave;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x40041C4")]
		[FieldOffset(Offset = "0x2")]
		public bool ReturnToShotStart;

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x40041C5")]
		[FieldOffset(Offset = "0x8")]
		public string FolderName;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x40041C6")]
		[FieldOffset(Offset = "0x10")]
		public bool RecordDof;
	}

	// Token: 0x02000376 RID: 886
	[Token(Token = "0x2000B33")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <StartRecording>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001E33 RID: 7731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D49")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <StartRecording>d__23(int <>1__state)
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4A")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0x8D5FE0", Offset = "0x8D4DE0", VA = "0x1808D5FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070D")]
		private object Current
		{
			[Token(Token = "0x6004D4C")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4D")]
		[Address(RVA = "0x8D67E0", Offset = "0x8D55E0", VA = "0x1808D67E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070E")]
		private object Current
		{
			[Token(Token = "0x6004D4E")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x40041C7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x40041C8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x40041C9")]
		[FieldOffset(Offset = "0x20")]
		public DemoShotRecorder <>4__this;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x40041CA")]
		[FieldOffset(Offset = "0x28")]
		public DemoShotRecorder.RecorderSettings withSettings;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x40041CB")]
		[FieldOffset(Offset = "0x40")]
		public string shotName;

		// Token: 0x04001917 RID: 6423
		[Token(Token = "0x40041CC")]
		[FieldOffset(Offset = "0x48")]
		private float <waitTime>5__2;

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x40041CD")]
		[FieldOffset(Offset = "0x4C")]
		private float <leftover>5__3;
	}
}
