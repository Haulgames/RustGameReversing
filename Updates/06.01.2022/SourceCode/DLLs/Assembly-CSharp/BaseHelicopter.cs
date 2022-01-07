using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000105 RID: 261
[Token(Token = "0x200009D")]
public class BaseHelicopter : BaseCombatEntity
{
	// Token: 0x06000FFC RID: 4092 RVA: 0x000096D8 File Offset: 0x000078D8
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x89D760", Offset = "0x89C560", VA = "0x18089D760", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x89D2C0", Offset = "0x89C0C0", VA = "0x18089D2C0")]
	public void InitalizeWeakspots()
	{
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x000096F0 File Offset: 0x000078F0
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x31BB70", Offset = "0x31A970", VA = "0x18031BB70", Slot = "111")]
	public override float MaxVelocity()
	{
		return 0f;
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x89D230", Offset = "0x89C030", VA = "0x18089D230", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x89D5A0", Offset = "0x89C3A0", VA = "0x18089D5A0", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x89CC30", Offset = "0x89BA30", VA = "0x18089CC30", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x89D340", Offset = "0x89C140", VA = "0x18089D340")]
	public void InitializeClientsideEffects()
	{
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x89CC70", Offset = "0x89BA70", VA = "0x18089CC70", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x89DBB0", Offset = "0x89C9B0", VA = "0x18089DBB0")]
	public void SetLights(bool areOn)
	{
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x89E630", Offset = "0x89D430", VA = "0x18089E630")]
	public void Update()
	{
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x89DCD0", Offset = "0x89CAD0", VA = "0x18089DCD0")]
	public void UpdateEffects()
	{
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x89E4F0", Offset = "0x89D2F0", VA = "0x18089E4F0")]
	public void UpdateRotorWashPosition(Vector3 pos, Vector3 normal)
	{
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x89DC50", Offset = "0x89CA50", VA = "0x18089DC50")]
	public void ToggleRotorWash(bool enabled)
	{
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x89E460", Offset = "0x89D260", VA = "0x18089E460")]
	public void UpdateRotorVisibility()
	{
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x89CD50", Offset = "0x89BB50", VA = "0x18089CD50")]
	[global::BaseEntity.RPC_Client]
	public void FireGun(global::BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x89EDC0", Offset = "0x89DBC0", VA = "0x18089EDC0")]
	public BaseHelicopter()
	{
	}

	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x238")]
	public BaseHelicopter.weakspot[] weakspots;

	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x240")]
	public GameObject rotorPivot;

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x248")]
	public GameObject mainRotor;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x250")]
	public GameObject mainRotor_blades;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x258")]
	public GameObject mainRotor_blur;

	// Token: 0x04000A23 RID: 2595
	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x260")]
	public GameObject tailRotor;

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x268")]
	public GameObject tailRotor_blades;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0x270")]
	public GameObject tailRotor_blur;

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0x278")]
	public GameObject rocket_tube_left;

	// Token: 0x04000A27 RID: 2599
	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0x280")]
	public GameObject rocket_tube_right;

	// Token: 0x04000A28 RID: 2600
	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0x288")]
	public GameObject left_gun_yaw;

	// Token: 0x04000A29 RID: 2601
	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0x290")]
	public GameObject left_gun_pitch;

	// Token: 0x04000A2A RID: 2602
	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0x298")]
	public GameObject left_gun_muzzle;

	// Token: 0x04000A2B RID: 2603
	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObject right_gun_yaw;

	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0x2A8")]
	public GameObject right_gun_pitch;

	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObject right_gun_muzzle;

	// Token: 0x04000A2E RID: 2606
	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0x2B8")]
	public GameObject spotlight_rotation;

	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x2C0")]
	public GameObjectRef rocket_fire_effect;

	// Token: 0x04000A30 RID: 2608
	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x2C8")]
	public GameObjectRef gun_fire_effect;

	// Token: 0x04000A31 RID: 2609
	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x2D0")]
	public GameObjectRef bulletEffect;

	// Token: 0x04000A32 RID: 2610
	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0x2D8")]
	public GameObjectRef explosionEffect;

	// Token: 0x04000A33 RID: 2611
	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0x2E0")]
	public GameObjectRef fireBall;

	// Token: 0x04000A34 RID: 2612
	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0x2E8")]
	public GameObjectRef crateToDrop;

	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0x2F0")]
	public int maxCratesToSpawn;

	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0x2F4")]
	public float bulletSpeed;

	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x2F8")]
	public float bulletDamage;

	// Token: 0x04000A38 RID: 2616
	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0x300")]
	public GameObjectRef servergibs;

	// Token: 0x04000A39 RID: 2617
	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x308")]
	public GameObjectRef debrisFieldMarker;

	// Token: 0x04000A3A RID: 2618
	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x310")]
	public SoundDefinition rotorWashSoundDef;

	// Token: 0x04000A3B RID: 2619
	[Token(Token = "0x400085C")]
	[FieldOffset(Offset = "0x318")]
	private Sound _rotorWashSound;

	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x320")]
	public SoundDefinition flightEngineSoundDef;

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x400085E")]
	[FieldOffset(Offset = "0x328")]
	public SoundDefinition flightThwopsSoundDef;

	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0x330")]
	private Sound flightEngineSound;

	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000860")]
	[FieldOffset(Offset = "0x338")]
	private Sound flightThwopsSound;

	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x340")]
	private SoundModulation.Modulator flightEngineGainMod;

	// Token: 0x04000A41 RID: 2625
	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x348")]
	private SoundModulation.Modulator flightThwopsGainMod;

	// Token: 0x04000A42 RID: 2626
	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0x350")]
	public float rotorGainModSmoothing;

	// Token: 0x04000A43 RID: 2627
	[Token(Token = "0x4000864")]
	[FieldOffset(Offset = "0x354")]
	public float engineGainMin;

	// Token: 0x04000A44 RID: 2628
	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0x358")]
	public float engineGainMax;

	// Token: 0x04000A45 RID: 2629
	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x35C")]
	public float thwopGainMin;

	// Token: 0x04000A46 RID: 2630
	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x360")]
	public float thwopGainMax;

	// Token: 0x04000A47 RID: 2631
	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x364")]
	public float spotlightJitterAmount;

	// Token: 0x04000A48 RID: 2632
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x368")]
	public float spotlightJitterSpeed;

	// Token: 0x04000A49 RID: 2633
	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x370")]
	public GameObject[] nightLights;

	// Token: 0x04000A4A RID: 2634
	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x378")]
	public Vector3 spotlightTarget;

	// Token: 0x04000A4B RID: 2635
	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x384")]
	public float engineSpeed;

	// Token: 0x04000A4C RID: 2636
	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x388")]
	public float targetEngineSpeed;

	// Token: 0x04000A4D RID: 2637
	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x38C")]
	public float blur_rotationScale;

	// Token: 0x04000A4E RID: 2638
	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x390")]
	public ParticleSystem[] _rotorWashParticles;

	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x398")]
	private PatrolHelicopterAI myAI;

	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x3A0")]
	private Quaternion client_rotorPivotIdeal;

	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x3B0")]
	private bool nightLightsOn;

	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000AA2")]
	[Serializable]
	public class weakspot
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x326B60", Offset = "0x325960", VA = "0x180326B60")]
		public float HealthFraction()
		{
			return 0f;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x326A40", Offset = "0x325840", VA = "0x180326A40")]
		public void ClientHealthUpdate(float newHealth)
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x326B70", Offset = "0x325970", VA = "0x180326B70")]
		public weakspot()
		{
		}

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4003F12")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public BaseHelicopter body;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4003F13")]
		[FieldOffset(Offset = "0x18")]
		public string[] bonenames;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4003F14")]
		[FieldOffset(Offset = "0x20")]
		public float maxHealth;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4003F15")]
		[FieldOffset(Offset = "0x24")]
		public float health;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4003F16")]
		[FieldOffset(Offset = "0x28")]
		public float healthFractionOnDestroyed;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4003F17")]
		[FieldOffset(Offset = "0x30")]
		public GameObjectRef destroyedParticles;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4003F18")]
		[FieldOffset(Offset = "0x38")]
		public GameObjectRef damagedParticles;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4003F19")]
		[FieldOffset(Offset = "0x40")]
		public GameObject damagedEffect;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4003F1A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject destroyedEffect;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4003F1B")]
		[FieldOffset(Offset = "0x50")]
		public List<global::BasePlayer> attackers;
	}
}
