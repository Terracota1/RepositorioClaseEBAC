using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseNormal
{
    //Este codigo funciona sin MonoBehaviour
    int numero1;
    int numero2;
    public ClaseNormal (int param1, int param2)
    {
        numero1 =param1;
        numero2 = param2;
    }

    public ClaseNormal(float param1, float param2)
    {
        numero1 = (int)param1;
        numero2 = (int)param2;
    }
    public int SuarEnteros (int a, int b)
    {
        return a + b;
    }

    public float sumarFlotantes (float a, float b)
    {
        return a + b;
    }

    public static float MultiplicarFlotantes (float a, float b)
    {
        return a * b;
    }

}
