using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idioma : MonoBehaviour
{
    //Idiomas
    [SerializeField] GameObject Boton_Start;
    [SerializeField] GameObject Boton_Start_Ing;
    [SerializeField] GameObject Boton_Exit;
    [SerializeField] GameObject Boton_Exit_Ing;
    [SerializeField] GameObject Boton_Ingles;
    [SerializeField] GameObject Boton_Ingles_Ing;
    [SerializeField] GameObject Boton_Español;
    [SerializeField] GameObject Boton_Español_Ing;

    void Start()
    {
        español();
    }

    public void ingles()
    {
        this.Boton_Start.SetActive(false);
        this.Boton_Start_Ing.SetActive(true);
        this.Boton_Exit.SetActive(false);
        this.Boton_Exit_Ing.SetActive(true);
        this.Boton_Ingles.SetActive(false);
        this.Boton_Ingles_Ing.SetActive(true);
        this.Boton_Español.SetActive(false);
        this.Boton_Español_Ing.SetActive(true);
        VariablesGlobales.idioma = "ingles";
    }

    public void español() 
    {
        this.Boton_Start.SetActive(true);
        this.Boton_Start_Ing.SetActive(false);
        this.Boton_Exit.SetActive(true);
        this.Boton_Exit_Ing.SetActive(false);
        this.Boton_Ingles.SetActive(true);
        this.Boton_Ingles_Ing.SetActive(false);
        this.Boton_Español.SetActive(true);
        this.Boton_Español_Ing.SetActive(false);
        VariablesGlobales.idioma = "español";
    }


}
