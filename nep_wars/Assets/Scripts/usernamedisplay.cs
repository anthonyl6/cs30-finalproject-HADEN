using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Text.RegularExpressions;
using TMPro;

public class usernamedisplay : MonoBehaviour {
	
	TextMeshProUGUI text;
	void Start()
	{
		text = GetComponent<TextMeshProUGUI>();
		readFile();
	}

	private void readFile()
	{
		string path = @"/Users/"+Environment.UserName+"/Documents/NepWars/usernamedump.txt";

		StreamReader reader = new StreamReader(path);
		text.text = reader.ReadLine();
		reader.Close();
	}
	
}
