using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun2 : MonoBehaviour
{
    public float startDelay = 0.0f;
    public float spawnInterval = 0.05f;
    public GameObject projectilePrefab;
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("FireGun", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void FireGun()
    {
        // check for user input of left mouse button
        if (Input.GetMouseButton(0) && playerControllerScript.ammoCount2 != 0)
        {
            //create projectile
            Instantiate(projectilePrefab, GameObject.Find("Player").transform.position + new Vector3(0,0,2), projectilePrefab.transform.rotation);
            playerControllerScript.ammoCount2 -= 1;
        }
    }
}
