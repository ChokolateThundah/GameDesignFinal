using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	// Use this for initialization
	public BaseMageClass(){
		ClassType = ClassTypes.MAGE;
		ClassDescription = "Wise Powerful Wizard";

		//Health Stats
		ClassHealth = new BaseHealth ();
		ClassHealth.StatBaseValue = 100;
		ClassHealth.StatModifiedValue = 0;
		ClassHealth.StatMaxValue = 100;
		
		//Defense Stats
		ClassDefense = new BaseDefense ();
		ClassDefense.StatBaseValue = 30;
		ClassDefense.StatModifiedValue = 0;
		ClassDefense.StatMaxValue = 100;
		
		//Attack Stats
		ClassAttack = new BaseAttack ();
		ClassAttack.StatBaseValue = 25;
		ClassAttack.StatModifiedValue = 0;
		ClassAttack.StatMaxValue = 100;
		
		//Magic Stats
		ClassMagic = new BaseMagic ();
		ClassMagic.StatBaseValue = 60;
		ClassMagic.StatModifiedValue = 0;
		ClassMagic.StatMaxValue = 100;
		
		//Mana Stats
		ClassMana = new BaseMana ();
		ClassMana.StatBaseValue = 50;
		ClassMana.StatModifiedValue = 0;
		ClassMana.StatMaxValue = 100;
		
		//Stamina Stats
		ClassStamina = new BaseStamina (); 
		ClassStamina.StatBaseValue = 20;
		ClassStamina.StatModifiedValue = 0;
		ClassStamina.StatMaxValue = 100;
		
		
		
	}
}
