using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
// using System.Configuration;
// using System.Data;
// using System.Data.Common;

public class Register : MonoBehaviour {
	[SerializeField] InputField username;
	[SerializeField] InputField email;
	[SerializeField] InputField password;
	[SerializeField] InputField confPassword;
	[SerializeField] Text notificationText;

    

    private string form;
	private bool EmailValid = false;
	private string[] Characters = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
								   "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
								   "1","2","3","4","5","6","7","8","9","0","_","-"};
	

	// Use this for initialization
	void Start () {
        // string provider = ConfigurationManager.AppSettings["provider"];
        // string connectionString = ConfigurationManager.AppSettings["connectionString"];
        // DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

        // using (DbConnection connection = factory.CreateConnection())
        // {
        //     if(connection == null)
        //     {
        //         Debug.LogError("Connection Error");
                
        //     }

        //     connection.ConnectionString = connectionString;
        //     connection.Open();
        //     DbCommand command = factory.CreateCommand();

        //     if(command == null)
        //     {
        //         Debug.LogError("Command Error");
        //     }

        //     command.Connection = connection;
        //     command.CommandText = "Select * From Table";
       
        // }
    }
	
	public void registerButton() {
		bool UN = false;
		bool EM = false;
		bool PW = false;
		bool CP = false;

		if(password.text != "" && email.text != "" && confPassword.text != "" && username.text != "") {
			notificationText.text = "Registration Sucessful";
			notificationText.color = Color.green;
		} else {
			notificationText.text = "Error: Please fill out all input fields!";
			notificationText.color = Color.red;
		}

		if(username.text != "") {
			if(!System.IO.File.Exists(@"/Users/"+Environment.UserName+"/Documents/NepWars/"+username.text+"/"+username.text+".txt")) {
				UN = true;

			} else {
			notificationText.text = "Error: Username already exists!";
			notificationText.color = Color.red;
			}
		} else {
			Debug.LogWarning("Username field empty!");
		}

		if(email.text != "") {
			EmailValidation();
			if(EmailValid) {
				if(email.text.Contains("@")) {
					if(email.text.Contains(".")) {
						EM = true;
					} else {
						notificationText.text = "Error: Email is invalid";
						notificationText.color = Color.red;
						Debug.LogWarning("Email doesn't contain a .");
					}
				} else {
					notificationText.text = "Error: Email is invalid";
					notificationText.color = Color.red;
					Debug.LogWarning("Email doesn't contain a @");
				}
			} else {
				notificationText.text = "Error: Email is invalid";
				notificationText.color = Color.red;
			}
		} else {
			Debug.LogWarning("Email field is empty.");
		}

		if(password.text != "") {
			if(password.text.Length > 5 && password.text.Length < 17) {
				PW = true;
			} else {
				notificationText.text = "Error: Password must be greater than 5 characters and less than 17 characters.";
				notificationText.color = Color.red;
			}
		} else {
			Debug.LogWarning("Password field is empty");
		}

		if(confPassword.text != "") {
			if(confPassword.text == password.text) {
				CP = true;
			} else {
				notificationText.text = "Error: Passwords don't match!";
				notificationText.color = Color.red;
			}
		} else {
			Debug.LogWarning("Confirm password field is empty.");
		}

		if(UN == true && EM == true && PW == true && CP == true) {
			bool Clear = true;
			int i = 1;

			foreach(char c in password.text) {
				if(Clear) {
					password.text = "";
					Clear = false;
				}
				i++;
				char Encrypted = (char) (c * i);
				password.text += Encrypted.ToString();
			}
			form = (username.text + Environment.NewLine + email.text + Environment.NewLine + password.text);
			System.IO.Directory.CreateDirectory(@"/Users/"+Environment.UserName+"/Documents/NepWars");
			System.IO.Directory.CreateDirectory(@"/Users/"+Environment.UserName+"/Documents/NepWars/"+username.text);
			System.IO.File.WriteAllText(@"/Users/"+Environment.UserName+"/Documents/NepWars/"+username.text+"/"+username.text+".txt", form);

			//clear all fields
			username.text = "";
			email.text = "";
			password.text = "";
			confPassword.text = "";

			print("Registration Complete");
		}
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)) {
			if(username.isFocused) {
				email.Select();
			}
			if(email.isFocused) {
				password.Select();
			}
			if(password.isFocused) {
				confPassword.Select();
			}
		}

		// if(Input.GetKeyDown(KeyCode.Return)) {
		// 	if(password.text != "" && email.text != "" && confPassword.text != "" && username.text != "") {
		// 		registerButton();
		// 	}
		// }
	}

	void EmailValidation() {
		bool SW = false;
		bool EW = false;

		for(int i = 0;i<Characters.Length;i++) {
			if(email.text.StartsWith(Characters[i])) {
				SW = true;
			}
		}
		for(int i = 0;i<Characters.Length;i++) {
			if(email.text.EndsWith(Characters[i])) {
				EW = true;
			}
		}
		if(SW == true && EW == true) {
			EmailValid = true;
		} else {
			EmailValid = false;
		}
	}
}
