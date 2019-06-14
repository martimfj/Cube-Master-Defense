using UnityEngine.UI;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    void Update()
    {
        scoreText.text = PlayerStats.Score.ToString();
    }
}
