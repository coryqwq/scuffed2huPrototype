using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public GameObject passMsg;
    public GameObject passSound;
    public GameObject enemy;

    public bool invoked = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(enemy == null && invoked == false)
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
    }
}
