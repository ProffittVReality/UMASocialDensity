using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Switcher3 : MonoBehaviour {
	public KeyCode method;
	public GameObject target;
	public GameObject target2;
<<<<<<< HEAD
	public bool dense = false;
	public bool sparse = false;
	public bool start = false;
	public InputField timer;
	public float timeLeft;
	public GameObject blackBlock;
	public Color c;
	int count;
	void Awake() {
		//switcher = false;
		count = 0;
		c = blackBlock.GetComponent<Renderer> ().material.color;
=======
	//public bool switcher;


	void Awake() {
		//switcher = false;
>>>>>>> parent of 898e409... outdoor scene update
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		if (start) {
			if (count == 0) {
				timeLeft = float.Parse (timer.text) * 60.0f;
			}
			count = 1;
			if (dense) {
				target.SetActive (true);
				target2.SetActive (false);
			} 
			else if (sparse){
				target2.SetActive (true);
				target.SetActive (false);
			}

			timeLeft -= Time.deltaTime;
			if (timeLeft <= 5) {
				c.a += Mathf.Clamp01 (Time.deltaTime / 5);
				blackBlock.GetComponent<Renderer> ().material.color = c;
			}
			if (timeLeft <= 0) {
				target.SetActive (false);
				target2.SetActive (false);
			}
		}

	}
	void setDense(){
		dense = true;
	}
	void setSparse(){
		sparse = true;
=======
		if (Input.GetKeyDown(method))
			//Debug.Log("key was pressed");
			target.SetActive(true); 
		if (target.active)
			target2.SetActive(false);


			//switcher = true;
		//if (switcher == true)
			
>>>>>>> parent of 898e409... outdoor scene update
	}
	void exportStart(){
		start = true;
	}
}
