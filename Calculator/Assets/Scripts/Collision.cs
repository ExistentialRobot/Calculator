using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {

    public CalcScript score;
    public GameObject gameOverScene;
    public GameObject startScreen;
    public Text finalScore;
    public Text highScore;
    public Button equals;
    public Button clear;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Astroid")
        {
            gameOverScene.SetActive(true);
            Time.timeScale = 0f;
            finalScore.text = "SCORE: " + score.score.ToString();
                if(score.score > score.highScore)
                {
                    score.highScore = score.score;
                    PlayerPrefs.SetInt("highScore", score.highScore);
                    PlayerPrefs.Save();
            }
            highScore.text = "HIGHSCORE: " + score.highScore.ToString();     
        }
    }
    public void restartGame()
    {
        score.score = 0;
    }
    public void Begin()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Update()
    {
        if (gameOverScene.activeSelf)
        {
            clear.interactable = false;
            equals.interactable = false;
        }
        else
        {
            clear.interactable = true;
            equals.interactable = true;
        }
    }
}
