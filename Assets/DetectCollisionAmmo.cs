using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionAmmo : MonoBehaviour
{
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //initializing the playerControllerScript object
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        //if on collision with gameobject tagged with "Ammo", increment ammoCount and destroy gameobject 
        if (collision.CompareTag("Ammo"))
        {
            playerControllerScript.ammoCount += 30;
            Destroy(collision.gameObject);

        }

        //if on collision with gameobject tagged with "Ammo2", increment ammoCount2 and destroy gameobject
        if (collision.CompareTag("Ammo2"))
        {
            playerControllerScript.ammoCount2 += 30;
            Destroy(collision.gameObject);

        }
    }
}
