using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class usernamedisplay : MonoBehaviour {

	//cached references
	Login login;
	TextMeshProUGUI myTextMeshProUGUI;

	// Use this for initialization
	void Start () {
		login = FindObjectOfType<Login>();
		myTextMeshProUGUI = GetComponent<TextMeshProUGUI>().text;
		myTextMeshProUGUI = login.UsernameDisplay();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
