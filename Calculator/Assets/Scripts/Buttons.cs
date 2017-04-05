using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    public MathOperators math;
    public InputField num1;
    public InputField num2;
    public string answer;
    public Text result;

    public void PlusButton()
    {
        math.mathOperator = "+";
    }
    public void MinusButtton()
    {
        math.mathOperator = "-";
    }
    public void MultiplyButton()
    {
        math.mathOperator = "*";
    }
    public void DivideButton()
    {
        math.mathOperator = "/";
    }
    public void EqualsButton()
    {
        print(math.mathOperator);
        result.text = num1 + math.mathOperator + num2;
        print(answer);
    }
}
