using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") != null)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 direction = new Vector2(
            GameObject.Find("Player").transform.position.x - transform.position.x,
            GameObject.Find("Player").transform.position.y - transform.position.y
            );

            transform.up = direction;
        }
        
    }
}
