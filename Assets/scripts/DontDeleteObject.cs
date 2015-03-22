using UnityEngine;
using System.Collections;

public class DontDeleteObject : MonoBehaviour {

	// object won't be destroyed
	void Awake() {
		DontDestroyOnLoad(gameObject);
	}
}
