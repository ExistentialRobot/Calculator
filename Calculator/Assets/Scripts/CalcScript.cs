using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour {

    public Text equationLine;
    public string valueX;
    public string valueY;
    public string equation;
    public string mathOp;
    public float x;
    public float y;
    public float z;
    public bool math = false;
    public int score;

    public void EqualsButton()
    {
        if (math)
        {
            float.TryParse(valueX, out x);
            float.TryParse(valueY, out y);
            switch (mathOp)
            {
                case " + ":
                    z = x + y;
                    break;
                case " - ":
                    z = x - y;
                    break;
                case " * ":
                    z = x * y;
                    break;
                case " / ":
                    z = x / y;
                    break;
            }
        }
        equationLine.text = valueX + mathOp + valueY + " = " + z.ToString();
        valueX = null;
        valueY = null;
        math = false;
    }
    public void ClearButton()
    {
        valueX = null;
        valueY = null;
        mathOp = null;
        math = false;
        equationLine.text = "0";
    }
}
