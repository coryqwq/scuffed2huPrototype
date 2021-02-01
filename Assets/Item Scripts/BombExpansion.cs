using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExpansion : MonoBehaviour
{
    public float speed = 5;
    public float scaleChangeRate = 0;
    public float bombSize = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x < bombSize)
        {
            scaleChangeRate += speed * Time.deltaTime;
            Vector3 scaleChange = new Vector3(scaleChangeRate, scaleChangeRate, 0);
            transform.localScale += scaleChange;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
