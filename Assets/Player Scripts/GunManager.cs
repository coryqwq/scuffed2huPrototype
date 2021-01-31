using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public int key = -1;
    public GameObject[] guns;
    public GameObject[] temp;
    public int num = -1;

    // Start is called before the first frame update
    void Start()
    {
        temp[0] = Instantiate(guns[0], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //assign value key the return value of method GetPressedNumber() 
        key = GetPressedNumber();
        //check if value of key does not equal -1, if true, call method SwitchGun() and pass the value of key
        //if false, skip body of if statment
        if (key != -1)
        {
            SwitchGun(key);
        }
        //assign value of key to -1;
        key = -1;

        //note* this is so method SwitchGun() is not called every frame
    }

    void SwitchGun(int key)
    {
        //the key pressed for gun1 is 2, for gun2 is 3 
        switch (key - 2)
        {
            case 0:
                //if player isnt already equipping current gun, run body of if statement
                if(GameObject.Find("Gun1(Clone)") == false)
                {
                    //destroy current gun gameobject
                    Destroy(GameObject.FindGameObjectWithTag("CurrentGun"));
                    //call method Instantiate and pass it the gameobject (the gun), the position of the player at the instance, and the rotation of the gun at that instance
                    temp[0] = Instantiate(guns[key - 2], transform.position, transform.rotation);
                }
                break;

            case 1:
                if (GameObject.Find("Gun2(Clone)") == false)
                {
                    Destroy(GameObject.FindGameObjectWithTag("CurrentGun"));
                    temp[1] = Instantiate(guns[key - 2], transform.position, transform.rotation);
                }
                break;

            default:
                break;
        }
    }

    public int GetPressedNumber()
    {
        for(num = 0; num <= 9; num++)
        {
            //if detect user input of number key, return the value of that key
            if (Input.GetKeyDown(num.ToString()))
            {
                return num;
            }
        }
        //return value of -1 for key
        return -1;
    }
}
