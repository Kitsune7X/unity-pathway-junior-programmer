using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    // 回転速度設定　-- Set Spin!!!! speed
    public float spin = 0.0f;

    // 色ランダムスイッチ -- Color randomize switch
    public bool randomizeColor = false;
    // ランダム色範囲　-- Randomize color range
    public Color colorStartRange = new Color(0.0f, 0.0f, 0.0f);
    public Color colorEndRange = new Color(255.0f, 255.0f, 255.0f);

    // ランダム色変数 -- Random Color variable
    private Color randomColor;

    // 色ランダム間隔　-- Color randomize interval
    public float randomInterval = 2.0f;

    // タイマー -- Timer
    private float timer = 0.0f;

    // Scale 値
    public float scaleValue = 1.0f;

    // Scale 間隔 -- Scale interval
    public float scaleInterval = 2.0f;

    // Scale ランダムスイッチ
    public bool sizeRandomize = false;

    // マテリアル設定
    Material material;

    void Start()
    {
        //transform.position = new Vector3(3, 4, 1);
        //transform.localScale = Vector3.one * 1.3f;

        material = GetComponent<Renderer>().material;

        // material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        UpdateRandomColor();
    }

    void Update()
    {
        // Spin!!!!
        transform.Rotate(spin * Time.deltaTime, 0.0f, 0.0f);
        // ランダム色設定
        if (randomizeColor)
        {
            timer += Time.deltaTime;
            if (timer >= randomInterval)
            {
                UpdateRandomColor();
                // タイマーをリセット -- Reset Timer
                timer = 0.0f;
            }
        }

        // Scale 設定
        if (sizeRandomize)
        {
            timer += Time.deltaTime;
            if (timer >= scaleInterval)
            {
                SizeRandomize();
                timer = 0.0f;
            }
        }

    }

    void UpdateRandomColor()
    {
        randomColor = new Color(
                Random.Range(colorStartRange.r, colorEndRange.r),
                Random.Range(colorStartRange.g, colorEndRange.g),
                Random.Range(colorStartRange.b, colorEndRange.b)
                );

        material.color = randomColor;
    }

    void SizeRandomize()
    {
        transform.localScale = Vector3.one * Random.Range(0.0f, scaleValue);
    }
}