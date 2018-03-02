using UnityEngine;
using System.Collections;

public class Switcher3 : MonoBehaviour {
	public KeyCode method;
	public GameObject target;
	public GameObject target2;
	public bool dense = false;
	public bool sparse = false;
	public GameObject cam;
	//public Text timer;
	private float timeLeft = 100.0f;

	void Awake() {
		//switcher = false;
		cam = GameObject.FindGameObjectWithTag("CameraRig");
	}
	
	// Update is called once per frame
	void Update () {
		print (timeLeft);
		/*if (Input.GetKeyDown(method))
			//Debug.Log("key was pressed");
			target.SetActive(true); 
		if (target.active)
			target2.SetActive(false);
			*/
		if (dense) {
			target.SetActive (true);
			target2.SetActive (false);
		} 
		else if (sparse){
			target2.SetActive (true);
			target.SetActive (false);
		}
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			//target.SetActive (false);
			//target2.SetActive (false);
			cam.SetActive (false);
		}
			//switcher = true;
		//if (switcher == true)
	}
	void setDense(){
		dense = true;
	}
	void setSparse(){
		sparse = true;
	}
}
