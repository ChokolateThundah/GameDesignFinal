﻿using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	// Use this for initialization
	public BaseWarriorClass(){
		ClassType = ClassTypes.WARRIOR;
		ClassDescription = "Strong Brave Knight";

		//Health Stats
		ClassHealth = new BaseHealth ();
		ClassHealth.StatBaseValue = 50;
		ClassHealth.StatModifiedValue = 0;
		ClassHealth.StatMaxValue = 100;

		//Defense Stats
		ClassDefense = new BaseDefense ();
		ClassDefense.StatBaseValue = 60;
		ClassDefense.StatModifiedValue = 0;
		ClassDefense.StatMaxValue = 100;

		//Attack Stats
		ClassAttack = new BaseAttack ();
		ClassAttack.StatBaseValue = 50;
	    ClassAttack.StatModifiedValue = 0;
		ClassAttack.StatMaxValue = 100;

		//Magic Stats
		ClassMagic = new BaseMagic ();
		ClassMagic.StatBaseValue = 25;
		ClassMagic.StatModifiedValue = 0;
		ClassMagic.StatMaxValue = 100;

		//Mana Stats
		ClassMana = new BaseMana ();
		ClassMana.StatBaseValue = 20;
		ClassMana.StatModifiedValue = 0;
		ClassMana.StatMaxValue = 100;

		//Stamina Stats
		ClassStamina = new BaseStamina (); 
		ClassStamina.StatBaseValue = 50;
		ClassStamina.StatModifiedValue = 0;
		ClassStamina.StatMaxValue = 100;

	}
}
