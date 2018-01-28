using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlutoMovement : MonoBehaviour {

    private int movespeed, size;
    private double sizeMult;
    private float moveXDir, moveYDir;

    private int frameCounter;

	// Use this for initialization
	void Start () {
        movespeed = 5;
        size = 1;
        sizeMult = 1.0;
        frameCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        movePluto();
        frameCounter++;
	}

    void movePluto()
    {
        moveXDir = Input.GetAxis("Vertical");
        moveYDir = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveXDir * movespeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveYDir * movespeed, gameObject.GetComponent<Rigidbody2D>().velocity.x);
    }
}
