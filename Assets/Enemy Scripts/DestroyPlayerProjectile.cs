using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayerProjectile : MonoBehaviour
{
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
