
[System.Serializable]
public class BaseDefense : BaseStat {
	
	// Use this for initialization
	public BaseDefense(){
		
		StatName = "Defense";
		StatDescription = "The Defense value of a class";
		StatType = StatTypes.DEFENSE;
		StatBaseValue = 0;
		StatModifiedValue = 0;
		StatMaxValue = 0;
		
	}
}
