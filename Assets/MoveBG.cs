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
        //move image down
        transform.Translate(Vector2.left * Time.deltaTime * 40);

        //spawn new image when current image is at -22 on the y axis
        if(transform.position.y < -22  && spawned == false)
        {
            Instantiate(bg, new Vector3(0, 50, 10), transform.rotation);
            spawned = true;
        }

        //destroy current image when it is at -60 on the y axis
        if(transform.position.y < -60)
        {
            Destroy(gameObject);
        }
    }
}
