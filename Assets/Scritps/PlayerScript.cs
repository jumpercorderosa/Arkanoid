using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public int vida;
	public float velocidade;

	void Mover() {

		//Mover
		//resposta instantanea GetAxisRaw
		float move_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		//float move_y = Input.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;
		//transform.Translate (move_x, move_y, 0.0f);
		transform.Translate (move_x, 0.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
		//print(vida);
		Mover();
	}
}
