using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionEnemy2 : MonoBehaviour
{
    //declaring and initializing variable
    public float HP = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Projectile"
        if (collision.CompareTag("Projectile2"))
        {
            HP -= 1;

            //if enemy health equals 0, destroy enemy gameobject
            if (HP == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
