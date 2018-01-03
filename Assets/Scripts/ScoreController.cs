using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public GameObject txtScore;
    public static int totalScore = 0;
    Text text;

    Color oldColor;
    SpriteRenderer renderer; //Get the renderer via GetComponent or have it cached previously
                


    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        oldColor = renderer.color;
    }

    private void Awake()
    {
        text = txtScore.GetComponent<Text>();
        totalScore = 0;
    }

    private void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {

            Vector2 mousePosition  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hitCollider  = Physics2D.OverlapPoint(mousePosition);

            if (hitCollider.tag == "Box")
            {
                Debug.Log("send update");


                



                renderer.color = new Color(0f, 0f, 0f, 1f); // Set to opaque black
                
            }

                
        }

        if(Input.GetMouseButtonUp(0))
        {
            renderer.color = oldColor; // Set to opaque black
        }

        //text.text = totalScore.ToString();
    }


    public void SendFish()
    {
        int gg = 1;
        gg += 1;
        Debug.Log("send");
    }

}
