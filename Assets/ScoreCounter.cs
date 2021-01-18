using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text highScore;
    public Text score;


    public int highScoreNumber = 0;
    public int scoreNumber = 0;

    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
       //highScore.text = "HI-SCORE:" + PlayerPrefs.GetInt("HI", 0);
    }

    void Update()
    {
        if(GameObject.Find("Player") != null)
        {
            time += Time.deltaTime;
            highScore.text = "TIME:" + time;
        }
       
        score.text = "SCORE:" + scoreNumber;

        /*
        if (scoreNumber >= highScoreNumber)
        {
            highScoreNumber = scoreNumber;
            highScore.text = "HI-SCORE:" + highScoreNumber;
        }
        
        if(GameObject.Find("Player") == null)
        {
            PlayerPrefs.SetInt("HI", highScoreNumber);
            PlayerPrefs.Save();
        }
        */
      
    }
}
