using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {


    public int moveSpeed;


    Rigidbody2D rb2d;

    Vector2 movement = Vector2.zero;

    bool moveToLeft = false;
    bool moveToRight = false;

    public float minX;
    public float maxX;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if(transform.position.x < minX)
        {
            moveToLeft = false;
        }

        if(transform.position.x > maxX)
        {
            moveToRight = false;
        }

        if(moveToLeft)
        {
            movement.x = (transform.right * Time.deltaTime * -moveSpeed).x;

            movement = movement + (Vector2)transform.position;


        } else if (moveToRight)
        {
            movement.x = (transform.right * Time.deltaTime * moveSpeed).x;

            movement = movement + (Vector2)transform.position;

//            rb2d.MovePosition(movement);
        }

        rb2d.MovePosition(movement);
    }


    public void MoveLeft ()
    {
        moveToRight = false;
        moveToLeft = true;
        


    }


    public void MoveRight ()
    {
        moveToLeft = false;
        moveToRight = true;
        
    }


    public void StopMove ()
    {
        moveToRight = false;
        moveToLeft = false;
    }
}
