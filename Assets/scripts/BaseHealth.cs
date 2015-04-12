
[System.Serializable]
public class BaseHealth : BaseStat {

	// Use this for initialization
	public BaseHealth(){

		StatName = "Health";
		StatDescription = "The Health value of a class";
		StatType = StatTypes.HEALTH;
		StatBaseValue = 0;
		StatModifiedValue = 0;
		StatMaxValue = 0;
   }
}
