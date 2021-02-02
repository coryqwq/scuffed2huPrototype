using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedMoveProjectileForward : MonoBehaviour
{
    public float speed = 10.0f;
    public float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > 1.5f)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
    }
}
