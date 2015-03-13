
[System.Serializable]
public class BaseMagic : BaseStat {
	
	// Use this for initialization
	public BaseMagic(){
		
		StatName = "Magic";
		StatDescription = "Determines damage of spells";
		StatType = StatTypes.MAGIC;
		StatBaseValue = 0;
		StatModifiedValue = 0;
		StatMaxValue = 0;
		
	}
}
