using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour {

    BoxCollider2D bc2d;
    bool passCheck = false;
    private int scoreValue = 100;
    //public GameObject parent;

    private void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (transform.position.y >= 0.75 && passCheck == false)
        {
            bc2d.isTrigger = false;
            passCheck = true;
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Hit something");
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Owned")
        {
            //Destroy(gameObject);

            GameObject ship = GameObject.FindGameObjectWithTag("Player");
            transform.tag = "Owned";
            transform.parent = ship.transform;

            //ScoreController.totalScore += scoreValue;

        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Water" && passCheck)
        {
            Destroy(gameObject);

            //Debug.Log("Hit player");
        }
    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    Debug.Log(collision);

    //    if(collision.gameObject.tag == "Player")
    //    {
    //        bc2d.isTrigger = false;
    //        passCheck = true;
    //    }
    //}
}
