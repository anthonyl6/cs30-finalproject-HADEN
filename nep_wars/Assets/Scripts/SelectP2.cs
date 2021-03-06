﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectP2 : MonoBehaviour {

	//cached references
	[SerializeField] GameObject Chicken;
	[SerializeField] GameObject Penguin;


	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal2") < 0)
		{
			GetComponent<Transform>().position = new Vector3(Chicken.transform.position.x, Chicken.transform.position.y, Chicken.transform.position.z - 1);
		}
		if(Input.GetAxis("Horizontal2") > 0)
		{
			GetComponent<Transform>().position = new Vector3(Penguin.transform.position.x, Penguin.transform.position.y, Chicken.transform.position.z - 1);
		}
	}
}
