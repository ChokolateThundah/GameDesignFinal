using UnityEngine;
using System.Collections;

public class BaseArcherClass : BaseCharacterClass {

	// Use this for initialization
	public BaseArcherClass(){
		ClassType = ClassTypes.ARCHER;
		ClassDescription = "Skilled Ranged Sharpshooter";

		//Health Stats
		ClassHealth = new BaseHealth ();
		ClassHealth.StatBaseValue = 100;
		ClassHealth.StatModifiedValue = 0;
		ClassHealth.StatMaxValue = 100;
		
		//Defense Stats
		ClassDefense = new BaseDefense ();
		ClassDefense.StatBaseValue = 45;
		ClassDefense.StatModifiedValue = 0;
		ClassDefense.StatMaxValue = 100;
		
		//Attack Stats
		ClassAttack = new BaseAttack ();
		ClassAttack.StatBaseValue = 35;
		ClassAttack.StatModifiedValue = 0;
		ClassAttack.StatMaxValue = 100;
		
		//Magic Stats
		ClassMagic = new BaseMagic ();
		ClassMagic.StatBaseValue = 35;
		ClassMagic.StatModifiedValue = 0;
		ClassMagic.StatMaxValue = 100;
		
		//Mana Stats
		ClassMana = new BaseMana ();
		ClassMana.StatBaseValue = 30;
		ClassMana.StatModifiedValue = 0;
		ClassMana.StatMaxValue = 100;
		
		//Stamina Stats
		ClassStamina = new BaseStamina (); 
		ClassStamina.StatBaseValue = 60;
		ClassStamina.StatModifiedValue = 0;
		ClassStamina.StatMaxValue = 100;
		
		
	}
}
