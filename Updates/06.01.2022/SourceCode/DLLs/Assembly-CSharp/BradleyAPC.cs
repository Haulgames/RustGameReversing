using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Facepunch;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000117 RID: 279
[Token(Token = "0x20000A6")]
public class BradleyAPC : BaseCombatEntity
{
	// Token: 0x060010F9 RID: 4345 RVA: 0x0000A098 File Offset: 0x00008298
	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x469120", Offset = "0x467F20", VA = "0x180469120", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x468C20", Offset = "0x467A20", VA = "0x180468C20")]
	public void InitializeClientsideEffects()
	{
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x469570", Offset = "0x468370", VA = "0x180469570")]
	public void ShutdownClientsideEffects()
	{
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x469710", Offset = "0x468510", VA = "0x180469710")]
	public void UpdateSounds()
	{
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x4684C0", Offset = "0x4672C0", VA = "0x1804684C0")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_FireGun(global::BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x468140", Offset = "0x466F40", VA = "0x180468140")]
	public void AimWeaponAt(Transform weaponYaw, Transform weaponPitch, Vector3 direction, float minPitch = -360f, float maxPitch = 360f, float maxYaw = 360f, [Optional] Transform parentOverride)
	{
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x468D10", Offset = "0x467B10", VA = "0x180468D10")]
	public void LateUpdate()
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x469040", Offset = "0x467E40", VA = "0x180469040", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x468980", Offset = "0x467780", VA = "0x180468980", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x468A80", Offset = "0x467880", VA = "0x180468A80", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x46A380", Offset = "0x469180", VA = "0x18046A380")]
	public BradleyAPC()
	{
	}

	// Token: 0x04000B50 RID: 2896
	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x748A0", Offset = "0x73CA0")]
	public BlendedLoopEngineSound engineSound;

	// Token: 0x04000B51 RID: 2897
	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public SoundDefinition treadLoopDef;

	// Token: 0x04000B52 RID: 2898
	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public AnimationCurve treadGainCurve;

	// Token: 0x04000B53 RID: 2899
	[Token(Token = "0x4000901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public AnimationCurve treadPitchCurve;

	// Token: 0x04000B54 RID: 2900
	[Token(Token = "0x4000902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public AnimationCurve treadFreqCurve;

	// Token: 0x04000B55 RID: 2901
	[Token(Token = "0x4000903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private Sound treadLoop;

	// Token: 0x04000B56 RID: 2902
	[Token(Token = "0x4000904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private SoundModulation.Modulator treadGain;

	// Token: 0x04000B57 RID: 2903
	[Token(Token = "0x4000905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private SoundModulation.Modulator treadPitch;

	// Token: 0x04000B58 RID: 2904
	[Token(Token = "0x4000906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public SoundDefinition chasisLurchSoundDef;

	// Token: 0x04000B59 RID: 2905
	[Token(Token = "0x4000907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public float chasisLurchAngleDelta;

	// Token: 0x04000B5A RID: 2906
	[Token(Token = "0x4000908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	public float chasisLurchSpeedDelta;

	// Token: 0x04000B5B RID: 2907
	[Token(Token = "0x4000909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private float lastAngle;

	// Token: 0x04000B5C RID: 2908
	[Token(Token = "0x400090A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
	private float lastSpeed;

	// Token: 0x04000B5D RID: 2909
	[Token(Token = "0x400090B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public SoundDefinition turretTurnLoopDef;

	// Token: 0x04000B5E RID: 2910
	[Token(Token = "0x400090C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public float turretLoopGainSpeed;

	// Token: 0x04000B5F RID: 2911
	[Token(Token = "0x400090D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
	public float turretLoopPitchSpeed;

	// Token: 0x04000B60 RID: 2912
	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public float turretLoopMinAngleDelta;

	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x400090F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	public float turretLoopMaxAngleDelta;

	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x4000910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public float turretLoopPitchMin;

	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x4000911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
	public float turretLoopPitchMax;

	// Token: 0x04000B64 RID: 2916
	[Token(Token = "0x4000912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public float turretLoopGainThreshold;

	// Token: 0x04000B65 RID: 2917
	[Token(Token = "0x4000913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private Sound turretTurnLoop;

	// Token: 0x04000B66 RID: 2918
	[Token(Token = "0x4000914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private SoundModulation.Modulator turretTurnLoopGain;

	// Token: 0x04000B67 RID: 2919
	[Token(Token = "0x4000915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private SoundModulation.Modulator turretTurnLoopPitch;

	// Token: 0x04000B68 RID: 2920
	[Token(Token = "0x4000916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public float enginePitch;

	// Token: 0x04000B69 RID: 2921
	[Token(Token = "0x4000917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
	public float rpmMultiplier;

	// Token: 0x04000B6A RID: 2922
	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private TreadAnimator treadAnimator;

	// Token: 0x04000B6B RID: 2923
	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private float lastTurretAngle;

	// Token: 0x04000B6C RID: 2924
	[Token(Token = "0x400091A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8ECF0", Offset = "0x8E0F0")]
	public List<Vector3> currentPath;

	// Token: 0x04000B6D RID: 2925
	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public int currentPathIndex;

	// Token: 0x04000B6E RID: 2926
	[Token(Token = "0x400091C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
	public bool pathLooping;

	// Token: 0x04000B6F RID: 2927
	[Token(Token = "0x400091D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8ED70", Offset = "0x8E170")]
	public float viewDistance;

	// Token: 0x04000B70 RID: 2928
	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
	public float searchRange;

	// Token: 0x04000B71 RID: 2929
	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public float searchFrequency;

	// Token: 0x04000B72 RID: 2930
	[Token(Token = "0x4000920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
	public float memoryDuration;

	// Token: 0x04000B73 RID: 2931
	[Token(Token = "0x4000921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float sightUpdateRate;

	// Token: 0x04000B74 RID: 2932
	[Token(Token = "0x4000922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public List<global::BradleyAPC.TargetInfo> targetList;

	// Token: 0x04000B75 RID: 2933
	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8EEA0", Offset = "0x8E2A0")]
	public float coaxFireRate;

	// Token: 0x04000B76 RID: 2934
	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	public int coaxBurstLength;

	// Token: 0x04000B77 RID: 2935
	[Token(Token = "0x4000925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public float coaxAimCone;

	// Token: 0x04000B78 RID: 2936
	[Token(Token = "0x4000926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	public float bulletDamage;

	// Token: 0x04000B79 RID: 2937
	[Token(Token = "0x4000927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8EFF0", Offset = "0x8E3F0")]
	public float topTurretFireRate;

	// Token: 0x04000B7A RID: 2938
	[Token(Token = "0x4000928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public GameObjectRef gun_fire_effect;

	// Token: 0x04000B7B RID: 2939
	[Token(Token = "0x4000929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public GameObjectRef bulletEffect;

	// Token: 0x04000B7C RID: 2940
	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private float lastLateUpdate;

	// Token: 0x04000B7D RID: 2941
	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8F260", Offset = "0x8E660")]
	public WheelCollider[] leftWheels;

	// Token: 0x04000B7E RID: 2942
	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public WheelCollider[] rightWheels;

	// Token: 0x04000B7F RID: 2943
	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8F430", Offset = "0x8E830")]
	public float moveForceMax;

	// Token: 0x04000B80 RID: 2944
	[Token(Token = "0x400092E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
	public float brakeForce;

	// Token: 0x04000B81 RID: 2945
	[Token(Token = "0x400092F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public float turnForce;

	// Token: 0x04000B82 RID: 2946
	[Token(Token = "0x4000930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
	public float sideStiffnessMax;

	// Token: 0x04000B83 RID: 2947
	[Token(Token = "0x4000931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public float sideStiffnessMin;

	// Token: 0x04000B84 RID: 2948
	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public Transform centerOfMass;

	// Token: 0x04000B85 RID: 2949
	[Token(Token = "0x4000933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public float stoppingDist;

	// Token: 0x04000B86 RID: 2950
	[Token(Token = "0x4000934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8F4F0", Offset = "0x8E8F0")]
	public float throttle;

	// Token: 0x04000B87 RID: 2951
	[Token(Token = "0x4000935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public float turning;

	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
	public float rightThrottle;

	// Token: 0x04000B89 RID: 2953
	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public float leftThrottle;

	// Token: 0x04000B8A RID: 2954
	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
	public bool brake;

	// Token: 0x04000B8B RID: 2955
	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8F5B0", Offset = "0x8E9B0")]
	public Rigidbody myRigidBody;

	// Token: 0x04000B8C RID: 2956
	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public Collider myCollider;

	// Token: 0x04000B8D RID: 2957
	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public Vector3 destination;

	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
	private Vector3 finalDestination;

	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	public Transform followTest;

	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	public TriggerHurtEx impactDamager;

	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8F610", Offset = "0x8EA10")]
	public Transform mainTurretEyePos;

	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	public Transform mainTurret;

	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	public Transform CannonPitch;

	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	public Transform CannonMuzzle;

	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	public Transform coaxPitch;

	// Token: 0x04000B96 RID: 2966
	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	public Transform coaxMuzzle;

	// Token: 0x04000B97 RID: 2967
	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	public Transform topTurretEyePos;

	// Token: 0x04000B98 RID: 2968
	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	public Transform topTurretYaw;

	// Token: 0x04000B99 RID: 2969
	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	public Transform topTurretPitch;

	// Token: 0x04000B9A RID: 2970
	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public Transform topTurretMuzzle;

	// Token: 0x04000B9B RID: 2971
	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	private Vector3 turretAimVector;

	// Token: 0x04000B9C RID: 2972
	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
	private Vector3 desiredAimVector;

	// Token: 0x04000B9D RID: 2973
	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	private Vector3 topTurretAimVector;

	// Token: 0x04000B9E RID: 2974
	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
	private Vector3 desiredTopTurretAimVector;

	// Token: 0x04000B9F RID: 2975
	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x880D0", Offset = "0x874D0")]
	public GameObjectRef explosionEffect;

	// Token: 0x04000BA0 RID: 2976
	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
	public GameObjectRef servergibs;

	// Token: 0x04000BA1 RID: 2977
	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
	public GameObjectRef fireBall;

	// Token: 0x04000BA2 RID: 2978
	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
	public GameObjectRef crateToDrop;

	// Token: 0x04000BA3 RID: 2979
	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
	public GameObjectRef debrisFieldMarker;

	// Token: 0x04000BA4 RID: 2980
	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8F870", Offset = "0x8EC70")]
	public int maxCratesToSpawn;

	// Token: 0x04000BA5 RID: 2981
	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
	public int patrolPathIndex;

	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
	public BasePath patrolPath;

	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
	public bool DoAI;

	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
	public GameObjectRef mainCannonMuzzleFlash;

	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
	public GameObjectRef mainCannonProjectile;

	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
	public float recoilScale;

	// Token: 0x04000BAB RID: 2987
	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
	public NavMeshPath navMeshPath;

	// Token: 0x04000BAC RID: 2988
	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
	public int navMeshPathIndex;

	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000AA9")]
	[Serializable]
	public class TargetInfo : Pool.IPooled
	{
		// Token: 0x06001105 RID: 4357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public TargetInfo()
		{
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3C")]
		[Address(RVA = "0x470570", Offset = "0x46F370", VA = "0x180470570", Slot = "4")]
		public void EnterPool()
		{
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0x470A10", Offset = "0x46F810", VA = "0x180470A10")]
		public void Setup(global::BaseEntity ent, float time)
		{
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		public void LeavePool()
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x4705F0", Offset = "0x46F3F0", VA = "0x1804705F0")]
		public float GetPriorityScore(global::BradleyAPC apc)
		{
			return 0f;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x6004C40")]
		[Address(RVA = "0x470960", Offset = "0x46F760", VA = "0x180470960")]
		public bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x6004C41")]
		[Address(RVA = "0x470900", Offset = "0x46F700", VA = "0x180470900")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4003F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float damageReceivedFrom;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4003F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public global::BaseEntity entity;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4003F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float lastSeenTime;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4003F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 lastSeenPosition;
	}
}
