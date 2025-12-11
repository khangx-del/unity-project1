using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject startGameScreen;
   
    private void Start()
    {
        Time.timeScale = 0f;
        startGameScreen.SetActive(true);
    } 
    [ContextMenu("Increse Score")]
      public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    
    public void startButton()
    {
        Time.timeScale = 1f;
        startGameScreen.SetActive(false);
    }
    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }
}
