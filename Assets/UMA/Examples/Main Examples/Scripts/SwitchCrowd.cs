using UnityEngine;
using System.Collections;


public class SwitchCrowd : MonoBehaviour 
{
	//public GameObject target;
	public bool switcher;
	float timeLeft = 30.0f;

	void Awake() {
		switcher = false;
	}
	// Update is called once per frame
	void Update () 
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			switcher = true;
		}
		//if (Input.GetKeyDown (KeyCode.Space) == true)
			//switcher = true;

		if (switcher == true)
			
			gameObject.SetActive(false);
}
}