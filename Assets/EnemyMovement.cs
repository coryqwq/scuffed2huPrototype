using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //public GameObject pointOfReference;
    public float turnSpeed = 360.0f;
    public float speed = 10.0f;
    public float xDistance = 0;
    public float totalDistance = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate this gameobject around the pointOfReference gameobejct
        // transform.RotateAround(pointOfReference.transform.position, Vector3.forward, turnSpeed * Time.deltaTime);

        totalDistance += speed * Time.deltaTime;

        if(totalDistance > xDistance)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);

            if(totalDistance >  xDistance * 2)
            {
                totalDistance = 0;
            }
        }
        if (totalDistance < xDistance)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
    }
}
