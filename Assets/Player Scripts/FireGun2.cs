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

    public bool invoked1;
    public bool invoked2;

    public GameObject projectilePrefab;

    void Update()
    {
        PlayerController playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        GunManager gunManagerScript = GameObject.Find("Player").GetComponent<GunManager>();


        //reset values when the player is not holding the fire button, so next time, start with first round of shotgun fire
        if (Input.GetMouseButton(0) == false)
        {
            CancelInvoke("Fire1");
            CancelInvoke("Fire2");
            invoked1 = false;
            invoked2 = true;
        }
         gunManagerScript.timer += Time.deltaTime;
        //first rounds of shotgun fire
        if (Input.GetMouseButton(0) && playerControllerScript.ammoCount2 > 0 && invoked1 == false && gunManagerScript.timer >= 1)
        {
            InvokeRepeating("Fire1", startDelay1, spawnInterval1);
            InvokeRepeating("Fire1", startDelay2, spawnInterval2);
            gunManagerScript.timer = 0;
            StartCoroutine(Delay1(0.2f));
            invoked1 = true;
            invoked2 = false;
        }

        //every round of shotgun fire after the first rounds while still holding the fire button
        if (Input.GetMouseButton(0) && playerControllerScript.ammoCount2 > 0 && invoked2 == false)
        {
            InvokeRepeating("Fire2", spawnInterval1 + 0.05f, spawnInterval1);
            InvokeRepeating("Fire2", spawnInterval2 + 0.2f, spawnInterval2);

            invoked2 = true;
        }
    }
    // Update is called once per frame
    void Fire1()
    {

        PlayerController playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        //play shotgun sfx
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        //create projectiles
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   transform.rotation * Quaternion.AngleAxis(0, Vector3.forward));
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   transform.rotation * Quaternion.AngleAxis(bulletSpread, Vector3.forward));
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   transform.rotation * Quaternion.AngleAxis(-bulletSpread, Vector3.forward));

        playerControllerScript.ammoCount2 -= 3;
    }
    void Fire2()
    {

        PlayerController playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        //play shotgun sfx
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        //create projectiles
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   transform.rotation * Quaternion.AngleAxis(0, Vector3.forward));
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   transform.rotation * Quaternion.AngleAxis(bulletSpread, Vector3.forward));
        Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2),
                   transform.rotation * Quaternion.AngleAxis(-bulletSpread, Vector3.forward));

        playerControllerScript.ammoCount2 -= 3;
    }

    IEnumerator Delay1(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        CancelInvoke("FireGun");
        
    }
}
