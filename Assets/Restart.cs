using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    private int instance = 0;
    public GameObject canvas;
    public AudioSource audio;

    public void Update()
    {
        if(GameObject.Find("Player") == false && instance == 0)
        {
            DisplayQuitAndRetry();
            instance = 1;
        }
    }
    public void DisplayQuitAndRetry()
    {
        if(GameObject.Find("Player") == false)
        {
            GameObject newCanvas = Instantiate(canvas) as GameObject;
        }
    }

    public void playSound()
    {
        Instantiate(audio);
        DontDestroyOnLoad(audio);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");  
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
