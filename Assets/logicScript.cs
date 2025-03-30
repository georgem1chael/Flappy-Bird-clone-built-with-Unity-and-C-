using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;

    private void Start(){
        score = 0;
        scoreText.text = score.ToString();
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd){
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        if(score > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "High Score: " + score.ToString();
        }
    }

    public void returnToTitle(){
        SceneManager.LoadScene("TitleScene");
    }
}
