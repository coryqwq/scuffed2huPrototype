using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 1.5f, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.Find("Player").transform.position + offset;

        Vector3 mousePos = Input.mousePosition;
        Vector3 objPos = Camera.main.WorldToScreenPoint(transform.position);
      
        mousePos.x -= objPos.x;
        mousePos.y -= objPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        if(angle != 0)
        {
            transform.RotateAround(GameObject.Find("PlayerImage").transform.position, Vector3.forward, angle - 90);
        }
    }
}
