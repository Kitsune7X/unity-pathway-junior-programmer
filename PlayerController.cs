using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ユーザーの入力宣言
    private float horizontalInput = 0.0f;
    private float verticalInput = 0.0f;
    // 速度宣言
    public float speed = 0.0f;
    // 範囲制限 -- Range limit
    public float xRange = 10.0f;
    public float zRange = 13.0f;
    private float origPos = 0.0f;
    // 物を宣言する
    public GameObject projectilePrefabs;
    // オフセット値
    public float offsetValue = 0.0f;
    // オフセット   
    Vector3 offset;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // オフセット指定 -- Assign offset value
        offset = new Vector3(0.0f, offsetValue, 0.0f);
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
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z < origPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, origPos);
        }
        // ユーザー操作
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // プレイヤーを動かす
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        // 物を投げる
        if(Input.GetKeyDown(KeyCode.Space))
        {            
            Instantiate(projectilePrefabs, transform.position + offset, projectilePrefabs.transform.rotation);
        }
    }
}
