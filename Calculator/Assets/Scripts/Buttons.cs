using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    public MathOperators math;
    public InputField num1;
    public InputField num2;
    public int answer;
    public Text result;
    public string value1;
    public string value2;
    public string mathOperator = "+";

    public void value()
    {
        value1 = num1.text;
        value2 = num2.text;
        result.text = value1 + mathOperator + value2;
    }

    public void PlusButton()
    {
        mathOperator = "+";
    }
    public void MinusButtton()
    {
        mathOperator = "-";
    }
    public void MultiplyButton()
    {
        mathOperator = "*";
    }
    public void DivideButton()
    {
        mathOperator = "/";
    }
    public void EqualsButton()
    {
        int firstNumber;
        int secondNumber;
        int.TryParse(value1, out firstNumber);
        int.TryParse(value2, out secondNumber);

        switch (mathOperator)
        {
            case "+":
                answer = firstNumber += secondNumber;              
                break;
            case "-":
                answer = firstNumber -= secondNumber;
                break;
            case "*":
                answer = firstNumber *= secondNumber;
                break;
            case "/":
                answer = firstNumber /= secondNumber;
                break;
        }
        result.text = answer.ToString();
    }
}
