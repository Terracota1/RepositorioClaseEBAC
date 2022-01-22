using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        if (variable1 && true) 
        {
            Debug.Log("Esta variable es verdadera");
            Debug.Log("Ya tienes el valor de la variable1");
        }
        else
        {
            Debug.Log("La operación dio resultado Falso");
        }
        if (valor1 <= 5)
        {
            Debug.Log("El valor de la variable es menor o igual a 5");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
