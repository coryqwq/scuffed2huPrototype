using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{

    public float xPos = 0f;
    public float yPos = 14.0f;
    public float speed = 5.0f;

    public bool phase1 = true;
    public bool phase2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y >= 0 && phase1 == true)
        {
            yPos -= 1 * Time.deltaTime * speed;
            transform.localPosition = new Vector2(xPos, yPos);
            
            if(transform.localPosition.y <= 0)
            {
                phase1 = false;
                phase2 = true;
            }
        }
        
        if(phase2 == true)
        {
            xPos += Time.deltaTime;
            transform.localPosition = new Vector2(0f + (4f * Mathf.Sin(xPos)),
                                                 -1f + (1f * Mathf.Cos(xPos)));
        }
    }
}
