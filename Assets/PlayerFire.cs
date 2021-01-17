using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public float startDelay = 0.0f;
    public float spawnInterval = 0.05f;
    public GameObject projectilePrefab;
    public GameObject player;
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //initialize the playerControllerScript object
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>(); 

        //invoking method
        InvokeRepeating("FireGun", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void FireGun()
    {
        // check for user input of left mouse button
        if (Input.GetMouseButton(0) && playerControllerScript.ammoCount != 0)
        {
            //create projectile
            Instantiate(projectilePrefab, GameObject.Find("Player").transform.position, GameObject.Find("PlayerImage").transform.rotation);
            //decrement ammo by 1
            playerControllerScript.ammoCount -= 1;
        }
    }
}
