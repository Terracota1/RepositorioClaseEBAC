using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int AumentaValorEnCadaFrame, resultado, modulo, a, b, primerapellido, segundoapellido, inicio1, inicio2, inicio3, final1, final2, final3;
    int variablemilint, variablemilint2, resultadoTryParse, fraseAcortada;
    float AumentaValorEnCadaFixedUpdate, resultado2, valor1, valor2;
    uint Operación;
    string switchcolor, número, númerofinal, nombre, nombreinicial, variabledemil1, variabledemil2, Oración2, Oración;
    char ParOración;

    enum SelecciónPalabra
    {
        par,
        impar,
    }
    Color white = Color.white;
    Color black = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        b = 2;

        AumentaValorEnCadaFrame = 0;
        AumentaValorEnCadaFixedUpdate = 1;

        valor1 = -1.93221f;
        valor2 = 3.92917432f;
        Operación = (uint)(valor1 * valor2);
        Debug.Log("El resultado de la operación es: "+ Operación);

        número = valor2.ToString();
        númerofinal = número.Substring(0, 5);
        Debug.Log("El número recortado es:" + númerofinal);

        nombre = "Gianluca de la Rosa Bandini";
        nombreinicial = nombre.Substring(0, 8);
        Debug.Log(nombreinicial);

        inicio1 = 9;
        final1 = 19;
        primerapellido = final1 - inicio1;
        Debug.Log(nombre.Substring(inicio1, primerapellido));

        inicio2 = 20;
        final2 = 27;
        segundoapellido = final2 - inicio2;
        Debug.Log(nombre.Substring(inicio2, segundoapellido));

        variabledemil1 = "1056";
        variabledemil2 = "3290";
        int.TryParse(variabledemil1, out variablemilint);
        int.TryParse(variabledemil2, out variablemilint2);
        resultadoTryParse = (variablemilint + variablemilint2);
        Debug.Log("El resultado de la suma TryParse es: " + resultadoTryParse);

        Oración2 = "Buenas noches";
        inicio3 = 5;
        final3 = 13;
        fraseAcortada = final3 - inicio3;
        Debug.Log(Oración2.Substring(inicio3, fraseAcortada));

        Oración = "Hola Mundo";
        ParOración = Oración[1];
        Debug.Log(ParOración);
        ParOración = Oración[3];
        Debug.Log(ParOración);
        ParOración = Oración[5];
        Debug.Log(ParOración);
        ParOración = Oración[7];
        Debug.Log(ParOración);
        ParOración = Oración[9];
        Debug.Log(ParOración);
    }

    // Update is called once per frame
    void Update()
    {
        resultado = AumentaValorEnCadaFrame += 1;
        Debug.Log(resultado);
    }
    private void FixedUpdate()
    {
        resultado2 = AumentaValorEnCadaFixedUpdate *= 1.5f;
        Debug.Log(resultado2);

        modulo = Random.Range(a, b);
        if (modulo % 2 == 0)
        {
            switchcolor = "par";
        }
        else
        {
            switchcolor = "impar";
        }

        switch (switchcolor)
        {
            case "par":
                EscriptCubo3.cubo3.GetComponent<MeshRenderer>().material.color = white;
                break;
            case "impar":
                EscriptCubo3.cubo3.GetComponent<MeshRenderer>().material.color = black;
                break;
        }
    }
}
