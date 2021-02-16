using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageEnemyBoss : MonoBehaviour
{
    //declaring and initializing variable
    public float currentHP = 750;
    public float maxHP = 750;
    public int points = 69000;
    public GameObject spawnAmmoInBulk;
    public GameObject projectilePrefab;
    public GameObject gun2;
    public GameObject gun1;

    private bool invoked = false;

    public RectTransform healthBar;
    public float healthBarMax;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = currentHP;
        healthBarMax = healthBar.sizeDelta.x;
    }
    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Projectile"
        if (collision.CompareTag("Projectile"))
        {
            FireGun1 fireGun1Script = gun1.GetComponent<FireGun1>();
            for (int count = 0; count < fireGun1Script.bulletDamage; count++)
            {
                currentHP -= 1;
                healthBar.sizeDelta = new Vector2((currentHP * (healthBarMax / maxHP)), healthBar.sizeDelta.y);
            }

        }

        if (collision.CompareTag("Projectile2"))
        {
            FireGun2 fireGun2Script = gun2.GetComponent<FireGun2>();
            for (int count = 0; count < fireGun2Script.bulletDamage; count++)
            {
                currentHP -= 1;
                healthBar.sizeDelta = new Vector2((currentHP * (healthBarMax / maxHP)), healthBar.sizeDelta.y);
            }
        }

        //if enemy health equals 0, destroy enemy gameobject
        if (currentHP <= 0)
        {
            if (invoked == false)
            {
                SelfDestruct();
                Instantiate(spawnAmmoInBulk, transform.position, transform.rotation);

                GameState gameStateScript = GameObject.FindWithTag("GameState").GetComponent<GameState>();
                gameStateScript.endLevel = true;

                ScoreCounter scoreCounterScript = GameObject.FindWithTag("MainCamera").GetComponent<ScoreCounter>();
                scoreCounterScript.scoreNumber += (int)(points * gameStateScript.scoreMultiplier);

                invoked = true;
            }

            Destroy(gameObject);
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
