using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroids : MonoBehaviour {

    public int numAstroid;
    public Text number;
    public GameObject astroid;
    public Text gameOver;
    public CalcScript values;
    public float points = 0;
    public Text score;
    public float newY;
    public string mathThing;
    public float scoreCount;

    void Start ()
    {
        numAstroid = Random.Range(1, 20);
        number.text = numAstroid.ToString();
    }

    void Update()
    {
        newY = values.z;
        if (values.z == numAstroid)
        {
            astroid.SetActive(false);
        }
    }

    public void ScoreCount()
    {
        if (values.z == numAstroid)
        {
            switch (mathThing)
            {
                case " + ":
                    scoreCount = points + newY;
                    break;
                case " - ":
                    points = points + newY * 2;
                    break;
                case " * ":
                    points = points + newY * 3;
                    break;
                case " / ":
                    points = points + newY * 4;
                    break;
            }
        }
        print(points);
    }
}
