using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008C3 RID: 2243
[Token(Token = "0x2000653")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xB8D80", Offset = "0xB8180")]
public class AtmosphereVolumeRenderer : MonoBehaviour
{
	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x06003664 RID: 13924 RVA: 0x00016C38 File Offset: 0x00014E38
	[Token(Token = "0x170003F3")]
	private static bool isSupported
	{
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x83C200", Offset = "0x83B000", VA = "0x18083C200")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x06003665 RID: 13925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F4")]
	public Camera TargetCamera
	{
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x83C160", Offset = "0x83AF60", VA = "0x18083C160")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003666 RID: 13926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x83A130", Offset = "0x838F30", VA = "0x18083A130")]
	public static void Clear()
	{
	}

	// Token: 0x06003667 RID: 13927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x83AB20", Offset = "0x839920", VA = "0x18083AB20")]
	public static void Register(AtmosphereVolume volume)
	{
	}

	// Token: 0x06003668 RID: 13928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DBF")]
	[Address(RVA = "0x83BD30", Offset = "0x83AB30", VA = "0x18083BD30")]
	public static void Unregister(AtmosphereVolume volume)
	{
	}

	// Token: 0x06003669 RID: 13929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0x83AAA0", Offset = "0x8398A0", VA = "0x18083AAA0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600366A RID: 13930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x83A900", Offset = "0x839700", VA = "0x18083A900")]
	private void OnDisable()
	{
	}

	// Token: 0x0600366B RID: 13931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC2")]
	[Address(RVA = "0x83BF80", Offset = "0x83AD80", VA = "0x18083BF80")]
	private void Update()
	{
	}

	// Token: 0x0600366C RID: 13932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC3")]
	[Address(RVA = "0x839CF0", Offset = "0x838AF0", VA = "0x180839CF0")]
	private void CheckCommandBuffer()
	{
	}

	// Token: 0x0600366D RID: 13933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC4")]
	[Address(RVA = "0x839F40", Offset = "0x838D40", VA = "0x180839F40")]
	private void CleanupCommandBuffer()
	{
	}

	// Token: 0x0600366E RID: 13934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC5")]
	[Address(RVA = "0x839E70", Offset = "0x838C70", VA = "0x180839E70")]
	private void CheckMaterials()
	{
	}

	// Token: 0x0600366F RID: 13935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0x83A000", Offset = "0x838E00", VA = "0x18083A000")]
	private void CleanupMaterials()
	{
	}

	// Token: 0x06003670 RID: 13936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC7")]
	[Address(RVA = "0x83BE40", Offset = "0x83AC40", VA = "0x18083BE40")]
	private void UpdateVolumeMesh()
	{
	}

	// Token: 0x06003671 RID: 13937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC8")]
	[Address(RVA = "0x83A560", Offset = "0x839360", VA = "0x18083A560")]
	public void FindAndSortVolumes(Camera camera)
	{
	}

	// Token: 0x06003672 RID: 13938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC9")]
	[Address(RVA = "0x83BDF0", Offset = "0x83ABF0", VA = "0x18083BDF0")]
	public void UpdateAtmosphere()
	{
	}

	// Token: 0x06003673 RID: 13939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0x83ABE0", Offset = "0x8399E0", VA = "0x18083ABE0")]
	private void SetFrustumGlobalShaderParams(CommandBuffer cb, Camera camera)
	{
	}

	// Token: 0x06003674 RID: 13940 RVA: 0x00016C50 File Offset: 0x00014E50
	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x83B3D0", Offset = "0x83A1D0", VA = "0x18083B3D0")]
	private bool SetGlobalShaderParams(CommandBuffer cb)
	{
		return default(bool);
	}

	// Token: 0x06003675 RID: 13941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x83A0B0", Offset = "0x838EB0", VA = "0x18083A0B0")]
	private void ClearGlobalShaderParams(CommandBuffer cb)
	{
	}

	// Token: 0x06003676 RID: 13942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0x83A1E0", Offset = "0x838FE0", VA = "0x18083A1E0")]
	private void FillCommandBuffer(CommandBuffer cb)
	{
	}

	// Token: 0x06003677 RID: 13943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0x83C0C0", Offset = "0x83AEC0", VA = "0x18083C0C0")]
	public AtmosphereVolumeRenderer()
	{
	}

	// Token: 0x040032DE RID: 13022
	[Token(Token = "0x4002739")]
	[FieldOffset(Offset = "0x18")]
	public FogMode Mode;

	// Token: 0x040032DF RID: 13023
	[Token(Token = "0x400273A")]
	[FieldOffset(Offset = "0x1C")]
	public bool DistanceFog;

	// Token: 0x040032E0 RID: 13024
	[Token(Token = "0x400273B")]
	[FieldOffset(Offset = "0x1D")]
	public bool HeightFog;

	// Token: 0x040032E1 RID: 13025
	[Token(Token = "0x400273C")]
	[FieldOffset(Offset = "0x20")]
	public AtmosphereVolume Volume;

	// Token: 0x040032E2 RID: 13026
	[Token(Token = "0x400273D")]
	[FieldOffset(Offset = "0x28")]
	private Camera targetCamera;

	// Token: 0x040032E3 RID: 13027
	[Token(Token = "0x400273E")]
	[FieldOffset(Offset = "0x30")]
	private CommandBufferManager commandBufferManager;

	// Token: 0x040032E4 RID: 13028
	[Token(Token = "0x400273F")]
	[FieldOffset(Offset = "0x38")]
	private CommandBufferDesc commandBufferDesc;

	// Token: 0x040032E5 RID: 13029
	[Token(Token = "0x4002740")]
	[FieldOffset(Offset = "0x40")]
	private Material fogMaterial;

	// Token: 0x040032E6 RID: 13030
	[Token(Token = "0x4002741")]
	[FieldOffset(Offset = "0x48")]
	private Vector4[] matrixArray;

	// Token: 0x040032E7 RID: 13031
	[Token(Token = "0x4002742")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh volumeMesh;

	// Token: 0x040032E8 RID: 13032
	[Token(Token = "0x4002743")]
	[FieldOffset(Offset = "0x8")]
	private static HashSet<AtmosphereVolume> registeredVolumes;

	// Token: 0x040032E9 RID: 13033
	[Token(Token = "0x4002744")]
	[FieldOffset(Offset = "0x50")]
	private List<AtmosphereVolumeRenderer.CurrentVolumeEntry> currentVolumes;

	// Token: 0x020008C4 RID: 2244
	[Token(Token = "0x2000C9C")]
	private struct CurrentVolumeEntry
	{
		// Token: 0x06003679 RID: 13945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005020")]
		[Address(RVA = "0xF3FA0", Offset = "0xF33A0", VA = "0x1800F3FA0")]
		public CurrentVolumeEntry(AtmosphereVolume volume, float distance)
		{
		}

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x4004898")]
		[FieldOffset(Offset = "0x0")]
		public AtmosphereVolume volume;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x4004899")]
		[FieldOffset(Offset = "0x8")]
		public float distanceSqr;
	}

	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x2000C9D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600367B RID: 13947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005022")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00016C68 File Offset: 0x00014E68
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x84CAD0", Offset = "0x84B8D0", VA = "0x18084CAD0")]
		internal int <FindAndSortVolumes>b__28_0(AtmosphereVolumeRenderer.CurrentVolumeEntry x, AtmosphereVolumeRenderer.CurrentVolumeEntry y)
		{
			return 0;
		}

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x400489A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AtmosphereVolumeRenderer.<>c <>9;

		// Token: 0x040032ED RID: 13037
		[Token(Token = "0x400489B")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<AtmosphereVolumeRenderer.CurrentVolumeEntry> <>9__28_0;
	}
}
