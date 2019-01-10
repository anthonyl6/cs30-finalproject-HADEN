using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	[SerializeField] float randomizer = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 Velocity = new Vector3(Random.Range(0f, randomizer), 0.0f);

		transform.Translate(Velocity * Time.deltaTime);
	}
}
