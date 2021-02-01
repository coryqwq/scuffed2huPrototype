using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoFollowPlayer : MonoBehaviour
{
    public float timer = 0;
    public Vector3 position;
    public int speed = 20;
   
    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") != null)
        {
            timer += Time.deltaTime;
            if (timer > 3)
            {
                position = (GameObject.Find("Player").transform.position + new Vector3(0, 0, 1));
                transform.position = Vector3.MoveTowards(transform.position, position, speed * Time.deltaTime);
            }
        }
    }
}
