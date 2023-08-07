using TMPro;
using UnityEngine;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestscoreText;
     

    public void PLayerLose()
    {
        int score = ScoreManager.Instance.score;
        scoreText.text = ScoreManager.Instance.score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");

        if (score > bestScore) { bestScore = score; }

        bestscoreText.text=bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
