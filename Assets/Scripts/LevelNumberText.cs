using TMPro;
using UnityEngine;

public class LevelNumberText : MonoBehaviour
{
    public TextMeshProUGUI TextCurrentLevel;
    public TextMeshProUGUI TextNextLevel;

    public Game Game;

    private void Start()
    {
        TextCurrentLevel.text = (Game.LevelIndex + 1).ToString();
        TextNextLevel.text = (Game.LevelIndex + 2).ToString();
    }
}
