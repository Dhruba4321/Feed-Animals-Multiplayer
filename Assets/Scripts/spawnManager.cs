using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] spawnEnemy;
    
    

    
    void Start()
    {
        InvokeRepeating("ManageEnemy", 1, 1.5f);
    }

    void ManageEnemy()
    {
        int spawnCount = Random.Range(0, spawnEnemy.Length);
        float spawnLocationCount = Random.Range(-15, 15);
        Instantiate(spawnEnemy[spawnCount], new Vector3(spawnLocationCount, 0, 20), spawnEnemy[spawnCount].transform.rotation);

    }
}
