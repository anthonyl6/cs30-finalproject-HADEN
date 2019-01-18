using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectP1 : MonoBehaviour {

	//cached references
	[SerializeField] GameObject Chicken;
	[SerializeField] GameObject Penguin;

	SelectP2 player2;

	//variabled
	int readyCheckP1;

	void Start()
	{
		player2 = FindObjectOfType<SelectP2>();
	}

	// Update is called once per frame
	void Update () {
		SelectCharacter();
	}

	private void SelectCharacter()
	{
		if(Input.GetAxis("Horizontal1") < 0)
		{
			GetComponent<Transform>().position = new Vector3(Chicken.transform.position.x, Chicken.transform.position.y, Chicken.transform.position.z - 1);
		}
		if(Input.GetAxis("Horizontal1") > 0)
		{
			GetComponent<Transform>().position = new Vector3(Penguin.transform.position.x, Penguin.transform.position.y, Chicken.transform.position.z - 1);
		}
		if(Input.GetAxis("Fire1") > 0)
		{
			readyCheckP1 = 1;
			Ready();
		}
	}

	private void Ready()
	{
		while(readyCheckP1 == 1)
		{
			if(Input.GetAxis("Boost1") > 0)
			{
				readyCheckP1 = 0;
			}
		}
	}

	
}
