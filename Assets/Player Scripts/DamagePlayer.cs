using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DamagePlayer : MonoBehaviour
{
    //declaring and initializing variable
    public float HP = 10;
    public GameObject playerImage;
    public GameObject bomb;
    public Image[] healthBar;
    public int indexHP = 0;
    public int indexMaxHP = 11;

    private void OnTriggerEnter(Collider collision)
    {
        //check if on collision with gameobject tagged "Player"
        if (collision.CompareTag("EnemyProjectile"))
        {
            HP -= 1;
            Destroy(healthBar[indexHP].gameObject);
            Instantiate(bomb, transform.position, transform.rotation);
            
            //if index of health bar does not equal indexMaxHP, increment index (prevents overaccessing array)
            if(indexHP != indexMaxHP)
            {
                indexHP += 1;
            }
            

            //if player health equals 0, destroy player gameobject and create death message gameobject
            if (HP <= 0)
            {
                GameState gameStateScript = GameObject.FindWithTag("GameState").GetComponent<GameState>();
                gameStateScript.isAlive = false;

                Destroy(playerImage.gameObject);
                Destroy(GameObject.Find("Gun1(Clone)"));
                Destroy(GameObject.Find("Gun2(Clone)"));
                Destroy(GameObject.Find("empty(Clone)"));
                Destroy(gameObject);
            }
        }
    }
}
