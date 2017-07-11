using UnityEngine;
using System.Collections;

public class RemoveGUI : MonoBehaviour {
	public KeyCode method;
	public GameObject target;
	//public bool switcher;


	void Awake() {
		//switcher = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(method))
			//Debug.Log("key was pressed");
			target.SetActive(false); 


		//switcher = true;
		//if (switcher == true)

	}
}
