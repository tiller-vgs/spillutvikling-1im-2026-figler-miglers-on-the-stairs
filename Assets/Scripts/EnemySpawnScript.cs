using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform rightSpawnPoint;


    public int maxEnemies = 5;
    public float spawnInterval = 2f;

    private int currentEnemyCount = 0;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
        Debug.Log("Spawner started on: " + gameObject.name);
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }
    void SpawnEnemy()
    {
        if (currentEnemyCount >= maxEnemies)
        {
            CancelInvoke(nameof(SpawnEnemy));
            return;
        }

        Instantiate(enemyPrefab, rightSpawnPoint.position, Quaternion.identity);
        currentEnemyCount++;

        Debug.Log("Spawning enemy number: " + currentEnemyCount);


    }
}
