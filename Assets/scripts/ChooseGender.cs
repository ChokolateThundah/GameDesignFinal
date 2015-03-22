using UnityEngine;
using System.Collections;

public class ChooseGender : MonoBehaviour {

	public GameObject playerGameObject;
	// Use this for initialization
	public void onClick () {
		if (gameObject.tag == "Male") {
			
			//male code
			Instantiate(playerGameObject, playerGameObject.transform.position, playerGameObject.transform.rotation);

			//TODO code for changing sprite
			
		} else if(gameObject.tag == "Female"){
			
			//female code
			Instantiate(playerGameObject, playerGameObject.transform.position, playerGameObject.transform.rotation);

			//TODO code for changing sprite
			
		}
	}

}
