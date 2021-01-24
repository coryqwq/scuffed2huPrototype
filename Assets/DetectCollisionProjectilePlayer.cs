using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionProjectilePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("EnemyProjectile"))
        {
            Destroy(collision.gameObject);

        }
    }
}
