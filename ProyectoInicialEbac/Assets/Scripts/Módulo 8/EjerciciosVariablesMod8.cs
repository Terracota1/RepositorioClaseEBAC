using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int AumentaValorEnCadaFrame, modulo, a, b, primerapellido, segundoapellido, inicio1, inicio2, inicio3, final1, final2, final3;
    int variablemilint, variablemilint2, resultadoTryParse, fraseAcortada, posici�n, posici�n1;
    float AumentaValorEnCadaFixedUpdate, valor1, valor2;
    uint Operaci�n;
    string switchcolor, n�mero, n�merofinal, nombre, nombreinicial, variabledemil1, variabledemil2, Oraci�n2, Oraci�n;
    char ParOraci�n, PalabraPar;

    enum Selecci�nPalabra
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
        Operaci�n = (uint)(valor1 * valor2);
        Debug.Log("El resultado de la operaci�n es: "+ Operaci�n);

        n�mero = valor2.ToString();
        n�merofinal = n�mero.Substring(0, 6);
        Debug.Log("El n�mero recortado es:" + n�merofinal);

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

        string[] nombreseparado = nombre.Split(' ');
        foreach (var separaci�n in nombreseparado)
        {
            Debug.Log($"Substring: {separaci�n}");
        }

        variabledemil1 = "1056";
        variabledemil2 = "3290";
        int.TryParse(variabledemil1, out variablemilint);
        int.TryParse(variabledemil2, out variablemilint2);
        resultadoTryParse = (variablemilint + variablemilint2);
        Debug.Log("El resultado de la suma TryParse es: " + resultadoTryParse);

        posici�n1 = 0;
        Oraci�n = "Hola Mundo";
        foreach (char PalabraPar in Oraci�n)
        {
            if (posici�n1 % 2 == 0)
            {
                Debug.Log("Letras en par:" + PalabraPar);
            }
            posici�n1++;
        }


        Oraci�n2 = "Buenas noches";
        inicio3 = 5;
        final3 = 13;
        fraseAcortada = final3 - inicio3;
        Debug.Log(Oraci�n2.Substring(inicio3, fraseAcortada));

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(AumentaValorEnCadaFrame += 1);
    }
    private void FixedUpdate()
    {
        Debug.Log(AumentaValorEnCadaFixedUpdate *= 1.5f);

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
