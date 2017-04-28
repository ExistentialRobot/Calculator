using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    public CalcScript numButtons;
    public string num;
    public Text equation;
    public Collision gameOver;
    public Button buttons;

    public void ValueChange()
    {
        switch (numButtons.math)
        {
            case true:
                numButtons.valueY += num;
                equation.text = numButtons.valueX + numButtons.mathOp + numButtons.valueY;
                break;
            default:
                numButtons.valueX += num;
                equation.text = numButtons.valueX;
                break;
        }
    }
    public void MathOperator()
    {
        numButtons.mathOp = num;
        numButtons.math = true;
        equation.text = numButtons.valueX + numButtons.mathOp;
    }
    public void Update()
    {
        if(gameOver.gameOverScene.activeSelf)
        {
            buttons.interactable = false;
        }
        else
        {
            buttons.interactable = true;
        }
    }
}
