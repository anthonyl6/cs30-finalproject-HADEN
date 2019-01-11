using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;

public class Login : MonoBehaviour {
	[SerializeField] public InputField username;
	[SerializeField] InputField password;
	[SerializeField] Text notificationText;
	[SerializeField] GameObject loadingPanel;
	[SerializeField] GameObject loadingText;
	private String[] Lines;
	private string DecryptedPass;

	//cached references
	usernamedisplay usernameTest;
	public string usernameTemp;
	string test;
	

	// Use this for initialization
	void Start () {
		usernameTest = FindObjectOfType<usernamedisplay>();
		test = "Hello Working";
		
	}
	
	public void loginButton() {
		bool UN = false;
		bool PW = false;

		if(password.text != "" && username.text != "") {
			Debug.Log("Fields are not empty");
		} else {
			Debug.LogWarning("Login fields empty.");
			notificationText.text = "Error: Login fields are empty";
			notificationText.color = Color.red;
		}

		if(username.text != "") {
			if(System.IO.File.Exists(@"/Users/"+Environment.UserName+"/Documents/NepWars/"+username.text+"/"+username.text+".txt")) {
				UN = true;
				Lines = System.IO.File.ReadAllLines(@"/Users/"+Environment.UserName+"/Documents/NepWars/"+username.text+"/"+username.text+".txt");

			} else {
				Debug.LogWarning("Username invalid");
				notificationText.text = "Error: Username invalid! Please register!";
				notificationText.color = Color.red;
			}
		} else {
			Debug.LogWarning("Username Field empty");
			notificationText.text = "Error: The username field is empty!";
			notificationText.color = Color.red;
		}
		
		if(password.text != "") {
			if(System.IO.File.Exists(@"/Users/"+Environment.UserName+"/Documents/NepWars/"+username.text+"/"+username.text+".txt")) {
				int i = 1;
				foreach(char c in Lines[2]) {
					i++;
					char Decrypted = (char) (c / i);
					DecryptedPass += Decrypted.ToString();
				}
				if(password.text == DecryptedPass) {
					PW = true;
				} else {
					Debug.LogWarning("Password/Username is invalid");
					notificationText.text = "Error: Password/Username is invalid!";
					notificationText.color = Color.red;
					DecryptedPass = "";
				}
			} else {
				Debug.LogWarning("Password/Username is invalid");
				notificationText.text = "Error: Password/Username is invalid!";
				notificationText.color = Color.red;
				DecryptedPass = "";
			}
		} else {
			Debug.LogWarning("Password field is empty");
			notificationText.text = "Error: Password field is empty!";
			notificationText.color = Color.red;
		}
		if(UN == true && PW == true) {
			
		
			Debug.Log("Login successful");
			notificationText.text = "Login successful!";
			notificationText.color = Color.green;

			loadingPanel.SetActive(true);
			loadingText.SetActive(true);

			usernameTemp = username.text;
			

			UsernameDisplay();


			StartCoroutine(wait());
		}
	}

	public IEnumerator wait() {
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene("Title Screen");
	}

	public string UsernameDisplay()
	{
		Debug.Log("Username function ran");
		Debug.Log(usernameTemp);
		test = "temp user";
		Debug.Log(test);
		return test;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)) {
			if(username.isFocused) {
				password.Select();
			}
		}
	}
}
