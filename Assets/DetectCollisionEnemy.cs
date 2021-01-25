using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionEnemy : MonoBehaviour
{
    //declaring and initializing variable
    public float HP = 8;
    public GameObject ammoPack1;
    public GameObject temp;
    public SpawnManager spawnManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        spawnManagerScript = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();

    }

    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Projectile"
        if (collision.CompareTag("Projectile"))
        {
            HP -= 1;

            //if enemy health equals 0, destroy enemy gameobject
            if (HP == 0)
            {
                temp = Instantiate(ammoPack1, transform.position + new Vector3(0, 0, 1), ammoPack1.transform.rotation);
                spawnManagerScript.StartCoroutine(spawnManagerScript.CountDown(temp));
                ScoreCounter scoreCounterScript = GameObject.Find("Main Camera").GetComponent<ScoreCounter>(); 
                scoreCounterScript.scoreNumber += 10;
                Destroy(gameObject);

            }
        }

        //check if on collision with gameobject tagged "Bounds"
        if (collision.CompareTag("Bounds"))
        {
            //destroy enemy gameobject
            Destroy(gameObject);
        }
    }
}
