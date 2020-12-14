using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangoNumeros : MonoBehaviour
{
    
    public void minNum(GameObject num)
    {
        string text = num.GetComponent<Text>().text;
        VariablesGlobales.min = int.Parse(text);
    }
    public void maxNum(GameObject num)
    {
        string text = num.GetComponent<Text>().text;
        VariablesGlobales.max = int.Parse(text);
    }
}
