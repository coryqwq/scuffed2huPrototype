using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 1.5f, 1);

    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.FindWithTag("Player").transform.position + offset;
        transform.rotation = GameObject.FindWithTag("Player").transform.rotation;

        Vector3 mousePos = Input.mousePosition;
        Vector3 objPos = Camera.main.WorldToScreenPoint(transform.position);
      
        mousePos.x -= objPos.x;
        mousePos.y -= objPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        if(angle != 0)
        {
            transform.RotateAround(GameObject.FindWithTag("PlayerImage").transform.position, Vector3.forward, angle - 90);
        }
    }
}
