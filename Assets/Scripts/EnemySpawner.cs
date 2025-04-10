using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minimumSpawnTime;
    [SerializeField] private float maximumSpawnTime;
    [SerializeField] private int maxEnemiesAfterPlayerDies = 2;

    [SerializeField] private GameObject playerObject; 
    private playerHealth playerHealthScript;

    private float timeUntilSpawn;

    void Awake()
    {
        if (playerObject != null)
        {
            playerHealthScript = playerObject.GetComponent<playerHealth>();
        }
        SetTimeUntilSpawn();
    }

    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;

        if (timeUntilSpawn <= 0)
        {
            int currentEnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

            
            if (playerObject == null || playerHealthScript == null || !playerHealthScript.isAlive)
            {
                if (currentEnemyCount < maxEnemiesAfterPlayerDies)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                }
            }
            else
            {
                
                Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            }

            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        timeUntilSpawn = Random.Range(minimumSpawnTime, maximumSpawnTime);
    }
}
