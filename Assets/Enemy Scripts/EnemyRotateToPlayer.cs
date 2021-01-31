using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateToPlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") != null)
        {
            Vector2 direction = new Vector2(
            GameObject.Find("Player").transform.position.x - transform.position.x,
            GameObject.Find("Player").transform.position.y - transform.position.y
            );

            transform.up = direction;
        }
    }
}
