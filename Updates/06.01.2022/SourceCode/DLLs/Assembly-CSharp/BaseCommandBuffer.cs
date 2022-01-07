using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000B31 RID: 2865
[Token(Token = "0x20007FD")]
public class BaseCommandBuffer : MonoBehaviour
{
	// Token: 0x060042CA RID: 17098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003856")]
	[Address(RVA = "0x8848F0", Offset = "0x8836F0", VA = "0x1808848F0")]
	protected CommandBuffer GetCommandBuffer(string name, Camera camera, CameraEvent cameraEvent)
	{
		return null;
	}

	// Token: 0x060042CB RID: 17099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003857")]
	[Address(RVA = "0x884520", Offset = "0x883320", VA = "0x180884520")]
	protected void CleanupCamera(string name, Camera camera, CameraEvent cameraEvent)
	{
	}

	// Token: 0x060042CC RID: 17100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003858")]
	[Address(RVA = "0x8845F0", Offset = "0x8833F0", VA = "0x1808845F0")]
	protected void CleanupCommandBuffer(Camera camera, CameraEvent cameraEvent)
	{
	}

	// Token: 0x060042CD RID: 17101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003859")]
	[Address(RVA = "0x8846A0", Offset = "0x8834A0", VA = "0x1808846A0")]
	protected void Cleanup()
	{
	}

	// Token: 0x060042CE RID: 17102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385A")]
	[Address(RVA = "0x884AF0", Offset = "0x8838F0", VA = "0x180884AF0")]
	public BaseCommandBuffer()
	{
	}

	// Token: 0x04003FFF RID: 16383
	[Token(Token = "0x4003155")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Camera, Dictionary<int, CommandBuffer>> cameras;
}
