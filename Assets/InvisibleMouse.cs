using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") == true)
        {
            Cursor.visible = false;
        }
        if (GameObject.Find("Player") == false)
        {
            Cursor.visible = true;
        }
    }
}
