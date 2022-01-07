using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using JSON;
using Network;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000126 RID: 294
[Token(Token = "0x20000AE")]
public class CommunityEntity : PointEntity
{
	// Token: 0x06001193 RID: 4499 RVA: 0x0000A488 File Offset: 0x00008688
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x4A3250", Offset = "0x4A2050", VA = "0x1804A3250", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x4A15A0", Offset = "0x4A03A0", VA = "0x1804A15A0")]
	[BaseEntity.RPC_Client]
	public void CL_ReceiveFilePng(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x4A3DA0", Offset = "0x4A2BA0", VA = "0x1804A3DA0")]
	private void SetImageFromServer(MaskableGraphic component, uint textureID)
	{
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x4A2F80", Offset = "0x4A1D80", VA = "0x1804A2F80")]
	private void LoadPngIntoGraphic(MaskableGraphic component, byte[] bytes)
	{
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x4A29F0", Offset = "0x4A17F0", VA = "0x1804A29F0")]
	public static void DestroyServerCreatedUI()
	{
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x4A3F70", Offset = "0x4A2D70", VA = "0x1804A3F70")]
	public void SetVisible(bool b)
	{
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x4A3CE0", Offset = "0x4A2AE0", VA = "0x1804A3CE0")]
	private static void RegisterUi(GameObject go)
	{
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x4A0EB0", Offset = "0x49FCB0", VA = "0x1804A0EB0")]
	[BaseEntity.RPC_Client]
	public void AddUI(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x4A2D00", Offset = "0x4A1B00", VA = "0x1804A2D00")]
	private GameObject FindPanel(string name)
	{
		return null;
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x4A1850", Offset = "0x4A0650", VA = "0x1804A1850")]
	private void CreateComponents(GameObject go, JSON.Object obj)
	{
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD0")]
	private static T ParseEnum<T>(string value, T defaultValue) where T : struct, Enum
	{
		return null;
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x4A2E10", Offset = "0x4A1C10", VA = "0x1804A2E10")]
	private void GraphicComponentCreated(Graphic c, JSON.Object obj)
	{
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x4A31C0", Offset = "0x4A1FC0", VA = "0x1804A31C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x90E50", Offset = "0x90250")]
	private IEnumerator LoadTextureFromWWW(RawImage c, string p)
	{
		return null;
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x4A2CB0", Offset = "0x4A1AB0", VA = "0x1804A2CB0")]
	[BaseEntity.RPC_Client]
	public void DestroyUI(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x4A2850", Offset = "0x4A1650", VA = "0x1804A2850")]
	private void DestroyPanel(string pnlName)
	{
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x4A2ED0", Offset = "0x4A1CD0", VA = "0x1804A2ED0", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x4A2C00", Offset = "0x4A1A00", VA = "0x1804A2C00", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x4A4130", Offset = "0x4A2F30", VA = "0x1804A4130")]
	public CommunityEntity()
	{
	}

	// Token: 0x04000C0E RID: 3086
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<uint, List<MaskableGraphic>> requestingTextureImages;

	// Token: 0x04000C0F RID: 3087
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x8")]
	private static List<GameObject> AllUi;

	// Token: 0x04000C10 RID: 3088
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, GameObject> UiDict;

	// Token: 0x04000C11 RID: 3089
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x18")]
	public static CommunityEntity ServerInstance;

	// Token: 0x04000C12 RID: 3090
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x20")]
	public static CommunityEntity ClientInstance;

	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000AB0")]
	private class Countdown : MonoBehaviour
	{
		// Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0x4A8A30", Offset = "0x4A7830", VA = "0x1804A8A30")]
		private void Start()
		{
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x4A8B80", Offset = "0x4A7980", VA = "0x1804A8B80")]
		private void UpdateCountdown()
		{
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x4A8950", Offset = "0x4A7750", VA = "0x1804A8950")]
		private void End()
		{
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x4A8CA0", Offset = "0x4A7AA0", VA = "0x1804A8CA0")]
		public Countdown()
		{
		}

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4003F88")]
		[FieldOffset(Offset = "0x18")]
		public string command;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4003F89")]
		[FieldOffset(Offset = "0x20")]
		public int endTime;

		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4003F8A")]
		[FieldOffset(Offset = "0x24")]
		public int startTime;

		// Token: 0x04000C16 RID: 3094
		[Token(Token = "0x4003F8B")]
		[FieldOffset(Offset = "0x28")]
		public int step;

		// Token: 0x04000C17 RID: 3095
		[Token(Token = "0x4003F8C")]
		[FieldOffset(Offset = "0x2C")]
		private int sign;

		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4003F8D")]
		[FieldOffset(Offset = "0x30")]
		private Text textComponent;
	}

	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000AB1")]
	private class FadeOut : MonoBehaviour
	{
		// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x4ACFC0", Offset = "0x4ABDC0", VA = "0x1804ACFC0")]
		public void FadeOutAndDestroy()
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C50")]
		[Address(RVA = "0x4AD0A0", Offset = "0x4ABEA0", VA = "0x1804AD0A0")]
		public void Kill()
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C51")]
		[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
		public FadeOut()
		{
		}

		// Token: 0x04000C19 RID: 3097
		[Token(Token = "0x4003F8E")]
		[FieldOffset(Offset = "0x18")]
		public float duration;
	}

	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000AB2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0x4B03E0", Offset = "0x4AF1E0", VA = "0x1804B03E0")]
		internal void <CreateComponents>b__0()
		{
		}

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4003F8F")]
		[FieldOffset(Offset = "0x10")]
		public string cmd;
	}

	// Token: 0x0200012A RID: 298
	[Token(Token = "0x2000AB3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass14_1
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C54")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass14_1()
		{
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C55")]
		[Address(RVA = "0x4B03F0", Offset = "0x4AF1F0", VA = "0x1804B03F0")]
		internal void <CreateComponents>b__1()
		{
		}

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4003F90")]
		[FieldOffset(Offset = "0x10")]
		public string pnlName;

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4003F91")]
		[FieldOffset(Offset = "0x18")]
		public CommunityEntity <>4__this;
	}

	// Token: 0x0200012B RID: 299
	[Token(Token = "0x2000AB4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass14_2
	{
		// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C56")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass14_2()
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C57")]
		[Address(RVA = "0x4B0420", Offset = "0x4AF220", VA = "0x1804B0420")]
		internal void <CreateComponents>b__2(string value)
		{
		}

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4003F92")]
		[FieldOffset(Offset = "0x10")]
		public string cmd;
	}

	// Token: 0x0200012C RID: 300
	[Token(Token = "0x2000AB5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <LoadTextureFromWWW>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <LoadTextureFromWWW>d__17(int <>1__state)
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C59")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x4AF200", Offset = "0x4AE000", VA = "0x1804AF200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F5")]
		private object Current
		{
			[Token(Token = "0x6004C5B")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x4AF620", Offset = "0x4AE420", VA = "0x1804AF620", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F6")]
		private object Current
		{
			[Token(Token = "0x6004C5D")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4003F93")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4003F94")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4003F95")]
		[FieldOffset(Offset = "0x20")]
		public string p;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4003F96")]
		[FieldOffset(Offset = "0x28")]
		public RawImage c;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4003F97")]
		[FieldOffset(Offset = "0x30")]
		private WWW <www>5__2;
	}
}
