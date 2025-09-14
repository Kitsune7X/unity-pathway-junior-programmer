using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    public int player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (player == 1)
        {
            // プレイヤーから横方向の入力を取得 -- Get Horizontal Input from player
            horizontalInput = Input.GetAxis("1P Horizontal");
            // プレイヤーから前後方向の入力を取得 -- Get Vertical Input from player
            forwardInput = Input.GetAxis("1P Vertical");
            // 車を前方向に移動させる -- Move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            // 車を旋回させる -- Turn the vehicle
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
            // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        }
        else if (player == 2)
        {
            // プレイヤーから横方向の入力を取得 -- Get Horizontal Input from player
            horizontalInput = Input.GetAxis("2P Horizontal");
            // プレイヤーから前後方向の入力を取得 -- Get Vertical Input from player
            forwardInput = Input.GetAxis("2P Vertical");
            // 車を前方向に移動させる -- Move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            // 車を旋回させる -- Turn the vehicle
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
            // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        }

    }
}
