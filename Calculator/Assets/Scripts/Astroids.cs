using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astroids : MonoBehaviour {

    public GameObject astroid;
    public CalcScript blaster;
    public int numAstroid;
    public float astroidPosition = 0;
    public Vector3 placer;

    void Start ()
    {
        numAstroid = Random.Range(1, 20);
        astroidPosition = Random.Range(-5.0f, 5.0f);
        placer.Set(astroidPosition, 6.5f, 0f);
        astroid.transform.position = placer;
        print(numAstroid);
    }

	void Update ()
    {
        if (blaster.z == numAstroid)
        {
            Instantiate(astroid);
            GameObject.Destroy(astroid);     
        }   
	}
}
