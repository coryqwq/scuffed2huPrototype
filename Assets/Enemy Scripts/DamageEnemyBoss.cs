using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageEnemyBoss : MonoBehaviour
{
    //declaring and initializing variable
    public float HP = 750;
    public int points = 69000;
    public GameObject spawnAmmoInBulk;
    public GameObject projectilePrefab;
    public GameObject gun2;

    public RectTransform healthBar;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Projectile"
        if (collision.CompareTag("Projectile2") || collision.CompareTag("Projectile"))
        {
            if (collision.CompareTag("Projectile"))
            {
                HP -= 1;
                healthBar.sizeDelta = new Vector2((HP * 1.6f), healthBar.sizeDelta.y);
            }

            if (collision.CompareTag("Projectile2"))
            {
                FireGun2 fireGun2Script = gun2.GetComponent<FireGun2>();
                for(int count = 0; count < fireGun2Script.bulletDamage; count++)
                {
                    HP -= 1;
                    healthBar.sizeDelta = new Vector2((HP * 1.6f), healthBar.sizeDelta.y);
                }
            }

            //if enemy health equals 0, destroy enemy gameobject
            if (HP <= 0)
            {
                SelfDestruct();
                Instantiate(spawnAmmoInBulk, transform.position, transform.rotation);
                ScoreCounter scoreCounterScript = GameObject.Find("Main Camera").GetComponent<ScoreCounter>();
                scoreCounterScript.scoreNumber += points;
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