using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPT : MonoBehaviour
{
    int limiteinferior = 0;
    int limitesuperior = 2;
    int valor1;

    bool variable1;
    bool variable2;
    bool variable3;
    bool variable4;

    Color w = Color.white;
    Color b = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        valor1 = Random.Range(limiteinferior, limitesuperior);
        if (valor1 == 1) //Valor verdadero
        {
            EscriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color = w;
            variable1 = true;
            variable4 = false;
        }
        else //Valor falso
        {
            EscriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color = b;
            variable1 = false;
            variable4 = true;
        }

        variable2 = true;
        EscriptCubo2.cubo2.GetComponent<MeshRenderer>().material.color = w;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        variable2 = true;
        EscriptCubo2.cubo2.GetComponent<MeshRenderer>().material.color = w;

        Color resultado = (variable1 == true) ? EscriptCubo4.cubo4.GetComponent<MeshRenderer>().material.color = b : EscriptCubo4.cubo4.GetComponent<MeshRenderer>().material.color = w;

        if (valor1 == 1)
        {
            valor1 = 0;
            EscriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color = b;
            variable1 = false;
            variable4 = true;
        }
        else
        {
            valor1 = 1;
            EscriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color = w;
            variable1 = true;
            variable4 = false;
        }

        if (variable1 && variable2)
        {
            EscriptCubo3.cubo3.GetComponent<MeshRenderer>().material.color = w;
            variable3 = true;
        }
        else
        {
            EscriptCubo3.cubo3.GetComponent<MeshRenderer>().material.color = b;
            variable3 = false;
        }

        if (variable1 && variable2 && variable3 && variable4)
        {
            EscriptCubo5.cubo5.GetComponent<MeshRenderer>().material.color = w;
        }
        else
        {
            EscriptCubo5.cubo5.GetComponent<MeshRenderer>().material.color = b;
        }
    }
}
