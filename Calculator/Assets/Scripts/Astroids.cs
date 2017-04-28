using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroids : MonoBehaviour {

    public int numAstroid;
    public Text number;
    public Text scoreCount;
    public CalcScript values;
    public Image astroid;
    public Vector3 placer;
    public Vector3 spawn;
    public Collision coll;

    void Start()
    {   
        numAstroid = Random.Range(1, 20);
        number.text = numAstroid.ToString();
        Time.timeScale = 0f;
    }

    void Update()
    {
        scoreCount.text = values.score.ToString();
        if (values.z == numAstroid)
        {
            astroid.transform.localPosition = spawn;
            numAstroid = Random.Range(1, 20);
            number.text = numAstroid.ToString();
            switch (values.mathOp)
            {
                case " + ":
                    values.score++;
                    break;
                case " - ":
                    values.score += 2;
                    break;
                case " * ":
                    values.score += 3;
                    break;
                case " / ":
                    values.score += 4;
                    break;
            }
        }
    }

    public void Restart()
    {
        coll.gameOverScene.SetActive(false);
        astroid.transform.localPosition = placer;
        values.score = 0;
        values.scoreCount.text = values.score.ToString();
        Time.timeScale = 1f;
    }
}
