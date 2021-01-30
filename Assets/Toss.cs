using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toss : MonoBehaviour
{
    public Rigidbody targetRb;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(5.0f, 8.0f), ForceMode.Impulse);
        targetRb.AddForce(Vector3.right * Random.Range(-10.0f, 10.0f), ForceMode.Impulse);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
