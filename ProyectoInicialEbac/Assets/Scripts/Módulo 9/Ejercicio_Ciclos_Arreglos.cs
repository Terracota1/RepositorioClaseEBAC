using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_Ciclos_Arreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Ejercicio 1
        int a = 0;
        int b = 10;

        int[] Arreglo_Unidimensional = new int[5] { 0, 0, 0, 0, 0 };
        for (int j = 0; j < Arreglo_Unidimensional.GetLength(0); j++)
        {
            Arreglo_Unidimensional[j] = Random.Range(a, b);
            Debug.Log(Arreglo_Unidimensional[j]);
        }

        int[] Arreglo_Unidimensional_2 = new int[5] { 0, 0, 0, 0, 0 };
        for (int j = 0; j < Arreglo_Unidimensional_2.GetLength(0); j++)
        {
            Arreglo_Unidimensional_2[j] = Random.Range(a, b);
            Debug.Log(Arreglo_Unidimensional_2[j]);
        }

        int[] Arreglo_Unidimensional_3 = new int[5] { 0, 0, 0, 0, 0 };
        for (int j = 0; j < Arreglo_Unidimensional_3.GetLength(0); j++)
        {
            Arreglo_Unidimensional_3[j] = Arreglo_Unidimensional[j] + Arreglo_Unidimensional_2[j];
            Debug.Log(Arreglo_Unidimensional_3[j]);
        }


        //Ejercicio 2
        string[] Oración = new string[5] { "Hoy", "Es", "Un", "Bonito", "Día" };
        foreach (string palabra in Oración)
        {
            Debug.Log(palabra);
        }
        Debug.Log(Oración[0] + " " + Oración[1] + " " + Oración[2] + " " + Oración[3] + " " + Oración[4]);


        //Ejercicio 3
        int[,] Matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] Arreglo = new int[3] { 7, 8, 9 };
        int[] Operaciones = new int[3] { 0, 0, 0 };
        int[] Resultado = new int[2] { 0, 0 };
        int i = 0;

        for (int j = 0; j <= Matriz.GetLength(0); j++)
        {
            Operaciones[i] = Matriz[0, j] * Arreglo[j];
            i++;
        }

        int o = 0;
        Resultado[o] = Operaciones[0] + Operaciones[1] + Operaciones[2];
        Operaciones = new int[3];
        i = 0;

        for (int j = 0; j <= Matriz.GetLength(0); j++)
        {
            Operaciones[i] = Matriz[1, j] * Arreglo[j];
            i++;
        }

        o++;
        Resultado[o] = Operaciones[0] + Operaciones[1] + Operaciones[2];
        foreach (int numero in Resultado)
        {
            Debug.Log(numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
