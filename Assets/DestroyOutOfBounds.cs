using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //declaring and initializing bound
    public float xBound = 20;
    public float yBound = 11.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if position of projectile exceeds bounds on y axis
        if (transform.position.x > xBound || transform.position.x < -xBound)
        {
            //destroy the projectile
            Destroy(gameObject);
        }

        //check if position of projectile exceeds boudns on x axisd
        if (transform.position.y > yBound || transform.position.y < -yBound)
        {
            //destroy the projectile
            Destroy(gameObject);
        }
    }
}
