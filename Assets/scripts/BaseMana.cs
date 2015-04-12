
[System.Serializable]
public class BaseMana : BaseStat {
	
	// Use this for initialization
	public BaseMana(){
		
		StatName = "Mana";
		StatDescription = "Amount of magical power. How oftem spells can be cast";
		StatType = StatTypes.MANA;
		StatBaseValue = 0;
		StatModifiedValue = 0;
		StatMaxValue = 0;
		
	}
}
