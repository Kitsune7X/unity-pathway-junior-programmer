using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{

    // 初めてのHP -- Starting HP
    public int lives = 3;
    // 初めてのスコア -- Starting Score
    private int score = 0;
    public TextMeshProUGUI HP;
    public TextMeshProUGUI Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // HPとスコア表示
        Debug.Log($"--- Lives: {lives} -- Scores: {score}");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Add Score function
    public void AddScore()
    {
        // スコア加算
        score++;
        UpdateScoreUI();
        Debug.Log($"--- Lives: {lives} -- Scores: {score}");
    }

    // HP reduce function
    public void HPreduce()
    {
        if (lives > 0)
        {
            lives--;
            UpdateHPUI();
            Debug.Log($"--- Lives: {lives} -- Scores: {score}");
        }
        else if (lives <= 0)
        {
            Debug.Log("Game Over!");
        }

    }

    public void UpdateHPUI()
    {
        HP.text = "Lives: " + lives;
    }

    public void UpdateScoreUI()
    {
        Score.text = "Score: " + score;
    }
}
