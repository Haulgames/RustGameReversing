using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000101 RID: 257
[Token(Token = "0x200009C")]
public class BaseFishingRod : HeldEntity
{
	// Token: 0x06000FDE RID: 4062 RVA: 0x000095D0 File Offset: 0x000077D0
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x897690", Offset = "0x896490", VA = "0x180897690", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000FDF RID: 4063 RVA: 0x000095E8 File Offset: 0x000077E8
	// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000151")]
	public BaseFishingRod.CatchState CurrentState
	{
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x8999E0", Offset = "0x8987E0", VA = "0x1808999E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return BaseFishingRod.CatchState.None;
		}
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x899A60", Offset = "0x898860", VA = "0x180899A60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00009600 File Offset: 0x00007800
	[Token(Token = "0x17000152")]
	public static bool ShowLureFailError
	{
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x8999F0", Offset = "0x8987F0", VA = "0x1808999F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x896930", Offset = "0x895730", VA = "0x180896930", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x8965A0", Offset = "0x8953A0", VA = "0x1808965A0", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x899010", Offset = "0x897E10", VA = "0x180899010")]
	private void UpdateLineRenderer()
	{
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x899410", Offset = "0x898210", VA = "0x180899410")]
	private void UpdateSounds(bool onLine, float strainAmount)
	{
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00009618 File Offset: 0x00007818
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x895BF0", Offset = "0x8949F0", VA = "0x180895BF0")]
	private Vector3 GetCurrentCastArcTarget(BasePlayer ply)
	{
		return default(Vector3);
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00009630 File Offset: 0x00007830
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x896100", Offset = "0x894F00", VA = "0x180896100")]
	private Vector3 GetWorldSpaceLineRendererStartPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel)
	{
		return default(Vector3);
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x00009648 File Offset: 0x00007848
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x895E10", Offset = "0x894C10", VA = "0x180895E10")]
	private Vector3 GetRodCatchPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel)
	{
		return default(Vector3);
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x00009660 File Offset: 0x00007860
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x896440", Offset = "0x895240", VA = "0x180896440", Slot = "150")]
	public override bool HeldEntityBlocksMovement(InputState state)
	{
		return default(bool);
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x894B50", Offset = "0x893950", VA = "0x180894B50")]
	[BaseEntity.RPC_Client]
	private void Client_ReceiveCastPoint(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x894730", Offset = "0x893530", VA = "0x180894730")]
	[BaseEntity.RPC_Client]
	private void Client_HookedSomething(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x894E50", Offset = "0x893C50", VA = "0x180894E50")]
	[BaseEntity.RPC_Client]
	private void Client_UpdateFishState(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x8947D0", Offset = "0x8935D0", VA = "0x1808947D0")]
	[BaseEntity.RPC_Client]
	private void Client_OnCaughtFish(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x894C70", Offset = "0x893A70", VA = "0x180894C70")]
	[BaseEntity.RPC_Client]
	private void Client_ResetLine(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x898AA0", Offset = "0x8978A0", VA = "0x180898AA0", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x898B80", Offset = "0x897980", VA = "0x180898B80", Slot = "146")]
	protected override void ProcessPlayerModel(PlayerModel playerModel)
	{
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x896860", Offset = "0x895660", VA = "0x180896860", Slot = "141")]
	public override void OnHolster()
	{
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x898CA0", Offset = "0x897AA0", VA = "0x180898CA0", Slot = "151")]
	public override void ProcessSpectatorViewmodel(ViewModel vm)
	{
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "152")]
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x896500", Offset = "0x895300", VA = "0x180896500", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x00009678 File Offset: 0x00007878
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x894720", Offset = "0x893520", VA = "0x180894720", Slot = "154")]
	public override bool BlocksGestures()
	{
		return default(bool);
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00009690 File Offset: 0x00007890
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x8945B0", Offset = "0x8933B0", VA = "0x1808945B0")]
	private bool AllowPullInDirection(Vector3 worldDirection, Vector3 bobberPosition)
	{
		return default(bool);
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x000096A8 File Offset: 0x000078A8
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x894EC0", Offset = "0x893CC0", VA = "0x180894EC0")]
	private bool EvaluateFishingPosition(ref Vector3 pos, BasePlayer ply, out BaseFishingRod.FailReason reason, out WaterBody waterBody)
	{
		return default(bool);
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x895D90", Offset = "0x894B90", VA = "0x180895D90")]
	private Item GetCurrentLure()
	{
		return null;
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x000096C0 File Offset: 0x000078C0
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x8963F0", Offset = "0x8951F0", VA = "0x1808963F0")]
	private bool HasReelInInput(InputState state)
	{
		return default(bool);
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x8998F0", Offset = "0x8986F0", VA = "0x1808998F0")]
	public BaseFishingRod()
	{
	}

	// Token: 0x040009DC RID: 2524
	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObjectRef FishingBobberRef;

	// Token: 0x040009DD RID: 2525
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x1F8")]
	public float FishCatchDistance;

	// Token: 0x040009DE RID: 2526
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x200")]
	public LineRenderer ReelLineRenderer;

	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x208")]
	public Transform LineRendererWorldStartPos;

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x210")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseFishingRod.CatchState <CurrentState>k__BackingField;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x214")]
	private BaseFishingRod.FishState currentFishState;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x218")]
	private EntityRef<FishingBobber> currentBobber;

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x228")]
	public float ConditionLossOnSuccess;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x22C")]
	public float ConditionLossOnFail;

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x230")]
	public float GlobalStrainSpeedMultiplier;

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x234")]
	public float MaxCastDistance;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x4000820")]
	public const BaseEntity.Flags Straining = BaseEntity.Flags.Reserved1;

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x238")]
	public ItemModFishable ForceFish;

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x0")]
	public static BaseEntity.Flags PullingLeftFlag;

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x4")]
	public static BaseEntity.Flags PullingRightFlag;

	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x8")]
	public static BaseEntity.Flags ReelingInFlag;

	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x240")]
	public GameObjectRef BobberPreview;

	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x248")]
	public SoundDefinition onLineSoundDef;

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x250")]
	public SoundDefinition strainSoundDef;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x258")]
	public AnimationCurve strainGainCurve;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x260")]
	public SoundDefinition tensionBreakSoundDef;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0xC")]
	[ClientVar]
	public static bool ShowUI;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x268")]
	private Vector3[] lineRendererPositionsArray;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x270")]
	private Vector3[] lineRendererResultArray;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x278")]
	private float[] lineRendererSlack;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x280")]
	private float clientStrainAmountNormalised;

	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x284")]
	private TimeUntil canCancel;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x288")]
	private FishingRodViewmodel rodViewModel;

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x290")]
	private BobberPreview spawnedPreview;

	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x10")]
	private static int FailedCatch_Param;

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x14")]
	private static int CaughtFish_Param;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x18")]
	private static int ReelingIn_Param;

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x1C")]
	private static int IsFishing_Param;

	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x298")]
	private bool aimAnimationReady;

	// Token: 0x040009FE RID: 2558
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x20")]
	private static TimeSince lastLureFail;

	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x24")]
	public static TimeSince lastLineReset;

	// Token: 0x04000A00 RID: 2560
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x28")]
	public static BaseFishingRod.FailReason lastFailReason;

	// Token: 0x04000A01 RID: 2561
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x2A0")]
	private Sound onLineSound;

	// Token: 0x04000A02 RID: 2562
	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x2A8")]
	private Sound strainSound;

	// Token: 0x04000A03 RID: 2563
	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x2B0")]
	private SoundModulation.Modulator strainGainMod;

	// Token: 0x04000A04 RID: 2564
	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x2B8")]
	private TimeUntil consumingBackMovement;

	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x2BC")]
	private TimeSince reelInAnimTimer;

	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000A9F")]
	public enum CatchState
	{
		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4003EFB")]
		None,
		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4003EFC")]
		Aiming,
		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4003EFD")]
		Waiting,
		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4003EFE")]
		Catching,
		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4003EFF")]
		Caught
	}

	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000AA0")]
	[Flags]
	public enum FishState
	{
		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4003F01")]
		PullingLeft = 1,
		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4003F02")]
		PullingRight = 2,
		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4003F03")]
		PullingBack = 4
	}

	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000AA1")]
	public enum FailReason
	{
		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4003F05")]
		UserRequested,
		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4003F06")]
		BadAngle,
		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4003F07")]
		TensionBreak,
		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4003F08")]
		Unequipped,
		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4003F09")]
		TimeOut,
		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4003F0A")]
		Success,
		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4003F0B")]
		NoWaterFound,
		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4003F0C")]
		Obstructed,
		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4003F0D")]
		NoLure,
		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4003F0E")]
		TooShallow,
		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4003F0F")]
		TooClose,
		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4003F10")]
		TooFarAway,
		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4003F11")]
		PlayerMoved
	}
}
