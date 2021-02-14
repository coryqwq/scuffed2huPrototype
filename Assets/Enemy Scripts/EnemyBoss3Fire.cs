using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss3Fire : MonoBehaviour
{
    public float startDelay1 = 0.5f;
    public float spawnInterval1 = 0.7f;
    public float startDelay1_1 = 0.5f;
    public float spawnInterval1_1 = 3f;
    public float startDelay2 = 0f;
    public float spawnInterval2 = 2.7f;
    public float startDelay3 = 0.7f;
    public float spawnInterval3 = 2.7f;
    public float startDelay4 = 1.4f;
    public float spawnInterval4 = 2.7f;
    public float spawnDelay = 0.0f;
    public GameObject projectilePrefabs;
    public GameObject[] projectilePrefab;
    public GameObject projectilePrefab1;
    public float angleOffset = 0;
    public float timer = 0;
    public bool phase1 = true;
    public bool phase2 = true;
    public float timePhase2 = 5;
    public bool phase3 = true;

    GameState gameStateScript;

    // Start is called before the first frame update
    void Start()
    {
        gameStateScript = GameObject.FindWithTag("GameState").GetComponent<GameState>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (phase1 == true)
        {
            InvokeRepeating("FireGun1_1", startDelay1_1, spawnInterval1_1 * gameStateScript.spawnIntervalOffset);

            float delay = 0;
            for (int i = 0; i < 12; i++)
            {
                delay += 0.2f;
                InvokeRepeating("FireGun1", startDelay1 + delay, spawnInterval1 * gameStateScript.spawnIntervalOffset);

            }
            phase1 = false;
        }
        /*
        if (timer > timePhase2 && phase2 == true)
        {
            InvokeRepeating("FireGun2", startDelay2, spawnInterval2 * gameStateScript.spawnIntervalOffset);
            InvokeRepeating("FireGun2", startDelay3, spawnInterval3 * gameStateScript.spawnIntervalOffset);
            InvokeRepeating("FireGun2", startDelay4, spawnInterval4 * gameStateScript.spawnIntervalOffset);
            phase2 = false;
        }

        if (timer > 35 && phase3 == true)
        {
            InvokeRepeating("FireGun3", startDelay2, spawnInterval2 * gameStateScript.spawnIntervalOffset);
            InvokeRepeating("FireGun3", startDelay3, spawnInterval3 * gameStateScript.spawnIntervalOffset);
            InvokeRepeating("FireGun3", startDelay4, spawnInterval4 * gameStateScript.spawnIntervalOffset);
            phase3 = false;
        }
        */
    }

    void FireGun1()
    {
        int angle = 0;
        //create projectiles
        for (int i = 0; i < 6; i++)
        {
            Instantiate(projectilePrefabs, transform.position + new Vector3(0, 0, -1), transform.rotation * Quaternion.AngleAxis(angle + angleOffset, Vector3.forward));
            Instantiate(projectilePrefabs, transform.position + new Vector3(0, 0, -1), transform.rotation * Quaternion.AngleAxis(angle + angleOffset + 180, Vector3.forward));
            angle += 10;
        }

        angleOffset += 5;
    }

    void FireGun1_1()
    {
        //create projectiles
        for (int index = 0; index < projectilePrefab.Length; index++)
        {
            spawnDelay += 0.1f;
            StartCoroutine(projectileSpawnDelay(index));
        }
    }

    IEnumerator projectileSpawnDelay(int index)
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(projectilePrefab[index], transform.position + new Vector3(0, 0, -1), transform.rotation);
        

    }

    void FireGun2()
    {
        int angle = 0;

        for (int i = 0; i < 8; i++)
        {
            //set angle of projectile
            projectilePrefab1.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //create projectiles
            Instantiate(projectilePrefab1, transform.position + new Vector3(0, 0, 1), projectilePrefab1.transform.rotation);

            angle += 45;
        }
    }

    void FireGun3()
    {
        int angle = 0;

        for (int i = 0; i < 8; i++)
        {
            //set angle of projectile
            projectilePrefab1.transform.rotation = Quaternion.AngleAxis(angle + 22.5f, Vector3.forward);
            //create projectiles
            Instantiate(projectilePrefab1, transform.position + new Vector3(0, 0, 1), projectilePrefab1.transform.rotation);

            angle += 45;
        }
    }
}
