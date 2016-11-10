using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private GameObject gameOverPanel;

    private int score;
    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreText.text = score.ToString();
        }
    }
    public bool IsGameOver { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        IsGameOver = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Scene");
    }
}
