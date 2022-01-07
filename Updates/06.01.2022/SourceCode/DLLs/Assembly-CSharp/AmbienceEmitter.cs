using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A8 RID: 680
[Token(Token = "0x20001E1")]
public class AmbienceEmitter : MonoBehaviour, IClientComponent, IComparable<AmbienceEmitter>
{
	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x060019DB RID: 6619 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
	// (set) Token: 0x060019DC RID: 6620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B2")]
	public TerrainTopology.Enum currentTopology
	{
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x56E740", Offset = "0x56D540", VA = "0x18056E740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return (TerrainTopology.Enum)0;
		}
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x8267D0", Offset = "0x8255D0", VA = "0x1808267D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x060019DD RID: 6621 RVA: 0x0000D110 File Offset: 0x0000B310
	// (set) Token: 0x060019DE RID: 6622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B3")]
	public TerrainBiome.Enum currentBiome
	{
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x56E5C0", Offset = "0x56D3C0", VA = "0x18056E5C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return (TerrainBiome.Enum)0;
		}
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x60CA40", Offset = "0x60B840", VA = "0x18060CA40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001476")]
	[Address(RVA = "0x823F60", Offset = "0x822D60", VA = "0x180823F60")]
	protected void Awake()
	{
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001477")]
	[Address(RVA = "0x825020", Offset = "0x823E20", VA = "0x180825020")]
	protected void OnEnable()
	{
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001478")]
	[Address(RVA = "0x824E90", Offset = "0x823C90", VA = "0x180824E90")]
	protected void OnDisable()
	{
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001479")]
	[Address(RVA = "0x824D40", Offset = "0x823B40", VA = "0x180824D40")]
	protected void OnDestroy()
	{
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147A")]
	[Address(RVA = "0x824370", Offset = "0x823170", VA = "0x180824370")]
	public void FadeOut(float fadeTimeOverride = -1f)
	{
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0000D128 File Offset: 0x0000B328
	[Token(Token = "0x600147B")]
	[Address(RVA = "0x824D20", Offset = "0x823B20", VA = "0x180824D20")]
	public bool IsFadingOut()
	{
		return default(bool);
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147C")]
	[Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10")]
	public void Reset()
	{
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147D")]
	[Address(RVA = "0x825F70", Offset = "0x824D70", VA = "0x180825F70")]
	public void SetBaseAmbience(AmbienceDefinitionList ambienceList)
	{
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147E")]
	[Address(RVA = "0x824200", Offset = "0x823000", VA = "0x180824200")]
	public void DoUpdate()
	{
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147F")]
	[Address(RVA = "0x826460", Offset = "0x825260", VA = "0x180826460")]
	public void Tick()
	{
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001480")]
	[Address(RVA = "0x8265B0", Offset = "0x8253B0", VA = "0x1808265B0")]
	public void UpdateCameraDistance()
	{
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001481")]
	[Address(RVA = "0x826210", Offset = "0x825010", VA = "0x180826210")]
	public void StartImmediately()
	{
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001482")]
	[Address(RVA = "0x8258E0", Offset = "0x8246E0", VA = "0x1808258E0")]
	private void ReadAndUpdateEnvironment()
	{
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001483")]
	[Address(RVA = "0x825AF0", Offset = "0x8248F0", VA = "0x180825AF0")]
	private void ReadEnvironment()
	{
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x826660", Offset = "0x825460", VA = "0x180826660")]
	private void UpdateCurrentEnvironment()
	{
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x0000D140 File Offset: 0x0000B340
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x824830", Offset = "0x823630", VA = "0x180824830")]
	private int GetMostCommonReading(List<int> readings)
	{
		return 0;
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x0000D158 File Offset: 0x0000B358
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x824AD0", Offset = "0x8238D0", VA = "0x180824AD0")]
	private float GetScore(AmbienceDefinition definition, float rain, float snow, float wind, bool underground)
	{
		return 0f;
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x8264A0", Offset = "0x8252A0", VA = "0x1808264A0")]
	private void UpdateBaseSound(float crossFadeTimeOverride = -1f)
	{
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001488")]
	[Address(RVA = "0x824A20", Offset = "0x823820", VA = "0x180824A20")]
	public SoundModulation.Modulator GetPitchModulator()
	{
		return null;
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001489")]
	[Address(RVA = "0x826240", Offset = "0x825040", VA = "0x180826240")]
	private void StartSound(SoundDefinition def, float fadeTime)
	{
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148A")]
	[Address(RVA = "0x8240F0", Offset = "0x822EF0", VA = "0x1808240F0")]
	private void CrossfadeTo(SoundDefinition def, float fadeTime)
	{
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600148B")]
	[Address(RVA = "0x824690", Offset = "0x823490", VA = "0x180824690")]
	public SoundDefinition GetBaseSound()
	{
		return null;
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600148C")]
	[Address(RVA = "0x8243C0", Offset = "0x8231C0", VA = "0x1808243C0")]
	private SoundDefinition GetBaseSound(AmbienceDefinitionList ambienceDefinitionList)
	{
		return null;
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148D")]
	[Address(RVA = "0x825150", Offset = "0x823F50", VA = "0x180825150")]
	public void PlayStings()
	{
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148E")]
	[Address(RVA = "0x8253A0", Offset = "0x8241A0", VA = "0x1808253A0")]
	private void PlayStings(AmbienceDefinitionList ambienceDefinitionList)
	{
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148F")]
	[Address(RVA = "0x825DA0", Offset = "0x824BA0", VA = "0x180825DA0")]
	private void ResetStingTimes(AmbienceDefinitionList ambienceDefinitionList)
	{
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x0000D170 File Offset: 0x0000B370
	[Token(Token = "0x6001490")]
	[Address(RVA = "0x8249D0", Offset = "0x8237D0", VA = "0x1808249D0")]
	public float GetNextStingTime(AmbienceDefinition sting)
	{
		return 0f;
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x0000D188 File Offset: 0x0000B388
	[Token(Token = "0x6001491")]
	[Address(RVA = "0x8240C0", Offset = "0x822EC0", VA = "0x1808240C0", Slot = "4")]
	public int CompareTo(AmbienceEmitter other)
	{
		return 0;
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001492")]
	[Address(RVA = "0x8266A0", Offset = "0x8254A0", VA = "0x1808266A0")]
	public AmbienceEmitter()
	{
	}

	// Token: 0x04001467 RID: 5223
	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x18")]
	public AmbienceDefinitionList baseAmbience;

	// Token: 0x04001468 RID: 5224
	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x20")]
	public AmbienceDefinitionList stings;

	// Token: 0x04001469 RID: 5225
	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x28")]
	public bool isStatic;

	// Token: 0x0400146A RID: 5226
	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x29")]
	public bool followCamera;

	// Token: 0x0400146B RID: 5227
	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x2A")]
	public bool isBaseEmitter;

	// Token: 0x0400146C RID: 5228
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x2B")]
	public bool active;

	// Token: 0x0400146D RID: 5229
	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x2C")]
	public float cameraDistanceSq;

	// Token: 0x0400146E RID: 5230
	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x30")]
	public BoundingSphere boundingSphere;

	// Token: 0x0400146F RID: 5231
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x40")]
	public float crossfadeTime;

	// Token: 0x04001470 RID: 5232
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private TerrainTopology.Enum <currentTopology>k__BackingField;

	// Token: 0x04001471 RID: 5233
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private TerrainBiome.Enum <currentBiome>k__BackingField;

	// Token: 0x04001472 RID: 5234
	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x50")]
	public Dictionary<AmbienceDefinition, float> nextStingTime;

	// Token: 0x04001473 RID: 5235
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x58")]
	public float deactivateTime;

	// Token: 0x04001474 RID: 5236
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x5C")]
	public bool playUnderwater;

	// Token: 0x04001475 RID: 5237
	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x5D")]
	public bool playAbovewater;

	// Token: 0x04001476 RID: 5238
	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x60")]
	private Sound baseSound;

	// Token: 0x04001477 RID: 5239
	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x68")]
	private SoundModulation.Modulator occlusionGain;

	// Token: 0x04001478 RID: 5240
	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x70")]
	private SoundModulation.Modulator pitchModulator;

	// Token: 0x04001479 RID: 5241
	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x78")]
	private float lastCrossfade;

	// Token: 0x0400147A RID: 5242
	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0x80")]
	private List<int> biomeReadings;

	// Token: 0x0400147B RID: 5243
	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0x88")]
	private List<int> topologyReadings;

	// Token: 0x0400147C RID: 5244
	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0x90")]
	private int readingsToKeep;

	// Token: 0x0400147D RID: 5245
	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 lastPosition;

	// Token: 0x0400147E RID: 5246
	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<int, int> readingOccurences;
}
