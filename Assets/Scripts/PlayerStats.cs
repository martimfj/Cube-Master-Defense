using UnityEngine.UI;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Lives;
    public static int Score;
    public int startLives = 3;

    void Start()
    {
        Lives = startLives;
    }
}
