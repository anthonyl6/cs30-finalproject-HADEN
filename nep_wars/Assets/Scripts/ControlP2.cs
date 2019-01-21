using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlP2 : MonoBehaviour {

	float speed = 5.0f;



	// Update is called once per frame
	void Update () {
		var move = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);

		var movement = transform.position += move * speed * Time.deltaTime;

		if(Input.GetButton("Boost2")) {
			speed = 10f;
		} else {
			speed = 5f;
		}

	}
}
