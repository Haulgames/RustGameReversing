using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000031")]
public class AudioVisualisationEntity : IOEntity
{
	// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x83EFD0", Offset = "0x83DDD0", VA = "0x18083EFD0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600055A RID: 1370 RVA: 0x00002910 File Offset: 0x00000B10
	[Token(Token = "0x17000012")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x840160", Offset = "0x83EF60", VA = "0x180840160", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002928 File Offset: 0x00000B28
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x83F590", Offset = "0x83E390", VA = "0x18083F590", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600055C RID: 1372 RVA: 0x00002940 File Offset: 0x00000B40
	// (set) Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000013")]
	public AudioVisualisationEntity.LightColour currentColour
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x840230", Offset = "0x83F030", VA = "0x180840230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return AudioVisualisationEntity.LightColour.Red;
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x840270", Offset = "0x83F070", VA = "0x180840270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600055E RID: 1374 RVA: 0x00002958 File Offset: 0x00000B58
	// (set) Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000014")]
	public AudioVisualisationEntity.VolumeSensitivity currentVolumeSensitivity
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x840260", Offset = "0x83F060", VA = "0x180840260")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return AudioVisualisationEntity.VolumeSensitivity.Small;
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x8402A0", Offset = "0x83F0A0", VA = "0x1808402A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000560 RID: 1376 RVA: 0x00002970 File Offset: 0x00000B70
	// (set) Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000015")]
	public AudioVisualisationEntity.Speed currentSpeed
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x840250", Offset = "0x83F050", VA = "0x180840250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return AudioVisualisationEntity.Speed.Low;
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x840290", Offset = "0x83F090", VA = "0x180840290")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000562 RID: 1378 RVA: 0x00002988 File Offset: 0x00000B88
	// (set) Token: 0x06000563 RID: 1379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000016")]
	public int currentGradient
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x840240", Offset = "0x83F040", VA = "0x180840240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x840280", Offset = "0x83F080", VA = "0x180840280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x83F3F0", Offset = "0x83E1F0", VA = "0x18083F3F0", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x83FBD0", Offset = "0x83E9D0", VA = "0x18083FBD0")]
	private void UpdateInvoke()
	{
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x83FAA0", Offset = "0x83E8A0", VA = "0x18083FAA0", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "158")]
	protected virtual void UpdateVisualisation(float volume, bool force = false)
	{
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000143")]
	[Address(RVA = "0x83EE70", Offset = "0x83DC70", VA = "0x18083EE70")]
	[BaseEntity.RPC_Client]
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000569 RID: 1385 RVA: 0x000029A0 File Offset: 0x00000BA0
	[Token(Token = "0x17000017")]
	public virtual bool ShowColourOption
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "159")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600056A RID: 1386 RVA: 0x000029B8 File Offset: 0x00000BB8
	[Token(Token = "0x17000018")]
	public virtual bool ShowVolumeOption
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600056B RID: 1387 RVA: 0x000029D0 File Offset: 0x00000BD0
	[Token(Token = "0x17000019")]
	public virtual bool ShowSpeedOption
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "161")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600056C RID: 1388 RVA: 0x000029E8 File Offset: 0x00000BE8
	[Token(Token = "0x1700001A")]
	public virtual bool ShowPatternOption
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "162")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600056D RID: 1389 RVA: 0x00002A00 File Offset: 0x00000C00
	[Token(Token = "0x1700001B")]
	public virtual bool ShowGradientOption
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "163")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600056E RID: 1390 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x1700001C")]
	protected bool HasAudioSource
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x840100", Offset = "0x83EF00", VA = "0x180840100")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "164")]
	protected virtual void UpdateVisualSettings()
	{
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x83ED70", Offset = "0x83DB70", VA = "0x18083ED70")]
	[Attribute(Name = "Menu", RVA = "0xA1350", Offset = "0xA0750")]
	[Attribute(Name = "Description", RVA = "0xA1350", Offset = "0xA0750")]
	[Attribute(Name = "ShowIf", RVA = "0xA1350", Offset = "0xA0750")]
	[Attribute(Name = "Icon", RVA = "0xA1350", Offset = "0xA0750")]
	public void ChangeLightSettings(BasePlayer player)
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x83FB30", Offset = "0x83E930", VA = "0x18083FB30")]
	public void SendNewLightSettings(int newColour, int newVolumeRange, int newSpeed, int newGradient)
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x6B5C00", Offset = "0x6B4A00", VA = "0x1806B5C00")]
	private bool CanChangeLightSettings(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x83EF60", Offset = "0x83DD60", VA = "0x18083EF60", Slot = "130")]
	public override bool DisplayHealthInfo(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x83F2F0", Offset = "0x83E0F0", VA = "0x18083F2F0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x840090", Offset = "0x83EE90", VA = "0x180840090")]
	public AudioVisualisationEntity()
	{
	}

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x268")]
	private Option __menuOption_ChangeLightSettings;

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x2C0")]
	private EntityRef<BaseEntity> connectedTo;

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x2D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AudioVisualisationEntity.LightColour <currentColour>k__BackingField;

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x2D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AudioVisualisationEntity.VolumeSensitivity <currentVolumeSensitivity>k__BackingField;

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x2D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AudioVisualisationEntity.Speed <currentSpeed>k__BackingField;

	// Token: 0x04000218 RID: 536
	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x2E0")]
	public GameObjectRef SettingsDialog;

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x2E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <currentGradient>k__BackingField;

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x2F0")]
	private IAudioConnectionSource currentSource;

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x0")]
	private static float[] bands;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x2F8")]
	private float roughPeak;

	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000A52")]
	public enum LightColour
	{
		// Token: 0x0400021E RID: 542
		[Token(Token = "0x4003D93")]
		Red,
		// Token: 0x0400021F RID: 543
		[Token(Token = "0x4003D94")]
		Green,
		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4003D95")]
		Blue,
		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4003D96")]
		Yellow,
		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4003D97")]
		Pink
	}

	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000A53")]
	public enum VolumeSensitivity
	{
		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4003D99")]
		Small,
		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4003D9A")]
		Medium,
		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4003D9B")]
		Large
	}

	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000A54")]
	public enum Speed
	{
		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4003D9D")]
		Low,
		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4003D9E")]
		Medium,
		// Token: 0x0400022A RID: 554
		[Token(Token = "0x4003D9F")]
		High
	}
}
