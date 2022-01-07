using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E4 RID: 996
[Token(Token = "0x20002CB")]
public class DevCamera : MonoBehaviour
{
	// Token: 0x060020E9 RID: 8425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0xB6A750", Offset = "0xB69550", VA = "0x180B6A750")]
	private void Start()
	{
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0xB6A820", Offset = "0xB69620", VA = "0x180B6A820")]
	private void Update()
	{
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0xB69E80", Offset = "0xB68C80", VA = "0x180B69E80")]
	private void DoFreeMovement()
	{
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0xB6A8D0", Offset = "0xB696D0", VA = "0x180B6A8D0")]
	public DevCamera()
	{
	}

	// Token: 0x04001BA7 RID: 7079
	[Token(Token = "0x4001683")]
	[FieldOffset(Offset = "0x18")]
	public float movementScale;

	// Token: 0x04001BA8 RID: 7080
	[Token(Token = "0x4001684")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 view;

	// Token: 0x04001BA9 RID: 7081
	[Token(Token = "0x4001685")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 velocity;

	// Token: 0x04001BAA RID: 7082
	[Token(Token = "0x4001686")]
	[FieldOffset(Offset = "0x34")]
	private float zoom;
}
