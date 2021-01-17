using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyOutOfBounds : MonoBehaviour
{
    //declaring and initializing bound
    public float xBound = 24f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if position of projectile exceeds bounds on y axis
        if (transform.position.x > xBound)
        {
            //destroy the projectile
            Destroy(gameObject);
        }
    }
}
