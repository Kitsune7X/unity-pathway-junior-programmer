using UnityEngine;

public class MovingFoward : MonoBehaviour
{
    // 速度変数
    public float speed = 0.0f;    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {          
        // 物を前に動かす。
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
