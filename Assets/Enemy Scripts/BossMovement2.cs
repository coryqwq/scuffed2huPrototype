using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement2 : MonoBehaviour
{
    public GameObject[] pointOfReferences;
    //initialize array for phases to false
    public bool[] phases = { false };
    public int index = 1;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //set first phase to true
        phases[0] = true;
    }

    // Update is called once per frame
    void Update()
    {
        //iterate body of for loop for the number of times that is the length of PoR array - 1
        for( index = 0 ; index < pointOfReferences.Length ; index++)
        {
            //if the referenced phase is true, and the object is not at the position of the referenced POI, move towards the referenced PoR          
            if (phases[index] == true && transform.position != pointOfReferences[index].transform.position)
            {
                Vector3 targetPosition = pointOfReferences[index].transform.position;
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }

            //if index equals the length of the PoR array - 1, and is at the position of the referenced PoR
            //set current phase to false, and first phase to true
            if (index == pointOfReferences.Length - 1 && transform.position == pointOfReferences[index].transform.position)
            {
                phases[index] = false;
                phases[0] = true;
            }

            //if index is less than the length of the PoR array - 1, and the object is at the position of the referenced PoR
            //set current phase to false and next phase to true
            if (index < pointOfReferences.Length - 1 && transform.position == pointOfReferences[index].transform.position)
            {
                phases[index] = false;
                phases[index + 1] = true;
            }
        } 
    }    
}
