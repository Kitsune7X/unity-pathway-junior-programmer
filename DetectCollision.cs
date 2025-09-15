using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // GameManger参照 -- Reference GameManger Class
    private GameManger gameManager;
    // Score value
    public int scoreValue = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // オブジェクトを破壊する
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        // Adding score
        gameManager.AddScore();
    }  
}
