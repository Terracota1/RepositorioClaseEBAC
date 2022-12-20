using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clases : MonoBehaviour
{
    //Para funcionar un MonoBehavior necesita estar en un game object
    /// <summary>
    /// Campos
    /// </summary>
    public float campo1;
    private bool campo2;
    protected float campo3 = 5;
    public float campo4 = 4;

    /// <summary>
    /// Funciones de unity
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        campo1 = SumaFlotantes(campo3, campo4);
        Debug.Log(campo1);
        VuelveCeroAlNumero(out campo1);
        Debug.Log(campo1);
        ClaseNormal miclase = new ClaseNormal(campo3, campo4);
        campo1 = miclase.sumarFlotantes(campo3, campo4);
        Debug.Log(campo1);
        campo1 = ClaseNormal.MultiplicarFlotantes(campo3, campo4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Funciones propias
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    
    private float SumaFlotantes (float a, float b)
    {
        return a + b;
    }

    protected void VuelveCeroAlNumero (out float numero)
    {
        numero = 0;
    }

    /// <summary>
    /// propiedades
    /// </summary>
    
    public int propiedad1 { get; set; }
    public bool propiedad2 { get; set; }
    public float propiedadSoloLectura { get; }
}
