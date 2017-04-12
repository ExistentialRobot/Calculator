using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsExtended : MonoBehaviour {

    public Text result;
    public string value1 = null;
    public string value2 = null;
    public string num = null;
    public string mathOperator = null;
    public float x;
    public float y;
    public float answer;
    public bool math = false;
    public List<Button> numPad;

    public void PlusButton()
    {
        mathOperator = " + ";
        math = true;
        result.text = value1 + mathOperator;
    }
    public void MinusButtton()
    {
        mathOperator = " - ";
        math = true;
        result.text = value1 + mathOperator;
    }
    public void MultiplyButton()
    {
        mathOperator = " * ";
        math = true;
        result.text = value1 + mathOperator;
    }
    public void DivideButton()
    {
        mathOperator = " / ";
        math = true;
        result.text = value1 + mathOperator;
    }
    public void ValueChange()
    {
        switch (math)
            {
                case true:
                    num = null;
                    value2 += num;
                    result.text = value1 + mathOperator + value2;
                    break;
                default:
                    value1 += num;
                    result.text = value1;
                    break;
            }
    }
   public void NumberButtons()
    {

    }
    public void EqualsButton()
    {
        if (mathOperator != null)
        {
            float.TryParse(value1, out x);
            float.TryParse(value2, out y);
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
        string solution = value1 + mathOperator + value2 + " = " + answer.ToString();
        result.text = solution;
        print(answer);
        value1 = null;
        value2 = null;
        math = false;
    }
    public void ClearButton()
    {
        result.text = null;
        mathOperator = null;
        value1 = null;
        value2 = null;
        math = false;
    }
}
