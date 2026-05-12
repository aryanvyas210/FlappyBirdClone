using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PointSystem : MonoBehaviour
{
    public int playerScore;
    public Text pointScore;
    public GameObject gameOverScreen;


    public void addScore(int ScoreToAdd)
    {
        playerScore = playerScore + ScoreToAdd;
        pointScore.text = playerScore.ToString();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
