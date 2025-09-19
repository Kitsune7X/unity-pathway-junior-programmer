using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    // 速度変数　-- Speed variable
    private float speed = 30.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 前に動かす -- Move the object forward
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
