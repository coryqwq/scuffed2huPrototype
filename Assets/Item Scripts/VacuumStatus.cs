using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumStatus : MonoBehaviour
{
    public bool on = false;
    public bool off = true;

    // Update is called once per frame
    void Update()
    {
        if (off == true )
        {
            GameObject.Find("VacuumCompound").GetComponent<SpriteRenderer>().enabled = false;
            GameObject[] colliders = GameObject.FindGameObjectsWithTag("Vacuum");

            for (int index = 0; index < colliders.Length; index++)
            {
                colliders[index].GetComponent<BoxCollider>().enabled = false;
            }

            on = false;
        }
    }
}
