using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire2 : MonoBehaviour
{
    public float startDelay = 0.5f;
    public float spawnInterval = 0.8f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameState gameStateScript = GameObject.FindWithTag("GameState").GetComponent<GameState>();
        InvokeRepeating("FireGun", startDelay, spawnInterval * gameStateScript.spawnIntervalOffset);
    }

    // Update is called once per frame
    void FireGun()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
