using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteinferior = -5;
    int limitesuperior = 5;

    // A B C    OR  AND ((A or B) and C)
    // 1 1 1    1   1   1
    // 1 1 0    1   1   0
    // 1 0 1    1   0   1
    // 1 0 0    1   0   0
    // 0 1 1    1   0   1
    // 0 1 0    1   0   0
    // 0 0 1    0   0   0
    // 0 0 0    0   0   0


    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
    }

    // and aqu� es &&
    // or aqu� es ||
    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La operaci�n 1 es verdadera");
        }
        else if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("La variable 1 es la verdadera");
            }
            Debug.Log("La operaci�n 2 es verdadera");
        }
        else if ((variable3 && variable2) || variable1)
        {
            Debug.Log("La operaci�n 3 es verdadera");
        }
        valor1 = Random.Range(limiteinferior, limitesuperior);
        Debug.Log(valor1);
        //if (valor1 >= 0)
        //{
        //    Debug.Log("El valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("El valor es negativo");
        //}
        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo";
        Debug.Log(resultado);
        //switch (valor1)
        //{
        //    case (int)SeleccionColor.rojo:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    case (int)SeleccionColor.verde:
        //        Debug.Log("El color seleccionado es verde");
        //        break;
        //    case (int)SeleccionColor.azul:
        //        Debug.Log("El color seleccionado es azul");
        //        break;
        //    case (int)SeleccionColor.blanco:
        //        Debug.Log("El color seleccionado es blanco");
        //        break;
        //    case (int)SeleccionColor.gris:
        //        Debug.Log("El color seleccionado es gris");
        //        break;
        //    default:
        //        Debug.Log("Ese no es un color v�lido");
        //        break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
