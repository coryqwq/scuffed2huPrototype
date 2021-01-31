using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGun : MonoBehaviour
{
    public GameObject gun2;
    public GunManager gunManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        //initiliaze gunManagerScript object
        gunManagerScript =  GameObject.Find("Player").GetComponent<GunManager>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Gun2" assign the gameobject array in gunmanager and destroy the gun2collectible gameobject
        if (collision.CompareTag("Gun2"))
        {
            gunManagerScript.guns[1] = gun2;

            //check if the empty gameobject exists (which means player is empty handed), destroy empty gameobject and create gun
            if (GameObject.Find("empty(Clone)") == true)
            {
                gunManagerScript.temp[1] = Instantiate(gunManagerScript.guns[1], transform.position, transform.rotation);
                Destroy(GameObject.Find("empty(Clone)"));
            }

            Destroy(collision.gameObject);
        }
    }
}
