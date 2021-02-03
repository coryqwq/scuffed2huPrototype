using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameState : MonoBehaviour
{
    public GameObject passMsg;
    public GameObject passSound;

    public bool endLevel;
    public bool invoked;
    public bool scoreboardTransition = false;

    public float spawnIntervalOffset = 1;
    public float projectileSpeedOffset = 0;
    public float scoreMultiplier = 1;

    public float easyInterval = 2.0f;
    public float easySpeed = -3.0f;
    public float easyScoreMultiplier = 0.5f;

    public float mediumInterval = 1.0f;
    public float mediumSpeed = 0.0f;
    public float mediumScoreMultiplier = 1.0f;

    public float hardInterval = 0.5f;
    public float hardSpeed = 3.0f;
    public float hardScoreMultiplier = 2.0f;

    public float hardestInterval = 0.33f;
    public float hardestSpeed = 6.0f;
    public float hardestScoreMultiplier = 3.0f;

    public void SetEasyDifficulty()
    {
        PlayerPrefs.SetFloat("ModeSpawnInterval", easyInterval);
        PlayerPrefs.SetFloat("ModeScoreMultiplier", easyScoreMultiplier);
    }
    public void SetMediumDifficulty()
    {
        PlayerPrefs.SetFloat("ModeSpawnInterval", mediumInterval);
        PlayerPrefs.SetFloat("ModeScoreMultiplier", mediumScoreMultiplier);

    }
    public void SetHardDifficulty()
    {
        PlayerPrefs.SetFloat("ModeSpawnInterval", hardInterval);
        PlayerPrefs.SetFloat("ModeScoreMultiplier", hardScoreMultiplier);

    }
    public void SetHardestDifficulty()
    {
        PlayerPrefs.SetFloat("ModeSpawnInterval", hardestInterval);
        PlayerPrefs.SetFloat("ModeScoreMultiplier", hardestScoreMultiplier);

    }

    void Start()
    {
        spawnIntervalOffset = PlayerPrefs.GetFloat("ModeSpawnInterval", 0);
        scoreMultiplier = PlayerPrefs.GetFloat("ModeScoreMultiplier", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (endLevel == true && GameObject.FindWithTag("Player") != null && invoked == false)
        {
            StartCoroutine(LevelPassed());
            invoked = true;
        }
    }

    IEnumerator LevelPassed()
    {
        yield return new WaitForSeconds(5);
        Instantiate(passMsg, passMsg.transform.position, passMsg.transform.rotation);
        Instantiate(passSound, passMsg.transform.position, passMsg.transform.rotation);
        scoreboardTransition = true;

        yield return new WaitForSeconds(2);
        DontDestroyOnLoad(GameObject.Find("PreviousScene"));
        SceneManager.LoadScene("TitleScene 2");
    }
}
