using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement1 : MonoBehaviour
{

    public float xPos = 0f;
    public float yPos = 14.0f;
    public float speed = 5.0f;

    public bool phase1 = true;
    public bool phase2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //run body if y position of gameobject is greater than or equal to  0 and phase1 equals true
        if (transform.localPosition.y >= 0 && phase1 == true)
        {
            //move gameobject down by decrementing current y position 
            yPos -= 1 * Time.deltaTime * speed;
            transform.localPosition = new Vector2(xPos, yPos);

            //ruyn body if y position of gameobject is less  than or equal to  0 
            if (transform.localPosition.y <= 0)
            {
                //set phase1 to false and phase2 to true
                phase1 = false;
                phase2 = true;
            }
        }
        
        //run body if phase2 is true
        if(phase2 == true)
        {
            //increment an x value for calculating and setting x,y coordintes of gameobect to elliptical path
            xPos += Time.deltaTime * speed * 0.3f;
            transform.localPosition = new Vector2(0f + (4f * Mathf.Sin(xPos)),
                                                 -1f + (1f * Mathf.Cos(xPos)));
        }
    }
}
