using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasteoDeDatos : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 0;
    ushort miShortSinSingno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0;

    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("El valor de miByteConSigno es: " + miByteConSigno);
        Debug.Log("El valor de miInt es: " + miInt);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno = (uint)miByteConSigno;
        Debug.Log("El valor de miIntSinSigno es: " + miIntSinSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("El valor de miInt es: " + miInt);

        int a, b, c;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a / b;
        Debug.Log(c);
        miInt = Random.Range(a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("El número " + miInt + "es par");
        }
        else
        {
            Debug.Log("El número " + miInt + "es impar");
        }

    }

    // Update is called once per frame
    void Update()
    {
        miShort += 3;
        Debug.Log(miShort);
    }
}
