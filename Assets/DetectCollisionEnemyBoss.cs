using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionEnemyBoss : MonoBehaviour
{
    //declaring and initializing variable
    public float HP = 8;
    public GameObject spawnAmmoInBulk;
    public GameObject projectilePrefab;
    public GameObject passMsg;
    public GameObject passSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Projectile"
        if (collision.CompareTag("Projectile2") || collision.CompareTag("Projectile"))
        {
            HP -= 1;

            //if enemy health equals 0, destroy enemy gameobject
            if (HP == 0)
            {
                SelfDestruct();
                Instantiate(spawnAmmoInBulk, transform.position, transform.rotation);
                ScoreCounter scoreCounterScript = GameObject.Find("Main Camera").GetComponent<ScoreCounter>();
                scoreCounterScript.scoreNumber += 6900;
                Destroy(gameObject);

            }

        }
    }

    void SelfDestruct()
    {
        int angle = 0;

        for (int i = 0; i < 30; i++)
        {
            projectilePrefab.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, -1), projectilePrefab.transform.rotation);

            angle += 12;
        }
    }
}