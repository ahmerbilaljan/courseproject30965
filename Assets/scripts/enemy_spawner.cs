using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  
    public float spawnInterval = 2f;  
    public float spawnRangeX = 8f;  
    public float spawnY = 6f;  

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);

        Vector2 spawnPosition = new Vector2(randomX, spawnY);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
