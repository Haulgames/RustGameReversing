using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Facepunch;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using Rust.Demo;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000350 RID: 848
[Token(Token = "0x200025F")]
public class Client : SingletonComponent<global::Client>, IClientCallback
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06001D4F RID: 7503 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06001D50 RID: 7504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	public static event Action OnConnected
	{
		[Token(Token = "0x60017A7")]
		[Address(RVA = "0x4EB590", Offset = "0x4EA390", VA = "0x1804EB590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		add
		{
		}
		[Token(Token = "0x60017A8")]
		[Address(RVA = "0x4EBFA0", Offset = "0x4EADA0", VA = "0x1804EBFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		remove
		{
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06001D51 RID: 7505 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06001D52 RID: 7506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000002")]
	public static event Action OnDisconnected
	{
		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x4EB690", Offset = "0x4EA490", VA = "0x1804EB690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		add
		{
		}
		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x4EC0A0", Offset = "0x4EAEA0", VA = "0x1804EC0A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		remove
		{
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06001D53 RID: 7507 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
	[Token(Token = "0x170001E9")]
	private bool StatsEnabled
	{
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x4EBEE0", Offset = "0x4EACE0", VA = "0x1804EBEE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x4E9030", Offset = "0x4E7E30", VA = "0x1804E9030")]
	private void RegisterIncoming(string type, long bytes)
	{
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x4E9170", Offset = "0x4E7F70", VA = "0x1804E9170")]
	private void RegisterIncoming(string type, string entity, long bytes)
	{
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x4E7650", Offset = "0x4E6450", VA = "0x1804E7650", Slot = "8")]
	public void OnNetworkMessage(Message packet)
	{
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x4E7510", Offset = "0x4E6310", VA = "0x1804E7510")]
	private void OnMessage(Message packet)
	{
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x4E89A0", Offset = "0x4E77A0", VA = "0x1804E89A0")]
	private void OnRequestUserInformation(Message packet)
	{
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x4E4E70", Offset = "0x4E3C70", VA = "0x1804E4E70")]
	private void OnApproved(Message packet)
	{
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x4E8610", Offset = "0x4E7410", VA = "0x1804E8610")]
	private void OnRPCMessage(Message packet)
	{
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x4E48F0", Offset = "0x4E36F0", VA = "0x1804E48F0")]
	private string GetOSName()
	{
		return null;
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x4E18F0", Offset = "0x4E06F0", VA = "0x1804E18F0")]
	public void CancelAuthTicket()
	{
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x4E4720", Offset = "0x4E3520", VA = "0x1804E4720")]
	public IAuthTicket GetAuthTicket(bool cancelOld = true)
	{
		return null;
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x4E19B0", Offset = "0x4E07B0", VA = "0x1804E19B0")]
	private void CancelLoading()
	{
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x4E9A60", Offset = "0x4E8860", VA = "0x1804E9A60")]
	private Coroutine StartLoading(IEnumerator coroutine)
	{
		return null;
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x4E1C50", Offset = "0x4E0A50", VA = "0x1804E1C50")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xB1140", Offset = "0xB0540")]
	public Task Connect(string strAddress, int port, string protocol, bool hideIpAddress = false)
	{
		return null;
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B9")]
	[Address(RVA = "0x4E3CD0", Offset = "0x4E2AD0", VA = "0x1804E3CD0")]
	private void DestroyNetworkables()
	{
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x4E3EF0", Offset = "0x4E2CF0", VA = "0x1804E3EF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13C0", Offset = "0xB07C0")]
	private IEnumerator DoClientConnected(Approval msg)
	{
		return null;
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x4E5090", Offset = "0x4E3E90", VA = "0x1804E5090", Slot = "9")]
	public void OnClientDisconnected(string strReason)
	{
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x4E1A60", Offset = "0x4E0860", VA = "0x1804E1A60")]
	public static void ClientCleanup()
	{
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017BD")]
	[Address(RVA = "0x4E52D0", Offset = "0x4E40D0", VA = "0x1804E52D0")]
	private static void OnConsoleReplicatedVars(Message packet)
	{
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x4E9720", Offset = "0x4E8520", VA = "0x1804E9720")]
	private static void SetReplicatedVar(string fullName, string value)
	{
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x4E9370", Offset = "0x4E8170", VA = "0x1804E9370")]
	private void RunDebugCommands()
	{
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x4E3F80", Offset = "0x4E2D80", VA = "0x1804E3F80")]
	private void DrawColliders()
	{
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x4EA530", Offset = "0x4E9330", VA = "0x1804EA530")]
	private void UpdateNetgraph()
	{
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x4E47D0", Offset = "0x4E35D0", VA = "0x1804E47D0")]
	private Stats GetCurrentNetworkStats()
	{
		return null;
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
	[Token(Token = "0x170001EA")]
	public static bool IsPlayingDemo
	{
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x4EBD40", Offset = "0x4EAB40", VA = "0x1804EBD40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
	[Token(Token = "0x170001EB")]
	public static bool IsRecordingDemo
	{
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x4EBD90", Offset = "0x4EAB90", VA = "0x1804EBD90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
	// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EC")]
	public static bool IsScrubbingDemo
	{
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x4EBDE0", Offset = "0x4EABE0", VA = "0x1804EBDE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x4EC280", Offset = "0x4EB080", VA = "0x1804EC280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06001D6F RID: 7535 RVA: 0x0000E400 File Offset: 0x0000C600
	[Token(Token = "0x170001ED")]
	public static TimeSpan RecordingTimeElapsed
	{
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x4EBE90", Offset = "0x4EAC90", VA = "0x1804EBE90")]
		get
		{
			return default(TimeSpan);
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001EE")]
	public static string RecordingFilename
	{
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x4EBE40", Offset = "0x4EAC40", VA = "0x1804EBE40")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001EF")]
	public static global::BasePlayer DemoLocalPlayer
	{
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x4EB810", Offset = "0x4EA610", VA = "0x1804EB810")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0000E418 File Offset: 0x0000C618
	[Token(Token = "0x170001F0")]
	public static TimeSpan DemoProgress
	{
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x4EB9D0", Offset = "0x4EA7D0", VA = "0x1804EB9D0")]
		get
		{
			return default(TimeSpan);
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0000E430 File Offset: 0x0000C630
	[Token(Token = "0x170001F1")]
	public static TimeSpan DemoLength
	{
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x4EB790", Offset = "0x4EA590", VA = "0x1804EB790")]
		get
		{
			return default(TimeSpan);
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0000E448 File Offset: 0x0000C648
	[Token(Token = "0x170001F2")]
	public static float DemoNormalizedTime
	{
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x4EB910", Offset = "0x4EA710", VA = "0x1804EB910")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F3")]
	public static string DemoName
	{
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x4EB8A0", Offset = "0x4EA6A0", VA = "0x1804EB8A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0000E460 File Offset: 0x0000C660
	[Token(Token = "0x170001F4")]
	public static DateTime DemoRecordedTime
	{
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x4EBA70", Offset = "0x4EA870", VA = "0x1804EBA70")]
		get
		{
			return default(DateTime);
		}
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017CF")]
	[Address(RVA = "0x4E9B40", Offset = "0x4E8940", VA = "0x1804E9B40")]
	public void StartPlayingDemo(Reader demo, bool inPlace)
	{
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D0")]
	[Address(RVA = "0x4E9AA0", Offset = "0x4E88A0", VA = "0x1804E9AA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xB1730", Offset = "0xB0B30")]
	private IEnumerator StartPlayingDemoInternal(Reader demo, bool inPlace)
	{
		return null;
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x4E53E0", Offset = "0x4E41E0", VA = "0x1804E53E0")]
	private void OnDemoKeyframe(Indexer.Keyframe keyframe, HashSet<uint> changedEnts)
	{
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x4E9EE0", Offset = "0x4E8CE0", VA = "0x1804E9EE0")]
	public void StopRecordingDemo()
	{
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D3")]
	[Address(RVA = "0x4E9BE0", Offset = "0x4E89E0", VA = "0x1804E9BE0")]
	public void StopPlayingDemo(bool finished = false)
	{
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D4")]
	[Address(RVA = "0x4E2F10", Offset = "0x4E1D10", VA = "0x1804E2F10")]
	private void DemoFrame()
	{
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06001D7D RID: 7549 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D7E RID: 7550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F5")]
	public static global::BasePlayer DemoSpectatePlayer
	{
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x4EBB20", Offset = "0x4EA920", VA = "0x1804EBB20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x4EC1A0", Offset = "0x4EAFA0", VA = "0x1804EC1A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x4E3B20", Offset = "0x4E2920", VA = "0x1804E3B20")]
	private void DemoSpectateNextPlayer(bool forward)
	{
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x4E3460", Offset = "0x4E2260", VA = "0x1804E3460")]
	private void DemoLateUpdate(bool isLastCall)
	{
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x4E3990", Offset = "0x4E2790", VA = "0x1804E3990")]
	private void DemoPlayerTick(PlayerTick playerTick)
	{
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x4E6F90", Offset = "0x4E5D90", VA = "0x1804E6F90")]
	private void OnGroupEnter(Message msg)
	{
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x4E7090", Offset = "0x4E5E90", VA = "0x1804E7090")]
	private void OnGroupLeave(Message msg)
	{
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x4E61B0", Offset = "0x4E4FB0", VA = "0x1804E61B0")]
	private void OnEntityDestroy(Message msg)
	{
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x4E6D30", Offset = "0x4E5B30", VA = "0x1804E6D30")]
	private void OnGroupDestroy(Message msg)
	{
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x4E6590", Offset = "0x4E5390", VA = "0x1804E6590")]
	private void OnGroupChange(Message msg)
	{
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DF")]
	[Address(RVA = "0x4E5EC0", Offset = "0x4E4CC0", VA = "0x1804E5EC0")]
	private void OnEntities(Message packet)
	{
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x4E1D90", Offset = "0x4E0B90", VA = "0x1804E1D90")]
	private global::BaseEntity CreateOrUpdateEntity(Entity info, long size)
	{
		return null;
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E1")]
	[Address(RVA = "0x4E6410", Offset = "0x4E5210", VA = "0x1804E6410")]
	private void OnEntityPosition(Message packet)
	{
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x4EA2B0", Offset = "0x4E90B0", VA = "0x1804EA2B0")]
	private void UpdateEntityPosition(uint entID, Vector3 pos, Vector3 rot, float time, uint parentID)
	{
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x4E6390", Offset = "0x4E5190", VA = "0x1804E6390")]
	private void OnEntityFlags(Message packet)
	{
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E4")]
	[Address(RVA = "0x4EA030", Offset = "0x4E8E30", VA = "0x1804EA030")]
	private void UpdateEntityFlags(uint entID, int flags)
	{
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F6")]
	public static EventSystem EventSystem
	{
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x4EBBE0", Offset = "0x4EA9E0", VA = "0x1804EBBE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x4E19F0", Offset = "0x4E07F0", VA = "0x1804E19F0")]
	private void ClearVisibility()
	{
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x4E4BE0", Offset = "0x4E39E0", VA = "0x1804E4BE0")]
	private void NetworkInit()
	{
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x4EA890", Offset = "0x4E9690", VA = "0x1804EA890")]
	private void Update()
	{
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E9")]
	[Address(RVA = "0x4E4950", Offset = "0x4E3750", VA = "0x1804E4950")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x4E3E10", Offset = "0x4E2C10", VA = "0x1804E3E10")]
	private void Disconnect()
	{
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x4E5E50", Offset = "0x4E4C50", VA = "0x1804E5E50")]
	private void OnDisable()
	{
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x4E4DC0", Offset = "0x4E3BC0", VA = "0x1804E4DC0")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017ED")]
	[Address(RVA = "0x4E7190", Offset = "0x4E5F90", VA = "0x1804E7190")]
	private void OnLeaveServer()
	{
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x4E9590", Offset = "0x4E8390", VA = "0x1804E9590")]
	private void SaveConfigs(bool force = false)
	{
	}

	// Token: 0x06001D97 RID: 7575
	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x4E4880", Offset = "0x4E3680", VA = "0x1804E4880")]
	[PreserveSig]
	private static extern uint GetCurrentProcessId();

	// Token: 0x06001D98 RID: 7576
	[Token(Token = "0x60017F0")]
	[Address(RVA = "0x4E8FA0", Offset = "0x4E7DA0", VA = "0x1804E8FA0")]
	[PreserveSig]
	private static extern IntPtr OpenProcess(global::Client.ProcessAccessFlags processAccess, bool bInheritHandle, uint processId);

	// Token: 0x06001D99 RID: 7577
	[Token(Token = "0x60017F1")]
	[Address(RVA = "0x4E9FA0", Offset = "0x4E8DA0", VA = "0x1804E9FA0")]
	[PreserveSig]
	private static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

	// Token: 0x06001D9A RID: 7578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F2")]
	[Address(RVA = "0x4E9820", Offset = "0x4E8620", VA = "0x1804E9820")]
	private void ShutdownClient()
	{
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F3")]
	[Address(RVA = "0x4EB4D0", Offset = "0x4EA2D0", VA = "0x1804EB4D0")]
	public Client()
	{
	}

	// Token: 0x04001878 RID: 6264
	[Token(Token = "0x40013FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Translate.Phrase loading_loading;

	// Token: 0x04001879 RID: 6265
	[Token(Token = "0x4001400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Translate.Phrase loading_connecting;

	// Token: 0x0400187A RID: 6266
	[Token(Token = "0x4001401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Translate.Phrase loading_connectionaccepted;

	// Token: 0x0400187B RID: 6267
	[Token(Token = "0x4001402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Translate.Phrase loading_connecting_negotiate;

	// Token: 0x0400187C RID: 6268
	[Token(Token = "0x4001403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Translate.Phrase loading_level;

	// Token: 0x0400187D RID: 6269
	[Token(Token = "0x4001404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Translate.Phrase loading_skinnablewarmup;

	// Token: 0x0400187E RID: 6270
	[Token(Token = "0x4001405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Translate.Phrase loading_preloadcomplete;

	// Token: 0x0400187F RID: 6271
	[Token(Token = "0x4001406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static Translate.Phrase loading_openingscene;

	// Token: 0x04001880 RID: 6272
	[Token(Token = "0x4001407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static Translate.Phrase loading_clientready;

	// Token: 0x04001881 RID: 6273
	[Token(Token = "0x4001408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static Translate.Phrase loading_prefabwarmup;

	// Token: 0x04001884 RID: 6276
	[Token(Token = "0x400140B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IAuthTicket authTicket;

	// Token: 0x04001885 RID: 6277
	[Token(Token = "0x400140C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IEnumerator currentCoroutine;

	// Token: 0x04001886 RID: 6278
	[Token(Token = "0x400140D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool connectionRetry;

	// Token: 0x04001887 RID: 6279
	[Token(Token = "0x400140E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static global::Client.ConnectionConfig[] config_raknet;

	// Token: 0x04001888 RID: 6280
	[Token(Token = "0x400140F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static global::Client.ConnectionConfig[] config_steam_networking;

	// Token: 0x04001889 RID: 6281
	[Token(Token = "0x4001410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static global::Client.ConnectionConfig[] config_steam_datagram_relay;

	// Token: 0x0400188A RID: 6282
	[Token(Token = "0x4001411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static global::Client.ConnectionConfig[] config_default;

	// Token: 0x0400188B RID: 6283
	[Token(Token = "0x4001412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static Mesh _cubeMesh;

	// Token: 0x0400188C RID: 6284
	[Token(Token = "0x4001413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private static bool <IsScrubbingDemo>k__BackingField;

	// Token: 0x0400188D RID: 6285
	[Token(Token = "0x4001414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static ulong DemoLocalClient;

	// Token: 0x0400188E RID: 6286
	[Token(Token = "0x4001415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static Reader Demo;

	// Token: 0x0400188F RID: 6287
	[Token(Token = "0x4001416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static float PreDemoPhysicsSteps;

	// Token: 0x04001890 RID: 6288
	[Token(Token = "0x4001417")]
	private const float demoTickDistSq = 2500f;

	// Token: 0x04001891 RID: 6289
	[Token(Token = "0x4001418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private static global::BasePlayer <DemoSpectatePlayer>k__BackingField;

	// Token: 0x04001892 RID: 6290
	[Token(Token = "0x4001419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static global::BaseEntity CurrentEntity;

	// Token: 0x04001893 RID: 6291
	[Token(Token = "0x400141A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HashSet<uint> subscriptions;

	// Token: 0x04001894 RID: 6292
	[Token(Token = "0x400141B")]
	private const long EntityPositionPacketSize = 36L;

	// Token: 0x04001895 RID: 6293
	[Token(Token = "0x400141C")]
	private const long EntityFlagsPacketSize = 8L;

	// Token: 0x04001896 RID: 6294
	[Token(Token = "0x400141D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static EventSystem _eventsystem;

	// Token: 0x04001897 RID: 6295
	[Token(Token = "0x400141E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float LastConfigSaveTime;

	// Token: 0x04001898 RID: 6296
	[Token(Token = "0x400141F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Stopwatch ngTimer;

	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000B26")]
	private enum ConnectionProtocol
	{
		// Token: 0x0400189A RID: 6298
		[Token(Token = "0x4004190")]
		Raknet,
		// Token: 0x0400189B RID: 6299
		[Token(Token = "0x4004191")]
		SteamNetworking,
		// Token: 0x0400189C RID: 6300
		[Token(Token = "0x4004192")]
		SteamDatagramRelay
	}

	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000B27")]
	private struct ConnectionConfig
	{
		// Token: 0x06001D9D RID: 7581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D26")]
		[Address(RVA = "0xEE780", Offset = "0xEDB80", VA = "0x1800EE780")]
		public ConnectionConfig(global::Client.ConnectionProtocol protocol, int timeout = 10000)
		{
		}

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x4004193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public global::Client.ConnectionProtocol protocol;

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x4004194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int timeout;
	}

	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000B28")]
	[Flags]
	public enum ProcessAccessFlags : uint
	{
		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x4004196")]
		Terminate = 1U,
		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x4004197")]
		Synchronize = 1048576U
	}

	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000B2A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001DA1 RID: 7585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2A")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x6004D2B")]
		[Address(RVA = "0x4F2F60", Offset = "0x4F1D60", VA = "0x1804F2F60")]
		internal bool <DoClientConnected>b__41_0(ConsoleSystem.Command x)
		{
			return default(bool);
		}

		// Token: 0x040018AC RID: 6316
		[Token(Token = "0x40041A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly global::Client.<>c <>9;

		// Token: 0x040018AD RID: 6317
		[Token(Token = "0x40041A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ConsoleSystem.Command, bool> <>9__41_0;
	}

	// Token: 0x02000356 RID: 854
	[Token(Token = "0x2000B2B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <DoClientConnected>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2C")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <DoClientConnected>d__41(int <>1__state)
		{
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2D")]
		[Address(RVA = "0x4F1330", Offset = "0x4F0130", VA = "0x1804F1330", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0000E490 File Offset: 0x0000C690
		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0x4EFD60", Offset = "0x4EEB60", VA = "0x1804EFD60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0x4F13E0", Offset = "0x4F01E0", VA = "0x1804F13E0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000709")]
		private object Current
		{
			[Token(Token = "0x6004D30")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x4F12E0", Offset = "0x4F00E0", VA = "0x1804F12E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070A")]
		private object Current
		{
			[Token(Token = "0x6004D32")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040018AE RID: 6318
		[Token(Token = "0x40041A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40041A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40041A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Approval msg;

		// Token: 0x040018B1 RID: 6321
		[Token(Token = "0x40041A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public global::Client <>4__this;

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40041A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BenchmarkTimer <>7__wrap1;
	}

	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000B2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <StartPlayingDemoInternal>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001DAA RID: 7594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <StartPlayingDemoInternal>d__80(int <>1__state)
		{
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x4F2850", Offset = "0x4F1650", VA = "0x1804F2850", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x4F1430", Offset = "0x4F0230", VA = "0x1804F1430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x4F2A30", Offset = "0x4F1830", VA = "0x1804F2A30")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x4F2A80", Offset = "0x4F1880", VA = "0x1804F2A80")]
		private void <>m__Finally2()
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D38")]
		[Address(RVA = "0x4F2AD0", Offset = "0x4F18D0", VA = "0x1804F2AD0")]
		private void <>m__Finally3()
		{
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x4F2B20", Offset = "0x4F1920", VA = "0x1804F2B20")]
		private void <>m__Finally4()
		{
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3A")]
		[Address(RVA = "0x4F2B70", Offset = "0x4F1970", VA = "0x1804F2B70")]
		private void <>m__Finally5()
		{
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070B")]
		private object Current
		{
			[Token(Token = "0x6004D3B")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3C")]
		[Address(RVA = "0x4F2800", Offset = "0x4F1600", VA = "0x1804F2800", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070C")]
		private object Current
		{
			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040018B3 RID: 6323
		[Token(Token = "0x40041A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040018B4 RID: 6324
		[Token(Token = "0x40041AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040018B5 RID: 6325
		[Token(Token = "0x40041AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Reader demo;

		// Token: 0x040018B6 RID: 6326
		[Token(Token = "0x40041AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public global::Client <>4__this;

		// Token: 0x040018B7 RID: 6327
		[Token(Token = "0x40041AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool inPlace;

		// Token: 0x040018B8 RID: 6328
		[Token(Token = "0x40041AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BenchmarkTimer <>7__wrap1;

		// Token: 0x040018B9 RID: 6329
		[Token(Token = "0x40041AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BenchmarkTimer <>7__wrap2;
	}
}
