using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idioma_Game : MonoBehaviour
{
    //Idiomas
    [SerializeField] GameObject Rango;
    [SerializeField] GameObject Rango_Ing;
    [SerializeField] GameObject From;
    [SerializeField] GameObject From_Ing;
    [SerializeField] GameObject To;
    [SerializeField] GameObject To_Ing;
    [SerializeField] GameObject PickNumber;
    [SerializeField] GameObject PickNumber_Ing;
    [SerializeField] GameObject Listo;
    [SerializeField] GameObject Listo_Ing;
    [SerializeField] GameObject Listo_Si;
    [SerializeField] GameObject Listo_Si_Ing;
    [SerializeField] GameObject Español;
    [SerializeField] GameObject Español_Ing;
    [SerializeField] GameObject Ingles;
    [SerializeField] GameObject Ingles_Ing;

    void Start()
    {
        Rango.SetActive(true);
        Rango_Ing.SetActive(false);
        From.SetActive(true);
        From_Ing.SetActive(false);
        To.SetActive(true);
        To_Ing.SetActive(false);
        PickNumber.SetActive(true);
        PickNumber_Ing.SetActive(false);
        Listo.SetActive(true);
        Listo_Ing.SetActive(false);
        Listo_Si.SetActive(true);
        Listo_Si_Ing.SetActive(false);
        Español.SetActive(true);
        Español_Ing.SetActive(false);
        Ingles.SetActive(true);
        Ingles_Ing.SetActive(false);
    }

    public void ingles()
    {
        Rango.SetActive(false);
        Rango_Ing.SetActive(true);
        From.SetActive(false);
        From_Ing.SetActive(true);
        To.SetActive(false);
        To_Ing.SetActive(true);
        PickNumber.SetActive(false);
        PickNumber_Ing.SetActive(true);
        Listo.SetActive(false);
        Listo_Ing.SetActive(true);
        Listo_Si.SetActive(false);
        Listo_Si_Ing.SetActive(true);
        Español.SetActive(false);
        Español_Ing.SetActive(true);
        Ingles.SetActive(false);
        Ingles_Ing.SetActive(true);
    }

    public void español()
    {
        Rango.SetActive(true);
        Rango_Ing.SetActive(false);
        From.SetActive(true);
        From_Ing.SetActive(false);
        To.SetActive(true);
        To_Ing.SetActive(false);
        PickNumber.SetActive(true);
        PickNumber_Ing.SetActive(false);
        Listo.SetActive(true);
        Listo_Ing.SetActive(false);
        Listo_Si.SetActive(true);
        Listo_Si_Ing.SetActive(false);
        Español.SetActive(true);
        Español_Ing.SetActive(false);
        Ingles.SetActive(true);
        Ingles_Ing.SetActive(false);
    }
}
