using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreResults : MonoBehaviour
{
    public Text score;
    public Text highScore;

    public int highScoreNumber;
    public int highScoreCount = 0;
    public int scoreNumber;
    public int scoreCount = 0;
    public int count = 10;
    public bool invoked1 = false;
    public bool invoked2 = false;

    // Start is called before the first frame update
    void Start()
    {
        PreviousScene previousSceneScript = GameObject.Find("PreviousScene").GetComponent<PreviousScene>();

        if (previousSceneScript.previousScene == "SampleScene")
        {
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl1", 0);
            scoreNumber = previousSceneScript.score;
        }

        if (previousSceneScript.previousScene == "SampleScene 1")
        {
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl2", 0);
            scoreNumber = previousSceneScript.score;
        }

        if (previousSceneScript.previousScene == "SampleScene 2")
        {
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl3", 0);
            scoreNumber = previousSceneScript.score;
        }

        if (previousSceneScript.previousScene == "SampleScene 3")
        {
            highScoreNumber = PlayerPrefs.GetInt("highscorelvl4", 0);
            scoreNumber = previousSceneScript.score;
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (invoked1 == false)
        {
            highScoreCount += count;
            highScore.text = "HI-SCORE:" + highScoreCount;

            if (highScoreCount > highScoreNumber - 60)
            {
                invoked1 = true;
            }

        }

        if (invoked1 == true)
        {
            if(highScoreCount < highScoreNumber)
            {
                highScoreCount += 1;
                highScore.text = "HI-SCORE:" + highScoreCount;
            }
        }

        if (invoked2 == false)
        {
            scoreCount += count;
            score.text = "SCORE:" + scoreCount;

            if (scoreCount > scoreNumber - 60)
            {
                invoked2 = true;
            }
        }

        if (invoked2 == true)
        {
            if (scoreCount < scoreNumber)
            {
                scoreCount += 1;
                score.text = "SCORE:" + scoreCount;
            }
        }
    }
}
