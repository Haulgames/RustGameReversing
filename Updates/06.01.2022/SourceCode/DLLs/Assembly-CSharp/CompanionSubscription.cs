using System;
using System.Net.Http;
using System.Threading.Tasks;
using Il2CppDummyDll;

// Token: 0x02000A7E RID: 2686
[Token(Token = "0x200078B")]
public static class CompanionSubscription
{
	// Token: 0x06003F6D RID: 16237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60035BA")]
	[Address(RVA = "0x4A4E90", Offset = "0x4A3C90", VA = "0x1804A4E90")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE4900", Offset = "0xE3D00")]
	public static Task<CompanionSubscription.Status> CheckStatus()
	{
		return null;
	}

	// Token: 0x06003F6E RID: 16238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60035BB")]
	[Address(RVA = "0x4A4DC0", Offset = "0x4A3BC0", VA = "0x1804A4DC0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE4AA0", Offset = "0xE3EA0")]
	public static Task Add()
	{
		return null;
	}

	// Token: 0x06003F6F RID: 16239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60035BC")]
	[Address(RVA = "0x4A5160", Offset = "0x4A3F60", VA = "0x1804A5160")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE4BC0", Offset = "0xE3FC0")]
	public static Task Remove()
	{
		return null;
	}

	// Token: 0x06003F70 RID: 16240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60035BD")]
	[Address(RVA = "0x4A4F70", Offset = "0x4A3D70", VA = "0x1804A4F70")]
	private static StringContent GenerateRequest(IAuthTicket authTicket)
	{
		return null;
	}

	// Token: 0x04003CBE RID: 15550
	[Token(Token = "0x4002F19")]
	private const string ApiEndpoint = "https://127.0.0.1/123456789/12345678/api/subscriptions";

	// Token: 0x04003CBF RID: 15551
	[Token(Token = "0x4002F1A")]
	private const string CheckApi = "https://127.0.0.1/123456789/12345678/api/subscriptions/check";

	// Token: 0x04003CC0 RID: 15552
	[Token(Token = "0x4002F1B")]
	private const string AddApi = "https://127.0.0.1/123456789/12345678/api/subscriptions/add";

	// Token: 0x04003CC1 RID: 15553
	[Token(Token = "0x4002F1C")]
	private const string RemoveApi = "https://127.0.0.1/123456789/12345678/api/subscriptions/remove";

	// Token: 0x04003CC2 RID: 15554
	[Token(Token = "0x4002F1D")]
	[FieldOffset(Offset = "0x24D0")]
	private static readonly HttpClient Http;

	// Token: 0x02000A7F RID: 2687
	[Token(Token = "0x2000D1C")]
	private class Request
	{
		// Token: 0x06003F72 RID: 16242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005128")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public Request()
		{
		}

		// Token: 0x04003CC3 RID: 15555
		[Token(Token = "0x4004A8F")]
		[FieldOffset(Offset = "0x10")]
		public string SteamTicket;

		// Token: 0x04003CC4 RID: 15556
		[Token(Token = "0x4004A90")]
		[FieldOffset(Offset = "0x18")]
		public string ServerId;
	}

	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000D1D")]
	public class Status
	{
		// Token: 0x06003F73 RID: 16243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005129")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public Status()
		{
		}

		// Token: 0x04003CC5 RID: 15557
		[Token(Token = "0x4004A91")]
		[FieldOffset(Offset = "0x10")]
		public bool IsInstalled;

		// Token: 0x04003CC6 RID: 15558
		[Token(Token = "0x4004A92")]
		[FieldOffset(Offset = "0x11")]
		public bool IsSubscribed;
	}
}
