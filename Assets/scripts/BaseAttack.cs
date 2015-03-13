
[System.Serializable]
public class BaseAttack : BaseStat {
	
	// Use this for initialization
	public BaseAttack(){
		
		StatName = "Attack";
		StatDescription = "Determines physical (non-magical) damage of a class";
		StatType = StatTypes.ATTACK;
		StatBaseValue = 0;
		StatModifiedValue = 0;
		StatMaxValue = 0;
		
	}
}
