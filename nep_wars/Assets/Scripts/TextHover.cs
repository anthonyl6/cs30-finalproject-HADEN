using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHover : MonoBehaviour {



	void Start () {
		BoxCollider2D select = gameObject.GetComponent<BoxCollider2D>();
		Sprite multiplayer = Resources.Load("text_multiplayer", typeof(Sprite)) as Sprite;
		Sprite options = Resources.Load("text_options", typeof(Sprite)) as Sprite;
		Sprite exit = Resources.Load("text_exit", typeof(Sprite)) as Sprite;
	//---------
		Sprite multiplayerHover = Resources.Load("text_multiplayer_hover", typeof(Sprite)) as Sprite;
		Sprite optionsHover = Resources.Load("text_options_hover", typeof(Sprite)) as Sprite;
		Sprite exitHover = Resources.Load("text_exit_hover", typeof(Sprite)) as Sprite;
	}

	void OnMouseOver() {
		Debug.Log("ur over haha");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
