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
    // プレイヤー操作変数　-- Player controller variable
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ランダムな間隔オブジェクトを生成 -- Spawn object at random interval
        InvokeRepeating(nameof(SpawnObject), startTimer, spawnInterval);
        // プレイヤー操作スクリプトゲット　-- Get Player controller script
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // オブジェクト生成関数　-- Create object function
    void SpawnObject()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
