using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text txtVida;
	public static int vida = 3;

	// Use this for initialization
	void Start () {
		vida = 3;
	}
	
	// Update is called once per frame
	void Update () {
		txtVida.text = vida.ToString ();
	}
}
