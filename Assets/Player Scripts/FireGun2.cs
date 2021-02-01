using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun2 : MonoBehaviour
{
    public float startDelay = 0.0f;
    public float spawnInterval = 1f;
    public float startDelay1 = 0.2f;
    public float spawnInterval1 = 1f;
    public float bulletSpread = 10.0f;
    public int bulletDamage = 8;
    
    public GameObject projectilePrefab;
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("FireGun", startDelay, spawnInterval);
        InvokeRepeating("FireGun", startDelay1, spawnInterval1);

    }

    // Update is called once per frame
    void FireGun()
    {
        // check for user input of left mouse button
        if (Input.GetMouseButton(0) && playerControllerScript.ammoCount2 != 0)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            //create projectile
            Instantiate(projectilePrefab, transform.position + new Vector3(0,0,2),
                       transform.rotation * Quaternion.AngleAxis(0, Vector3.forward));
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                       transform.rotation * Quaternion.AngleAxis(bulletSpread, Vector3.forward));
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                       transform.rotation * Quaternion.AngleAxis(-bulletSpread, Vector3.forward));

            playerControllerScript.ammoCount2 -= 3;
        }
    }
}
