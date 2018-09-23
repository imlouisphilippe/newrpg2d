using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterBase : MonoBehaviour
{
	// Status
	public string Name;
	public string Description;
	public string Race; // Vai vir de outro arquivo
	public float HealthNow;
	public float HealthMax;
	public float Speed;
	public float Experience;
	
	// Strategy
	public float AttackRate;
	public float DefenseRate;
	
	// Flags
	public bool Hostile;
	public bool Summonable;
	public bool Attackable;
	public float RunOnHealth;
	public float SpeedOnRun;
	public float LostTarget;
	public bool CanHealing;
	
	// AttackBase
	public float AttackInterval;
	public float AttackMin;
	public float AttackMax;
	public float CriticalRate;
	public float Chance;
	public float Range;
	public int Skill;
	
	/*
	Spells {
		Spells virao de outra classe;
	}
	*/

	// Healing
	public float HealthHealing;
	public float HealthHealingRate;
	public float HealingOnHealth;
	
	// Defense
	public float Armor;
	public float Defense;
	public float BlockChance;
	public float FirePercent;
	public float IcePercent;
	public float EarthPercent;
	public float HolyPercent;
	public float DeathPercent;
	public float ConfusionPercent;
	public float PyshicalPercent;
	public float DistancePercent;
	public float MagicPercent;
	public float EnergyPercent;
	
	// Immunity 
	public bool FireImmunity;
	public bool IceImmunity;
	public bool EarthImmunity;
	public bool HolyImmunity;
	public bool DeathImmunity;
	public bool ConfusionImmunity;
	public bool PhysicalImmunity;
	public bool DistanceImmunity;
	public bool MagicImmunity;
	public bool InvisibleImmunity;
	public bool EnergyImmunity;
	
	// Summons 
	public int SummonMax;
	public int SummonMonster; // Vai vir de outro arquivo 
	public float SummonInterval;
	public float SummonChance;
	
	// Loot 
	
	public int[,] Loot = new int[,]
	{
		{ /* Item ID */ 7741, /* CountMMax */ 5, /* ChanceDrop*/ 5000,}, 
		{ /* Item ID */ 7742, /* CountMMax */ 20, /* ChanceDrop*/ 2000,}, 
	};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
