using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A84 RID: 2692
[Token(Token = "0x200078C")]
public class ConnectionScreen : SingletonComponent<ConnectionScreen>
{
	// Token: 0x06003F7A RID: 16250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035BF")]
	[Address(RVA = "0x7199C0", Offset = "0x7187C0", VA = "0x1807199C0")]
	public static void Show()
	{
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C0")]
	[Address(RVA = "0x719B00", Offset = "0x718900", VA = "0x180719B00")]
	public static void UpdateServer(ServerInfo server)
	{
	}

	// Token: 0x06003F7C RID: 16252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C1")]
	[Address(RVA = "0x719540", Offset = "0x718340", VA = "0x180719540")]
	public static void FailedWith(string str)
	{
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C2")]
	[Address(RVA = "0x7193C0", Offset = "0x7181C0", VA = "0x1807193C0")]
	public static void FailedWithException(Exception e)
	{
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C3")]
	[Address(RVA = "0x7198D0", Offset = "0x7186D0", VA = "0x1807198D0")]
	public static void SetStatus(string status)
	{
	}

	// Token: 0x06003F7F RID: 16255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C4")]
	[Address(RVA = "0x719110", Offset = "0x717F10", VA = "0x180719110")]
	public static void DisconnectReason(string str)
	{
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C5")]
	[Address(RVA = "0x719790", Offset = "0x718590", VA = "0x180719790")]
	public void RetryConnection()
	{
	}

	// Token: 0x06003F81 RID: 16257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C6")]
	[Address(RVA = "0x7196A0", Offset = "0x7184A0", VA = "0x1807196A0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE5130", Offset = "0xE4530")]
	public static void LoadServerInfo(string address, int port, bool addToHistory = false)
	{
	}

	// Token: 0x06003F82 RID: 16258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C7")]
	[Address(RVA = "0x719D10", Offset = "0x718B10", VA = "0x180719D10")]
	public ConnectionScreen()
	{
	}

	// Token: 0x04003CD7 RID: 15575
	[Token(Token = "0x4002F1E")]
	[FieldOffset(Offset = "0x18")]
	public Text statusText;

	// Token: 0x04003CD8 RID: 15576
	[Token(Token = "0x4002F1F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject disconnectButton;

	// Token: 0x04003CD9 RID: 15577
	[Token(Token = "0x4002F20")]
	[FieldOffset(Offset = "0x28")]
	public GameObject retryButton;

	// Token: 0x04003CDA RID: 15578
	[Token(Token = "0x4002F21")]
	[FieldOffset(Offset = "0x30")]
	public ServerBrowserInfo browserInfo;

	// Token: 0x04003CDB RID: 15579
	[Token(Token = "0x4002F22")]
	[FieldOffset(Offset = "0x38")]
	internal ServerInfo currentServer;
}
