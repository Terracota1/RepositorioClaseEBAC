using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCubo4 : MonoBehaviour
{
    public static GameObject cubo4;
    Color w = Color.white;
    Color b = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        cubo4 = this.gameObject;
       bool resultado = (ScriptCubo1.cubo1.GetComponent<MeshRenderer>().material.color == w) ? cubo4.GetComponent<MeshRenderer>().material.color == b : cubo4.GetComponent<MeshRenderer>().material.color == w;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
