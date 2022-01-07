using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200056E RID: 1390
[Token(Token = "0x2000409")]
public class DamageRenderer : MonoBehaviour, IClientComponent, IPrefabPreProcess
{
	// Token: 0x06002816 RID: 10262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600217B")]
	[Address(RVA = "0x6DE1B0", Offset = "0x6DCFB0", VA = "0x1806DE1B0", Slot = "4")]
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06002817 RID: 10263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600217C")]
	[Address(RVA = "0x6DF090", Offset = "0x6DDE90", VA = "0x1806DF090")]
	public void UpdateDamage(BaseCombatEntity bce)
	{
	}

	// Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600217D")]
	[Address(RVA = "0x6DEFD0", Offset = "0x6DDDD0", VA = "0x1806DEFD0")]
	public void UpdateDamage(float curHealth, bool isDead, float healthFraction)
	{
	}

	// Token: 0x06002819 RID: 10265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600217E")]
	[Address(RVA = "0x6DE9B0", Offset = "0x6DD7B0", VA = "0x1806DE9B0")]
	private void RefreshDamageTex(float healthPercent, bool isDead)
	{
	}

	// Token: 0x0600281A RID: 10266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600217F")]
	[Address(RVA = "0x6DED60", Offset = "0x6DDB60", VA = "0x1806DED60")]
	private void SetDamageTex(DamageRenderer.DamageShowingRenderer dsr)
	{
	}

	// Token: 0x0600281B RID: 10267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002180")]
	[Address(RVA = "0x6DD9B0", Offset = "0x6DC7B0", VA = "0x1806DD9B0")]
	public void DrawHighlight()
	{
	}

	// Token: 0x0600281C RID: 10268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002181")]
	[Address(RVA = "0x6DDBD0", Offset = "0x6DC9D0", VA = "0x1806DDBD0")]
	private void Highlight(Renderer renderer)
	{
	}

	// Token: 0x0600281D RID: 10269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002182")]
	[Address(RVA = "0x6DF1D0", Offset = "0x6DDFD0", VA = "0x1806DF1D0")]
	public DamageRenderer()
	{
	}

	// Token: 0x0600281F RID: 10271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002184")]
	[Address(RVA = "0x6DEE90", Offset = "0x6DDC90", VA = "0x1806DEE90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int[] <PreProcess>g__GetValidMatIndices|12_0(Renderer renderer, ref DamageRenderer.<>c__DisplayClass12_0 A_2)
	{
		return null;
	}

	// Token: 0x0400234B RID: 9035
	[Token(Token = "0x4001CD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Material> damageShowingMats;

	// Token: 0x0400234C RID: 9036
	[Token(Token = "0x4001CD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float maxDamageOpacity;

	// Token: 0x0400234D RID: 9037
	[Token(Token = "0x4001CD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private List<DamageRenderer.DamageShowingRenderer> damageShowingRenderers;

	// Token: 0x0400234E RID: 9038
	[Token(Token = "0x4001CD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private List<GlassPane> damageShowingGlassRenderers;

	// Token: 0x0400234F RID: 9039
	[Token(Token = "0x4001CD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float prevHealth;

	// Token: 0x04002350 RID: 9040
	[Token(Token = "0x4001CD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool prevIsDead;

	// Token: 0x04002351 RID: 9041
	[Token(Token = "0x4001CD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color damageColour;

	// Token: 0x04002352 RID: 9042
	[Token(Token = "0x4001CD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock materialPB;

	// Token: 0x04002353 RID: 9043
	[Token(Token = "0x4001CD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static MaterialPropertyBlock glassMaterialPB;

	// Token: 0x04002354 RID: 9044
	[Token(Token = "0x4001CD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int detailColorID;

	// Token: 0x04002355 RID: 9045
	[Token(Token = "0x4001CDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Material highlightMaterial;

	// Token: 0x0200056F RID: 1391
	[Token(Token = "0x2000B98")]
	[Serializable]
	private struct DamageShowingRenderer
	{
		// Token: 0x06002820 RID: 10272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E17")]
		[Address(RVA = "0xF0180", Offset = "0xEF580", VA = "0x1800F0180")]
		public DamageShowingRenderer(Renderer renderer, int[] indices)
		{
		}

		// Token: 0x04002356 RID: 9046
		[Token(Token = "0x4004385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Renderer renderer;

		// Token: 0x04002357 RID: 9047
		[Token(Token = "0x4004386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] indices;
	}

	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000B99")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[StructLayout(3)]
	private struct <>c__DisplayClass12_0
	{
		// Token: 0x04002358 RID: 9048
		[Token(Token = "0x4004387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<int> matList;

		// Token: 0x04002359 RID: 9049
		[Token(Token = "0x4004388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DamageRenderer <>4__this;
	}
}
