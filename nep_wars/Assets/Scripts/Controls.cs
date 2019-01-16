using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {

	//https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
	//Edit -> Project Settings
	[SerializeField] Button Up;
	[SerializeField] Button Down;
	[SerializeField] Button Left;
	[SerializeField] Button Right;

	string UserInput;

	
	// Update is called once per frame
	void Update () 
	{
		Up.onClick.AddListener(ButtonUP);
		Down.onClick.AddListener(ButtonDown);
		Left.onClick.AddListener(ButtonLeft);
		Right.onClick.AddListener(ButtonRight);
	}

	void ButtonUP()
	{
		Debug.Log("Button Up Pressed");
		Input.GetAxis("Vertical");
	}

	void ButtonDown()
	{
		Debug.Log("Button Down Pressed");
		Input.GetAxis("Vertical");
		
	}

	void ButtonLeft()
	{
		Debug.Log("Button Left Pressed");
		Input.GetAxis("Horizontal");
	}

	void ButtonRight()
	{
		Debug.Log("Button Right Pressed");
		Input.GetAxis("Horizontal");
	}
}
