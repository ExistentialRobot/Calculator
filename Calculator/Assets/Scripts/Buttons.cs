using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    public InputField num1;
    public InputField num2;  
    public Text result;
    public string value1 = null;
    public string value2 = null;
    public string mathOperator = null;
    public float x;
    public float y;
    public float answer;

    public void value()
    {
        value1 = num1.text;
        value2 = num2.text;
        float.TryParse(value1, out x);
        float.TryParse(value2, out y);
        if (value2 != null && mathOperator != null && value2 != null)
        {
            result.text = value1 + mathOperator + value2;
        }
    }

    public void PlusButton()
    {
        mathOperator = " + ";
        result.text = value1 + mathOperator;
    }
    public void MinusButtton()
    {
        mathOperator = " - ";
        result.text = value1 + mathOperator;
    }
    public void MultiplyButton()
    {
        mathOperator = " * ";
        result.text = value1 + mathOperator;
    }
    public void DivideButton()
    {
        mathOperator = " / ";
        result.text = value1 + mathOperator;
    }
    public void EqualsButton()
    {
        if (mathOperator != null)
        {
            switch (mathOperator)
            {
                case " + ":
                    answer = x + y;
                    break;
                case " - ":
                    answer = x - y;
                    break;
                case " * ":
                    answer = x * y;
                    break;
                case " / ":
                    answer = x / y;
                    break;
            }
        }
        result.text = value1 + mathOperator + value2 + " = " + answer.ToString();
        print(answer);
    }
    public void ClearButton()
    {
        result.text = null;
        mathOperator = null;
        num1.text = null;
        num2.text = null;
    }

}
