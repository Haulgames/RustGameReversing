using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200002E")]
public class AdvancedChristmasLights : IOEntity
{
	// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x821100", Offset = "0x81FF00", VA = "0x180821100", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600052F RID: 1327 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x1700000F")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x823000", Offset = "0x821E00", VA = "0x180823000", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x8220E0", Offset = "0x820EE0", VA = "0x1808220E0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x8210A0", Offset = "0x81FEA0", VA = "0x1808210A0")]
	public void ClearPoints()
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x8210F0", Offset = "0x81FEF0", VA = "0x1808210F0")]
	public void FinishEditing()
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x821C10", Offset = "0x820A10", VA = "0x180821C10")]
	public bool IsFinalized()
	{
		return default(bool);
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x820FB0", Offset = "0x81FDB0", VA = "0x180820FB0")]
	public void AddPoint(Vector3 newPoint, Vector3 newNormal)
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x6000111")]
	[Address(RVA = "0x6442E0", Offset = "0x6430E0", VA = "0x1806442E0", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x821C30", Offset = "0x820A30", VA = "0x180821C30", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x8221D0", Offset = "0x820FD0", VA = "0x1808221D0", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x822DC0", Offset = "0x821BC0", VA = "0x180822DC0")]
	public void UpdateBulbs()
	{
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x822C90", Offset = "0x821A90", VA = "0x180822C90", Slot = "158")]
	public virtual void SetBulbsOn(bool wantsOn)
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x822EE0", Offset = "0x821CE0", VA = "0x180822EE0")]
	public void UpdateCulling()
	{
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x822290", Offset = "0x821090", VA = "0x180822290")]
	public void RegenerateLights()
	{
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x822080", Offset = "0x820E80", VA = "0x180822080")]
	[Attribute(Name = "Menu", RVA = "0x9E6B0", Offset = "0x9DAB0")]
	[Attribute(Name = "Description", RVA = "0x9E6B0", Offset = "0x9DAB0")]
	[Attribute(Name = "Icon", RVA = "0x9E6B0", Offset = "0x9DAB0")]
	[Attribute(Name = "ShowIf", RVA = "0x9E6B0", Offset = "0x9DAB0")]
	public void Menu_Lightmode_SteadyOn(BasePlayer player)
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x822070", Offset = "0x820E70", VA = "0x180822070")]
	public bool Menu_Lightmode_SteadyOn_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x821FD0", Offset = "0x820DD0", VA = "0x180821FD0")]
	[Attribute(Name = "Menu", RVA = "0x9E960", Offset = "0x9DD60")]
	[Attribute(Name = "Description", RVA = "0x9E960", Offset = "0x9DD60")]
	[Attribute(Name = "Icon", RVA = "0x9E960", Offset = "0x9DD60")]
	[Attribute(Name = "ShowIf", RVA = "0x9E960", Offset = "0x9DD60")]
	public void Menu_Lightmode_Flashing(BasePlayer player)
	{
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x821FC0", Offset = "0x820DC0", VA = "0x180821FC0")]
	public bool Menu_Lightmode_Flashing_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x821F10", Offset = "0x820D10", VA = "0x180821F10")]
	[Attribute(Name = "Menu", RVA = "0x9EC70", Offset = "0x9E070")]
	[Attribute(Name = "Description", RVA = "0x9EC70", Offset = "0x9E070")]
	[Attribute(Name = "Icon", RVA = "0x9EC70", Offset = "0x9E070")]
	[Attribute(Name = "ShowIf", RVA = "0x9EC70", Offset = "0x9E070")]
	public void Menu_Lightmode_Chasing(BasePlayer player)
	{
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x821F00", Offset = "0x820D00", VA = "0x180821F00")]
	public bool Menu_Lightmode_Chasing_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x821F70", Offset = "0x820D70", VA = "0x180821F70")]
	[Attribute(Name = "Menu", RVA = "0x9F140", Offset = "0x9E540")]
	[Attribute(Name = "Description", RVA = "0x9F140", Offset = "0x9E540")]
	[Attribute(Name = "Icon", RVA = "0x9F140", Offset = "0x9E540")]
	[Attribute(Name = "ShowIf", RVA = "0x9F140", Offset = "0x9E540")]
	public void Menu_Lightmode_Fade(BasePlayer player)
	{
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x821F60", Offset = "0x820D60", VA = "0x180821F60")]
	public bool Menu_Lightmode_Fade_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x822020", Offset = "0x820E20", VA = "0x180822020")]
	[Attribute(Name = "Menu", RVA = "0x9F350", Offset = "0x9E750")]
	[Attribute(Name = "Description", RVA = "0x9F350", Offset = "0x9E750")]
	[Attribute(Name = "Icon", RVA = "0x9F350", Offset = "0x9E750")]
	[Attribute(Name = "ShowIf", RVA = "0x9F350", Offset = "0x9E750")]
	public void Menu_Lightmode_SlowGlow(BasePlayer player)
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x8220D0", Offset = "0x820ED0", VA = "0x1808220D0")]
	public bool Menu_Lightmode_slowglow_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x821C20", Offset = "0x820A20", VA = "0x180821C20")]
	public bool IsStyle(AdvancedChristmasLights.AnimationType testType)
	{
		return default(bool);
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10")]
	public bool CanPlayerManipulate(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x822F10", Offset = "0x821D10", VA = "0x180822F10")]
	public AdvancedChristmasLights()
	{
	}

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x268")]
	private Option __menuOption_Menu_Lightmode_Chasing;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x2C0")]
	private Option __menuOption_Menu_Lightmode_Fade;

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x318")]
	private Option __menuOption_Menu_Lightmode_Flashing;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x370")]
	private Option __menuOption_Menu_Lightmode_SlowGlow;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x3C8")]
	private Option __menuOption_Menu_Lightmode_SteadyOn;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x420")]
	public GameObjectRef bulbPrefab;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x428")]
	public LineRenderer lineRenderer;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x430")]
	public List<AdvancedChristmasLights.pointEntry> points;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x438")]
	public List<BaseBulb> bulbs;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x440")]
	public float bulbSpacing;

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x444")]
	public float wireThickness;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x448")]
	public Transform wireEmission;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x450")]
	public AdvancedChristmasLights.AnimationType animationStyle;

	// Token: 0x040001F8 RID: 504
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x458")]
	public RendererLOD _lod;

	// Token: 0x040001F9 RID: 505
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x460")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x9E580", Offset = "0x9D980")]
	public float lengthToPowerRatio;

	// Token: 0x040001FA RID: 506
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x464")]
	private bool finalized;

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x468")]
	private int lengthUsed;

	// Token: 0x040001FC RID: 508
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x46C")]
	private int oldAnimationStyle;

	// Token: 0x040001FD RID: 509
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x470")]
	private int oldPointCount;

	// Token: 0x0200003C RID: 60
	[Token(Token = "0x2000A4F")]
	public struct pointEntry
	{
		// Token: 0x040001FE RID: 510
		[Token(Token = "0x4003D89")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 point;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x4003D8A")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 normal;
	}

	// Token: 0x0200003D RID: 61
	[Token(Token = "0x2000A50")]
	public enum AnimationType
	{
		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4003D8C")]
		ON = 1,
		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4003D8D")]
		FLASHING,
		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4003D8E")]
		CHASING,
		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4003D8F")]
		FADE,
		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4003D90")]
		SLOWGLOW = 6
	}
}
