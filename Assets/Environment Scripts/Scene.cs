using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    private int instance = 0;
    public GameObject canvas;
    public AudioSource audioClip;

    public Animator transition;
    public float transitionTime = 0.21f;

    //check to see if player is alive, if not, call method for displaying buttons for quit and retry on player death
    public void Update()
    {
        if (GameObject.FindWithTag("Player") == false && instance == 0)
        {
            DisplayQuitAndRetry();
            instance = 1;
        }
    }

    //display buttons for quit and retry on player death
    public void DisplayQuitAndRetry()
    {
        if (GameObject.FindWithTag("Player") == false)
        {
            GameObject newCanvas = Instantiate(canvas) as GameObject;
        }
    }

    //play sound
    public void playSound()
    {

        Destroy(GameObject.Find("menuhit(Clone)"));

        Instantiate(audioClip);
        

        if(GameObject.FindWithTag("PreviousScene") != null)
        {
            DontDestroyOnLoad(GameObject.FindWithTag("PreviousScene"));

        }
    }

    public void StartGame()
    {
        StartCoroutine(Transition());
    }
    public void StartGame1()
    {
        StartCoroutine(Transition1());
    }

    public void StartGame2()
    {
        StartCoroutine(Transition2());
    }
    public void StartGame3()
    {
        StartCoroutine(Transition3());
    }

    //load current scene
    public void RestartGame()
    {
        //Debug.Log("The object", this);
        //Debug.Break();
        //StartCoroutine(Transition4());
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //load title scene
    public void Title()
    {
        StartCoroutine(Transition5());
    }
    public void LevelSelect()
    {
        StartCoroutine(Transition6());
    }

    //quit program
    public void QuitGame()
    {
        StartCoroutine(Transition7());
    }

    IEnumerator Transition()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator Transition1()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("SampleScene 1");
    }
    IEnumerator Transition2()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("SampleScene 2");
    }
    IEnumerator Transition3()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("SampleScene 4");
    }
    IEnumerator Transition4()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator Transition5()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("TitleScene");
    }
    IEnumerator Transition6()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("TitleScene 1");
    }
    IEnumerator Transition7()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
}
