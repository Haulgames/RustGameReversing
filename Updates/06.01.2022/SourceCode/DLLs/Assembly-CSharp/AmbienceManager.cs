using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AA RID: 682
[Token(Token = "0x20001E3")]
public class AmbienceManager : SingletonComponent<AmbienceManager>, IClientComponent
{
	// Token: 0x06001A00 RID: 6656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001497")]
	[Address(RVA = "0x828240", Offset = "0x827040", VA = "0x180828240")]
	private void Start()
	{
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001498")]
	[Address(RVA = "0x827B10", Offset = "0x826910", VA = "0x180827B10")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001499")]
	[Address(RVA = "0x827D10", Offset = "0x826B10", VA = "0x180827D10")]
	private void OnDisable()
	{
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149A")]
	[Address(RVA = "0x828E50", Offset = "0x827C50", VA = "0x180828E50")]
	private void Update()
	{
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149B")]
	[Address(RVA = "0x828940", Offset = "0x827740", VA = "0x180828940")]
	private void Tick()
	{
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149C")]
	[Address(RVA = "0x828680", Offset = "0x827480", VA = "0x180828680")]
	private void TickLocalEmitters()
	{
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149D")]
	[Address(RVA = "0x827580", Offset = "0x826380", VA = "0x180827580")]
	public void DeactivateEmitter(AmbienceEmitter emitter)
	{
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149E")]
	[Address(RVA = "0x826DC0", Offset = "0x825BC0", VA = "0x180826DC0")]
	public void ActivateEmitter(AmbienceEmitter emitter)
	{
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149F")]
	[Address(RVA = "0x828380", Offset = "0x827180", VA = "0x180828380")]
	private void TickCameraEmitters()
	{
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x8280C0", Offset = "0x826EC0", VA = "0x1808280C0")]
	private void SortLocalEmitters()
	{
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x827830", Offset = "0x826630", VA = "0x180827830")]
	private AmbienceManager.EmitterTypeLimit EmitterLimit(AmbienceEmitter emitter)
	{
		return null;
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x827C30", Offset = "0x826A30", VA = "0x180827C30")]
	public void OnCullingGroupChange(CullingGroupEvent evt, AmbienceManager.AmbienceGroup group)
	{
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x827790", Offset = "0x826590", VA = "0x180827790")]
	public void EmitterLeaveRange(AmbienceEmitter emitter)
	{
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x826F10", Offset = "0x825D10", VA = "0x180826F10")]
	public void AddEmitter(AmbienceEmitter emitter)
	{
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x827DE0", Offset = "0x826BE0", VA = "0x180827DE0")]
	public void RemoveEmitter(AmbienceEmitter emitter)
	{
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A6")]
	[Address(RVA = "0x826EB0", Offset = "0x825CB0", VA = "0x180826EB0")]
	public void AddCameraEmitter(AmbienceEmitter emitter)
	{
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x827D80", Offset = "0x826B80", VA = "0x180827D80")]
	public void RemoveCameraEmitter(AmbienceEmitter emitter)
	{
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x828980", Offset = "0x827780", VA = "0x180828980")]
	private void UpdateCullingGroups()
	{
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x827200", Offset = "0x826000", VA = "0x180827200")]
	private AmbienceManager.AmbienceGroup AmbienceGroupForEmitter(AmbienceEmitter emitter)
	{
		return null;
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x8278C0", Offset = "0x8266C0", VA = "0x1808278C0")]
	public void EnableAdvancedAmbience()
	{
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x8275E0", Offset = "0x8263E0", VA = "0x1808275E0")]
	public void DisableAdvancedAmbience()
	{
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x828060", Offset = "0x826E60", VA = "0x180828060")]
	private void SortEmitters(List<AmbienceEmitter> emitterList)
	{
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x827E90", Offset = "0x826C90", VA = "0x180827E90")]
	private void SortEmitters(List<AmbienceEmitter> emitterList, int left, int right)
	{
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x8273A0", Offset = "0x8261A0", VA = "0x1808273A0")]
	public void AmbienceZoneEntered(AmbienceZone zone)
	{
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x827400", Offset = "0x826200", VA = "0x180827400")]
	public void AmbienceZoneExited(AmbienceZone zone)
	{
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x827460", Offset = "0x826260", VA = "0x180827460")]
	public AmbienceZone CurrentAmbienceZone()
	{
		return null;
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x829340", Offset = "0x828140", VA = "0x180829340")]
	public AmbienceManager()
	{
	}

	// Token: 0x04001485 RID: 5253
	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0x18")]
	public List<AmbienceManager.EmitterTypeLimit> localEmitterLimits;

	// Token: 0x04001486 RID: 5254
	[Token(Token = "0x40010EE")]
	[FieldOffset(Offset = "0x20")]
	public AmbienceManager.EmitterTypeLimit catchallEmitterLimit;

	// Token: 0x04001487 RID: 5255
	[Token(Token = "0x40010EF")]
	[FieldOffset(Offset = "0x28")]
	public int maxActiveLocalEmitters;

	// Token: 0x04001488 RID: 5256
	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0x2C")]
	public int activeLocalEmitters;

	// Token: 0x04001489 RID: 5257
	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x30")]
	public List<AmbienceEmitter> cameraEmitters;

	// Token: 0x0400148A RID: 5258
	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x38")]
	public List<AmbienceEmitter> emittersInRange;

	// Token: 0x0400148B RID: 5259
	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0x40")]
	public List<AmbienceEmitter> activeEmitters;

	// Token: 0x0400148C RID: 5260
	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0x48")]
	public float localEmitterRange;

	// Token: 0x0400148D RID: 5261
	[Token(Token = "0x40010F5")]
	[FieldOffset(Offset = "0x50")]
	public List<AmbienceZone> currentAmbienceZones;

	// Token: 0x0400148E RID: 5262
	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0x58")]
	public bool isUnderwater;

	// Token: 0x0400148F RID: 5263
	[Token(Token = "0x40010F7")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<AmbienceDefinitionList, AmbienceManager.EmitterTypeLimit> emitterLimitByAmbience;

	// Token: 0x04001490 RID: 5264
	[Token(Token = "0x40010F8")]
	[FieldOffset(Offset = "0x68")]
	private float tickInterval;

	// Token: 0x04001491 RID: 5265
	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0x6C")]
	private float lastTick;

	// Token: 0x04001492 RID: 5266
	[Token(Token = "0x40010FA")]
	[FieldOffset(Offset = "0x70")]
	private List<AmbienceManager.AmbienceGroup> ambienceGroups;

	// Token: 0x04001493 RID: 5267
	[Token(Token = "0x40010FB")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<AmbienceDefinitionList, AmbienceManager.AmbienceGroup> ambienceGroupsByDef;

	// Token: 0x020002AB RID: 683
	[Token(Token = "0x2000AFC")]
	[Serializable]
	public class EmitterTypeLimit
	{
		// Token: 0x06001A1B RID: 6683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x82F9D0", Offset = "0x82E7D0", VA = "0x18082F9D0")]
		public EmitterTypeLimit()
		{
		}

		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x40040AE")]
		[FieldOffset(Offset = "0x10")]
		public List<AmbienceDefinitionList> ambience;

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x40040AF")]
		[FieldOffset(Offset = "0x18")]
		public int limit;

		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x40040B0")]
		[FieldOffset(Offset = "0x1C")]
		public int active;
	}

	// Token: 0x020002AC RID: 684
	[Token(Token = "0x2000AFD")]
	public class AmbienceGroup
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x8267E0", Offset = "0x8255E0", VA = "0x1808267E0")]
		public void OnCullingGroupChange(CullingGroupEvent evt)
		{
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x826920", Offset = "0x825720", VA = "0x180826920")]
		public AmbienceGroup()
		{
		}

		// Token: 0x04001497 RID: 5271
		[Token(Token = "0x40040B1")]
		[FieldOffset(Offset = "0x10")]
		public AmbienceDefinitionList ambienceDefinition;

		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x40040B2")]
		[FieldOffset(Offset = "0x18")]
		public HashSet<AmbienceEmitter> emitters;

		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x40040B3")]
		[FieldOffset(Offset = "0x20")]
		public CullingGroup cullingGroup;

		// Token: 0x0400149A RID: 5274
		[Token(Token = "0x40040B4")]
		[FieldOffset(Offset = "0x28")]
		public BoundingSphere[] cullGroupSpheres;

		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x40040B5")]
		[FieldOffset(Offset = "0x30")]
		public List<AmbienceEmitter> emittersBySphereIdx;

		// Token: 0x0400149C RID: 5276
		[Token(Token = "0x40040B6")]
		[FieldOffset(Offset = "0x38")]
		public bool cullingGroupDirty;
	}
}
