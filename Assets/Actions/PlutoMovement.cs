using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlutoMovement : MonoBehaviour {

    private int movespeed, size;
    private double sizeMult;
    private float moveXDir, moveYDir;
    public GameObject BulletObject;
    public Transform BulletSpawn;

    public double frameCounter,bulletCounter;

	// Use this for initialization
	void Start () {
        movespeed = 5;
        size = 1;
        sizeMult = 1.0;
        frameCounter = 0;
        bulletCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        movePluto();

        frameCounter++;
        if(frameCounter==10)
        bulletCounter++;
        if(bulletCounter % 1 == 0)
        {
            shoot1();
        }
        if (bulletCounter % 2 == 0)
        {
            shoot2();
        }
        if (bulletCounter % 3 == 0)
        {
            shoot3();
        }
        if (bulletCounter % 4 == 0)
        {
            shoot4();
        }
        if (bulletCounter % 5 == 0)
        {
            shoot5();
        }
    }

    void movePluto()
    {
        moveXDir = Input.GetAxis("Vertical");
        moveYDir = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveXDir * movespeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveYDir * movespeed, gameObject.GetComponent<Rigidbody2D>().velocity.x);
    }

    void shoot1()
    {
        var Bullet1 = (GameObject)Instantiate(BulletObject, BulletSpawn.position, BulletSpawn.rotation);
        Bullet1.GetComponent<Rigidbody>().velocity = Bullet1.transform.up * 6;
        Destroy(Bullet1, 2.0f);
    }
    void shoot2()
    {
        var Bullet1 = (GameObject)Instantiate(BulletObject, BulletSpawn.position, BulletSpawn.rotation);
        Bullet1.GetComponent<Rigidbody>().velocity = Bullet1.transform.up * 6;
        Destroy(Bullet1, 2.0f);
    }
    void shoot3()
    {
        var Bullet1 = (GameObject)Instantiate(BulletObject, BulletSpawn.position, BulletSpawn.rotation);
        Bullet1.GetComponent<Rigidbody>().velocity = Bullet1.transform.up * 6;
        Destroy(Bullet1, 2.0f);
    }
    void shoot4()
    {
        var Bullet1 = (GameObject)Instantiate(BulletObject, BulletSpawn.position, BulletSpawn.rotation);
        Bullet1.GetComponent<Rigidbody>().velocity = Bullet1.transform.up * 6;
        Destroy(Bullet1, 2.0f);
    }
    void shoot5()
    {
        var Bullet1 = (GameObject)Instantiate(BulletObject, BulletSpawn.position, BulletSpawn.rotation);
        Bullet1.GetComponent<Rigidbody>().velocity = Bullet1.transform.up * 6;
        Destroy(Bullet1, 2.0f);
    }
}
