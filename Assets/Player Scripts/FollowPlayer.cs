using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 0, 1);

    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.FindWithTag("Player").transform.position + offset;
    }
}
