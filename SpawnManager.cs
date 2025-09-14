using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 動物の配列
    public GameObject[] animalPrefabs;
 
    // 生成地点　-- Spawn Point
    public Vector3 spawnPoint = new Vector3(0.0f, 0.0f, 0.0f);
    // ランダムスイッチ
    public bool randomize = false;
    // ランダム範囲 -- Randomize range
    public float randomRangeX = 20.0f;
    public float randomRangeZ = 20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 動物を生成する
        if (Input.GetKeyDown(KeyCode.S))
        {
            // ランダムを選択した場合
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            if (randomize)
            {
                spawnPoint = new Vector3(Random.Range(-randomRangeX, randomRangeX), 0.0f, randomRangeZ);
            }
            Instantiate(animalPrefabs[animalIndex], spawnPoint, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
