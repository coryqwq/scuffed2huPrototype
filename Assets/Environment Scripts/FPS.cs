using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    Text fps;
    public float timer = 1;
    public int refresh = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = -1;
        fps = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.unscaledDeltaTime;
        refresh = (int)(1f / Time.unscaledDeltaTime);

        if (timer > 1)
        {
            fps.text = "FPS:" + refresh;
            timer = 0;

        }
    }
}
