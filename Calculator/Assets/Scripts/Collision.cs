using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {

    public Text newScore;
    public CalcScript score;
    public bool restart = false;
    public GameObject canvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Astroid")
        {
            canvas.SetActive(true);
            newScore.text = "Score: " + score.score.ToString();
            print("GAMEOVER");
            Time.timeScale = 0;
        }
    }
    public void restartGame()
    {
        score.score = 0;
        restart = true;
    }
}
