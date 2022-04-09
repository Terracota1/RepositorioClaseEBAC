using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCubo1 : MonoBehaviour
{
    int limiteinferior = 0;
    int limitesuperior = 2;
    int valor1;
    bool variable1;
    Color w = Color.white;
    Color b = Color.black;
    public static GameObject cubo1;
    // Start is called before the first frame update
    void Start()
    {
        valor1 = Random.Range(limiteinferior, limitesuperior);
        cubo1 = this.gameObject;
        if (valor1 == 1) //Valor verdadero
        {
            cubo1.GetComponent<MeshRenderer>().material.color = w;
            variable1 = true;
        }
        else //Valor falso
        {
            cubo1.GetComponent<MeshRenderer>().material.color = b;
            variable1 = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (valor1 == 1)
        {
            valor1 = 0;
            cubo1.GetComponent<MeshRenderer>().material.color = b;
            variable1 = false;
        }
        else
        {
            valor1 = 1;
            cubo1.GetComponent<MeshRenderer>().material.color = w;
            variable1 = true;
        }
    }

}