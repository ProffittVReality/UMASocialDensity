using UnityEngine;
using System.Collections;

public class Switcher3 : MonoBehaviour {
	public KeyCode method;
	public GameObject target;
	public GameObject target2;
	public bool dense = false;
	public bool sparse = false;

	void Awake() {
		//switcher = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (dense) {
			target.SetActive (true);
			target2.SetActive (false);
		} 
		else if (sparse){
			target2.SetActive (true);
			target.SetActive (false);
		}

	}
	void setDense(){
		dense = true;
	}
	void setSparse(){
		sparse = true;
	}
}
