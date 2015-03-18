using System.Collections;

[System.Serializable]
public class BaseStat {

	private string name; //name of stat
	private string description; //short description
	private float baseValue; //base stat value
	private float modifiedValue; //modifier ex. certain weps or pots
	private float maxValue; //max value
	private StatTypes type; //stat type

	public enum StatTypes{
		HEALTH,
		DEFENSE,
		ATTACK,
		MAGIC,    //Determines damage of spell attacks
		STAMINA, //Determines how often player can attack
		MANA    //Like Stamina, but for spells
	}

	public string StatName {

		get{ return name; }
		set{ name = value; }

	}

	public string StatDescription {
		
		get{ return description; }
		set{ description = value; }
		
	}

	public float StatBaseValue {
		
		get{ return baseValue; }
		set{ baseValue = value; }
		
	}

	public float StatModifiedValue {
		
		get{ return modifiedValue; }
		set{ modifiedValue = value; }
		
	}

	public float StatMaxValue {
		
		get{ return maxValue; }
		set{ maxValue = value; }
		
	}

	public StatTypes StatType {
		
		get{ return type; }
		set{ type = value; }
		
	}

}
