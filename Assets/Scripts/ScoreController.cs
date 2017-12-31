using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public GameObject txtScore;
    public static int totalScore = 0;
    Text text;


    private void Awake()
    {
        text = txtScore.GetComponent<Text>();
        totalScore = 0;
    }

    private void Update()
    {
        text.text = totalScore.ToString();
    }

    //void UpdateScore(float score)
    //{
    //    totalScore += (int)(score * 100f);

    //    Text tScore = txtScore.GetComponent<Text>();



    //    tScore.text = totalScore.ToString();

    //}
}
