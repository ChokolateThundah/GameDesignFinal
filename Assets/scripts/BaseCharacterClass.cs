using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseCharacterClass : MonoBehaviour {

	private ClassTypes characterClassType;
	private string characterClassDescription;
	private BaseHealth health;
	private BaseDefense defense;
	private BaseAttack attack;
	private BaseMagic magic;
	private BaseMana mana;
	private BaseStamina stamina;

	public enum ClassTypes{
		WARRIOR,
		MAGE,
		ARCHER
	}

	public ClassTypes ClassType{
		get{ return characterClassType; }
		set{ characterClassType = value; }
	}

	public string ClassDescription{
		get{ return characterClassDescription; }
		set{ characterClassDescription = value; }
	}

	public BaseHealth ClassHealth{
		get{ return health; }
		set{ health = value; }
	}
	
	public BaseDefense ClassDefense{
		get{ return defense; }
		set{ defense = value; }
	}

	public BaseAttack ClassAttack{
		get{ return attack; }
		set{ attack = value; }
	}

	public BaseMagic ClassMagic{
		get{ return magic; }
		set{ magic = value; }
	}

	public BaseMana ClassMana{
		get{ return mana; }
		set{ mana = value; }
	}

	public BaseStamina ClassStamina{
		get{ return stamina; }
		set{ stamina = value; }
    }
}
