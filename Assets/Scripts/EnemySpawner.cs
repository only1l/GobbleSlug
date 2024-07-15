using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;
    public GameObject enemyPrefab;
    public float spawnRate = 10.0f;

    private void Start()
    {
        spawnAreaMin = GetComponent<Collider>().bounds.min;
        spawnAreaMax = GetComponent<Collider>().bounds.max;
        InvokeRepeating("SpawnEnemy", 0.0f, spawnRate);
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(
                    Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                    Random.Range(spawnAreaMin.y, spawnAreaMax.y),
                    Random.Range(spawnAreaMin.z, spawnAreaMax.z)
                );
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}