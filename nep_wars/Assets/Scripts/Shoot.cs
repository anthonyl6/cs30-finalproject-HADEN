using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {


	ObjectPool objectPool;

	private void Start()
	{
		objectPool = ObjectPool.Instance;
	}

	void FixedUpdate () {

		if(Input.GetButton("Fire1")) {
			ObjectPool.Instance.SpawnFromPool("bullet", GameObject.Find("Player").transform.position, Quaternion.identity);
		}
			
	}
	
}
