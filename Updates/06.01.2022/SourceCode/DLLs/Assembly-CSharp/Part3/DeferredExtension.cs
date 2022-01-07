using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x020008D3 RID: 2259
[Token(Token = "0x200065D")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xB98F0", Offset = "0xB8CF0")]
[Attribute(Name = "RequireComponent", RVA = "0xB98F0", Offset = "0xB8CF0")]
public class DeferredExtension : MonoBehaviour
{
	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x060036BB RID: 14011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FD")]
	private Camera targetCamera
	{
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x8C5FC0", Offset = "0x8C4DC0", VA = "0x1808C5FC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x060036BC RID: 14012 RVA: 0x00016D70 File Offset: 0x00014F70
	[Token(Token = "0x170003FE")]
	private int TargetWidth
	{
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x8C5F10", Offset = "0x8C4D10", VA = "0x1808C5F10")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x060036BD RID: 14013 RVA: 0x00016D88 File Offset: 0x00014F88
	[Token(Token = "0x170003FF")]
	private int TargetHeight
	{
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x8C5E60", Offset = "0x8C4C60", VA = "0x1808C5E60")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060036BE RID: 14014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E06")]
	[Address(RVA = "0x8C5620", Offset = "0x8C4420", VA = "0x1808C5620")]
	public static void Register(DeferredExtensionMesh mesh)
	{
	}

	// Token: 0x060036BF RID: 14015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E07")]
	[Address(RVA = "0x8C5B60", Offset = "0x8C4960", VA = "0x1808C5B60")]
	public static void Unregister(DeferredExtensionMesh mesh)
	{
	}

	// Token: 0x060036C0 RID: 14016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E08")]
	[Address(RVA = "0x8C54F0", Offset = "0x8C42F0", VA = "0x1808C54F0")]
	private void OnEnable()
	{
	}

	// Token: 0x060036C1 RID: 14017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E09")]
	[Address(RVA = "0x8C5360", Offset = "0x8C4160", VA = "0x1808C5360")]
	private void OnDisable()
	{
	}

	// Token: 0x060036C2 RID: 14018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0A")]
	[Address(RVA = "0x8C4040", Offset = "0x8C2E40", VA = "0x1808C4040")]
	private void CheckCommandBuffers()
	{
	}

	// Token: 0x060036C3 RID: 14019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0B")]
	[Address(RVA = "0x8C45E0", Offset = "0x8C33E0", VA = "0x1808C45E0")]
	private void CleanupCommandBuffers()
	{
	}

	// Token: 0x060036C4 RID: 14020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0C")]
	[Address(RVA = "0x8C47C0", Offset = "0x8C35C0", VA = "0x1808C47C0")]
	private void CreateMaterials()
	{
	}

	// Token: 0x060036C5 RID: 14021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x8C46B0", Offset = "0x8C34B0", VA = "0x1808C46B0")]
	private void CleanupMaterials()
	{
	}

	// Token: 0x060036C6 RID: 14022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x8C3F50", Offset = "0x8C2D50", VA = "0x1808C3F50")]
	private void BindSystemTextures()
	{
	}

	// Token: 0x060036C7 RID: 14023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0F")]
	private void SafeCleanupTexture<T>(ref T tex) where T : Texture
	{
	}

	// Token: 0x060036C8 RID: 14024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x8C4760", Offset = "0x8C3560", VA = "0x1808C4760")]
	private void CleanupSystemTextures()
	{
	}

	// Token: 0x060036C9 RID: 14025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x8C4350", Offset = "0x8C3150", VA = "0x1808C4350")]
	private void CheckSystemTextures()
	{
	}

	// Token: 0x060036CA RID: 14026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x8C3ED0", Offset = "0x8C2CD0", VA = "0x1808C3ED0")]
	public static void BecameVisible(DeferredExtensionMesh mesh)
	{
	}

	// Token: 0x060036CB RID: 14027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E13")]
	[Address(RVA = "0x8C3E50", Offset = "0x8C2C50", VA = "0x1808C3E50")]
	public static void BecameInvisible(DeferredExtensionMesh mesh)
	{
	}

	// Token: 0x060036CC RID: 14028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x8C4860", Offset = "0x8C3660", VA = "0x1808C4860")]
	public void FillCommandBuffer_ExtendGBuffer(CommandBuffer cb)
	{
	}

	// Token: 0x060036CD RID: 14029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x8C4B20", Offset = "0x8C3920", VA = "0x1808C4B20")]
	public void FillCommandBuffer_PostSubsurface(CommandBuffer cb)
	{
	}

	// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E16")]
	[Address(RVA = "0x8C4230", Offset = "0x8C3030", VA = "0x1808C4230")]
	private void CheckConsoleVars()
	{
	}

	// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E17")]
	[Address(RVA = "0x8C42D0", Offset = "0x8C30D0", VA = "0x1808C42D0")]
	private void CheckShaderKeywords()
	{
	}

	// Token: 0x060036D0 RID: 14032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E18")]
	[Address(RVA = "0x8C56A0", Offset = "0x8C44A0", VA = "0x1808C56A0")]
	private void SetShaderGlobals()
	{
	}

	// Token: 0x060036D1 RID: 14033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E19")]
	[Address(RVA = "0x8C5BE0", Offset = "0x8C49E0", VA = "0x1808C5BE0")]
	private void Update()
	{
	}

	// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x8C5610", Offset = "0x8C4410", VA = "0x1808C5610")]
	private void OnPreRender()
	{
	}

	// Token: 0x060036D3 RID: 14035 RVA: 0x00016DA0 File Offset: 0x00014FA0
	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0x8C52F0", Offset = "0x8C40F0", VA = "0x1808C52F0")]
	public static float LightIntensityScale(float intensity)
	{
		return 0f;
	}

	// Token: 0x060036D4 RID: 14036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0x8C5D90", Offset = "0x8C4B90", VA = "0x1808C5D90")]
	public DeferredExtension()
	{
	}

	// Token: 0x04003325 RID: 13093
	[Token(Token = "0x4002775")]
	[FieldOffset(Offset = "0x18")]
	public ExtendGBufferParams extendGBuffer;

	// Token: 0x04003326 RID: 13094
	[Token(Token = "0x4002776")]
	[FieldOffset(Offset = "0x1C")]
	public SubsurfaceScatteringParams subsurfaceScattering;

	// Token: 0x04003327 RID: 13095
	[Token(Token = "0x4002777")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D blueNoise;

	// Token: 0x04003328 RID: 13096
	[Token(Token = "0x4002778")]
	[FieldOffset(Offset = "0x38")]
	public float depthScale;

	// Token: 0x04003329 RID: 13097
	[Token(Token = "0x4002779")]
	[FieldOffset(Offset = "0x3C")]
	public bool debug;

	// Token: 0x0400332A RID: 13098
	[Token(Token = "0x400277A")]
	[FieldOffset(Offset = "0x3D")]
	public bool forceToCameraResolution;

	// Token: 0x0400332B RID: 13099
	[Token(Token = "0x400277B")]
	[FieldOffset(Offset = "0x40")]
	private Camera _targetCamera;

	// Token: 0x0400332C RID: 13100
	[Token(Token = "0x400277C")]
	[FieldOffset(Offset = "0x48")]
	private CommandBufferManager commandBufferManager;

	// Token: 0x0400332D RID: 13101
	[Token(Token = "0x400277D")]
	[FieldOffset(Offset = "0x50")]
	private CommandBufferDesc extendGBufferCBDesc;

	// Token: 0x0400332E RID: 13102
	[Token(Token = "0x400277E")]
	[FieldOffset(Offset = "0x58")]
	private CommandBufferDesc postSubsurfaceCBDesc;

	// Token: 0x0400332F RID: 13103
	[Token(Token = "0x400277F")]
	[FieldOffset(Offset = "0x60")]
	private Material postSubsurfaceMat;

	// Token: 0x04003330 RID: 13104
	[Token(Token = "0x4002780")]
	[FieldOffset(Offset = "0x68")]
	private int frameIndexMod8;

	// Token: 0x04003331 RID: 13105
	[Token(Token = "0x4002781")]
	[FieldOffset(Offset = "0x70")]
	private PostProcessLayer post;

	// Token: 0x04003332 RID: 13106
	[Token(Token = "0x4002782")]
	[FieldOffset(Offset = "0x78")]
	private int gbufferWidth;

	// Token: 0x04003333 RID: 13107
	[Token(Token = "0x4002783")]
	[FieldOffset(Offset = "0x7C")]
	private int gbufferHeight;

	// Token: 0x04003334 RID: 13108
	[Token(Token = "0x4002784")]
	[FieldOffset(Offset = "0x80")]
	private RenderTexture gbufferTexture4;

	// Token: 0x04003335 RID: 13109
	[Token(Token = "0x4002785")]
	[FieldOffset(Offset = "0x88")]
	private RenderTexture gbufferTexture5;

	// Token: 0x04003336 RID: 13110
	[Token(Token = "0x4002786")]
	[FieldOffset(Offset = "0x90")]
	private RenderTargetIdentifier[] targets;

	// Token: 0x04003337 RID: 13111
	[Token(Token = "0x4002787")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<DeferredExtensionMesh> registeredMeshes;

	// Token: 0x04003338 RID: 13112
	[Token(Token = "0x4002788")]
	[FieldOffset(Offset = "0x8")]
	private static HashSet<DeferredExtensionMesh> visibleMeshes;

	// Token: 0x020008D4 RID: 2260
	[Token(Token = "0x2000CA1")]
	private enum SubsurfacePass
	{
		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x40048A3")]
		SetupFullRes,
		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x40048A4")]
		SetupHalfRes,
		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x40048A5")]
		Direction0,
		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x40048A6")]
		Direction1,
		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x40048A7")]
		RecombineFullRes,
		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x40048A8")]
		RecombineHalfRes,
		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x40048A9")]
		RecombinePassthrough
	}
}
