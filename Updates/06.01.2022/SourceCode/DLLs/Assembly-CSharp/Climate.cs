using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005CB RID: 1483
[Token(Token = "0x2000457")]
public class Climate : SingletonComponent<Climate>
{
	// Token: 0x1700034B RID: 843
	// (get) Token: 0x0600298D RID: 10637 RVA: 0x00012018 File Offset: 0x00010218
	// (set) Token: 0x0600298E RID: 10638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030A")]
	public float WeatherStateBlend
	{
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x4EED20", Offset = "0x4EDB20", VA = "0x1804EED20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x4EEDB0", Offset = "0x4EDBB0", VA = "0x1804EEDB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x0600298F RID: 10639 RVA: 0x00012030 File Offset: 0x00010230
	// (set) Token: 0x06002990 RID: 10640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030B")]
	public uint WeatherSeedPrevious
	{
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x4EED00", Offset = "0x4EDB00", VA = "0x1804EED00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x4EED90", Offset = "0x4EDB90", VA = "0x1804EED90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06002991 RID: 10641 RVA: 0x00012048 File Offset: 0x00010248
	// (set) Token: 0x06002992 RID: 10642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030C")]
	public uint WeatherSeedTarget
	{
		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x4EED10", Offset = "0x4EDB10", VA = "0x1804EED10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x4EEDA0", Offset = "0x4EDBA0", VA = "0x1804EEDA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06002993 RID: 10643 RVA: 0x00012060 File Offset: 0x00010260
	// (set) Token: 0x06002994 RID: 10644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030D")]
	public uint WeatherSeedNext
	{
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x4EECF0", Offset = "0x4EDAF0", VA = "0x1804EECF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x4EED80", Offset = "0x4EDB80", VA = "0x1804EED80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06002995 RID: 10645 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002996 RID: 10646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030E")]
	public WeatherPreset WeatherStatePrevious
	{
		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x2F3810", Offset = "0x2F2610", VA = "0x1802F3810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x4637E0", Offset = "0x4625E0", VA = "0x1804637E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06002997 RID: 10647 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002998 RID: 10648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030F")]
	public WeatherPreset WeatherStateTarget
	{
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x4EED40", Offset = "0x4EDB40", VA = "0x1804EED40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x4EEDD0", Offset = "0x4EDBD0", VA = "0x1804EEDD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x06002999 RID: 10649 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600299A RID: 10650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000310")]
	public WeatherPreset WeatherStateNext
	{
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x4EED30", Offset = "0x4EDB30", VA = "0x1804EED30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x4EEDC0", Offset = "0x4EDBC0", VA = "0x1804EEDC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x0600299B RID: 10651 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600299C RID: 10652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000311")]
	public WeatherPreset WeatherState
	{
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x4EED50", Offset = "0x4EDB50", VA = "0x1804EED50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x4EEDE0", Offset = "0x4EDBE0", VA = "0x1804EEDE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x0600299D RID: 10653 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600299E RID: 10654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000312")]
	public WeatherPreset WeatherClampsMin
	{
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x4EECE0", Offset = "0x4EDAE0", VA = "0x1804EECE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x4EED70", Offset = "0x4EDB70", VA = "0x1804EED70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x0600299F RID: 10655 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029A0 RID: 10656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000313")]
	public WeatherPreset WeatherClampsMax
	{
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x2F9B40", Offset = "0x2F8940", VA = "0x1802F9B40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x2F9BC0", Offset = "0x2F89C0", VA = "0x1802F9BC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x060029A1 RID: 10657 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000314")]
	public WeatherPreset WeatherOverrides
	{
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x2F9A70", Offset = "0x2F8870", VA = "0x1802F9A70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x2F9B50", Offset = "0x2F8950", VA = "0x1802F9B50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x060029A3 RID: 10659 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029A4 RID: 10660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000315")]
	public LegacyWeatherState Overrides
	{
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x4EECD0", Offset = "0x4EDAD0", VA = "0x1804EECD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x4EED60", Offset = "0x4EDB60", VA = "0x1804EED60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D8")]
	[Address(RVA = "0x4EC2E0", Offset = "0x4EB0E0", VA = "0x1804EC2E0", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x4EDEE0", Offset = "0x4ECCE0", VA = "0x1804EDEE0", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022DA")]
	[Address(RVA = "0x4EE0F0", Offset = "0x4ECEF0", VA = "0x1804EE0F0")]
	protected void Start()
	{
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022DB")]
	[Address(RVA = "0x4EE2E0", Offset = "0x4ED0E0", VA = "0x1804EE2E0")]
	protected void Update()
	{
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x00012078 File Offset: 0x00010278
	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x4EDBB0", Offset = "0x4EC9B0", VA = "0x1804EDBB0")]
	private static bool Initialized()
	{
		return default(bool);
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x00012090 File Offset: 0x00010290
	[Token(Token = "0x60022DD")]
	[Address(RVA = "0x4ECCD0", Offset = "0x4EBAD0", VA = "0x1804ECCD0")]
	public static float GetClouds(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x000120A8 File Offset: 0x000102A8
	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x4ECD60", Offset = "0x4EBB60", VA = "0x1804ECD60")]
	public static float GetFog(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x000120C0 File Offset: 0x000102C0
	[Token(Token = "0x60022DF")]
	[Address(RVA = "0x4EDB20", Offset = "0x4EC920", VA = "0x1804EDB20")]
	public static float GetWind(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029AD RID: 10669 RVA: 0x000120D8 File Offset: 0x000102D8
	[Token(Token = "0x60022E0")]
	[Address(RVA = "0x4ED740", Offset = "0x4EC540", VA = "0x1804ED740")]
	public static float GetThunder(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x000120F0 File Offset: 0x000102F0
	[Token(Token = "0x60022E1")]
	[Address(RVA = "0x4ED080", Offset = "0x4EBE80", VA = "0x1804ED080")]
	public static float GetRainbow(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x00012108 File Offset: 0x00010308
	[Token(Token = "0x60022E2")]
	[Address(RVA = "0x4ECAC0", Offset = "0x4EB8C0", VA = "0x1804ECAC0")]
	public static float GetAurora(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x00012120 File Offset: 0x00010320
	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x4ECDF0", Offset = "0x4EBBF0", VA = "0x1804ECDF0")]
	public static float GetRain(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x00012138 File Offset: 0x00010338
	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x4ED3C0", Offset = "0x4EC1C0", VA = "0x1804ED3C0")]
	public static float GetSnow(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x00012150 File Offset: 0x00010350
	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x4ED530", Offset = "0x4EC330", VA = "0x1804ED530")]
	public static float GetTemperature(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x00012168 File Offset: 0x00010368
	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x4ED360", Offset = "0x4EC160", VA = "0x1804ED360")]
	private uint GetSeedFromLong(long val)
	{
		return 0U;
	}

	// Token: 0x060029B4 RID: 10676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E7")]
	[Address(RVA = "0x4ED870", Offset = "0x4EC670", VA = "0x1804ED870")]
	private WeatherPreset GetWeatherPreset(uint seed)
	{
		return null;
	}

	// Token: 0x060029B5 RID: 10677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x4ED980", Offset = "0x4EC780", VA = "0x1804ED980")]
	private WeatherPreset GetWeatherPreset(uint seed, WeatherPresetType type)
	{
		return null;
	}

	// Token: 0x060029B6 RID: 10678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x4EC5A0", Offset = "0x4EB3A0", VA = "0x1804EC5A0")]
	private WeatherPreset[] CacheWeatherPresets(WeatherPresetType type)
	{
		return null;
	}

	// Token: 0x060029B7 RID: 10679 RVA: 0x00012180 File Offset: 0x00010380
	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x4EC660", Offset = "0x4EB460", VA = "0x1804EC660")]
	private float FindBlendParameters(Vector3 pos, out Climate.ClimateParameters src, out Climate.ClimateParameters dst)
	{
		return 0f;
	}

	// Token: 0x060029B8 RID: 10680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x4EEC60", Offset = "0x4EDA60", VA = "0x1804EEC60")]
	public Climate()
	{
	}

	// Token: 0x040024EF RID: 9455
	[Token(Token = "0x4001E30")]
	private const float fadeAngle = 20f;

	// Token: 0x040024F0 RID: 9456
	[Token(Token = "0x4001E31")]
	private const float defaultTemp = 15f;

	// Token: 0x040024F1 RID: 9457
	[Token(Token = "0x4001E32")]
	private const int weatherDurationHours = 18;

	// Token: 0x040024F2 RID: 9458
	[Token(Token = "0x4001E33")]
	private const int weatherFadeHours = 6;

	// Token: 0x040024F3 RID: 9459
	[Token(Token = "0x4001E34")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public float BlendingSpeed;

	// Token: 0x040024F4 RID: 9460
	[Token(Token = "0x4001E35")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x71660", Offset = "0x70A60")]
	public float FogMultiplier;

	// Token: 0x040024F5 RID: 9461
	[Token(Token = "0x4001E36")]
	[FieldOffset(Offset = "0x20")]
	public float FogDarknessDistance;

	// Token: 0x040024F6 RID: 9462
	[Token(Token = "0x4001E37")]
	[FieldOffset(Offset = "0x24")]
	public bool DebugLUTBlending;

	// Token: 0x040024F7 RID: 9463
	[Token(Token = "0x4001E38")]
	[FieldOffset(Offset = "0x28")]
	public Climate.WeatherParameters Weather;

	// Token: 0x040024F8 RID: 9464
	[Token(Token = "0x4001E39")]
	[FieldOffset(Offset = "0x30")]
	public WeatherPreset[] WeatherPresets;

	// Token: 0x040024F9 RID: 9465
	[Token(Token = "0x4001E3A")]
	[FieldOffset(Offset = "0x38")]
	public Climate.ClimateParameters Arid;

	// Token: 0x040024FA RID: 9466
	[Token(Token = "0x4001E3B")]
	[FieldOffset(Offset = "0x40")]
	public Climate.ClimateParameters Temperate;

	// Token: 0x040024FB RID: 9467
	[Token(Token = "0x4001E3C")]
	[FieldOffset(Offset = "0x48")]
	public Climate.ClimateParameters Tundra;

	// Token: 0x040024FC RID: 9468
	[Token(Token = "0x4001E3D")]
	[FieldOffset(Offset = "0x50")]
	public Climate.ClimateParameters Arctic;

	// Token: 0x040024FD RID: 9469
	[Token(Token = "0x4001E3E")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <WeatherStateBlend>k__BackingField;

	// Token: 0x040024FE RID: 9470
	[Token(Token = "0x4001E3F")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private uint <WeatherSeedPrevious>k__BackingField;

	// Token: 0x040024FF RID: 9471
	[Token(Token = "0x4001E40")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private uint <WeatherSeedTarget>k__BackingField;

	// Token: 0x04002500 RID: 9472
	[Token(Token = "0x4001E41")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private uint <WeatherSeedNext>k__BackingField;

	// Token: 0x04002501 RID: 9473
	[Token(Token = "0x4001E42")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private WeatherPreset <WeatherStatePrevious>k__BackingField;

	// Token: 0x04002502 RID: 9474
	[Token(Token = "0x4001E43")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private WeatherPreset <WeatherStateTarget>k__BackingField;

	// Token: 0x04002503 RID: 9475
	[Token(Token = "0x4001E44")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private WeatherPreset <WeatherStateNext>k__BackingField;

	// Token: 0x04002504 RID: 9476
	[Token(Token = "0x4001E45")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private WeatherPreset <WeatherState>k__BackingField;

	// Token: 0x04002505 RID: 9477
	[Token(Token = "0x4001E46")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private WeatherPreset <WeatherClampsMin>k__BackingField;

	// Token: 0x04002506 RID: 9478
	[Token(Token = "0x4001E47")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private WeatherPreset <WeatherClampsMax>k__BackingField;

	// Token: 0x04002507 RID: 9479
	[Token(Token = "0x4001E48")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private WeatherPreset <WeatherOverrides>k__BackingField;

	// Token: 0x04002508 RID: 9480
	[Token(Token = "0x4001E49")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private LegacyWeatherState <Overrides>k__BackingField;

	// Token: 0x04002509 RID: 9481
	[Token(Token = "0x4001E4A")]
	[FieldOffset(Offset = "0xA8")]
	private Camera cam;

	// Token: 0x0400250A RID: 9482
	[Token(Token = "0x4001E4B")]
	[FieldOffset(Offset = "0xB0")]
	private TOD_Scattering scattering;

	// Token: 0x0400250B RID: 9483
	[Token(Token = "0x4001E4C")]
	[FieldOffset(Offset = "0xB8")]
	private WindZone windZone;

	// Token: 0x0400250C RID: 9484
	[Token(Token = "0x4001E4D")]
	[FieldOffset(Offset = "0xC0")]
	private Climate.ClimateParameters currentClimate;

	// Token: 0x0400250D RID: 9485
	[Token(Token = "0x4001E4E")]
	[FieldOffset(Offset = "0xC8")]
	private Climate.ClimateParameters prevClimate;

	// Token: 0x0400250E RID: 9486
	[Token(Token = "0x4001E4F")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<WeatherPresetType, WeatherPreset[]> presetLookup;

	// Token: 0x0400250F RID: 9487
	[Token(Token = "0x4001E50")]
	[FieldOffset(Offset = "0xD8")]
	private Climate.ClimateParameters[] climateLookup;

	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x2000BA7")]
	[Serializable]
	public class ClimateParameters
	{
		// Token: 0x060029B9 RID: 10681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public ClimateParameters()
		{
		}

		// Token: 0x04002510 RID: 9488
		[Token(Token = "0x40043C9")]
		[FieldOffset(Offset = "0x10")]
		public AnimationCurve Temperature;

		// Token: 0x04002511 RID: 9489
		[Token(Token = "0x40043CA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HorizontalAttribute", RVA = "0x75090", Offset = "0x74490")]
		public Climate.Float4 AerialDensity;

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x40043CB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HorizontalAttribute", RVA = "0x75090", Offset = "0x74490")]
		public Climate.Float4 FogDensity;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x40043CC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HorizontalAttribute", RVA = "0x75090", Offset = "0x74490")]
		public Climate.Texture2D4 LUT;
	}

	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x2000BA8")]
	[Serializable]
	public class WeatherParameters
	{
		// Token: 0x060029BA RID: 10682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x4B0A20", Offset = "0x4AF820", VA = "0x1804B0A20")]
		public WeatherParameters()
		{
		}

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x40043CD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
		public float ClearChance;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x40043CE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
		public float DustChance;

		// Token: 0x04002516 RID: 9494
		[Token(Token = "0x40043CF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
		public float FogChance;

		// Token: 0x04002517 RID: 9495
		[Token(Token = "0x40043D0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
		public float OvercastChance;

		// Token: 0x04002518 RID: 9496
		[Token(Token = "0x40043D1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
		public float StormChance;

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x40043D2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
		public float RainChance;
	}

	// Token: 0x020005CE RID: 1486
	[Token(Token = "0x2000BA9")]
	public class Value4<T>
	{
		// Token: 0x060029BB RID: 10683 RVA: 0x00012198 File Offset: 0x00010398
		[Token(Token = "0x6004E4B")]
		public float FindBlendParameters(TOD_Sky sky, out T src, out T dst)
		{
			return 0f;
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4C")]
		public Value4()
		{
		}

		// Token: 0x0400251A RID: 9498
		[Token(Token = "0x40043D3")]
		[FieldOffset(Offset = "0x0")]
		public T Dawn;

		// Token: 0x0400251B RID: 9499
		[Token(Token = "0x40043D4")]
		[FieldOffset(Offset = "0x0")]
		public T Noon;

		// Token: 0x0400251C RID: 9500
		[Token(Token = "0x40043D5")]
		[FieldOffset(Offset = "0x0")]
		public T Dusk;

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x40043D6")]
		[FieldOffset(Offset = "0x0")]
		public T Night;
	}

	// Token: 0x020005CF RID: 1487
	[Token(Token = "0x2000BAA")]
	[Serializable]
	public class Float4 : Climate.Value4<float>
	{
		// Token: 0x060029BD RID: 10685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x4AD4F0", Offset = "0x4AC2F0", VA = "0x1804AD4F0")]
		public Float4()
		{
		}
	}

	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x2000BAB")]
	[Serializable]
	public class Color4 : Climate.Value4<Color>
	{
		// Token: 0x060029BE RID: 10686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4E")]
		[Address(RVA = "0x49F7A0", Offset = "0x49E5A0", VA = "0x18049F7A0")]
		public Color4()
		{
		}
	}

	// Token: 0x020005D1 RID: 1489
	[Token(Token = "0x2000BAC")]
	[Serializable]
	public class Texture2D4 : Climate.Value4<Texture2D>
	{
		// Token: 0x060029BF RID: 10687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x4ADCD0", Offset = "0x4ACAD0", VA = "0x1804ADCD0")]
		public Texture2D4()
		{
		}
	}

	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x2000BAD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass87_0
	{
		// Token: 0x060029C0 RID: 10688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass87_0()
		{
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x4B04C0", Offset = "0x4AF2C0", VA = "0x1804B04C0")]
		internal bool <CacheWeatherPresets>b__0(WeatherPreset x)
		{
			return default(bool);
		}

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x40043D7")]
		[FieldOffset(Offset = "0x10")]
		public WeatherPresetType type;
	}
}
