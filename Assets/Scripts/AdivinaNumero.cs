using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class AdivinaNumero : MonoBehaviour { 

    //Atributos de la clase
    [SerializeField] Text guessOnText;
    [SerializeField] Text intentosOnText;
    int min = VariablesGlobales.min; 
    int max = VariablesGlobales.max;
    int guess_number;
    int intentos;

    // Start is called before the first frame update
    void Start()
    {
        guess_number = Random.Range(min, max);
        guessOnText.text = "" + guess_number;
        intentos = 8;
        intentosOnText.text = "" + intentos;
    }

    void Update()
    {
        if (intentos == 0){
            SceneManager.LoadScene(4);
        }

    }

    public void mayorNumero()
    {
        min = guess_number;
        guess_number = (min + max) /2;
        guessOnText.text = "" + guess_number;
        intentos = intentos - 1;
        intentosOnText.text = "" + intentos;
    }

    public void menorNumero()
    {
        max = guess_number;
        guess_number = (min + max) / 2;
        guessOnText.text = "" + guess_number;
        intentos = intentos - 1;
        intentosOnText.text = "" + intentos;
    }
}
