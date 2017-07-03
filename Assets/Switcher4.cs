using UnityEngine;
using System.Collections;

public class Switcher4 : MonoBehaviour {
	public KeyCode method;
	public GameObject target;
	public GameObject target2;
	//public bool switcher;


	void Awake() {
		//switcher = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(method))
			//Debug.Log("key was pressed");
			target.SetActive(true);
		if (target.active)
			target2.SetActive(false);
		


		//switcher = true;
		//if (switcher == true)

	}
}
