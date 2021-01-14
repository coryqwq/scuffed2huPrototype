using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class konSfx : MonoBehaviour
{
    public AudioSource[] audio;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, audio.Length);
        Instantiate(audio[index]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
