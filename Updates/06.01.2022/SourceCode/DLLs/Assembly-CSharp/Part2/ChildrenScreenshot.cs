using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B3C RID: 2876
[Token(Token = "0x2000807")]
public class ChildrenScreenshot : MonoBehaviour
{
	// Token: 0x060042FB RID: 17147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003887")]
	[Address(RVA = "0x4DAB80", Offset = "0x4D9980", VA = "0x1804DAB80")]
	[Attribute(Name = "ContextMenu", RVA = "0x74840", Offset = "0x73C40")]
	public void CreateScreenshots()
	{
	}

	// Token: 0x060042FC RID: 17148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003888")]
	[Address(RVA = "0x4DB1D0", Offset = "0x4D9FD0", VA = "0x1804DB1D0")]
	public void PositionCamera(Camera cam, GameObject obj)
	{
	}

	// Token: 0x060042FD RID: 17149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003889")]
	[Address(RVA = "0x4DB5D0", Offset = "0x4DA3D0", VA = "0x1804DB5D0")]
	public ChildrenScreenshot()
	{
	}

	// Token: 0x04004021 RID: 16417
	[Token(Token = "0x4003172")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 offsetAngle;

	// Token: 0x04004022 RID: 16418
	[Token(Token = "0x4003173")]
	[FieldOffset(Offset = "0x24")]
	public int width;

	// Token: 0x04004023 RID: 16419
	[Token(Token = "0x4003174")]
	[FieldOffset(Offset = "0x28")]
	public int height;

	// Token: 0x04004024 RID: 16420
	[Token(Token = "0x4003175")]
	[FieldOffset(Offset = "0x2C")]
	public float fieldOfView;

	// Token: 0x04004025 RID: 16421
	[Token(Token = "0x4003176")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x74650", Offset = "0x73A50")]
	public string folder;
}
