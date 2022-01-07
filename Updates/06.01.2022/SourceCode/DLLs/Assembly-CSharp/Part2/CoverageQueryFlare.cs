using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000214 RID: 532
[Token(Token = "0x2000162")]
public class CoverageQueryFlare : BaseMonoBehaviour, IClientComponent, IOnParentDestroying, ILOD
{
	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0000C720 File Offset: 0x0000A920
	[Token(Token = "0x1700018B")]
	public float CurrentDistance
	{
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x6D7AC0", Offset = "0x6D68C0", VA = "0x1806D7AC0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x0000C738 File Offset: 0x0000A938
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x6D6900", Offset = "0x6D5700", VA = "0x1806D6900")]
	private float GetDistance()
	{
		return 0f;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001262")]
	[Address(RVA = "0x6D6610", Offset = "0x6D5410", VA = "0x1806D6610")]
	private void Awake()
	{
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x6D6CD0", Offset = "0x6D5AD0", VA = "0x1806D6CD0")]
	private void OnEnable()
	{
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x6D6760", Offset = "0x6D5560", VA = "0x1806D6760", Slot = "7")]
	public void ChangeLOD()
	{
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x6D6EB0", Offset = "0x6D5CB0", VA = "0x1806D6EB0", Slot = "8")]
	public void RefreshLOD()
	{
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x0000C750 File Offset: 0x0000A950
	[Token(Token = "0x6001266")]
	[Address(RVA = "0x6D69D0", Offset = "0x6D57D0", VA = "0x1806D69D0")]
	private int GetLOD(float distance)
	{
		return 0;
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001267")]
	[Address(RVA = "0x6D7360", Offset = "0x6D6160", VA = "0x1806D7360")]
	private void SetLOD(int newlod)
	{
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x6D74B0", Offset = "0x6D62B0", VA = "0x1806D74B0")]
	private void Show()
	{
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x6D6B20", Offset = "0x6D5920", VA = "0x1806D6B20")]
	private void Hide()
	{
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x6D73E0", Offset = "0x6D61E0", VA = "0x1806D73E0")]
	private void ShowRenderers()
	{
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126B")]
	[Address(RVA = "0x6D6A50", Offset = "0x6D5850", VA = "0x1806D6A50")]
	private void HideRenderers()
	{
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126C")]
	[Address(RVA = "0x6D6E80", Offset = "0x6D5C80", VA = "0x1806D6E80", Slot = "6")]
	public void OnParentDestroying()
	{
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126D")]
	[Address(RVA = "0x6D7590", Offset = "0x6D6390", VA = "0x1806D7590")]
	public void Tick()
	{
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126E")]
	[Address(RVA = "0x6D7740", Offset = "0x6D6540", VA = "0x1806D7740")]
	private void UpdateMaterialProperties()
	{
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x0000C768 File Offset: 0x0000A968
	[Token(Token = "0x600126F")]
	[Address(RVA = "0x6D6FB0", Offset = "0x6D5DB0", VA = "0x1806D6FB0")]
	public float SampleVisibility()
	{
		return 0f;
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001270")]
	[Address(RVA = "0x6D7350", Offset = "0x6D6150", VA = "0x1806D7350")]
	public void SetFlareIntensity(float intensity)
	{
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001271")]
	[Address(RVA = "0x6D6F40", Offset = "0x6D5D40", VA = "0x1806D6F40")]
	private void RegisterCoverageQuery()
	{
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001272")]
	[Address(RVA = "0x6D7620", Offset = "0x6D6420", VA = "0x1806D7620")]
	private void UnRegisterCoverageQuery()
	{
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001273")]
	[Address(RVA = "0x6D6BA0", Offset = "0x6D59A0", VA = "0x1806D6BA0")]
	private void OnDisable()
	{
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x6D7A20", Offset = "0x6D6820", VA = "0x1806D7A20")]
	public CoverageQueryFlare()
	{
	}

	// Token: 0x04001181 RID: 4481
	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0x18")]
	public bool isDynamic;

	// Token: 0x04001182 RID: 4482
	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0x19")]
	public bool timeShimmer;

	// Token: 0x04001183 RID: 4483
	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0x1A")]
	public bool positionalShimmer;

	// Token: 0x04001184 RID: 4484
	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0x1B")]
	public bool rotate;

	// Token: 0x04001185 RID: 4485
	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x1C")]
	public float maxVisibleDistance;

	// Token: 0x04001186 RID: 4486
	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x20")]
	public bool lightScaled;

	// Token: 0x04001187 RID: 4487
	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x24")]
	public float dotMin;

	// Token: 0x04001188 RID: 4488
	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0x28")]
	public float dotMax;

	// Token: 0x04001189 RID: 4489
	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x2C")]
	public CoverageQueries.RadiusSpace coverageRadiusSpace;

	// Token: 0x0400118A RID: 4490
	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0x30")]
	public float coverageRadius;

	// Token: 0x0400118B RID: 4491
	[Token(Token = "0x4000E45")]
	[FieldOffset(Offset = "0x34")]
	public LODDistanceMode DistanceMode;

	// Token: 0x0400118C RID: 4492
	[Token(Token = "0x4000E46")]
	private const float tickRate = 0.030303031f;

	// Token: 0x0400118D RID: 4493
	[Token(Token = "0x4000E47")]
	[FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock block;

	// Token: 0x0400118E RID: 4494
	[Token(Token = "0x4000E48")]
	[FieldOffset(Offset = "0x38")]
	private bool isCulled;

	// Token: 0x0400118F RID: 4495
	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x39")]
	private bool isOccluded;

	// Token: 0x04001190 RID: 4496
	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x3C")]
	private int curlod;

	// Token: 0x04001191 RID: 4497
	[Token(Token = "0x4000E4B")]
	[FieldOffset(Offset = "0x40")]
	private CoverageQueries.Query query;

	// Token: 0x04001192 RID: 4498
	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x48")]
	private bool queryRegistered;

	// Token: 0x04001193 RID: 4499
	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x4C")]
	private float privateRand;

	// Token: 0x04001194 RID: 4500
	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x50")]
	private bool force;

	// Token: 0x04001195 RID: 4501
	[Token(Token = "0x4000E4F")]
	[FieldOffset(Offset = "0x58")]
	private LODCell cell;

	// Token: 0x04001196 RID: 4502
	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x60")]
	private float currentDistance;

	// Token: 0x04001197 RID: 4503
	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x68")]
	private Renderer flareRenderer;

	// Token: 0x04001198 RID: 4504
	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x70")]
	private Renderer orbRenderer;

	// Token: 0x04001199 RID: 4505
	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x78")]
	private float startColorMultiplier;

	// Token: 0x0400119A RID: 4506
	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x7C")]
	private float flareIntensity;

	// Token: 0x0400119B RID: 4507
	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x80")]
	private float visibleFraction;

	// Token: 0x0400119C RID: 4508
	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x84")]
	private bool destroying;

	// Token: 0x0400119D RID: 4509
	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x88")]
	private readonly int VisibleFraction_DotMin_DotMax_Rotate;

	// Token: 0x0400119E RID: 4510
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x8C")]
	private readonly int PShimmer_TShimmer_Seed_LightScale;

	// Token: 0x0400119F RID: 4511
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x90")]
	private readonly int ColorMultID;

	// Token: 0x040011A0 RID: 4512
	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x94")]
	private LODEnvironmentMode EnvironmentMode;
}
