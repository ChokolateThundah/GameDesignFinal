using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Change to desired scene
	public void ChangeToScene (int sceneToChangeTo) {
		Application.LoadLevel(sceneToChangeTo);
	}
}
