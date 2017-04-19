using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroids : MonoBehaviour {

    public CalcScript breaker;
    public int numAstroid;
    public Text number;
    public GameObject astroid;
    public Text gameOver;


    void Start ()
    {

        numAstroid = Random.Range(1, 20);
        number.text = numAstroid.ToString();
    }

    void Update()
    {
        if (breaker.z == numAstroid)
        {
            GameObject.Destroy(astroid);
        }     
	}
    private void OnCollision2DEnter(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            print("gameOver");
            gameOver.text = "GAME OVER";
        }
    } 
}
