using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {
 
	public GameObject Explosion; // this is my explosion prefab

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}
		
	void OnCollisionEnter2D(Collision2D c) {

		if (c.gameObject.tag == "Ball") {

			PlayExplosion (gameObject.name);
			//Instantiate(explosion, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}

	//function to instantiate the explosion
	void PlayExplosion(string object_name) {
		
		GameObject explosion;
		explosion = (GameObject)Instantiate(Explosion);

		//set the position of the explosion
		explosion.transform.position = transform.position;

	}


}
