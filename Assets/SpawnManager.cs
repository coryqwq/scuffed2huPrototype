using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //declaring and initializing variables
    public GameObject[] ammoPrefabs;
    public GameObject[] enemyPrefab;
    public float spawnX = 19f;
    public float spawnY = 9f;
    public float startDelayAmmo = 1.0f;
    public float spawnIntervalAmmo = 1.2f;
    public float startDelayEnem = 2.0f;
    public float spawnIntervalEnem = 1.8f;


    // Start is called before the first frame update
    void Start()
    {
        //call function for spawning ammo at intervals
        InvokeRepeating("SpawnAmmo", startDelayAmmo, spawnIntervalAmmo);
        
        //call function for spawning enenmy at intervals
        InvokeRepeating("SpawnEnemy", startDelayEnem, spawnIntervalEnem);
    }

    // Update is called once per frame

    void SpawnAmmo()
    {
        if (GameObject.Find("PlayerImage") != null)
        {
            //declaring and initializing variables with randomized values within defined range
            int ammoIndex = Random.Range(0, ammoPrefabs.Length);
            Vector2 spawnPos = new Vector2(Random.Range(-spawnX, spawnX), Random.Range(-spawnY, spawnY));
       
            //create ammo at random x,y location within defined range
            Instantiate(ammoPrefabs[ammoIndex], spawnPos, ammoPrefabs[ammoIndex].transform.rotation);
        }
    }

    void SpawnEnemy()
    {
        if(GameObject.Find("PlayerImage") != null)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-spawnX, spawnX), Random.Range(-spawnY, spawnY));

            int enemyIndex = Random.Range(0, enemyPrefab.Length);

            //create ammo at random x,y location within defined range
            Instantiate(enemyPrefab[enemyIndex], spawnPos, enemyPrefab[enemyIndex].transform.rotation);
        }   
    }
}
