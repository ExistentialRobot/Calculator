using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsExtended : MonoBehaviour {

    public Text result;
    public string value1 = null;
    public string value2 = null;
    public string mathOperator = null;
    public float x;
    public float y;
    public float answer;
    public bool math = false;

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
    public void OneButton()
    {
        switch (math)
        {
            case true:
                value2 += "1";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "1";
                result.text = value1;
                break;
        }
    }
    public void TwoButton()
    {
        switch (math)
        {
            case true:
                value2 += "2";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "2";
                result.text = value1;
                break;
        }
    }
    public void ThreeButton()
    {
        switch (math)
        {
            case true:
                value2 += "3";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "3";
                result.text = value1;
                break;
        }
    }
    public void FourButton()
    {
        switch (math)
        {
            case true:
                value2 += "4";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "4";
                result.text = value1;
                break;
        }
    }
    public void FiveButton()
    {
        switch (math)
        {
            case true:
                value2 += "5";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "5";
                result.text = value1;
                break;
        }
    }
    public void SixButton()
    {
        switch (math)
        {
            case true:
                value2 += "6";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "6";
                result.text = value1;
                break;
        }
    }
    public void SevenButton()
    {
        switch (math)
        {
            case true:
                value2 += "7";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "7";
                result.text = value1;
                break;
        }
    }
    public void EightButton()
    {
        switch (math)
        {
            case true:
                value2 += "8";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "8";
                result.text = value1;
                break;
        }
    }
    public void NineButton()
    {
        switch (math)
        {
            case true:
                value2 += "9";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "9";
                result.text = value1;
                break;
        }
    }
    public void ZeroButton()
    {
        switch (math)
        {
            case true:
                value2 += "0";
                result.text = value1 + mathOperator + value2;
                break;
            default:
                value1 += "0";
                result.text = value1;
                break;
        }
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
