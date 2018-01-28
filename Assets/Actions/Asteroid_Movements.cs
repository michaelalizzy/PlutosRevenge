using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Movements : MonoBehaviour {

	private int asteroidSpeed; private int damage;


	// Use this for initialization
	void Start () {

		asteroidSpeed = 10;
		damage = 12;

	}

	// Update is called once per frame
	void Update () {

		moveAsteroid ();

	}

	void moveAsteroid () {

		gameObject.GetComponent<Rigidbody2D> ().velocity =
			new Vector2 (0, -asteroidSpeed);

	}

	void onCollisionEnter2D(Collision2D col) {

		Debug.Log ("Player has collided with " + col.collider.name);
	
	}

}
