
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // 始める位置変数　-- Starting position variable
    private Vector3 startPos;

    // 繰り返す幅 -- Repeating Width
    private float repeatWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        // 始める位置設定　-- Set up starting position
        startPos = transform.position;
        // 繰り返す幅設定　-- Setup repeat width
        repeatWidth = GetComponent<BoxCollider>().size.x / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {   
            // 繰り返す背景　-- Repeat the background
            transform.position = startPos;
        }
    }
}
