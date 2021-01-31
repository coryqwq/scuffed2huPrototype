using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    public int ammoDrop = 30;
    
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //initializing the playerControllerScript object
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        //if on collision with gameobject tagged with "Ammo", increment ammoCount and destroy gameobject 
        if (collision.CompareTag("Ammo"))
        {
            playerControllerScript.ammoCount += ammoDrop;
            Destroy(collision.gameObject);

        }

        //if on collision with gameobject tagged with "Ammo2", increment ammoCount2 and destroy gameobject
        if (collision.CompareTag("Ammo2"))
        {
            playerControllerScript.ammoCount2 += ammoDrop;
            Destroy(collision.gameObject);

        }
    }
}
