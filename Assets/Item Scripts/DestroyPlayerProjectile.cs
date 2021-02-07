using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayerProjectile : MonoBehaviour
{
    public ParticleSystem particles;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Instantiate(particles, transform.position, transform.rotation * Quaternion.AngleAxis(180, Vector3.forward));

            Destroy(gameObject);

        }
    }
}
