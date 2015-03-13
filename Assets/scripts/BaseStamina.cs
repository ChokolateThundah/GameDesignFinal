
[System.Serializable]
public class BaseStamina : BaseStat {
	
	// Use this for initialization
	public BaseStamina(){
		
		StatName = "Stamina";
		StatDescription = "Determines how often attacks can be carried out";
		StatType = StatTypes.STAMINA;
		StatBaseValue = 0;
		StatModifiedValue = 0;
		StatMaxValue = 0;
		
	}
}
