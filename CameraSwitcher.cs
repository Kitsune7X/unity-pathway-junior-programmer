using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // メインカメラ1を参照する -- Reference Main Camera 1
    public GameObject mainCamera1;
    // ボンネット視点1を参照する -- Reference Hood Camera 1
    public GameObject hoodCamera1;

    // メインカメラ2を参照する -- Reference Main Camera 2
    public GameObject mainCamera2;
    // ボンネット視点2を参照する -- Reference Hood Camera 2
    public GameObject hoodCamera2;

    // カメラ切り替え -- Camera Switcher
    private bool cameraInput1P = false;
    private bool cameraInput2P = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ゲーム開始時のデフォルトカメラ設定 -- Default Camera when starting the Game
        if (mainCamera1 != null && hoodCamera1 != null && mainCamera2 != null && hoodCamera2 != null)
        {
            mainCamera1.SetActive(true);
            hoodCamera1.SetActive(false);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーのカメラ切り替え入力
        cameraInput1P = Input.GetButtonDown("1P Camera");
        cameraInput2P = Input.GetButtonDown("2P Camera");

        // プレイヤーからの入力を受け取って切り替える -- Get Input from player to switch
        if (cameraInput1P)
        {
            mainCamera1.SetActive(!mainCamera1.activeSelf);
            hoodCamera1.SetActive(!hoodCamera1.activeSelf);
        }
        if (cameraInput2P)
        {
            mainCamera2.SetActive(!mainCamera2.activeSelf);
            hoodCamera2.SetActive(!hoodCamera2.activeSelf);
        }
    }
}
