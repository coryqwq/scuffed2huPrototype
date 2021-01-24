using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnAmmo : MonoBehaviour
{
    //declaring and initializing variable
    public GameObject ammoPack1;
    public GameObject ammoPack2;
    public float xPos;
    public float yPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAmmo1", 0, 0.1f);
        InvokeRepeating("SpawnAmmo2", 0.1f, 0.1f);
        StartCoroutine(StopAmmoSpawn());
    }
    public void SpawnAmmo1()
    {
        xPos = Random.Range(0.0f, 3.0f);
        yPos = Random.Range(0.0f, 2.5f);


        Instantiate(ammoPack1, transform.position + new Vector3(xPos, yPos, 1), ammoPack1.transform.rotation);
    }
    public void SpawnAmmo2()
    {
        xPos = Random.Range(0.0f, 3.0f);
        yPos = Random.Range(0.0f, 2.5f);

        Instantiate(ammoPack2, transform.position + new Vector3(xPos, yPos, 1), ammoPack2.transform.rotation);
    }
    public IEnumerator StopAmmoSpawn()
    {
        yield return new WaitForSeconds(2);
        CancelInvoke();
    }
}