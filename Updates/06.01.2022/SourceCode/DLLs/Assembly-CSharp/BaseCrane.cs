using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200002C RID: 44
[Token(Token = "0x2000020")]
public class BaseCrane : BaseVehicle
{
	// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x886060", Offset = "0x884E60", VA = "0x180886060")]
	[Attribute(Name = "Menu", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	[Attribute(Name = "Description", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	[Attribute(Name = "Icon", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	[Attribute(Name = "ShowIf", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	public void Menu_FuelStorage(BasePlayer player)
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x885FB0", Offset = "0x884DB0", VA = "0x180885FB0")]
	public bool Menu_FuelStorage_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x886440", Offset = "0x885240", VA = "0x180886440", Slot = "170")]
	public override void UpdatePlayerModel(BasePlayer player)
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x886560", Offset = "0x885360", VA = "0x180886560")]
	public void Update()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x885E30", Offset = "0x884C30", VA = "0x180885E30")]
	public float GetThrottle()
	{
		return 0f;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x885E30", Offset = "0x884C30", VA = "0x180885E30")]
	public float GetTurnState()
	{
		return 0f;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x885F10", Offset = "0x884D10", VA = "0x180885F10")]
	public bool IsArmMoving()
	{
		return default(bool);
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x885F10", Offset = "0x884D10", VA = "0x180885F10")]
	public bool IsBodyMoving()
	{
		return default(bool);
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x885F20", Offset = "0x884D20", VA = "0x180885F20")]
	public bool IsEngineOnAndIdle()
	{
		return default(bool);
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x885F30", Offset = "0x884D30", VA = "0x180885F30", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x886190", Offset = "0x884F90", VA = "0x180886190")]
	public void UpdateAnimator(bool shouldLerp = true)
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x885E50", Offset = "0x884C50", VA = "0x180885E50", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x885B20", Offset = "0x884920", VA = "0x180885B20", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000EA RID: 234 RVA: 0x000025C8 File Offset: 0x000007C8
	[Token(Token = "0x1700000B")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x886650", Offset = "0x885450", VA = "0x180886650", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x000025E0 File Offset: 0x000007E0
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x8860A0", Offset = "0x884EA0", VA = "0x1808860A0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x886600", Offset = "0x885400", VA = "0x180886600")]
	public BaseCrane()
	{
	}

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x3A8")]
	public float extensionArmState;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x3AC")]
	public float raiseArmState;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x3B0")]
	public float yawState;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x3B8")]
	public Transform COM;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x3C0")]
	public float extensionDirection;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x3C4")]
	public float yawDirection;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x3C8")]
	public float raiseArmDirection;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x3CC")]
	public float arm1Speed;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x3D0")]
	public float arm2Speed;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x3D4")]
	public float turnYawSpeed;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x3D8")]
	public Animator animator;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x3E0")]
	public BaseMagnet Magnet;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x3E8")]
	public Rigidbody myRigidbody;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x3F0")]
	public WheelCollider[] leftWheels;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x3F8")]
	public WheelCollider[] rightWheels;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x400")]
	public float brakeStrength;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x404")]
	public float engineStrength;

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x408")]
	public Transform[] collisionTestingPoints;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x410")]
	public float maxDistanceFromOrigin;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x418")]
	public GameObjectRef selfDamageEffect;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x420")]
	public GameObjectRef explosionEffect;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x428")]
	public Transform explosionPoint;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x430")]
	public CapsuleCollider driverCollision;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x438")]
	public Transform leftHandTarget;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x440")]
	public Transform rightHandTarget;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x448")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x9DC50", Offset = "0x9D050")]
	public GameObjectRef fuelStoragePrefab;

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x450")]
	public float fuelPerSec;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x458")]
	protected EntityFuelSystem fuelSystem;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x460")]
	public GameObject[] OnTriggers;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x468")]
	public TriggerHurtEx magnetDamage;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Translate.Phrase ReturnMessage;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x470")]
	private float testPreviousYaw;

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x478")]
	private Option __menuOption_Menu_FuelStorage;
}
