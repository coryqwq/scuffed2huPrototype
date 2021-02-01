using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameState : MonoBehaviour
{
    public GameObject passMsg;
    public GameObject passSound;
    public GameObject enemy;
    public bool endLevel = false;

    public bool invoked = false;

    // Update is called once per frame
    void Update()
    {
        if(enemy == null && GameObject.Find("Player") != null && invoked == false)
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
        endLevel = true;
        yield return new WaitForSeconds(2);
        DontDestroyOnLoad(GameObject.Find("PreviousScene"));
        SceneManager.LoadScene("TitleScene 2");
    }
}
