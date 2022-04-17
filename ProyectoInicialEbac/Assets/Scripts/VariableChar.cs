using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableChar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = 'k';
        int ValorEntero = 0;
        if (!int.TryParse(c.ToString(), out ValorEntero))
        {
            Debug.LogError("Eso no es un tipo de dato válido");
        }
        Debug.Log(ValorEntero);

        char miCaracter;
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.ToUpper();
        string tercerString = miString + " " + miSegundoString;
        string ejemploEscape = "C://Users//Gian//Documents";
        string miNombre = "Gianluca";
        string misApellidos = "de la Rosa Bandini";
        string salidasuma = "Mi nombre es" + miNombre + "Y mis apellidos son" + misApellidos;
        string salida = $"Mi nombre es {miNombre} Y mis apellidos son {misApellidos}";
        miCaracter = miString[3];
        int longitud = miString.Length;
        Debug.Log(miCaracter);
        Debug.Log(miSegundoString);
        Debug.Log(tercerString);
        Debug.Log(ejemploEscape);
        Debug.Log(salida);
        Debug.Log(salidasuma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
