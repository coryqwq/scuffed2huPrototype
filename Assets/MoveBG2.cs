using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG2 : MonoBehaviour
{
    public GameObject bg;
    public float speed = 5;
    public bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        if (transform.position.x > 0 && spawned == false)
        {
            Instantiate(bg, new Vector3(-43, 0, 20), transform.rotation);
            spawned = true;
        }

        if(transform.position.x > 50)
        {
            Destroy(gameObject);
        }
    }
}
