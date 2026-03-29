using TMPro;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timeText;

    public void addtoTxtScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
    public void addtoTxtTime(float time)
    {
        timeText.text = "Time: " + Mathf.FloorToInt(time).ToString();
    }
}

