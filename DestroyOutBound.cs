using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    // 上方向の境界範囲 -- Top Bound range
    public float topBound = 30;
    // 下方向の境界範囲 -- Low Bound range
    public float lowBound = -10;

    // GameManager参照
    private GameManger gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトを破壊する
        if (transform.position.z >= topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= lowBound)
        {
            Destroy(gameObject);
            gameManager.HPreduce();
        }
    }
}
