using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text score;

    public float time = 0.0f;
    public static int number = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (GameObject.Find("PlayerImage") != null)
        {
            /*
            time += Time.deltaTime;
            score.text = "TIME:" + time;
            */

            score.text = "SCORE:" + number;

        }
    }
}
