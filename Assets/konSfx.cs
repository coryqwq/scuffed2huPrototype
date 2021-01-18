using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KONSfx : MonoBehaviour
{
    public AudioSource[] audioClips;
    public int index = 0;

    // Start is called before the first frame update
    void Awake()
    {
        index = Random.Range(0, audioClips.Length);
        Instantiate(audioClips[index]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
