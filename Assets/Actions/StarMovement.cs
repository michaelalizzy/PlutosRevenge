using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMovement : MonoBehaviour {

    private int movespeed, size;
    

    // Use this for initialization
    void Start () {
        
        gameObject.GetComponent<Rigidbody2D>().position = new Vector2(Random.Range(-10.0f,10.0f),5f);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,-2.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if(gameObject.GetComponent<Rigidbody2D>().position.y<-5.32)
        {
            gameObject.GetComponent<Rigidbody2D>().position = new Vector2(Random.Range(-10.0f, 10.0f), 5f); ;
        }

    }
}
