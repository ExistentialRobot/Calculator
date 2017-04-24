using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroids : MonoBehaviour {

    public int numAstroid;
    public Text number;
    public Text gameOver;
    public CalcScript values;


    void Start()
    {     
        numAstroid = Random.Range(1, 20);
        number.text = numAstroid.ToString();
    }

    void Update()
    {
        if (values.z == numAstroid)
        {
            gameObject.transform.position.Set(-396f, 313f, 0f);
            numAstroid = Random.Range(1, 20);
            number.text = numAstroid.ToString();
        }
    }
}
