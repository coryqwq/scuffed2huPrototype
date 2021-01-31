using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnProjectileToPlayer : MonoBehaviour
{
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (GameObject.Find("Player") != null && timer < 1.5)
        {
            Vector2 direction = new Vector2(
            GameObject.Find("Player").transform.position.x - transform.position.x,
            GameObject.Find("Player").transform.position.y - transform.position.y
            );

            transform.up = direction;
        }
    }
}
