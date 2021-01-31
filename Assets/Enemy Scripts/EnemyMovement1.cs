using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public float speed = 10.0f;
    public float xPos = 8.0f;
    public float yPos = 0.2f;
    public float a = 0.5f;

    // Update is called once per frame
    void Update()
    {
        xPos -= 1 * Time.deltaTime * speed;
        yPos = a * xPos * xPos;

        transform.localPosition = new Vector2(xPos, yPos);
    }
}
