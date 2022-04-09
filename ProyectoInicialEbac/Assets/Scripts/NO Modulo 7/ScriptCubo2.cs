using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCubo2 : MonoBehaviour
{
    int valor2;
    bool variable2;
    public static GameObject cubo2;
    // Start is called before the first frame update
    void Start()
    {
        valor2 = 1;
        cubo2 = this.gameObject;
        Color w = Color.white;
        variable2 = true;
        if (valor2 == 1)
        cubo2.GetComponent<MeshRenderer>().material.color = w;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
