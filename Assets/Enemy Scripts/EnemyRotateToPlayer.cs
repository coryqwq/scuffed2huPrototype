using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateToPlayer : MonoBehaviour
{
    GameState gameStateScript;
    void Start()
    {
        gameStateScript = GameObject.FindWithTag("GameState").GetComponent<GameState>();
    }
    // Update is called once per frame
    void Update()
    {
        if(gameStateScript.isAlive == true)
        {
            Vector2 direction = new Vector2(
            GameObject.FindWithTag("Player").transform.position.x - transform.position.x,
            GameObject.FindWithTag("Player").transform.position.y - transform.position.y
            );

            transform.up = direction;
        }
    }
}
