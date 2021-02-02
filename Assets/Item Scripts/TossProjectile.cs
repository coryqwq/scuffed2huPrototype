using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossProjectile : MonoBehaviour
{
    public Rigidbody targetRb;
    public int force = 0;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        targetRb.AddForce(Vector3.right * force, ForceMode.Impulse);

    }
}
