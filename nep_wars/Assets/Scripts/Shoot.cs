using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {


	ObjectPool objectPool;
	public float speed = 5f;


	private void Start()
	{
		objectPool = ObjectPool.Instance;
		
	}

	void FixedUpdate () {

		if(Input.GetButton("Fire1")) {

			GameObject player = GameObject.FindGameObjectWithTag("Player");

			var shell = ObjectPool.Instance.SpawnFromPool("bullet", transform.position, Quaternion.identity);

			Vector3 moveDir = (player.transform.position - transform.position).normalized;

			transform.position += moveDir * speed * Time.deltaTime;

		}
			
	}
	
}
