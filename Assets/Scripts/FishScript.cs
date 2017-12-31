using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour {

    BoxCollider2D bc2d;
    bool passCheck = false;
    private int scoreValue = 100;

    private void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if(transform.position.y >= 0.75 && passCheck == false)
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
        Debug.Log("Hit something");
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            ScoreController.totalScore += scoreValue;

            Debug.Log("Hit player");
        }
    }
}
