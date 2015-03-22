using UnityEngine;
using System.Collections;

public class ChooseClass : MonoBehaviour {
	
	private Player player;
	// Use this for initialization
	public void onClick () {
		
		GameObject playerObject = GameObject.FindWithTag ("Player");
		if (playerObject != null)
		{
			player = playerObject.GetComponent <Player>();
		}
		if (player == null)
		{
			Debug.Log ("Cannot find 'Player' script");
		}
		
		
		
		if (gameObject.tag == "Warrior") {
			
			player.playerClass = new BaseWarriorClass();
			
		} else if (gameObject.tag == "Archer") {
			
			player.playerClass = new BaseArcherClass();
			
			
		} else if (gameObject.tag == "Mage") {
			
			player.playerClass = new BaseMageClass();
			
		}
		
		player.health = player.playerClass.ClassHealth;
		player.defense = player.playerClass.ClassDefense;
		player.attack = player.playerClass.ClassAttack;
		player.magic = player.playerClass.ClassMagic;
		player.mana = player.playerClass.ClassMana;
		player.stamina = player.playerClass.ClassStamina;
		
		
	}
	
}

