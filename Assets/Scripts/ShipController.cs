using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {


    public int moveSpeed;
    private Vector2 touchOrigin = -Vector2.one;


    Rigidbody2D rb2d;

    Vector2 movement = Vector2.zero;

    bool moveToLeft = false;
    bool moveToRight = false;

    public float minX;
    public float maxX;

    private float dist;
    private bool dragging = false;
    private Vector3 offset;
    private Transform toDrag;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {



        

        Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePoint.x >= minX && mousePoint.x <= maxX)
        {
            float curDirection = transform.localScale.x;

            float curX = transform.position.x;
            float newX = mousePoint.x;
            float dif = curX - newX;


            if (dif == 0)
            {
                transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
            }
            else if (dif > 0 && curDirection > 0)
            {
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }
            else if (dif < 0 )
            {
                transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
            }

            //rb2d.AddForce(new Vector2(mousePoint.x, transform.position.y), ForceMode2D.Force);



            transform.position = new Vector2(mousePoint.x, transform.position.y);
        }



        if (Input.touchCount != 1)
        {
            dragging = false;
            return;
        }

        Touch touch = Input.touches[0];

        if (touch.phase == TouchPhase.Moved)
        {
            Vector2 point = Camera.main.ScreenToWorldPoint(touch.position);
            if (point.x >= minX && point.x <= maxX)
            {
                transform.position = new Vector2(point.x, transform.position.y);
            }
        }


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
