using UnityEngine;
using UnityEngine.U2D.Animation;

[CreateAssetMenu(fileName = "Player Stats", menuName = "Scriptable Objects/Player Stat", order = 1)]
public class PlayerStatsSO : ScriptableObject
{
    [Header("Main")]
    public int characterIndex;
    public Sprite[] portraits;
    public AnimationSO _animation;
    public DialogueSO _dialogue;
    public EffectsLibrarySO _effectsLibrary;
    public EffectsLibrarySO _particlesLibrary;
    public EffectsLibrarySO _projectilesLibrary;
    public CharacterTypeEnum characterName;
    [Header("Stats")]
    public int defenseLevel;
    public int arcanaLevel;
    public int speedLevel;
    public int jumpLevel;
    public int dashLevel;
    public bool canDoubleJump = true;
    public int arcanaRecharge = 1;
    [Header("Moves")]
    public AttackSO m2L;
    public AttackSO m5L;
    public AttackSO m2M;
    public AttackSO m5M;
    public AttackSO m2H;
    public AttackSO m5H;
    public AttackSO jL;
    public AttackSO jM;
    public AttackSO jH;
    public AttackSO mThrow;
    public AttackSO mParry;
    public AttackSO mRedFrenzy;
    public ArcanaSO m5Arcana;
    public ArcanaSO m2Arcana;
    public ArcanaSO jArcana;
    [HideInInspector] public int maxHealth = 10000;

    public int Arcana { get { return arcanaLevel * ARCANA_MULTIPLIER; } set { } }
    public float Defense { get { return (defenseLevel - 1) * 0.05f + 0.95f; } set { } }
    public DemonFloat SpeedWalk
    {
        get
        {
            return speedLevel switch
            {
                1 => (DemonFloat)0.45,
                2 => (DemonFloat)0.62,
                3 => (DemonFloat)0.75,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }
    public DemonFloat SpeedWalkBackwards
    {
        get
        {
            return speedLevel switch
            {
                1 => (DemonFloat)0.39,
                2 => (DemonFloat)0.58,
                3 => (DemonFloat)0.72,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }
    public DemonFloat SpeedRun
    {
        get
        {
            return speedLevel switch
            {
                1 => (DemonFloat)2.3,
                2 => (DemonFloat)2.7,
                3 => (DemonFloat)3.1,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }
    public DemonFloat JumpForce
    {
        get
        {
            return jumpLevel switch
            {
                1 => (DemonFloat)4.44,
                2 => (DemonFloat)4.6,
                3 => (DemonFloat)4.92,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }
    public DemonFloat DashForce
    {
        get
        {
            return dashLevel switch
            {
                1 => (DemonFloat)3.5,
                2 => (DemonFloat)3.7,
                3 => (DemonFloat)3.9,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }
    public DemonFloat DashBackForce
    {
        get
        {
            return dashLevel switch
            {
                1 => (DemonFloat)2.8,
                2 => (DemonFloat)3.0,
                3 => (DemonFloat)3.2,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }
    public DemonFloat DashAirForce
    {
        get
        {
            return dashLevel switch
            {
                1 => (DemonFloat)3.3,
                2 => (DemonFloat)3.5,
                3 => (DemonFloat)3.7,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }
    public DemonFloat DashBackAirForce
    {
        get
        {
            return dashLevel switch
            {
                1 => (DemonFloat)2.8,
                2 => (DemonFloat)3.0,
                3 => (DemonFloat)3.2,
                _ => (DemonFloat)0,
            };
        }
        set { }
    }

    public const int ARCANA_MULTIPLIER = 1000;
}
