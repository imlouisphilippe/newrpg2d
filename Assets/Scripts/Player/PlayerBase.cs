using System.Collections;
using System.Collections.Generic;
using Core.Player;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
	/* Status */
	public Stats Stats { get; set; }

	#region Skills
	/* Apprentice, Warrior, Hunter, Pantomath */
	/* Druid, Arcanist, Necromancer*/
	/* Knight, Berserker, Paladin*/
	/* Ranger, Thief, Trapper */
	/* Celestial */
	
	public Skill MagicLevel { get; set; }
	public Skill OneHanded { get; set; }
	public Skill TwoHanded { get; set; }
	public Skill AxeFighting { get; set; }
	public Skill SwordFighting { get; set; }
	public Skill ClubFighting { get; set; }
	public Skill DistanceFighting { get; set; }
	public Skill FistFighting { get; set; }
	public Skill Shielding { get; set; }
	public Skill Fishing { get; set; }
	public Skill FarmLevel { get; set; }
	public Skill CraftLevel { get; set; }
	#endregion
	
	/* Promote */
	public Vocation Vocation { get; set; }
	public Flag isPromotion { get; set; }
	public Vocation Promotion { get; set; }

	/* TownCitizen */
	public Town Town { get; set; }
	
	/* Position */
	public Position Position { get; set; }

	/* Inventory */
	public Slot Head { get; set; }
	public Slot Chest { get; set; }
	public Slot Leg { get; set; }
	public Slot Feet { get; set; }
	public Slot Neck { get; set; }
	public Slot Ring { get; set; }
	public Slot Weapon { get; set; }
	public Slot Shield { get; set; }
	public Slot Ammunition { get; set; }
	public Slot Slot1 { get; set; }
	public Slot Slot2 { get; set; }
	public Slot Slot3 { get; set; }
	public Slot Slot4 { get; set; }
	public Slot Slot5 { get; set; }
	public Slot Slot6 { get; set; }

	/* Others */
	private Rigidbody2D Rb2d;


	// Use this for initialization
	private void Start()
	{
		Rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	private void Update()
	{
	}

	private void FixedUpdate()
	{
		Movement();
	}
	
	// Movement
	private void Movement()
	{
		float MoveX = Input.GetAxis("Horizontal");
		float MoveY = Input.GetAxis("Vertical");
		Rb2d.velocity = new Vector3(MoveX * this.Stats.Speed/10, MoveY * this.Stats.Speed/10, 0);

	}
}