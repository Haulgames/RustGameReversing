using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000BD8 RID: 3032
[Token(Token = "0x2000887")]
[Attribute(Name = "AddComponentMenu", RVA = "0x772D0", Offset = "0x766D0")]
public class AmplifyOcclusionBase : MonoBehaviour
{
	// Token: 0x06004603 RID: 17923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B44")]
	[Address(RVA = "0x82EEA0", Offset = "0x82DCA0", VA = "0x18082EEA0")]
	private void createCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent)
	{
	}

	// Token: 0x06004604 RID: 17924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B45")]
	[Address(RVA = "0x82CE50", Offset = "0x82BC50", VA = "0x18082CE50")]
	private void cleanupCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer)
	{
	}

	// Token: 0x06004605 RID: 17925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B46")]
	[Address(RVA = "0x82F0F0", Offset = "0x82DEF0", VA = "0x18082F0F0")]
	private void createQuadMesh()
	{
	}

	// Token: 0x06004606 RID: 17926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B47")]
	[Address(RVA = "0x82B470", Offset = "0x82A270", VA = "0x18082B470")]
	private void PerformBlit(CommandBuffer cb, Material mat, int pass)
	{
	}

	// Token: 0x06004607 RID: 17927 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003B48")]
	[Address(RVA = "0x82EF80", Offset = "0x82DD80", VA = "0x18082EF80")]
	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg)
	{
		return null;
	}

	// Token: 0x06004608 RID: 17928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B49")]
	[Address(RVA = "0x82C800", Offset = "0x82B600", VA = "0x18082C800")]
	private void checkMaterials(bool aThroughErrorMsg)
	{
	}

	// Token: 0x06004609 RID: 17929 RVA: 0x00019EF0 File Offset: 0x000180F0
	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0x82CDD0", Offset = "0x82BBD0", VA = "0x18082CDD0")]
	private bool checkRenderTextureFormats()
	{
		return default(bool);
	}

	// Token: 0x0600460A RID: 17930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0x82AE80", Offset = "0x829C80", VA = "0x18082AE80")]
	private void OnEnable()
	{
	}

	// Token: 0x0600460B RID: 17931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0x82AE30", Offset = "0x829C30", VA = "0x18082AE30")]
	private void Reset()
	{
	}

	// Token: 0x0600460C RID: 17932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4D")]
	[Address(RVA = "0x82AE30", Offset = "0x829C30", VA = "0x18082AE30")]
	private void OnDisable()
	{
	}

	// Token: 0x0600460D RID: 17933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4E")]
	[Address(RVA = "0x82F620", Offset = "0x82E420", VA = "0x18082F620")]
	private void releaseRT()
	{
	}

	// Token: 0x0600460E RID: 17934 RVA: 0x00019F08 File Offset: 0x00018108
	[Token(Token = "0x6003B4F")]
	[Address(RVA = "0x82CA70", Offset = "0x82B870", VA = "0x18082CA70")]
	private bool checkParamsChanged()
	{
		return default(bool);
	}

	// Token: 0x0600460F RID: 17935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B50")]
	[Address(RVA = "0x82F990", Offset = "0x82E790", VA = "0x18082F990")]
	private void updateParams()
	{
	}

	// Token: 0x06004610 RID: 17936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B51")]
	[Address(RVA = "0x82C060", Offset = "0x82AE60", VA = "0x18082C060")]
	private void Update()
	{
	}

	// Token: 0x06004611 RID: 17937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B52")]
	[Address(RVA = "0x82B020", Offset = "0x829E20", VA = "0x18082B020")]
	private void OnPreRender()
	{
	}

	// Token: 0x06004612 RID: 17938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B53")]
	[Address(RVA = "0x82AF90", Offset = "0x829D90", VA = "0x18082AF90")]
	private void OnPostRender()
	{
	}

	// Token: 0x06004613 RID: 17939 RVA: 0x00019F20 File Offset: 0x00018120
	[Token(Token = "0x6003B54")]
	[Address(RVA = "0x82F820", Offset = "0x82E620", VA = "0x18082F820")]
	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Point)
	{
		return 0;
	}

	// Token: 0x06004614 RID: 17940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B55")]
	[Address(RVA = "0x82F960", Offset = "0x82E760", VA = "0x18082F960")]
	private void safeReleaseTemporaryRT(CommandBuffer cb, int id)
	{
	}

	// Token: 0x06004615 RID: 17941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003B56")]
	[Address(RVA = "0x82F6F0", Offset = "0x82E4F0", VA = "0x18082F6F0")]
	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = FilterMode.Point)
	{
		return null;
	}

	// Token: 0x06004616 RID: 17942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B57")]
	[Address(RVA = "0x82F8A0", Offset = "0x82E6A0", VA = "0x18082F8A0")]
	private void safeReleaseRT(ref RenderTexture rt)
	{
	}

	// Token: 0x06004617 RID: 17943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B58")]
	[Address(RVA = "0x82ADD0", Offset = "0x829BD0", VA = "0x18082ADD0")]
	private void BeginSample(CommandBuffer cb, string name)
	{
	}

	// Token: 0x06004618 RID: 17944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B59")]
	[Address(RVA = "0x82AE00", Offset = "0x829C00", VA = "0x18082AE00")]
	private void EndSample(CommandBuffer cb, string name)
	{
	}

	// Token: 0x06004619 RID: 17945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5A")]
	[Address(RVA = "0x82E350", Offset = "0x82D150", VA = "0x18082E350")]
	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb)
	{
	}

	// Token: 0x0600461A RID: 17946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5B")]
	[Address(RVA = "0x82CF70", Offset = "0x82BD70", VA = "0x18082CF70")]
	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight)
	{
	}

	// Token: 0x0600461B RID: 17947 RVA: 0x00019F38 File Offset: 0x00018138
	[Token(Token = "0x6003B5C")]
	[Address(RVA = "0x82F600", Offset = "0x82E400", VA = "0x18082F600")]
	private int getTemporalPass()
	{
		return 0;
	}

	// Token: 0x0600461C RID: 17948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5D")]
	[Address(RVA = "0x82EA60", Offset = "0x82D860", VA = "0x18082EA60")]
	private void commandBuffer_TemporalFilter(CommandBuffer cb)
	{
	}

	// Token: 0x0600461D RID: 17949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5E")]
	[Address(RVA = "0x82D5E0", Offset = "0x82C3E0", VA = "0x18082D5E0")]
	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget)
	{
	}

	// Token: 0x0600461E RID: 17950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5F")]
	[Address(RVA = "0x82DFE0", Offset = "0x82CDE0", VA = "0x18082DFE0")]
	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb)
	{
	}

	// Token: 0x0600461F RID: 17951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B60")]
	[Address(RVA = "0x82D270", Offset = "0x82C070", VA = "0x18082D270")]
	private void commandBuffer_FillApplyDebug(CommandBuffer cb)
	{
	}

	// Token: 0x06004620 RID: 17952 RVA: 0x00019F50 File Offset: 0x00018150
	[Token(Token = "0x6003B61")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030")]
	private bool isStereoSinglePassEnabled()
	{
		return default(bool);
	}

	// Token: 0x06004621 RID: 17953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B62")]
	[Address(RVA = "0x82BB10", Offset = "0x82A910", VA = "0x18082BB10")]
	private void UpdateGlobalShaderConstants()
	{
	}

	// Token: 0x06004622 RID: 17954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B63")]
	[Address(RVA = "0x82B580", Offset = "0x82A380", VA = "0x18082B580")]
	private void UpdateGlobalShaderConstants_AmbientOcclusion()
	{
	}

	// Token: 0x06004623 RID: 17955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B64")]
	[Address(RVA = "0x82B760", Offset = "0x82A560", VA = "0x18082B760")]
	private void UpdateGlobalShaderConstants_Matrices()
	{
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B65")]
	[Address(RVA = "0x82C3E0", Offset = "0x82B1E0", VA = "0x18082C3E0")]
	public AmplifyOcclusionBase()
	{
	}

	// Token: 0x04004264 RID: 16996
	[Token(Token = "0x4003348")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x7F840", Offset = "0x7EC40")]
	public AmplifyOcclusionBase.ApplicationMethod ApplyMethod;

	// Token: 0x04004265 RID: 16997
	[Token(Token = "0x4003349")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x7FA40", Offset = "0x7EE40")]
	public AmplifyOcclusionBase.SampleCountLevel SampleCount;

	// Token: 0x04004266 RID: 16998
	[Token(Token = "0x400334A")]
	[FieldOffset(Offset = "0x20")]
	public AmplifyOcclusionBase.PerPixelNormalSource PerPixelNormals;

	// Token: 0x04004267 RID: 16999
	[Token(Token = "0x400334B")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x80E50", Offset = "0x80250")]
	[Attribute(Name = "RangeAttribute", RVA = "0x80E50", Offset = "0x80250")]
	public float Intensity;

	// Token: 0x04004268 RID: 17000
	[Token(Token = "0x400334C")]
	[FieldOffset(Offset = "0x28")]
	public Color Tint;

	// Token: 0x04004269 RID: 17001
	[Token(Token = "0x400334D")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x810C0", Offset = "0x804C0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x810C0", Offset = "0x804C0")]
	public float Radius;

	// Token: 0x0400426A RID: 17002
	[Token(Token = "0x400334E")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x81320", Offset = "0x80720")]
	[Attribute(Name = "RangeAttribute", RVA = "0x81320", Offset = "0x80720")]
	[NonSerialized]
	public int PixelRadiusLimit;

	// Token: 0x0400426B RID: 17003
	[Token(Token = "0x400334F")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x814B0", Offset = "0x808B0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x814B0", Offset = "0x808B0")]
	[NonSerialized]
	public float RadiusIntensity;

	// Token: 0x0400426C RID: 17004
	[Token(Token = "0x4003350")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x816D0", Offset = "0x80AD0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x816D0", Offset = "0x80AD0")]
	public float PowerExponent;

	// Token: 0x0400426D RID: 17005
	[Token(Token = "0x4003351")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x819D0", Offset = "0x80DD0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x819D0", Offset = "0x80DD0")]
	public float Bias;

	// Token: 0x0400426E RID: 17006
	[Token(Token = "0x4003352")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x81AB0", Offset = "0x80EB0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x81AB0", Offset = "0x80EB0")]
	public float Thickness;

	// Token: 0x0400426F RID: 17007
	[Token(Token = "0x4003353")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x81CB0", Offset = "0x810B0")]
	public bool Downsample;

	// Token: 0x04004270 RID: 17008
	[Token(Token = "0x4003354")]
	[FieldOffset(Offset = "0x51")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x81FE0", Offset = "0x813E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x81FE0", Offset = "0x813E0")]
	public bool FadeEnabled;

	// Token: 0x04004271 RID: 17009
	[Token(Token = "0x4003355")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x82250", Offset = "0x81650")]
	public float FadeStart;

	// Token: 0x04004272 RID: 17010
	[Token(Token = "0x4003356")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x82350", Offset = "0x81750")]
	public float FadeLength;

	// Token: 0x04004273 RID: 17011
	[Token(Token = "0x4003357")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x837F0", Offset = "0x82BF0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x837F0", Offset = "0x82BF0")]
	public float FadeToIntensity;

	// Token: 0x04004274 RID: 17012
	[Token(Token = "0x4003358")]
	[FieldOffset(Offset = "0x60")]
	public Color FadeToTint;

	// Token: 0x04004275 RID: 17013
	[Token(Token = "0x4003359")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x83850", Offset = "0x82C50")]
	[Attribute(Name = "RangeAttribute", RVA = "0x83850", Offset = "0x82C50")]
	public float FadeToRadius;

	// Token: 0x04004276 RID: 17014
	[Token(Token = "0x400335A")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x839A0", Offset = "0x82DA0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x839A0", Offset = "0x82DA0")]
	public float FadeToPowerExponent;

	// Token: 0x04004277 RID: 17015
	[Token(Token = "0x400335B")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x83B00", Offset = "0x82F00")]
	[Attribute(Name = "RangeAttribute", RVA = "0x83B00", Offset = "0x82F00")]
	public float FadeToThickness;

	// Token: 0x04004278 RID: 17016
	[Token(Token = "0x400335C")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x83BE0", Offset = "0x82FE0")]
	public bool BlurEnabled;

	// Token: 0x04004279 RID: 17017
	[Token(Token = "0x400335D")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x83CA0", Offset = "0x830A0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x83CA0", Offset = "0x830A0")]
	public int BlurRadius;

	// Token: 0x0400427A RID: 17018
	[Token(Token = "0x400335E")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x83DD0", Offset = "0x831D0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x83DD0", Offset = "0x831D0")]
	public int BlurPasses;

	// Token: 0x0400427B RID: 17019
	[Token(Token = "0x400335F")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x83FE0", Offset = "0x833E0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x83FE0", Offset = "0x833E0")]
	public float BlurSharpness;

	// Token: 0x0400427C RID: 17020
	[Token(Token = "0x4003360")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x84260", Offset = "0x83660")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x84260", Offset = "0x83660")]
	public bool FilterEnabled;

	// Token: 0x0400427D RID: 17021
	[Token(Token = "0x4003361")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x843E0", Offset = "0x837E0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x843E0", Offset = "0x837E0")]
	public float FilterBlending;

	// Token: 0x0400427E RID: 17022
	[Token(Token = "0x4003362")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x844C0", Offset = "0x838C0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x844C0", Offset = "0x838C0")]
	public float FilterResponse;

	// Token: 0x0400427F RID: 17023
	[Token(Token = "0x4003363")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x845A0", Offset = "0x839A0")]
	[NonSerialized]
	public bool TemporalDirections;

	// Token: 0x04004280 RID: 17024
	[Token(Token = "0x4003364")]
	[FieldOffset(Offset = "0x99")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x84680", Offset = "0x83A80")]
	[NonSerialized]
	public bool TemporalOffsets;

	// Token: 0x04004281 RID: 17025
	[Token(Token = "0x4003365")]
	[FieldOffset(Offset = "0x9A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x846F0", Offset = "0x83AF0")]
	[NonSerialized]
	public bool TemporalDilation;

	// Token: 0x04004282 RID: 17026
	[Token(Token = "0x4003366")]
	[FieldOffset(Offset = "0x9B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x85A90", Offset = "0x84E90")]
	[NonSerialized]
	public bool UseMotionVectors;

	// Token: 0x04004283 RID: 17027
	[Token(Token = "0x4003367")]
	[FieldOffset(Offset = "0x9C")]
	private AmplifyOcclusionBase.PerPixelNormalSource m_prevPerPixelNormals;

	// Token: 0x04004284 RID: 17028
	[Token(Token = "0x4003368")]
	[FieldOffset(Offset = "0xA0")]
	private AmplifyOcclusionBase.ApplicationMethod m_prevApplyMethod;

	// Token: 0x04004285 RID: 17029
	[Token(Token = "0x4003369")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_prevDeferredReflections;

	// Token: 0x04004286 RID: 17030
	[Token(Token = "0x400336A")]
	[FieldOffset(Offset = "0xA8")]
	private AmplifyOcclusionBase.SampleCountLevel m_prevSampleCount;

	// Token: 0x04004287 RID: 17031
	[Token(Token = "0x400336B")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_prevDownsample;

	// Token: 0x04004288 RID: 17032
	[Token(Token = "0x400336C")]
	[FieldOffset(Offset = "0xAD")]
	private bool m_prevBlurEnabled;

	// Token: 0x04004289 RID: 17033
	[Token(Token = "0x400336D")]
	[FieldOffset(Offset = "0xB0")]
	private int m_prevBlurRadius;

	// Token: 0x0400428A RID: 17034
	[Token(Token = "0x400336E")]
	[FieldOffset(Offset = "0xB4")]
	private int m_prevBlurPasses;

	// Token: 0x0400428B RID: 17035
	[Token(Token = "0x400336F")]
	[FieldOffset(Offset = "0xB8")]
	private Camera m_targetCamera;

	// Token: 0x0400428C RID: 17036
	[Token(Token = "0x4003370")]
	[FieldOffset(Offset = "0xC0")]
	private RenderTargetIdentifier[] applyDebugTargetsTemporal;

	// Token: 0x0400428D RID: 17037
	[Token(Token = "0x4003371")]
	[FieldOffset(Offset = "0xC8")]
	private RenderTargetIdentifier[] applyPostEffectTargetsTemporal;

	// Token: 0x0400428E RID: 17038
	[Token(Token = "0x4003372")]
	[FieldOffset(Offset = "0xD0")]
	private RenderTargetIdentifier[] applyDeferredTargets_Log_Temporal;

	// Token: 0x0400428F RID: 17039
	[Token(Token = "0x4003373")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTargetIdentifier[] applyDeferredTargetsTemporal;

	// Token: 0x04004290 RID: 17040
	[Token(Token = "0x4003374")]
	[FieldOffset(Offset = "0xE0")]
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Occlusion;

	// Token: 0x04004291 RID: 17041
	[Token(Token = "0x4003375")]
	[FieldOffset(Offset = "0xF8")]
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Apply;

	// Token: 0x04004292 RID: 17042
	[Token(Token = "0x4003376")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh m_quadMesh;

	// Token: 0x04004293 RID: 17043
	[Token(Token = "0x4003377")]
	[FieldOffset(Offset = "0x8")]
	private static Material m_occlusionMat;

	// Token: 0x04004294 RID: 17044
	[Token(Token = "0x4003378")]
	[FieldOffset(Offset = "0x10")]
	private static Material m_blurMat;

	// Token: 0x04004295 RID: 17045
	[Token(Token = "0x4003379")]
	[FieldOffset(Offset = "0x18")]
	private static Material m_applyOcclusionMat;

	// Token: 0x04004296 RID: 17046
	[Token(Token = "0x400337A")]
	[FieldOffset(Offset = "0x110")]
	private RenderTextureFormat m_occlusionRTFormat;

	// Token: 0x04004297 RID: 17047
	[Token(Token = "0x400337B")]
	[FieldOffset(Offset = "0x114")]
	private RenderTextureFormat m_accumTemporalRTFormat;

	// Token: 0x04004298 RID: 17048
	[Token(Token = "0x400337C")]
	[FieldOffset(Offset = "0x118")]
	private RenderTextureFormat m_temporaryEmissionRTFormat;

	// Token: 0x04004299 RID: 17049
	[Token(Token = "0x400337D")]
	[FieldOffset(Offset = "0x11C")]
	private bool m_paramsChanged;

	// Token: 0x0400429A RID: 17050
	[Token(Token = "0x400337E")]
	[FieldOffset(Offset = "0x120")]
	private RenderTexture m_occlusionDepthRT;

	// Token: 0x0400429B RID: 17051
	[Token(Token = "0x400337F")]
	[FieldOffset(Offset = "0x128")]
	private RenderTexture[] m_temporalAccumRT;

	// Token: 0x0400429C RID: 17052
	[Token(Token = "0x4003380")]
	[FieldOffset(Offset = "0x130")]
	private uint m_sampleStep;

	// Token: 0x0400429D RID: 17053
	[Token(Token = "0x4003381")]
	[FieldOffset(Offset = "0x134")]
	private uint m_curStepIdx;

	// Token: 0x0400429E RID: 17054
	[Token(Token = "0x4003382")]
	[FieldOffset(Offset = "0x20")]
	private static readonly uint m_maxSampleSteps;

	// Token: 0x0400429F RID: 17055
	[Token(Token = "0x4003383")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int PerPixelNormalSourceCount;

	// Token: 0x040042A0 RID: 17056
	[Token(Token = "0x4003384")]
	[FieldOffset(Offset = "0x138")]
	private Matrix4x4 m_prevViewProjMatrixLeft;

	// Token: 0x040042A1 RID: 17057
	[Token(Token = "0x4003385")]
	[FieldOffset(Offset = "0x178")]
	private Matrix4x4 m_prevInvViewProjMatrixLeft;

	// Token: 0x040042A2 RID: 17058
	[Token(Token = "0x4003386")]
	[FieldOffset(Offset = "0x1B8")]
	private Matrix4x4 m_prevViewProjMatrixRight;

	// Token: 0x040042A3 RID: 17059
	[Token(Token = "0x4003387")]
	[FieldOffset(Offset = "0x1F8")]
	private Matrix4x4 m_prevInvViewProjMatrixRight;

	// Token: 0x040042A4 RID: 17060
	[Token(Token = "0x4003388")]
	[FieldOffset(Offset = "0x28")]
	private static readonly float[] m_temporalRotations;

	// Token: 0x040042A5 RID: 17061
	[Token(Token = "0x4003389")]
	[FieldOffset(Offset = "0x30")]
	private static readonly float[] m_spatialOffsets;

	// Token: 0x040042A6 RID: 17062
	[Token(Token = "0x400338A")]
	[FieldOffset(Offset = "0x238")]
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets;

	// Token: 0x040042A7 RID: 17063
	[Token(Token = "0x400338B")]
	[FieldOffset(Offset = "0x240")]
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets_Log;

	// Token: 0x040042A8 RID: 17064
	[Token(Token = "0x400338C")]
	[FieldOffset(Offset = "0x248")]
	private AmplifyOcclusionBase.TargetDesc m_target;

	// Token: 0x02000BD9 RID: 3033
	[Token(Token = "0x2000D79")]
	public enum ApplicationMethod
	{
		// Token: 0x040042AA RID: 17066
		[Token(Token = "0x4004C02")]
		PostEffect,
		// Token: 0x040042AB RID: 17067
		[Token(Token = "0x4004C03")]
		Deferred,
		// Token: 0x040042AC RID: 17068
		[Token(Token = "0x4004C04")]
		Debug
	}

	// Token: 0x02000BDA RID: 3034
	[Token(Token = "0x2000D7A")]
	public enum PerPixelNormalSource
	{
		// Token: 0x040042AE RID: 17070
		[Token(Token = "0x4004C06")]
		None,
		// Token: 0x040042AF RID: 17071
		[Token(Token = "0x4004C07")]
		Camera,
		// Token: 0x040042B0 RID: 17072
		[Token(Token = "0x4004C08")]
		GBuffer,
		// Token: 0x040042B1 RID: 17073
		[Token(Token = "0x4004C09")]
		GBufferOctaEncoded
	}

	// Token: 0x02000BDB RID: 3035
	[Token(Token = "0x2000D7B")]
	public enum SampleCountLevel
	{
		// Token: 0x040042B3 RID: 17075
		[Token(Token = "0x4004C0B")]
		Low,
		// Token: 0x040042B4 RID: 17076
		[Token(Token = "0x4004C0C")]
		Medium,
		// Token: 0x040042B5 RID: 17077
		[Token(Token = "0x4004C0D")]
		High,
		// Token: 0x040042B6 RID: 17078
		[Token(Token = "0x4004C0E")]
		VeryHigh
	}

	// Token: 0x02000BDC RID: 3036
	[Token(Token = "0x2000D7C")]
	private struct CmdBuffer
	{
		// Token: 0x040042B7 RID: 17079
		[Token(Token = "0x4004C0F")]
		[FieldOffset(Offset = "0x0")]
		public CommandBuffer cmdBuffer;

		// Token: 0x040042B8 RID: 17080
		[Token(Token = "0x4004C10")]
		[FieldOffset(Offset = "0x8")]
		public CameraEvent cmdBufferEvent;

		// Token: 0x040042B9 RID: 17081
		[Token(Token = "0x4004C11")]
		[FieldOffset(Offset = "0x10")]
		public string cmdBufferName;
	}

	// Token: 0x02000BDD RID: 3037
	[Token(Token = "0x2000D7D")]
	private struct TargetDesc
	{
		// Token: 0x040042BA RID: 17082
		[Token(Token = "0x4004C12")]
		[FieldOffset(Offset = "0x0")]
		public int fullWidth;

		// Token: 0x040042BB RID: 17083
		[Token(Token = "0x4004C13")]
		[FieldOffset(Offset = "0x4")]
		public int fullHeight;

		// Token: 0x040042BC RID: 17084
		[Token(Token = "0x4004C14")]
		[FieldOffset(Offset = "0x8")]
		public RenderTextureFormat format;

		// Token: 0x040042BD RID: 17085
		[Token(Token = "0x4004C15")]
		[FieldOffset(Offset = "0xC")]
		public int width;

		// Token: 0x040042BE RID: 17086
		[Token(Token = "0x4004C16")]
		[FieldOffset(Offset = "0x10")]
		public int height;

		// Token: 0x040042BF RID: 17087
		[Token(Token = "0x4004C17")]
		[FieldOffset(Offset = "0x14")]
		public float oneOverWidth;

		// Token: 0x040042C0 RID: 17088
		[Token(Token = "0x4004C18")]
		[FieldOffset(Offset = "0x18")]
		public float oneOverHeight;
	}

	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000D7E")]
	private static class ShaderPass
	{
		// Token: 0x040042C1 RID: 17089
		[Token(Token = "0x4004C19")]
		public const int CombineDownsampledOcclusionDepth = 16;

		// Token: 0x040042C2 RID: 17090
		[Token(Token = "0x4004C1A")]
		public const int CombineEmission = 17;

		// Token: 0x040042C3 RID: 17091
		[Token(Token = "0x4004C1B")]
		public const int CombineEmissionLog = 18;

		// Token: 0x040042C4 RID: 17092
		[Token(Token = "0x4004C1C")]
		public const int BlurHorizontal1 = 0;

		// Token: 0x040042C5 RID: 17093
		[Token(Token = "0x4004C1D")]
		public const int BlurVertical1 = 1;

		// Token: 0x040042C6 RID: 17094
		[Token(Token = "0x4004C1E")]
		public const int BlurHorizontal2 = 2;

		// Token: 0x040042C7 RID: 17095
		[Token(Token = "0x4004C1F")]
		public const int BlurVertical2 = 3;

		// Token: 0x040042C8 RID: 17096
		[Token(Token = "0x4004C20")]
		public const int BlurHorizontal3 = 4;

		// Token: 0x040042C9 RID: 17097
		[Token(Token = "0x4004C21")]
		public const int BlurVertical3 = 5;

		// Token: 0x040042CA RID: 17098
		[Token(Token = "0x4004C22")]
		public const int BlurHorizontal4 = 6;

		// Token: 0x040042CB RID: 17099
		[Token(Token = "0x4004C23")]
		public const int BlurVertical4 = 7;

		// Token: 0x040042CC RID: 17100
		[Token(Token = "0x4004C24")]
		public const int ApplyDebug = 0;

		// Token: 0x040042CD RID: 17101
		[Token(Token = "0x4004C25")]
		public const int ApplyDebugTemporal = 1;

		// Token: 0x040042CE RID: 17102
		[Token(Token = "0x4004C26")]
		public const int ApplyDeferred = 5;

		// Token: 0x040042CF RID: 17103
		[Token(Token = "0x4004C27")]
		public const int ApplyDeferredTemporal = 6;

		// Token: 0x040042D0 RID: 17104
		[Token(Token = "0x4004C28")]
		public const int ApplyDeferredLog = 10;

		// Token: 0x040042D1 RID: 17105
		[Token(Token = "0x4004C29")]
		public const int ApplyDeferredLogTemporal = 11;

		// Token: 0x040042D2 RID: 17106
		[Token(Token = "0x4004C2A")]
		public const int ApplyPostEffect = 15;

		// Token: 0x040042D3 RID: 17107
		[Token(Token = "0x4004C2B")]
		public const int ApplyPostEffectTemporal = 16;

		// Token: 0x040042D4 RID: 17108
		[Token(Token = "0x4004C2C")]
		public const int ApplyPostEffectTemporalMultiply = 20;

		// Token: 0x040042D5 RID: 17109
		[Token(Token = "0x4004C2D")]
		public const int OcclusionLow_None = 0;

		// Token: 0x040042D6 RID: 17110
		[Token(Token = "0x4004C2E")]
		public const int OcclusionLow_Camera = 1;

		// Token: 0x040042D7 RID: 17111
		[Token(Token = "0x4004C2F")]
		public const int OcclusionLow_GBuffer = 2;

		// Token: 0x040042D8 RID: 17112
		[Token(Token = "0x4004C30")]
		public const int OcclusionLow_GBufferOctaEncoded = 3;
	}

	// Token: 0x02000BDF RID: 3039
	[Token(Token = "0x2000D7F")]
	private static class PropertyID
	{
		// Token: 0x040042D9 RID: 17113
		[Token(Token = "0x4004C31")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int _AO_Radius;

		// Token: 0x040042DA RID: 17114
		[Token(Token = "0x4004C32")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int _AO_PixelRadiusLimit;

		// Token: 0x040042DB RID: 17115
		[Token(Token = "0x4004C33")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int _AO_RadiusIntensity;

		// Token: 0x040042DC RID: 17116
		[Token(Token = "0x4004C34")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int _AO_PowExponent;

		// Token: 0x040042DD RID: 17117
		[Token(Token = "0x4004C35")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int _AO_Bias;

		// Token: 0x040042DE RID: 17118
		[Token(Token = "0x4004C36")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int _AO_Levels;

		// Token: 0x040042DF RID: 17119
		[Token(Token = "0x4004C37")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int _AO_ThicknessDecay;

		// Token: 0x040042E0 RID: 17120
		[Token(Token = "0x4004C38")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int _AO_BlurSharpness;

		// Token: 0x040042E1 RID: 17121
		[Token(Token = "0x4004C39")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int _AO_CameraViewLeft;

		// Token: 0x040042E2 RID: 17122
		[Token(Token = "0x4004C3A")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int _AO_CameraViewRight;

		// Token: 0x040042E3 RID: 17123
		[Token(Token = "0x4004C3B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int _AO_ProjMatrixLeft;

		// Token: 0x040042E4 RID: 17124
		[Token(Token = "0x4004C3C")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int _AO_ProjMatrixRight;

		// Token: 0x040042E5 RID: 17125
		[Token(Token = "0x4004C3D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int _AO_InvViewProjMatrixLeft;

		// Token: 0x040042E6 RID: 17126
		[Token(Token = "0x4004C3E")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int _AO_PrevViewProjMatrixLeft;

		// Token: 0x040042E7 RID: 17127
		[Token(Token = "0x4004C3F")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int _AO_PrevInvViewProjMatrixLeft;

		// Token: 0x040042E8 RID: 17128
		[Token(Token = "0x4004C40")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int _AO_InvViewProjMatrixRight;

		// Token: 0x040042E9 RID: 17129
		[Token(Token = "0x4004C41")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int _AO_PrevViewProjMatrixRight;

		// Token: 0x040042EA RID: 17130
		[Token(Token = "0x4004C42")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int _AO_PrevInvViewProjMatrixRight;

		// Token: 0x040042EB RID: 17131
		[Token(Token = "0x4004C43")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int _AO_GBufferNormals;

		// Token: 0x040042EC RID: 17132
		[Token(Token = "0x4004C44")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int _AO_Target_TexelSize;

		// Token: 0x040042ED RID: 17133
		[Token(Token = "0x4004C45")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int _AO_TemporalCurveAdj;

		// Token: 0x040042EE RID: 17134
		[Token(Token = "0x4004C46")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int _AO_TemporalMotionSensibility;

		// Token: 0x040042EF RID: 17135
		[Token(Token = "0x4004C47")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int _AO_CurrOcclusionDepth;

		// Token: 0x040042F0 RID: 17136
		[Token(Token = "0x4004C48")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int _AO_TemporalAccumm;

		// Token: 0x040042F1 RID: 17137
		[Token(Token = "0x4004C49")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int _AO_TemporalDirections;

		// Token: 0x040042F2 RID: 17138
		[Token(Token = "0x4004C4A")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int _AO_TemporalOffsets;

		// Token: 0x040042F3 RID: 17139
		[Token(Token = "0x4004C4B")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int _AO_OcclusionTexture;

		// Token: 0x040042F4 RID: 17140
		[Token(Token = "0x4004C4C")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int _AO_GBufferAlbedo;

		// Token: 0x040042F5 RID: 17141
		[Token(Token = "0x4004C4D")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int _AO_GBufferEmission;

		// Token: 0x040042F6 RID: 17142
		[Token(Token = "0x4004C4E")]
		[FieldOffset(Offset = "0x74")]
		public static readonly int _AO_UVToView;

		// Token: 0x040042F7 RID: 17143
		[Token(Token = "0x4004C4F")]
		[FieldOffset(Offset = "0x78")]
		public static readonly int _AO_HalfProjScale;

		// Token: 0x040042F8 RID: 17144
		[Token(Token = "0x4004C50")]
		[FieldOffset(Offset = "0x7C")]
		public static readonly int _AO_FadeParams;

		// Token: 0x040042F9 RID: 17145
		[Token(Token = "0x4004C51")]
		[FieldOffset(Offset = "0x80")]
		public static readonly int _AO_FadeValues;

		// Token: 0x040042FA RID: 17146
		[Token(Token = "0x4004C52")]
		[FieldOffset(Offset = "0x84")]
		public static readonly int _AO_FadeToTint;

		// Token: 0x040042FB RID: 17147
		[Token(Token = "0x4004C53")]
		[FieldOffset(Offset = "0x88")]
		public static readonly int _AO_Source_TexelSize;

		// Token: 0x040042FC RID: 17148
		[Token(Token = "0x4004C54")]
		[FieldOffset(Offset = "0x8C")]
		public static readonly int _AO_Source;
	}
}
