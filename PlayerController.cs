using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ユーザーの入力宣言
    private float horizontalInput = 0.0f;
    // 速度宣言
    public float speed = 0.0f;
    // 範囲制限 -- Range limit
    public float xRange = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        // プレイヤーがゲームエリアの外に出ないようになる -- Prevent player from going out of bound
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // ユーザーの入力を受け取る
        horizontalInput = Input.GetAxis("Horizontal");
        // プレイヤーを動かす
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
