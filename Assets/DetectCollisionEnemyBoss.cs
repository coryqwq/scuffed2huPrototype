using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionEnemyBoss : MonoBehaviour
{
    //declaring and initializing variable
    public int HP = 750;
    public GameObject spawnAmmoInBulk;
    public GameObject projectilePrefab;
    public GameObject healthBar;
    float healthBarOffset = 0;
    private GameObject[] temp = new GameObject[750];

    // Start is called before the first frame update
    void Start()
    {
        for(int index = 0; index < HP; index++)
        {
            healthBarOffset += 0.041f;
            temp[index] = Instantiate(healthBar, healthBar.transform.position + new Vector3(healthBarOffset, 0, 0), healthBar.transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Projectile"
        if (collision.CompareTag("Projectile2") || collision.CompareTag("Projectile"))
        {
            HP -= 1;
            GameObject.Destroy(temp[HP]);

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
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

            angle += 12;
        }
    }
}