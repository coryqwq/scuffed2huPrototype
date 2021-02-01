using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    private int instance = 0;
    public GameObject canvas;
    public AudioSource audioClip;

    //check to see if player is alive, if not, call method for displaying buttons for quit and retry on player death
    public void Update()
    {
        if (GameObject.Find("Player") == false && instance == 0)
        {
            DisplayQuitAndRetry();
            instance = 1;
        }
    }

    //display buttons for quit and retry on player death
    public void DisplayQuitAndRetry()
    {
        if (GameObject.Find("Player") == false)
        {
            GameObject newCanvas = Instantiate(canvas) as GameObject;
        }
    }

    //play sound
    public void playSound()
    {

        Destroy(GameObject.Find("menuhit(Clone)"));

        Instantiate(audioClip);
        DontDestroyOnLoad(audioClip);
        DontDestroyOnLoad(GameObject.Find("PreviousScene"));
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StartGame1()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void StartGame2()
    {
        SceneManager.LoadScene("SampleScene 2");
    }
    public void StartGame3()
    {
        SceneManager.LoadScene("SampleScene 3");
    }

    //load current scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //load title scene
    public void Title()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("TitleScene 1");
    }

    //quit program
    public void QuitGame()
    {
        Application.Quit();
    }
}
