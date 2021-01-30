using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement1 : MonoBehaviour
{
    public GameObject[] pointOfReferences;
    public bool[] phases = { false };
    public int index = 1;
 
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        phases[0] = true;
    }

    // Update is called once per frame
    void Update()
    {
        for( index = 0 ; index < pointOfReferences.Length ; index++)
        {
          
            if (phases[index] == true && transform.position != pointOfReferences[index].transform.position)
            {
                Vector3 targetPosition = pointOfReferences[index].transform.position;
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }

            if (index == pointOfReferences.Length - 1 && transform.position == pointOfReferences[index].transform.position)
            {
                phases[index] = false;
                phases[0] = true;
            }

            if (index < pointOfReferences.Length - 1 && transform.position == pointOfReferences[index].transform.position)
            {
                phases[index] = false;
                phases[index + 1] = true;
            }
        } 
    }    
}
