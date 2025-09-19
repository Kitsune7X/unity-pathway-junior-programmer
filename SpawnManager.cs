using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //　ゲームオブジェクト参照 -- Reference Game Object
    public GameObject obstaclePrefab;

    // 生成の位置 -- Spawn location
    private Vector3 spawnPos = new Vector3(25.0f, 0.0f, 0.0f);

    // 始める時 -- Start time
    public float startTimer = 2.0f;
    
    // 生成間隔　-- Spawn Interval
    public float spawnInterval = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ランダムな間隔オブジェクトを生成
        InvokeRepeating(nameof(SpawnObject), startTimer, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // オブジェクト生成関数　-- Create object function
    void SpawnObject()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
