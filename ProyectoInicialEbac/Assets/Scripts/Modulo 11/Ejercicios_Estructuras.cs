using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejercicios_Estructuras : MonoBehaviour
{
    List<int> ListaNumeros = new List<int>();
    List<int> ListaNumerosRepetidos = new List<int>();
    Stack<string> PilaStrings = new Stack<string>();
    Queue<string> ColaStrings = new Queue<string>();
    // Start is called before the first frame update
    void Start()
    {

        //Ejercicio 1:

        //int controlador = 0;
        //int tamaño = Random.Range(1, 10);
        //int rangoSuperior = Random.Range(5, 10);
        //int rangoInferior = Random.Range(0, 4);

        //Debug.Log("El tamaño es: "+ tamaño);
        //Debug.Log("El rango inferior es: " + rangoInferior);
        //Debug.Log("El rango superior es: " + rangoSuperior);


        //for (controlador = 0; controlador < tamaño; controlador++)
        //{
        //    ListaNumeros.Add(Random.Range(rangoInferior,rangoSuperior));
        //}
        //foreach (var numero in ListaNumeros)
        //{
        //    Debug.Log(numero);
        //}

        ////Ejercicio 2:

        //ListaNumeros.Sort();
        //ListaNumeros.Reverse();
        //foreach (var numero in ListaNumeros)
        //{
        //    Debug.Log(numero);
        //}

        //Ejercicio 3:

        //for (int i = 0; i < 20; i++)
        //{
        //    ListaNumerosRepetidos.Add(Random.Range(0, 5));
        //}
        //HashSet<int> hashSetInts = new HashSet<int>(ListaNumerosRepetidos);
        //foreach (var numero in hashSetInts)
        //{
        //    Debug.Log(numero);
        //}

        //Ejercicio 4

        PilaStrings.Push("Amaranta");
        PilaStrings.Push("Beto");
        PilaStrings.Push("Carla");
        PilaStrings.Push("Diego");
        PilaStrings.Push("Estefanía");
        PilaStrings.Push("Fernando");
        PilaStrings.Push("Gabriela");
        PilaStrings.Push("Harry");

        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();
        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();
        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();
        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();
        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();
        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();
        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();
        Debug.Log(PilaStrings.Peek());
        ColaStrings.Enqueue(PilaStrings.Peek());
        PilaStrings.Pop();

        Debug.Log(ColaStrings.Peek());
        ColaStrings.Dequeue();
        Debug.Log(ColaStrings.Peek());
        ColaStrings.Dequeue();
        Debug.Log(ColaStrings.Peek());
        ColaStrings.Dequeue();
        Debug.Log(ColaStrings.Peek());
        ColaStrings.Dequeue();
        Debug.Log(ColaStrings.Peek());
        ColaStrings.Dequeue();
        Debug.Log(ColaStrings.Peek());
        ColaStrings.Dequeue();
        Debug.Log(ColaStrings.Peek());
        ColaStrings.Dequeue();
        Debug.Log(ColaStrings.Peek());
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
