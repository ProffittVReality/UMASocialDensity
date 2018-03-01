﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class Wander : MonoBehaviour
{
	public float speed = 0.5f;
	//public float directionChangeInterval = Random.Range(1,3);
	public float directionChangeInterval = 3;
	public float maxHeadingChange = 2000;

	CharacterController controller;
	float heading;
	Vector3 targetRotation;

	public Animator animator;

	void Awake()
	{
		controller = GetComponent<CharacterController> ();

		// Set random initial rotation
		heading = Random.Range (0, 360);
		transform.eulerAngles = new Vector3 (0, heading, 10);

		//Get animator component
		animator = gameObject.GetComponent<Animator>();

		StartCoroutine (NewHeading ());
	}

	void Update()
	{
		transform.eulerAngles = Vector3.Slerp (transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		var forward = transform.TransformDirection (Vector3.forward);
		controller.SimpleMove (forward * speed);
	}

	/// Repeatedly calculates a new direction to move towards.
	/// Use this instead of MonoBehaviour.InvokeRepeating so that the interval can be changed at runtime.

	IEnumerator NewHeading()
	{
		while (true)
		{
			NewHeadingRoutine ();
			yield return new WaitForSeconds (directionChangeInterval);
		}
	}

	/// Calculates a new direction to move towards.
	void NewHeadingRoutine()
	{
		var floor = Mathf.Clamp (heading - maxHeadingChange, 0, 360);
		var ceil = Mathf.Clamp (heading + maxHeadingChange, 0, 360);
		heading = Random.Range (floor, ceil);
		targetRotation = new Vector3 (0, heading, 0);
	}
}