using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EstructuraDeDatos : MonoBehaviour
{
    List<int> ListaNumeros = new List<int>();
    List<string> ListaStrings = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>();
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();
    // Start is called before the first frame update
    void Start()
    {
        DemoDictionary("escopeta");
        DemoDictionary("espada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DemoListas()
    {
        for (int i = 0; i < 20; i++)
        {
            ListaNumeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in ListaNumeros)
        {
            Debug.Log(numero);
        }
        //ListaNumeros.Sort();
        var listaOrdenada = ListaNumeros.OrderBy(p => p).ToList();
        var listaConValoresGrandes = ListaNumeros.Where(p => p > 10).ToList();

        foreach (var numero in ListaNumeros)
        {
            Debug.Log(numero);
        }
        ListaStrings.Add("Diego");
        ListaStrings.Add("Sofia");
        ListaStrings.Add("Daniela");
        ListaStrings.Add("Javier");
        ListaStrings.Add("Diana");
        foreach (var nombre in ListaStrings)
        {
            Debug.Log(nombre);
        }
        ListaStrings.RemoveAt(2);
        ListaStrings.Remove("Daniel");
        foreach (var nombre in ListaStrings)
        {
            Debug.Log(nombre);
        }
    }

    public void DemoHashSet()
    {
        for (int i = 0; i < 20; i++)
        {
            hashSetInts.Add(i);
        }
        if (hashSetInts.Contains(5))
        {
            hashSetInts.Remove(5);
        }
        else
        {
            Debug.Log("El HashSet no contiene este elemento");
        }
    }
    public void DemoColas()
    {
        // First in First Out => FIFO
        colaStrings.Enqueue("Proyectil 1");
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
    }

    public void DemoPilas()
    {
        // First in Last Out => FILO
        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");

        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
    }

    public void DemoDictionary(string arma)
    {
        float temporal = 0;
        if (!poderArmas.ContainsKey("rifle"));
        {
            poderArmas.Add("rifle", 7.0f);
        }

        if (!poderArmas.ContainsKey("rifle")) ;
        {
            poderArmas.Add("pistola", 3.0f);
        }

        if (!poderArmas.ContainsKey("rifle")) ;
        {
            poderArmas.Add("escopeta", 5.0f);
        }

        if (!poderArmas.ContainsKey("rifle")) ;
        {
            poderArmas.Add("riflefrancotirador", 10.0f);
        }

        if (!poderArmas.ContainsKey("rifle")) ;
        {
            poderArmas.Add("Cuchillo", 2.0f);
        }

        Debug.Log(poderArmas["rifle"]);
        if (poderArmas.TryGetValue("escopeta", out temporal))
        {
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("El arma no existe");
        }
    }
}
