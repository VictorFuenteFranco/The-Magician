using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdivinaNumero : MonoBehaviour { 

    //Atributos de la clase
    //Min y Max
    [SerializeField] int min; 
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessOnText;
    int guess_number;
    
// Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    //Metodo que inicia las variables del juego
    void StartGame()
    {
        
    }

    void mayorNumero()
    {
        numero();
        
    }

    void menorNumero()
    {

    }

    void numero()
    {
        guess_number = (max + min) / 2;
    }
}
