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

		if(Input.GetButton("Fire2")) {
			ObjectPool.Instance.SpawnFromPool("prinnysword", transform.position, Quaternion.identity);
		}
			
	}
	
}
