using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootP2 : MonoBehaviour {


	ObjectPool objectPool;

	private void Start()
	{
		objectPool = ObjectPool.Instance;
	}

	void FixedUpdate () {

		if(Input.GetKeyDown(KeyCode.P)) {
			ObjectPool.Instance.SpawnFromPool("Cube", transform.position, Quaternion.identity);
		}
			
	}
	
}
