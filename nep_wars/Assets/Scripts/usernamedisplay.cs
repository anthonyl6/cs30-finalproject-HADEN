using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class usernamedisplay : MonoBehaviour {

	[SerializeField] TextMeshPro usernameText;

	//cached references
	Login login;
	void Start()
	{
		login = FindObjectOfType<Login>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		usernameText.text = login.UsernameDisplay();
	}
}
