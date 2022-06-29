using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int WaveCounter = 5;
    private float WaveTime = 0f;
    //public Transform SpawnPoint;
    public GameObject[] SpawnPoints;
    public GameObject SpawnPoint;
    public GameObject Enemy;
    public GameObject RangedEnemy;



    private void Start()
    {
        SpawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    private void Update()
    {
        if (WaveTime >= 5f && WaveCounter != 0)
        {
            StartCoroutine(SpawnEnemies());
            WaveTime = 0f;
            WaveCounter--;
        }

        WaveTime += Time.deltaTime;


    }

    IEnumerator SpawnEnemies()
    {
        if (WaveCounter == 5)
        {
            for (int i = 0; i < 5; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(2f);

            }
        }
        else if (WaveCounter == 4)
        {
            for (int i = 0; i < 3; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }
            for (int i = 0; i < 3; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }
        }
        else if (WaveCounter == 3)
        {
            for (int i = 0; i < 5; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }
            for (int i = 0; i < 5; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }
        }
        else if (WaveCounter == 2)
        {
            for (int i = 0; i < 3; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }
            for (int i = 0; i < 5; i++)
            {
                SpawnEnemy();
                SpawnRangedEnemy();
                yield return new WaitForSeconds(1f);
            }
            for (int i = 0; i < 5; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }

        }
        else if (WaveCounter == 1)
        {
            for (int i = 0; i < 7; i++)
            {
                SpawnEnemy();
                SpawnRangedEnemy();
                yield return new WaitForSeconds(1f);
            }


        }

    }


    void SpawnEnemy()
    {
        Transform SpawnPoint = SpawnPoints[Random.Range(0, SpawnPoints.Length)].transform;

        Instantiate(Enemy, SpawnPoint.position, Quaternion.Euler(0, 0, 0));
    }

    void SpawnRangedEnemy()
    {
        Transform SpawnPoint = SpawnPoints[Random.Range(0, SpawnPoints.Length)].transform;

        Instantiate(RangedEnemy, SpawnPoint.position, Quaternion.Euler(0, 0, 0));
    }
}
