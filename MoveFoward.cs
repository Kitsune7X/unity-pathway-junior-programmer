using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    // 速度変数　-- Speed variable
    private float speed = 20.0f;
    // プレイヤー操作変数　-- Player controller variable
    private PlayerController playerControllerScript;
    // Range limit variable
    public float rangeLimit = -10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // プレイヤー操作スクリプト設定 -- Setup Player controller script
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            // 前に動かす -- Move the object forward
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        // オブジェクトを破壊する　-- Destroy objects out of range
        if (transform.position.x < rangeLimit && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
