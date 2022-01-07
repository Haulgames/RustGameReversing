using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200034C RID: 844
[Token(Token = "0x200025D")]
public class CameraMan : SingletonComponent<CameraMan>
{
	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0000E280 File Offset: 0x0000C480
	// (set) Token: 0x06001D29 RID: 7465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E3")]
	public Color GuideColor
	{
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x64CBA0", Offset = "0x64B9A0", VA = "0x18064CBA0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x64CE20", Offset = "0x64BC20", VA = "0x18064CE20")]
		set
		{
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0000E298 File Offset: 0x0000C498
	// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E4")]
	public int Guide
	{
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x56E5C0", Offset = "0x56D3C0", VA = "0x18056E5C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x64CE90", Offset = "0x64BC90", VA = "0x18064CE90")]
		set
		{
		}
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001784")]
	[Address(RVA = "0x64B3A0", Offset = "0x64A1A0", VA = "0x18064B3A0")]
	private void Start()
	{
	}

	// Token: 0x06001D2D RID: 7469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001785")]
	[Address(RVA = "0x64A000", Offset = "0x648E00", VA = "0x18064A000")]
	private void OnEnable()
	{
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001786")]
	[Address(RVA = "0x649CA0", Offset = "0x648AA0", VA = "0x180649CA0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x64B540", Offset = "0x64A340", VA = "0x18064B540")]
	public void TogglePlayerFreeze()
	{
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x6497B0", Offset = "0x6485B0", VA = "0x1806497B0")]
	private bool IsPlayerUnfrozen()
	{
		return default(bool);
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
	[Token(Token = "0x6001789")]
	[Address(RVA = "0x649370", Offset = "0x648170", VA = "0x180649370")]
	public float FovToZoom(float fov)
	{
		return 0f;
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
	[Token(Token = "0x600178A")]
	[Address(RVA = "0x64C860", Offset = "0x64B660", VA = "0x18064C860")]
	public float ZoomToFov(float zoom)
	{
		return 0f;
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178B")]
	[Address(RVA = "0x64B270", Offset = "0x64A070", VA = "0x18064B270")]
	public void Save(string name)
	{
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178C")]
	[Address(RVA = "0x64B060", Offset = "0x649E60", VA = "0x18064B060")]
	public void SaveToFile(string name)
	{
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
	[Token(Token = "0x600178D")]
	[Address(RVA = "0x6493E0", Offset = "0x6481E0", VA = "0x1806493E0")]
	public CameraMan.CameraState GetCurrentCameraSettings()
	{
		return default(CameraMan.CameraState);
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x0000E310 File Offset: 0x0000C510
	[Token(Token = "0x600178E")]
	[Address(RVA = "0x649B00", Offset = "0x648900", VA = "0x180649B00")]
	public bool Load(string name)
	{
		return default(bool);
	}

	// Token: 0x06001D37 RID: 7479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178F")]
	[Address(RVA = "0x647A20", Offset = "0x646820", VA = "0x180647A20")]
	public void ApplyState(CameraMan.CameraState savedState)
	{
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001790")]
	[Address(RVA = "0x64A630", Offset = "0x649430", VA = "0x18064A630")]
	public string PrintSaved()
	{
		return null;
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001791")]
	[Address(RVA = "0x647D00", Offset = "0x646B00", VA = "0x180647D00")]
	public void Clear()
	{
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x64B180", Offset = "0x649F80", VA = "0x18064B180")]
	private void SaveToPlayerPrefs()
	{
	}

	// Token: 0x06001D3B RID: 7483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001793")]
	[Address(RVA = "0x649910", Offset = "0x648710", VA = "0x180649910")]
	private void LoadFromPlayerPrefs()
	{
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0000E328 File Offset: 0x0000C528
	[Token(Token = "0x170001E5")]
	private CameraMan.MovementType currentMovementType
	{
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x64CBC0", Offset = "0x64B9C0", VA = "0x18064CBC0")]
		get
		{
			return CameraMan.MovementType.Free;
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0000E340 File Offset: 0x0000C540
	// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E6")]
	public float Zoom
	{
		[Token(Token = "0x6001795")]
		[Address(RVA = "0x64CBB0", Offset = "0x64B9B0", VA = "0x18064CBB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x64CFA0", Offset = "0x64BDA0", VA = "0x18064CFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0000E358 File Offset: 0x0000C558
	// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E7")]
	public float Fov
	{
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x64CB30", Offset = "0x64B930", VA = "0x18064CB30")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x64CDA0", Offset = "0x64BBA0", VA = "0x18064CDA0")]
		set
		{
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0000E370 File Offset: 0x0000C570
	[Token(Token = "0x170001E8")]
	public static bool Active
	{
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x64CA60", Offset = "0x64B860", VA = "0x18064CA60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179A")]
	[Address(RVA = "0x64B370", Offset = "0x64A170", VA = "0x18064B370")]
	public void ShakeView(float amplitude, float frequency, float duration)
	{
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179B")]
	[Address(RVA = "0x64B460", Offset = "0x64A260", VA = "0x18064B460")]
	public void StopViewShake()
	{
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179C")]
	[Address(RVA = "0x64C720", Offset = "0x64B520", VA = "0x18064C720")]
	private void Update()
	{
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179D")]
	[Address(RVA = "0x64B480", Offset = "0x64A280", VA = "0x18064B480")]
	public void ToggleControl(bool state)
	{
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179E")]
	[Address(RVA = "0x64B6F0", Offset = "0x64A4F0", VA = "0x18064B6F0")]
	private void UpdateMovement()
	{
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600179F")]
	[Address(RVA = "0x647D80", Offset = "0x646B80", VA = "0x180647D80")]
	private void DoControls()
	{
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x0000E388 File Offset: 0x0000C588
	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x6495B0", Offset = "0x6483B0", VA = "0x1806495B0")]
	public float GetDofDistance(BaseEntity target)
	{
		return 0f;
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x649110", Offset = "0x647F10", VA = "0x180649110")]
	public void FocusOnTarget()
	{
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x64C970", Offset = "0x64B770", VA = "0x18064C970")]
	public CameraMan()
	{
	}

	// Token: 0x04001857 RID: 6231
	[Token(Token = "0x40013E6")]
	[FieldOffset(Offset = "0x0")]
	public static string DefaultSaveName;

	// Token: 0x04001858 RID: 6232
	[Token(Token = "0x40013E7")]
	public const string SavePositionExtension = ".cam";

	// Token: 0x04001859 RID: 6233
	[Token(Token = "0x40013E8")]
	public const string SavePositionDirectory = "camsaves";

	// Token: 0x0400185A RID: 6234
	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x18")]
	public bool OnlyControlWhenCursorHidden;

	// Token: 0x0400185B RID: 6235
	[Token(Token = "0x40013EA")]
	[FieldOffset(Offset = "0x19")]
	public bool NeedBothMouseButtonsToZoom;

	// Token: 0x0400185C RID: 6236
	[Token(Token = "0x40013EB")]
	[FieldOffset(Offset = "0x1C")]
	public float LookSensitivity;

	// Token: 0x0400185D RID: 6237
	[Token(Token = "0x40013EC")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	// Token: 0x0400185E RID: 6238
	[Token(Token = "0x40013ED")]
	[FieldOffset(Offset = "0x8")]
	public static float GuideAspect;

	// Token: 0x0400185F RID: 6239
	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0xC")]
	public static float GuideRatio;

	// Token: 0x04001860 RID: 6240
	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x28")]
	public Canvas canvas;

	// Token: 0x04001861 RID: 6241
	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x30")]
	public Graphic[] guides;

	// Token: 0x04001862 RID: 6242
	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x38")]
	private Color _guideColor;

	// Token: 0x04001863 RID: 6243
	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x48")]
	private int _guide;

	// Token: 0x04001864 RID: 6244
	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0x4C")]
	private bool startCulling;

	// Token: 0x04001865 RID: 6245
	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, CameraMan.CameraState> stateDictionary;

	// Token: 0x04001866 RID: 6246
	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x50")]
	private readonly ViewShake viewShake;

	// Token: 0x04001867 RID: 6247
	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x58")]
	public BaseEntity TargetEntity;

	// Token: 0x04001868 RID: 6248
	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x60")]
	private float targetDistance;

	// Token: 0x04001869 RID: 6249
	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x64")]
	private float targetDistancePrev;

	// Token: 0x0400186A RID: 6250
	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 wishMove;

	// Token: 0x0400186B RID: 6251
	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 view;

	// Token: 0x0400186C RID: 6252
	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 viewPrev;

	// Token: 0x0400186D RID: 6253
	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 velocity;

	// Token: 0x0400186E RID: 6254
	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Zoom>k__BackingField;

	// Token: 0x0200034D RID: 845
	[Token(Token = "0x2000B24")]
	[Serializable]
	public struct CameraState
	{
		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x4004187")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		// Token: 0x04001870 RID: 6256
		[Token(Token = "0x4004188")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 rotation;

		// Token: 0x04001871 RID: 6257
		[Token(Token = "0x4004189")]
		[FieldOffset(Offset = "0x18")]
		public float zoom;

		// Token: 0x04001872 RID: 6258
		[Token(Token = "0x400418A")]
		[FieldOffset(Offset = "0x1C")]
		public float dof;
	}

	// Token: 0x0200034E RID: 846
	[Token(Token = "0x2000B25")]
	private enum MovementType
	{
		// Token: 0x04001874 RID: 6260
		[Token(Token = "0x400418C")]
		Free,
		// Token: 0x04001875 RID: 6261
		[Token(Token = "0x400418D")]
		Target,
		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x400418E")]
		LookAtPlayer
	}
}
