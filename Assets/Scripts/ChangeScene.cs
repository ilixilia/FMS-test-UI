using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

    public GameObject playWindow;

    // to go to another scene by its name
    public void ChangeToScene (string goToScene) {
        Application.LoadLevel(goToScene);
	}

   

}
