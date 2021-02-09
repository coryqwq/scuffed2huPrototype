using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun2 : MonoBehaviour
{
    public float startDelay1 = 0.05f;
    public float spawnInterval1 = 1.0f;
    public float startDelay2 = 0.2f;
    public float spawnInterval2 = 1.0f;

    public float bulletSpread = 10.0f;
    public int bulletDamage = 3;

    public bool invoked;

    GunManager gunManagerScript;
    PlayerController playerControllerScript;

    public GameObject projectilePrefab;

     void Start()
    {
        playerControllerScript = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        gunManagerScript = GameObject.FindWithTag("Player").GetComponent<GunManager>();
    }

    void Update()
    {
        //reset values when the player is not holding the fire button
        if (Input.GetMouseButton(0) == false)
        {
            CancelInvoke("FireGun");
            invoked = false;
        }
         gunManagerScript.timer += Time.deltaTime;
        //rounds of shotgun fire
        if (Input.GetMouseButton(0) && playerControllerScript.ammoCount2 > 0 && invoked == false && gunManagerScript.timer >= 1)
        {
            InvokeRepeating("FireGun", startDelay1, spawnInterval1);
            InvokeRepeating("FireGun", startDelay2, spawnInterval2);
            gunManagerScript.timer = 0;
            invoked = true;
        }
    }
    void FireGun()
    {

        //play shotgun sfx
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        //create projectiles
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   GameObject.FindWithTag("PlayerImage").transform.rotation * Quaternion.AngleAxis(0, Vector3.forward));
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   GameObject.FindWithTag("PlayerImage").transform.rotation * Quaternion.AngleAxis(bulletSpread, Vector3.forward));
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   GameObject.FindWithTag("PlayerImage").transform.rotation * Quaternion.AngleAxis(-bulletSpread, Vector3.forward));

        playerControllerScript.ammoCount2 -= 3;
    }
}
