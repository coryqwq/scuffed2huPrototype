using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public Text highScore;
    public Text score;


    public int highScoreNumber = 0;
    public int scoreNumber = 0;

    //public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            //get the key value and display the high score
            highScore.text = "HI-SCORE:" + PlayerPrefs.GetInt("highscorelvl1", 0);
            //get the key value and assign to variable for high score
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl1", 0);
        }

        if (SceneManager.GetActiveScene().name == "SampleScene 1")
        {
            highScore.text = "HI-SCORE:" + PlayerPrefs.GetInt("highscorelvl2", 0);
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl2", 0);
        }

        if (SceneManager.GetActiveScene().name == "SampleScene 2")
        {
            highScore.text = "HI-SCORE:" + PlayerPrefs.GetInt("highscorelvl3", 0);
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl3", 0);
        }

        if (SceneManager.GetActiveScene().name == "SampleScene 3")
        {
            highScore.text = "HI-SCORE:" + PlayerPrefs.GetInt("highscorelvl4", 0);
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl4", 0);
        }
    }

    void Update()
    {
        GameState gameStateScript = GameObject.Find("GameState").GetComponent<GameState>();

        //display the current score
        score.text = "SCORE:" + scoreNumber;

        //update the high score and display it
        if (scoreNumber > highScoreNumber)
        {
            highScoreNumber = scoreNumber;
            highScore.text = "HI-SCORE:" + highScoreNumber;
        }

        //if player dies, set the key value, and save it
        if (GameObject.Find("Player") == null || gameStateScript.endLevel == true)
        {
            PreviousScene previousSceneScript = GameObject.Find("PreviousScene").GetComponent<PreviousScene>();
            previousSceneScript.score = scoreNumber;

            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                PlayerPrefs.SetInt("highscorelvl1", highScoreNumber);
            }

            if (SceneManager.GetActiveScene().name == "SampleScene 1")
            {
                PlayerPrefs.SetInt("highscorelvl2", highScoreNumber);
            }

            if (SceneManager.GetActiveScene().name == "SampleScene 2")
            {
                PlayerPrefs.SetInt("highscorelvl3", highScoreNumber);
            }

            if (SceneManager.GetActiveScene().name == "SampleScene 3")
            {
                PlayerPrefs.SetInt("highscorelvl4", highScoreNumber);
            }
        }
    }
}
