using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 動物の配列
    public GameObject[] animalPrefabs;

    // ランダム範囲 -- Randomize range
    public float randomRangeX = 20.0f;
    public float randomRangeZ = 20.0f;

    // 生成の初めて時　-- Spawn start time
    public float spawnTime = 2.0f;
    // 生成間隔　-- Spawn interval
    public float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 一定間隔でランダム動物を生成　-- Random Animal Spawn at interval
        InvokeRepeating("SpawnAnimal", spawnTime, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimal()
    {
        // ランダムを選択した場合
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // 生成地点　-- Spawn Point
        Vector3 spawnPoint = new Vector3(Random.Range(-randomRangeX, randomRangeX), 0.0f, randomRangeZ);
        // 動物を生成
        Instantiate(animalPrefabs[animalIndex], spawnPoint, animalPrefabs[animalIndex].transform.rotation);
    }
}
