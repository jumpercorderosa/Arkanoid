using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//enter ou clicar com 2 dedos na tela
		if(Input.GetKeyDown (KeyCode.Return) || Input.touchCount == 2) {
			SceneManager.LoadScene("game-scene");
		}

	}
}
