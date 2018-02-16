using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnTriggerEnter(Collider c) {
		SceneManager.LoadScene("intro-scene");
		//Destroy(c.gameObject);
	}
}
