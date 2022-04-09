using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCubo3 : MonoBehaviour
{
    public static GameObject cubo3;

    Color w = Color.white;
    Color b = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        cubo3 = this.gameObject;
        if (ScriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color == w || ScriptCubo2.cubo2.GetComponent<MeshRenderer>().material.color == b)
        {
            cubo3.GetComponent<MeshRenderer>().material.color = w;
        }
        else if (ScriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color == b || ScriptCubo2.cubo2.GetComponent<MeshRenderer>().material.color == w)
        {
            cubo3.GetComponent<MeshRenderer>().material.color = w;
        }
        else if (ScriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color == w && ScriptCubo2.cubo2.GetComponent<MeshRenderer>().material.color == w)
        {
            cubo3.GetComponent<MeshRenderer>().material.color = w;
        }
        else if (ScriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color == w && ScriptCubo2.cubo2.GetComponent<MeshRenderer>().material.color == b)
        {
            cubo3.GetComponent<MeshRenderer>().material.color = b;
        }
        else if (ScriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color == b && ScriptCubo2.cubo2.GetComponent<MeshRenderer>().material.color == w)
        {
            cubo3.GetComponent<MeshRenderer>().material.color = b;
        }
        else
        {
            cubo3.GetComponent<MeshRenderer>().material.color = b;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
