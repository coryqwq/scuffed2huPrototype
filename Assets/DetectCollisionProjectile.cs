using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);

        }
        if (collision.CompareTag("Projectile2"))
        {
            Destroy(collision.gameObject);

        }
    }
}
