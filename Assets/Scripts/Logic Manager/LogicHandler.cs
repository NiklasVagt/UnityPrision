using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicHandler : MonoBehaviour
{
    public int killedEnemys;
    public TMP_Text scoreText;
    public TMP_Text gameOverScore;
    public GameObject gameOverScreen;
    public GameObject score;

    public void EnemyKilled()
    {
        killedEnemys++;
        scoreText.text = killedEnemys.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        score.SetActive(false);
        gameOverScreen.SetActive(true);
        gameOverScore.text = killedEnemys.ToString();
    }
}
