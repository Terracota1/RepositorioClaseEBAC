using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_While_Do_While : MonoBehaviour
{
    // for                => Sabemos cuantas veces vamos a repetirlo
    // while              => No sabemos cuantas veces vamos a repetir el ciclo
    // do while           => Al menos una vez si se ejecutará
    // arreglos           => [1,2,3,4]
    // arreglos multidimensionales
    //                       [1,2,3,4]
    //                       [5,6,7,8]
    // arreglos jagged
    //                       [1,2,3,4]
    //                       [5,6]
    //                       [8,9,10]
    // Los datos de un arreglo no pueden ser modificados de golpe, para eso se necesitaria volver a poner "new". Pero lo que si se puede es irlos modificando uno por uno.
    // for each
    //int contador = 0;
    // Start is called before the first frame update
    void Start()
    {

            //int[] miArreglo = new int[5];
            int[] miArreglo = new int[7];
            string[] diasSemana = new string[7] { "Montag", "Dinnerstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
            //Debug.Log(diasSemana[0]);
            //Debug.Log(diasSemana[1]);
            //Debug.Log(diasSemana[2]);
            //Debug.Log(diasSemana[3]);
            //Debug.Log(diasSemana[4]);
            //Debug.Log(diasSemana[5]);
            //Debug.Log(diasSemana[6]);

            for (int i = 0; i < diasSemana.Length; i++)
            {
                miArreglo[i] = i + 1;
                Debug.Log(diasSemana[i]);
            }

            foreach (int i in miArreglo)
            {
                Debug.Log(i);
            }
            foreach (string dia in diasSemana)
            {
                Debug.Log(dia);
            }

        //int[,] miMatriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //for (int j = 0; j < miMatriz.GetLength(0); j++)
        //{
        //    for (int k = 0; k < miMatriz.GetLength(0); k++)
        //    {
        //        miMatriz[j, k] += 1;
        //        Debug.Log(miMatriz[j, k]);
        //    }
        //}

        //int[][] miArregloJagged = new int[][]
        //{
        //    new int []{1,2,3},
        //    new int []{4,5},
        //    new int []{6,7,8,9}
        //};
        //miArregloJagged[1] = new int[] { 10, 11, 12, 13 };

        //Debug.Log(miArregloJagged[0][1]);
        //for (int x = 0; x < miArregloJagged.Length; x++)
        //{
        //    for (int y = 0; y < miArregloJagged[x].Length; y++)
        //    {
        //        Debug.Log(miArregloJagged[x][y]);
        //    }
        //}

        //for (int i = 10; i > 1; i--)
        //{
        //    Debug.Log(i);
        //}
        //bool miBooleano = false;
        //while (contador < 10)
        //{
        //    contador++;
        //    Debug.Log("Hola");
        //}
        //while (miBooleano)
        //{
        //    contador++;
        //    Debug.Log("Hola");
        //}
        //do
        //{
        //    Debug.Log("Hola desde el do while");
        //} while (miBooleano);
    }

    // Update is called once per frame
    void Update()
    {
    //contador++;
    //Debug.Log(contador);
}
}
