using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    public GameObject bg;
    public GameObject temp;
    bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 40);

        if(transform.position.y < -24  && spawned == false)
        {
            Instantiate(bg, new Vector3(0, 47, 10), transform.rotation);
            spawned = true;
        }

        if(transform.position.y < -60)
        {
            Destroy(gameObject);
        }
    }
}
