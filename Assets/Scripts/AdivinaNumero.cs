using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AdivinaNumero : MonoBehaviour { 

    //Atributos de la clase
    [SerializeField] Text guessOnText;
    int min = VariablesGlobales.min; 
    int max = VariablesGlobales.max;
    int guess_number;

    // Start is called before the first frame update
    void Start()
    {
        guess_number = Random.Range(min, max);
        guessOnText.text = "" + guess_number;
    }

    public void mayorNumero()
    {
        min = guess_number;
        guess_number = (min + max) /2;
        guessOnText.text = "" + guess_number;
    }

    public void menorNumero()
    {
        max = guess_number;
        guess_number = (min + max) / 2;
        guessOnText.text = "" + guess_number;
    }
}
