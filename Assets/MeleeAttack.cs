using UnityEngine;
using System.Collections;

public class MeleeAttack : MonoBehaviour {
	// if = 0, single burst.
	public float fireRate = 100f;
	public float Damage = 10;

	// Stores the layers to hit
	public LayerMask ToHit;

	private float timeToFire = 0;
	Transform firePoint;


	// Use this for initialization
	void Start () {
		firePoint = transform.FindChild ("FirePoint");
		fireRate = 100f;
		if (firePoint == null) {
			Debug.Log ("Firepoint not found.");
		}

	}


	
	// Update is called once per frame
	// Handle the stuff for the fire rate.
	void Update () {
		// if (fireRate != 0) {
		if (Input.GetKeyDown(KeyCode.Y)
		    || Input.GetButtonDown("Jump")
		    && Time.time > timeToFire
		    ) { 
			{
				timeToFire = Time.time + 1/fireRate;
				// Debug.Log ("Swing: " + timeToFire + " time=" + Time.time + " fireRate= " + fireRate);
				Swing();
			}
		}
		// }
	}

	void Swing() {
		Debug.Log ("Swinging");
	}
}
