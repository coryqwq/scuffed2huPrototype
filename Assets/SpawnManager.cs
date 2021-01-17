using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //declaring and initializing variables
    public GameObject[] ammoPrefabs;
    public GameObject[] ammoTemp;
    public GameObject[] enemyPrefab;
    public float spawnX = 19f;
    public float spawnY = 9f;
    public float startDelayAmmo = 1.0f;
    public float spawnIntervalAmmo = 1.2f;
    public float startDelayEnem1 = 2.0f;
    public float spawnIntervalEnem1 = 1.8f;
    public float startDelayEnem2 = 2.0f;
    public float spawnIntervalEnem2 = 3.5f;
    public int delay = 10;

    public GameObject parentObject;

    // Start is called before the first frame update
    void Start()
    {
        //call function for spawning ammo at intervals
        InvokeRepeating("SpawnAmmo", startDelayAmmo, spawnIntervalAmmo);
        
        //call function for spawning enemy at intervals
        InvokeRepeating("SpawnEnemy1", startDelayEnem1, spawnIntervalEnem1);

        //call function for spawning enemy at intervals
        InvokeRepeating("SpawnEnemy2", startDelayEnem2, spawnIntervalEnem2);
    }
    void SpawnAmmo()
    {
        if (GameObject.Find("PlayerImage") != null)
        {
            //declaring and initializing variables with randomized values within defined range
            int ammoIndex = Random.Range(0, ammoPrefabs.Length);
            Vector2 spawnPos = new Vector2(Random.Range(-spawnX + 15.8f, spawnX), Random.Range(-spawnY, spawnY));
       
            //create ammo at random x,y location within defined range and start count down till despawn
            ammoTemp[ammoIndex] =  Instantiate(ammoPrefabs[ammoIndex], spawnPos, ammoPrefabs[ammoIndex].transform.rotation);
            StartCoroutine(CountDown(ammoTemp[ammoIndex]));
        }
    }
    
    void SpawnEnemy1()
    {
        if(GameObject.Find("PlayerImage") != null)
        {
            //create enemy as a child of the parent point of reference gameobject 
            GameObject childObject = Instantiate(enemyPrefab[0], new Vector2(-15,30), enemyPrefab[0].transform.rotation);
            childObject.transform.parent = parentObject.transform;
        }   
    }
    void SpawnEnemy2()
    {
        if (GameObject.Find("PlayerImage") != null)
        {
            //create enemy
            Instantiate(enemyPrefab[1], new Vector2(-12, 10), enemyPrefab[1].transform.rotation);
        }
    }

    IEnumerator CountDown(GameObject ammo)
    {
        //yeild for specified number of seconds and destroy the passed gameobject
        yield return new WaitForSeconds(delay);
        Destroy(ammo.gameObject);
    }
}
