using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AdivinaNumero : MonoBehaviour { 

    //Atributos de la clase
    //Min y Max
    int min; 
    int max;
    TextMeshProUGUI guessOnText;
    int guess_number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void mayorNumero()
    {
        
        
    }

    void menorNumero()
    {

    }

    void numero()
    {
        guess_number = (max + min) / 2;
    }

    public void minNum(GameObject num) { 
        string text = num.GetComponent<Text>().text;
        min = int.Parse(text);
    } 
    public void maxNum(GameObject num) {
        string text = num.GetComponent<Text>().text;
        max = int.Parse(text);
    }
}
