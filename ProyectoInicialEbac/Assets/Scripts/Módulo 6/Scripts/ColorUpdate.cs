using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUpdate : MonoBehaviour
{
    public static GameObject capsula;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        capsula = this.gameObject;
        Color c = new Color(Random.value, Random.value, Random.value);
        capsula.GetComponent<MeshRenderer>().material.color = c;
    }
}
