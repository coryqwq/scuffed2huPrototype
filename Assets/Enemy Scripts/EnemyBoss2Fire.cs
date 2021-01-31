using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss2Fire : MonoBehaviour
{
    public float startDelay1 = 0.5f;
    public float spawnInterval1 = 0.7f;
    public float startDelay2 = 0f;
    public float spawnInterval2 = 2.7f;
    public float startDelay3 = 0.7f;
    public float spawnInterval3 = 2.7f;
    public float startDelay4 = 1.4f;
    public float spawnInterval4 = 2.7f;
    public GameObject[] projectilePrefabs;
    public GameObject projectilePrefab1;
    public float turnSpeed = 30.0f;
    public float angleDistance = 0.0f;
    public float angleOffset = 0;
    public float angleBound = 360.0f;

    public float timer = 0;
    public bool phase1 = true;
    public bool phase2 = true;
    public bool phase3 = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (phase1 == true)
        {
            InvokeRepeating("FireGun1", startDelay1, spawnInterval1);
            phase1 = false;
        }

        if (timer > 20 && phase2 == true)
        {
            InvokeRepeating("FireGun2", startDelay2, spawnInterval2);
            InvokeRepeating("FireGun2", startDelay3, spawnInterval3);
            InvokeRepeating("FireGun2", startDelay4, spawnInterval4);
            phase2 = false;
        }

        if (timer > 35 && phase3 == true)
        {
            InvokeRepeating("FireGun3", startDelay2, spawnInterval2);
            InvokeRepeating("FireGun3", startDelay3, spawnInterval3);
            InvokeRepeating("FireGun3", startDelay4, spawnInterval4);
            phase3 = false;
        }
    }

    void FireGun1()
    {
        //create projectiles
        for( int index = 0; index < projectilePrefabs.Length; index++)
        {
            Instantiate(projectilePrefabs[index], transform.position, transform.rotation);
        }

    }

    void FireGun2()
    {
        int angle = 0;

        for (int i = 0; i < 8; i++)
        {
            //set angle of projectile
            projectilePrefab1.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //create projectiles
            Instantiate(projectilePrefab1, transform.position, projectilePrefab1.transform.rotation);

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
            Instantiate(projectilePrefab1, transform.position, projectilePrefab1.transform.rotation);

            angle += 45;
        }
    }
}
