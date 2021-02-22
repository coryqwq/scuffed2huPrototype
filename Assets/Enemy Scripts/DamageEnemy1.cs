using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy1 : MonoBehaviour
{
    //declaring and initializing variable
    public float HP = 8;
    public GameObject ammoPack1;
    public GameObject temp;
    public SpawnManager spawnManagerScript;
    public GameObject gun1;

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
            FireGun1 fireGun1Script = gun1.GetComponent<FireGun1>();
            HP -= fireGun1Script.bulletDamage;

            //if enemy health equals 0, destroy enemy gameobject
            if (HP <= 0)
            {
                temp = Instantiate(ammoPack1, transform.position + new Vector3(0, 0, 0.5f), ammoPack1.transform.rotation);
                spawnManagerScript.StartCoroutine(spawnManagerScript.CountDown(temp));

                ScoreCounter scoreCounterScript = GameObject.FindWithTag("MainCamera").GetComponent<ScoreCounter>();
                GameState gameStateScript = GameObject.FindWithTag("GameState").GetComponent<GameState>();
                scoreCounterScript.scoreNumber += (int)(10 * gameStateScript.scoreMultiplier);

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
