using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAngle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 direction = new Vector3(
        (mousePosition.x - transform.position.x),
        (mousePosition.y - transform.position.y)
        );

        transform.up = direction;
    }
}
