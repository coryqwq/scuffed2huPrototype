using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{

    public float xInput;
    public float yInput;
    public float speedRun = 20.0f;
    public float speedWalk = 7.0f;
    public GameObject projectilePrefab;

    public int ammoCount = 100;
    public int ammoCount2 = 100;
    public Text ammo1;
    public Text ammo2;


    //range the player can move on x axis
    public float xRange = 24.0f;
    //range the player can move on y axis
    public float yRange = 13.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ammo1.text = "AMMO 1:" + ammoCount;
        ammo2.text = "AMMO 2:" + ammoCount2;

        //keep player in bounds based on coordinate
        if (transform.position.x < -xRange + 15.8)
        {
            transform.position = new Vector2(-xRange + 15.8f, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        //declaring and initializing input variables
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift) != true)
        {
            //move player along x and y axis by the value of "speed" meters per second when activated by user input
            transform.position = transform.position + new Vector3(Time.deltaTime * xInput * speedRun, Time.deltaTime * yInput * speedRun, 0);
        }
        else
        {
            transform.Translate(Vector2.up * Time.deltaTime * yInput * speedWalk);
            transform.Translate(Vector2.right * Time.deltaTime * xInput * speedWalk);
        }
    }
}
