using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {

    public Text gameOver;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Astroid")
        {
            gameOver.text = "GAME OVER";
            print("GAMEOVER");
        }
    }
}
