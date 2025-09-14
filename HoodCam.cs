using UnityEngine;

public class HoodCam : MonoBehaviour
{
    // 車（プレイヤー）を参照する -- Reference camera to the car's position
    public GameObject player;
    private Vector3 offset = new Vector3(0.0f, 1.66f, 1.41f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // カメラをプレイヤーに追従させる
        transform.position = player.transform.position + offset;
    }
}
