using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200046E RID: 1134
[Token(Token = "0x2000345")]
public class DiscoFloor : AudioVisualisationEntity
{
	// Token: 0x1700028C RID: 652
	// (get) Token: 0x060022EC RID: 8940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700025C")]
	private Gradient ColourGradient
	{
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0xB75210", Offset = "0xB74010", VA = "0x180B75210")]
		get
		{
			return null;
		}
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0xB74780", Offset = "0xB73580", VA = "0x180B74780", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060022EE RID: 8942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0xB74870", Offset = "0xB73670", VA = "0x180B74870", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0xB74C50", Offset = "0xB73A50", VA = "0x180B74C50", Slot = "158")]
	protected override void UpdateVisualisation(float volume, bool force = false)
	{
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0xB74950", Offset = "0xB73750", VA = "0x180B74950", Slot = "80")]
	public override void OnFlagsChanged(global::BaseEntity.Flags old, global::BaseEntity.Flags next)
	{
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x060022F1 RID: 8945 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
	[Token(Token = "0x1700025D")]
	public override bool ShowPatternOption
	{
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "162")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
	[Token(Token = "0x1700025E")]
	public override bool ShowSpeedOption
	{
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "161")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
	[Token(Token = "0x1700025F")]
	public override bool ShowVolumeOption
	{
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
	[Token(Token = "0x17000260")]
	public override bool ShowGradientOption
	{
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "163")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060022F5 RID: 8949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CA9")]
	[Address(RVA = "0xB74BF0", Offset = "0xB739F0", VA = "0x180B74BF0", Slot = "164")]
	protected override void UpdateVisualSettings()
	{
	}

	// Token: 0x060022F6 RID: 8950 RVA: 0x0000FC00 File Offset: 0x0000DE00
	[Token(Token = "0x6001CAA")]
	[Address(RVA = "0xB74910", Offset = "0xB73710", VA = "0x180B74910")]
	private float GetCurrentVolumeSensitivity()
	{
		return 0f;
	}

	// Token: 0x060022F7 RID: 8951 RVA: 0x0000FC18 File Offset: 0x0000DE18
	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0xB748E0", Offset = "0xB736E0", VA = "0x180B748E0")]
	private float GetCurrentSpeed()
	{
		return 0f;
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0xB751A0", Offset = "0xB73FA0", VA = "0x180B751A0")]
	public DiscoFloor()
	{
	}

	// Token: 0x04001D78 RID: 7544
	[Token(Token = "0x4001811")]
	[FieldOffset(Offset = "0x300")]
	public float GradientDuration;

	// Token: 0x04001D79 RID: 7545
	[Token(Token = "0x4001812")]
	[FieldOffset(Offset = "0x304")]
	public float VolumeSensitivityMultiplier;

	// Token: 0x04001D7A RID: 7546
	[Token(Token = "0x4001813")]
	[FieldOffset(Offset = "0x308")]
	public float BaseSpeed;

	// Token: 0x04001D7B RID: 7547
	[Token(Token = "0x4001814")]
	[FieldOffset(Offset = "0x310")]
	public Light[] LightSources;

	// Token: 0x04001D7C RID: 7548
	[Token(Token = "0x4001815")]
	[FieldOffset(Offset = "0x318")]
	public DiscoFloorMesh FloorMesh;

	// Token: 0x04001D7D RID: 7549
	[Token(Token = "0x4001816")]
	[FieldOffset(Offset = "0x320")]
	private float currentFloorTime;

	// Token: 0x04001D7E RID: 7550
	[Token(Token = "0x4001817")]
	[FieldOffset(Offset = "0x328")]
	private DiscoFloorColourLookups cachedLookups;
}
