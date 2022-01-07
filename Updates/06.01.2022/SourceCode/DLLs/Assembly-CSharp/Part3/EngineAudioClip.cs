using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B7 RID: 695
[Token(Token = "0x20001EA")]
public class EngineAudioClip : MonoBehaviour, IClientComponent
{
	// Token: 0x06001A3F RID: 6719 RVA: 0x0000D200 File Offset: 0x0000B400
	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x991120", Offset = "0x98FF20", VA = "0x180991120")]
	private int GetBucketRPM(int RPM)
	{
		return 0;
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x990F90", Offset = "0x98FD90", VA = "0x180990F90")]
	private void Awake()
	{
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CD")]
	[Address(RVA = "0x991BC0", Offset = "0x9909C0", VA = "0x180991BC0")]
	private void Update()
	{
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x991AA0", Offset = "0x9908A0", VA = "0x180991AA0")]
	private void UpdateRPM()
	{
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x991190", Offset = "0x98FF90", VA = "0x180991190")]
	private void InitAudioClip()
	{
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x9912C0", Offset = "0x9900C0", VA = "0x1809912C0")]
	private void OnAudioRead(float[] data)
	{
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x991730", Offset = "0x990530", VA = "0x180991730")]
	private void SpawnGrain()
	{
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x991010", Offset = "0x98FE10", VA = "0x180991010")]
	private void CleanupFinishedGrains()
	{
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x991480", Offset = "0x990280", VA = "0x180991480")]
	private void SetupRPMBuckets()
	{
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x991F90", Offset = "0x990D90", VA = "0x180991F90")]
	public EngineAudioClip()
	{
	}

	// Token: 0x040014D1 RID: 5329
	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip granularClip;

	// Token: 0x040014D2 RID: 5330
	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip accelerationClip;

	// Token: 0x040014D3 RID: 5331
	[Token(Token = "0x400111F")]
	[FieldOffset(Offset = "0x28")]
	public TextAsset accelerationCyclesJson;

	// Token: 0x040014D4 RID: 5332
	[Token(Token = "0x4001120")]
	[FieldOffset(Offset = "0x30")]
	public List<EngineAudioClip.EngineCycle> accelerationCycles;

	// Token: 0x040014D5 RID: 5333
	[Token(Token = "0x4001121")]
	[FieldOffset(Offset = "0x38")]
	public List<EngineAudioClip.EngineCycleBucket> cycleBuckets;

	// Token: 0x040014D6 RID: 5334
	[Token(Token = "0x4001122")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<int, EngineAudioClip.EngineCycleBucket> accelerationCyclesByRPM;

	// Token: 0x040014D7 RID: 5335
	[Token(Token = "0x4001123")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<int, int> rpmBucketLookup;

	// Token: 0x040014D8 RID: 5336
	[Token(Token = "0x4001124")]
	[FieldOffset(Offset = "0x50")]
	public int sampleRate;

	// Token: 0x040014D9 RID: 5337
	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x54")]
	public int samplesUntilNextGrain;

	// Token: 0x040014DA RID: 5338
	[Token(Token = "0x4001126")]
	[FieldOffset(Offset = "0x58")]
	public int lastCycleId;

	// Token: 0x040014DB RID: 5339
	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x60")]
	public List<EngineAudioClip.Grain> grains;

	// Token: 0x040014DC RID: 5340
	[Token(Token = "0x4001128")]
	[FieldOffset(Offset = "0x68")]
	public int currentRPM;

	// Token: 0x040014DD RID: 5341
	[Token(Token = "0x4001129")]
	[FieldOffset(Offset = "0x6C")]
	public int targetRPM;

	// Token: 0x040014DE RID: 5342
	[Token(Token = "0x400112A")]
	[FieldOffset(Offset = "0x70")]
	public int minRPM;

	// Token: 0x040014DF RID: 5343
	[Token(Token = "0x400112B")]
	[FieldOffset(Offset = "0x74")]
	public int maxRPM;

	// Token: 0x040014E0 RID: 5344
	[Token(Token = "0x400112C")]
	[FieldOffset(Offset = "0x78")]
	public int cyclePadding;

	// Token: 0x040014E1 RID: 5345
	[Token(Token = "0x400112D")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public float RPMControl;

	// Token: 0x040014E2 RID: 5346
	[Token(Token = "0x400112E")]
	[FieldOffset(Offset = "0x80")]
	public AudioSource source;

	// Token: 0x040014E3 RID: 5347
	[Token(Token = "0x400112F")]
	[FieldOffset(Offset = "0x88")]
	public float rpmLerpSpeed;

	// Token: 0x040014E4 RID: 5348
	[Token(Token = "0x4001130")]
	[FieldOffset(Offset = "0x8C")]
	public float rpmLerpSpeedDown;

	// Token: 0x040014E5 RID: 5349
	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x90")]
	private System.Random random;

	// Token: 0x040014E6 RID: 5350
	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x98")]
	private float[] accelerationAudioData;

	// Token: 0x040014E7 RID: 5351
	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0xA0")]
	private EngineAudioClip.EngineCycle currentCycle;

	// Token: 0x040014E8 RID: 5352
	[Token(Token = "0x4001134")]
	[FieldOffset(Offset = "0xA8")]
	private bool audioDataLoaded;

	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x2000B02")]
	[Serializable]
	public class EngineCycle
	{
		// Token: 0x06001A49 RID: 6729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x9924A0", Offset = "0x9912A0", VA = "0x1809924A0")]
		public EngineCycle(int RPM, int startSample, int endSample, float period, int id)
		{
		}

		// Token: 0x040014E9 RID: 5353
		[Token(Token = "0x40040CA")]
		[FieldOffset(Offset = "0x10")]
		public int RPM;

		// Token: 0x040014EA RID: 5354
		[Token(Token = "0x40040CB")]
		[FieldOffset(Offset = "0x14")]
		public int startSample;

		// Token: 0x040014EB RID: 5355
		[Token(Token = "0x40040CC")]
		[FieldOffset(Offset = "0x18")]
		public int endSample;

		// Token: 0x040014EC RID: 5356
		[Token(Token = "0x40040CD")]
		[FieldOffset(Offset = "0x1C")]
		public float period;

		// Token: 0x040014ED RID: 5357
		[Token(Token = "0x40040CE")]
		[FieldOffset(Offset = "0x20")]
		public int id;
	}

	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x2000B03")]
	public class EngineCycleBucket
	{
		// Token: 0x06001A4A RID: 6730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x9923F0", Offset = "0x9911F0", VA = "0x1809923F0")]
		public EngineCycleBucket(int RPM)
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x992220", Offset = "0x991020", VA = "0x180992220")]
		public EngineAudioClip.EngineCycle GetCycle(System.Random random, int lastCycleId)
		{
			return null;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0x992330", Offset = "0x991130", VA = "0x180992330")]
		private void ResetRemainingCycles(System.Random random)
		{
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x9921B0", Offset = "0x990FB0", VA = "0x1809921B0")]
		public void Add(EngineAudioClip.EngineCycle cycle)
		{
		}

		// Token: 0x040014EE RID: 5358
		[Token(Token = "0x40040CF")]
		[FieldOffset(Offset = "0x10")]
		public int RPM;

		// Token: 0x040014EF RID: 5359
		[Token(Token = "0x40040D0")]
		[FieldOffset(Offset = "0x18")]
		public List<EngineAudioClip.EngineCycle> cycles;

		// Token: 0x040014F0 RID: 5360
		[Token(Token = "0x40040D1")]
		[FieldOffset(Offset = "0x20")]
		public List<int> remainingCycles;
	}

	// Token: 0x020002BA RID: 698
	[Token(Token = "0x2000B04")]
	public class Grain
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x17000702")]
		public bool finished
		{
			[Token(Token = "0x6004CF7")]
			[Address(RVA = "0x6076F0", Offset = "0x6064F0", VA = "0x1806076F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x993360", Offset = "0x992160", VA = "0x180993360")]
		public void Init(float[] source, EngineAudioClip.EngineCycle cycle, int cyclePadding)
		{
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x6004CF9")]
		[Address(RVA = "0x9932A0", Offset = "0x9920A0", VA = "0x1809932A0")]
		public float GetSample()
		{
			return 0f;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFA")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public Grain()
		{
		}

		// Token: 0x040014F1 RID: 5361
		[Token(Token = "0x40040D2")]
		[FieldOffset(Offset = "0x10")]
		private float[] sourceData;

		// Token: 0x040014F2 RID: 5362
		[Token(Token = "0x40040D3")]
		[FieldOffset(Offset = "0x18")]
		private int startSample;

		// Token: 0x040014F3 RID: 5363
		[Token(Token = "0x40040D4")]
		[FieldOffset(Offset = "0x1C")]
		private int currentSample;

		// Token: 0x040014F4 RID: 5364
		[Token(Token = "0x40040D5")]
		[FieldOffset(Offset = "0x20")]
		private int attackTimeSamples;

		// Token: 0x040014F5 RID: 5365
		[Token(Token = "0x40040D6")]
		[FieldOffset(Offset = "0x24")]
		private int sustainTimeSamples;

		// Token: 0x040014F6 RID: 5366
		[Token(Token = "0x40040D7")]
		[FieldOffset(Offset = "0x28")]
		private int releaseTimeSamples;

		// Token: 0x040014F7 RID: 5367
		[Token(Token = "0x40040D8")]
		[FieldOffset(Offset = "0x2C")]
		private float gain;

		// Token: 0x040014F8 RID: 5368
		[Token(Token = "0x40040D9")]
		[FieldOffset(Offset = "0x30")]
		private float gainPerSampleAttack;

		// Token: 0x040014F9 RID: 5369
		[Token(Token = "0x40040DA")]
		[FieldOffset(Offset = "0x34")]
		private float gainPerSampleRelease;

		// Token: 0x040014FA RID: 5370
		[Token(Token = "0x40040DB")]
		[FieldOffset(Offset = "0x38")]
		private int attackEndSample;

		// Token: 0x040014FB RID: 5371
		[Token(Token = "0x40040DC")]
		[FieldOffset(Offset = "0x3C")]
		private int releaseStartSample;

		// Token: 0x040014FC RID: 5372
		[Token(Token = "0x40040DD")]
		[FieldOffset(Offset = "0x40")]
		private int endSample;
	}
}
