using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public bool alive = true;

	/*
	 * These get instantiated when class is picked
	 * in GUI main menu. After GUI is set up, work on that.
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

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
