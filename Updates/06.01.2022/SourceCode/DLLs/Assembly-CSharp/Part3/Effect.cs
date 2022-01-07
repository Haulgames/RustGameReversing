using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000405 RID: 1029
[Token(Token = "0x20002E4")]
public class Effect : EffectData
{
	// Token: 0x06002162 RID: 8546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x989FC0", Offset = "0x988DC0", VA = "0x180989FC0")]
	public Effect()
	{
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x989FD0", Offset = "0x988DD0", VA = "0x180989FD0")]
	public Effect(string effectName, Vector3 posWorld, Vector3 normWorld, [Optional] Connection sourceConnection)
	{
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x98A100", Offset = "0x988F00", VA = "0x18098A100")]
	public Effect(string effectName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, [Optional] Connection sourceConnection)
	{
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x988E40", Offset = "0x987C40", VA = "0x180988E40")]
	public void Init(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, [Optional] Connection sourceConnection)
	{
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B31")]
	[Address(RVA = "0x988D30", Offset = "0x987B30", VA = "0x180988D30")]
	public void Init(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, [Optional] Connection sourceConnection)
	{
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x0000F648 File Offset: 0x0000D848
	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x989140", Offset = "0x987F40", VA = "0x180989140")]
	public bool NetworkConstruct()
	{
		return default(bool);
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x988C60", Offset = "0x987A60", VA = "0x180988C60")]
	public void Clear()
	{
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x989E20", Offset = "0x988C20", VA = "0x180989E20")]
	public static void Strip(GameObject obj)
	{
	}

	// Token: 0x04001C15 RID: 7189
	[Token(Token = "0x40016CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 Up;

	// Token: 0x04001C16 RID: 7190
	[Token(Token = "0x40016CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 worldPos;

	// Token: 0x04001C17 RID: 7191
	[Token(Token = "0x40016CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 worldNrm;

	// Token: 0x04001C18 RID: 7192
	[Token(Token = "0x40016CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool attached;

	// Token: 0x04001C19 RID: 7193
	[Token(Token = "0x40016D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform transform;

	// Token: 0x04001C1A RID: 7194
	[Token(Token = "0x40016D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject gameObject;

	// Token: 0x04001C1B RID: 7195
	[Token(Token = "0x40016D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string pooledString;

	// Token: 0x04001C1C RID: 7196
	[Token(Token = "0x40016D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool broadcast;

	// Token: 0x04001C1D RID: 7197
	[Token(Token = "0x40016D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Effect reusableInstace;

	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000B56")]
	public enum Type : uint
	{
		// Token: 0x04001C1F RID: 7199
		[Token(Token = "0x4004260")]
		Generic,
		// Token: 0x04001C20 RID: 7200
		[Token(Token = "0x4004261")]
		Projectile,
		// Token: 0x04001C21 RID: 7201
		[Token(Token = "0x4004262")]
		GenericGlobal
	}

	// Token: 0x02000407 RID: 1031
	[Token(Token = "0x2000B57")]
	public static class client
	{
		// Token: 0x0600216B RID: 8555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0x9948F0", Offset = "0x9936F0", VA = "0x1809948F0")]
		public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal)
		{
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x994BF0", Offset = "0x9939F0", VA = "0x180994BF0")]
		public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal)
		{
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x994A20", Offset = "0x993820", VA = "0x180994A20")]
		public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, [Optional] Vector3 up)
		{
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x994D60", Offset = "0x993B60", VA = "0x180994D60")]
		public static void Run(string strName, [Optional] Vector3 posWorld, [Optional] Vector3 normWorld, [Optional] Vector3 up, Effect.Type overrideType = Effect.Type.Generic)
		{
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x994690", Offset = "0x993490", VA = "0x180994690")]
		public static void Run(string strName, GameObject obj)
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB8")]
		[Address(RVA = "0x993E00", Offset = "0x992C00", VA = "0x180993E00")]
		public static void DoAdditiveImpactEffect(HitInfo info, string effectName)
		{
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB9")]
		[Address(RVA = "0x994050", Offset = "0x992E50", VA = "0x180994050")]
		public static void ImpactEffect(HitInfo info)
		{
		}
	}

	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000B58")]
	public static class server
	{
		// Token: 0x06002172 RID: 8562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBA")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
		public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, [Optional] Connection sourceConnection, bool broadcast = false)
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBB")]
		[Address(RVA = "0x9953A0", Offset = "0x9941A0", VA = "0x1809953A0")]
		public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, [Optional] Connection sourceConnection, bool broadcast = false)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBC")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
		public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, [Optional] Connection sourceConnection, bool broadcast = false)
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBD")]
		[Address(RVA = "0x9953A0", Offset = "0x9941A0", VA = "0x1809953A0")]
		public static void Run(string strName, [Optional] Vector3 posWorld, [Optional] Vector3 normWorld, [Optional] Connection sourceConnection, bool broadcast = false)
		{
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBE")]
		[Address(RVA = "0x994F70", Offset = "0x993D70", VA = "0x180994F70")]
		public static void DoAdditiveImpactEffect(HitInfo info, string effectName)
		{
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBF")]
		[Address(RVA = "0x994FA0", Offset = "0x993DA0", VA = "0x180994FA0")]
		public static void ImpactEffect(HitInfo info)
		{
		}
	}
}
