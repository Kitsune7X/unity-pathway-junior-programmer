using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Rigidbody 変数宣言　--  Declare Rigidbody variable
    private Rigidbody playerRb;
    // ジャンプ力　-- Jump force variable
    public float jumpForce = 10.0f;
    // 重力変更するもの　-- Gravity Modifier variable
    public float gravityModifier = 1.0f;
    // Is on ground boolean variable
    public bool isOnGround = true;
    // ゲームオーバー変数 -- Game Over variable
    public bool gameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Rigidbody コンポーネント参照 -- Reference Rigibody Component
        playerRb = GetComponent<Rigidbody>();

        // 重力設定　-- Set up Gravity
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //　スペースキーを押すとジャンプする
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    // On Ground & Game Over switch
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; // ジャンプスイッチ　-- Jump switch
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over"); 
            gameOver = true; // ゲームオーバースイッチ　-- Game Over switch
        }
    }
}
