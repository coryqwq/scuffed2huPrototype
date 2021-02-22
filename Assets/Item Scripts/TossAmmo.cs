﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossAmmo : MonoBehaviour
{
    public Rigidbody targetRb;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(12.0f, 16.0f), ForceMode.Impulse);
        targetRb.AddForce(Vector3.right * Random.Range(-8.0f, 8.0f), ForceMode.Impulse);

    }
}
