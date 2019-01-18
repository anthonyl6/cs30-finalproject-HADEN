using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, iPooledObject {

	public float upForce = 1f;
	public float sideForce = .1f;
	// Use this for initialization
	public void OnObjectSpawn () {
		
		float xForce = Random.Range(-sideForce, sideForce);
		float yForce = Random.Range(upForce / 2f, upForce);

		Vector3 force = new Vector3(xForce, yForce);

		GetComponent<Rigidbody2D>().velocity = force;


	}
	
}
