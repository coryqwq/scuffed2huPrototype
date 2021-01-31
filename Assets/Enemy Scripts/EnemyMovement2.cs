using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public float xPos = -10.0f;
    public float yPos = 8f;
    public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        xPos += 1 * Time.deltaTime * speed;
        transform.localPosition = new Vector2(xPos, yPos);
    }
}
