using UnityEngine;
using System.Collections;

public class SwitchCrowd : MonoBehaviour 
{

	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("space"))

		Destroy(this.gameObject);

	}
}
