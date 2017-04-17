using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroids : MonoBehaviour {

    public Image astroid;
    public CalcScript blaster;
    public int numAstroid;
    public float astroidPosition = 0;
    public Vector3 placer;
    public Text number;

    void Start ()
    {
        numAstroid = Random.Range(1, 20);
        number.text = numAstroid.ToString();
        blaster.nums.Add(number);
    }

    void Update()
    {
        if (blaster.z == numAstroid)
        {
            Text.Destroy(number);
            blaster.nums.Remove(number);

        } 
	}
}
