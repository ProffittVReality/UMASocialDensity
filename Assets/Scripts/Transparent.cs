using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour {
	public GameObject[] UserBlock; //boundary blocks around user

	void Start () {
		UserBlock = GameObject.FindGameObjectsWithTag ("UserBlock");
		foreach (GameObject block in UserBlock) {
			block.GetComponent<Renderer>().material.color= 
				new Color(1.0f,1.0f, 1.0f,1.0f);
		}


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
