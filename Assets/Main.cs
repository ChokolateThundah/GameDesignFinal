using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {
	static Dictionary<string, GameObject> gameObjects = new Dictionary<string,GameObject>();
	static Player player;

	// Use this for initialization
	void Start () {

		// capture all current game objects.
		GameObject[] gameObjects = FindObjectsOfType<GameObject>();
		foreach (GameObject obj in gameObjects) {
			Main.gameObjects.Add(obj.name, obj);
		}

		// capture player object
		Player ply = FindObjectOfType<Player>();
		if (ply != null) {
			player = ply;
			Debug.Log("Found player object: " + ply.name);
		}
	}

	// Update is called once per frame
	void Update () {

	}

	public static void KillPlayer() {
		player.alive = false;
		Destroy(player.gameObject);
	}

	// can be used for healing or damage.
	public static void ChangeHealth(float amount) {
		player.health.StatBaseValue += amount;
		// do the healthbar effect
		GameObject healthBar = gameObjects["HealthBar"];
		Image bar = healthBar.GetComponent<Image>();
		bar.fillAmount = player.health.StatBaseValue / player.health.StatMaxValue;

		// determine is player should be killed
		if (player.health.StatBaseValue <= 0) {
			Debug.Log("Played dead.");
		}


	}

	public static void ChangeMana(float amount) {
		player.mana.StatBaseValue += amount;
		// do the healthbar effect
		GameObject healthBar = gameObjects["ManaBar"];
		Image bar = healthBar.GetComponent<Image>();
		bar.fillAmount = player.mana.StatBaseValue / player.mana.StatMaxValue;
	}

	public static void OnLightCrystalPickup(GameObject lightCrystal) {
		// play particle effect at light crystal
		// play sound
		// increase light crystal count

	}
}
