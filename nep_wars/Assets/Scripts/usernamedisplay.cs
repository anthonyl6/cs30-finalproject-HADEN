using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class usernamedisplay : MonoBehaviour {

	//cached references
	Login login;
	TextMeshProUGUI usernameText;

	//variables
	public string UsernameText;
	
	void Start()
	{
		login = FindObjectOfType<Login>();
		
		usernameText = GetComponent<TextMeshProUGUI>();
		
		// usernameText.text = login.username.text;
	}
	
	// Update is called once per frame
	void Update() 
	{
		string temptest;
		// HAS TO BE login.UsernameDisplay()
		temptest = login.UsernameDisplay();
		Debug.Log(temptest);
		
	}
}
