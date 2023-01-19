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
        int tama�o_1 = Random.Range(1, 10);
        int rangoSuperior_1 = Random.Range(5, 10);
        int rangoInferior_1 = Random.Range(0, 4);

        ListaNumeros = ListaNumerosEnteros(tama�o_1, rangoSuperior_1, rangoInferior_1);

        //Ejercicio 2:
        ArreglosDescendentes();

        //Ejercicio 3:
        int cantidad_de_n�meros = 20;

        HashetSinElementosRepetidos(cantidad_de_n�meros);

        //Ejercicio 4
        int cantidad_de_nombres = 8;

        PilaStrings.Push("Amaranta");
        PilaStrings.Push("Beto");
        PilaStrings.Push("Carla");
        PilaStrings.Push("Diego");
        PilaStrings.Push("Estefan�a");
        PilaStrings.Push("Fernando");
        PilaStrings.Push("Gabriela");
        PilaStrings.Push("Harry");

        PilaColaStrings(cantidad_de_nombres);
    }




    // Update is called once per frame
    void Update()
    {
        
    }

    //Ejercicio 1:
    public List<int> ListaNumerosEnteros(int tama�o, int rangoSuperior, int rangoInferior)
    {

        List<int> ListaDeLosN�meros = new List<int>();

        for (int controlador = 0; controlador < tama�o; controlador++)
        {
            ListaDeLosN�meros.Add(Random.Range(rangoInferior, rangoSuperior));
        }

        Debug.Log("El tama�o es: " + tama�o);
        Debug.Log("El rango inferior es: " + rangoInferior);
        Debug.Log("El rango superior es: " + rangoSuperior);

        foreach (var numero in ListaDeLosN�meros)
        {
            Debug.Log(numero);
        }

        return ListaDeLosN�meros;

    }

    //Ejercicio 2:
    public void ArreglosDescendentes()
    {
        ListaNumeros.Sort();
        ListaNumeros.Reverse();
        foreach (var numero in ListaNumeros)
        {
            Debug.Log(numero);
        }
    }

    //Ejercicio 3:
    public void HashetSinElementosRepetidos(int cantidad_de_numeros)
    { 
        for (int numerosaleatorios = 0; numerosaleatorios < cantidad_de_numeros; numerosaleatorios++)
        {
            ListaNumerosRepetidos.Add(Random.Range(0, 5));
        }

        HashSet<int> hashSetInts = new HashSet<int>(ListaNumerosRepetidos);

        foreach (var numero in hashSetInts)
        {
            Debug.Log(numero);
        }
    }

    //Ejercicio 4
    public void PilaColaStrings(int cantidad_de_nombres)
    {
        for (int controlador = 0; controlador < cantidad_de_nombres; controlador++)
        {
            Debug.Log(PilaStrings.Peek());
            ColaStrings.Enqueue(PilaStrings.Peek());
            PilaStrings.Pop();
        }

        for (int controlador = 0; controlador < cantidad_de_nombres; controlador++)
        {
            Debug.Log(ColaStrings.Peek());
            ColaStrings.Dequeue();
        }
    }

}
