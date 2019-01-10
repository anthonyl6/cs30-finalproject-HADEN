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

		if(Input.GetKeyDown(KeyCode.G)) {
			ObjectPool.Instance.SpawnFromPool("bullet_placeholder", transform.position, Quaternion.identity);
		}
			
	}
	
}
