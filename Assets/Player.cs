using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public bool alive = true;

	/*
	 * These get instantiated when class is picked
	 * in GUI main menu.
	 * Hold class, skills and attributes
	 * including health, stamina, defense, etc
	*/
	public BaseCharacterClass playerClass;
	public BaseHealth health;
	public BaseDefense defense;
	public BaseAttack attack;
	public BaseMagic magic;
	public BaseMana mana;
	public BaseStamina stamina;


}
