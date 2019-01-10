using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class usernamedisplay : MonoBehaviour {

	//cached references
	Login login;
	TMP_Text myTextMeshProUGUI;

	// Use this for initialization
	void Start () {
		login = FindObjectOfType<Login>();
		myTextMeshProUGUI = GetComponent<TMP_Text>().text;
		myTextMeshProUGUI = login.UsernameDisplay();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
