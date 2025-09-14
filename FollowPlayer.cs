using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // 車（プレイヤー）を参照する -- Reference camera to the car's position
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2.2f, -6.9f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // カメラをプレイヤーの位置を固定する -- Anchor the camera to the player's position
        // カメラをプレイヤーに追従させる
        transform.position = player.transform.position + offset;
    }
}
