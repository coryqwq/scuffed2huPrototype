using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireVacuum : MonoBehaviour
{
    VacuumStatus vacuumStatusScript;

    void Start()
    {
        vacuumStatusScript = GameObject.Find("VacuumCompound").GetComponent<VacuumStatus>();
    }

    void Update()
    {
        // check for user input of left mouse button
        if (Input.GetMouseButton(0))
        {
            if (vacuumStatusScript.on == false)
            {
                GameObject.Find("VacuumCompound").GetComponent<SpriteRenderer>().enabled = true;
                GameObject[] colliders = GameObject.FindGameObjectsWithTag("Vacuum");

                for (int index = 0; index < colliders.Length; index++)
                {
                    colliders[index].GetComponent<BoxCollider>().enabled = true;
                }

                vacuumStatusScript.on = true;
                
            }
        }
        else
        {
            vacuumStatusScript.off = true;

        }
    }
}
