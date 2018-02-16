using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

	int count_blocks = 0;
	public float velocidade;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().mass = 7;
		GetComponent<Rigidbody2D>().gravityScale = 0.0003f;
		GetComponent<Rigidbody2D>().velocity = Vector2.down * velocidade;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//how to get the ball to bounce off the paddles at an angle

	float hitFactor(Vector2 ballPos, Vector2 playerPos, float playerWidht) {

		// ascii art:
		// ||  1 <- at the dir side of the player
		// ||
		// ||  0 <- at the middle of the player
		// ||
		// || -1 <- at the left side of the player

		return (ballPos.x - playerPos.x) / playerWidht;
	}

	void OnCollisionEnter2D(Collision2D c) {

		print("TAG [" + gameObject.tag + "]");
		print("C_TAG [" + c.gameObject.tag + "]");
		print("C_NAME [" + c.gameObject.name + "]");

		if (c.gameObject.tag == "Player" || 
			c.gameObject.name == "left_wall" ||
			c.gameObject.name == "right_wall") {

			float x = hitFactor(transform.position, c.transform.position, c.collider.bounds.size.x);

			//Calculate direction, make wight=1 via .normalized
			//                       (x, y)
			Vector2 dir = new Vector2(x, 1).normalized;
		
			//Set velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * (velocidade * 1.2f);
		}

		/*
		if (c.gameObject.name == "left_wall" || c.gameObject.name == "right_wall") {

			float y = hitFactorY (transform.position, c.transform.position, c.collider.bounds.size.y);

			//Calculate direction, make wight=1 via .normalized
			//                       (x, y)
			Vector2 dir = new Vector2(1, y).normalized;

			//Set velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * velocidade;
		}
		*/
			

		if (c.gameObject.tag == "Block") {

			count_blocks++;

			print ("COUNT [" + count_blocks +"]");

			if (count_blocks == 50) {
				SceneManager.LoadScene("intro-scene");
			}

			GetComponent<Rigidbody2D>().velocity = Vector2.down * velocidade;
		}

		if (c.gameObject.name == "ceiling") {
			GetComponent<Rigidbody2D>().velocity = Vector2.down * velocidade;
		}
			
	}
		
	void OnTriggerEnter2D(Collider2D c) {

		if (c.gameObject.name == "floor") {

			ScoreScript.vida--;

			if (ScoreScript.vida == 0) {
				SceneManager.LoadScene ("intro-scene");
			} else {
				transform.position = new Vector2(transform.position.x, transform.position.y);
			}
		}
	}

}
