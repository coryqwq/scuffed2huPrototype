using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyProjectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("EnemyProjectile"))
        {
            Destroy(collision.gameObject);
        }
    }
}
