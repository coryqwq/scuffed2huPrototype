using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public float startDelay = 0.5f;
    public float spawnInterval = 0.7f;
    public GameObject projectilePrefab;
    public float turnSpeed = 30.0f;
    public float angleDistance = 0.0f;
    public float angleOffset = 180;
    private float angleBound = 360.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireGun", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void FireGun()
    {
        //calculate angles
        
        angleDistance += turnSpeed;

        if (angleDistance > angleBound)
        {
            angleOffset -= turnSpeed;

            if(angleDistance == angleBound * 2)
            {
                angleDistance = 0;
            }
        }
        if(angleDistance < angleBound)
        {
            angleOffset += turnSpeed;
        }
        
        
        //create projectiles
        projectilePrefab.transform.rotation = Quaternion.AngleAxis(90 + angleOffset, Vector3.forward);
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        
        projectilePrefab.transform.rotation = Quaternion.AngleAxis(130 + angleOffset, Vector3.forward);
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        projectilePrefab.transform.rotation = Quaternion.AngleAxis(50 + angleOffset, Vector3.forward);
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        
    }
}
