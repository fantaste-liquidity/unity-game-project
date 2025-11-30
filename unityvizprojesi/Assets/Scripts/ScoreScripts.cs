using UnityEngine;
using TMPro;

public class ScoreTimer : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private float score = 0f;

    void Update()
    {
        score += 15f * Time.deltaTime;               
        scoreText.text = "SKOR: " + Mathf.FloorToInt(score);
    }
}
