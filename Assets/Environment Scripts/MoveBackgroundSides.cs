using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgroundSides : MonoBehaviour
{
    public GameObject bg;
    public GameObject temp;
    public bool spawned = false;
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        //move image down
        transform.Translate(Vector2.down * Time.deltaTime * speed);

        //spawn new image when current image is at -22 on the y axis
        if (transform.position.y < 0  && spawned == false)
        {
            Instantiate(bg, new Vector3(7.15f, 40, -8), transform.rotation);
            spawned = true;
        }

        //destroy current image when it is at -60 on the y axis
        if (transform.position.y < -60)
        {
            Destroy(gameObject);
        }
    }
}
