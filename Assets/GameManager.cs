using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // シングルトンインスタンス
    public Text scoreText; // ポイント表示用のUIテキスト

    private int score = 0; // 現在のポイント

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // ポイントを初期化
        score = 0;
        UpdateScoreText();
    }

    public void AddPoints(int points)
    {
        // ポイントを加算
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        // UIテキストにポイントを表示
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
        else
        {
            Debug.LogWarning("scoreText is not assigned.");
        }
    }
}