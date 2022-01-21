using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAwake : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject cubo;
    private void Awake()
    {
        cubo = this.gameObject;
        Color c = new Color(Random.value, Random.value, Random.value);
        cubo.GetComponent<MeshRenderer>().material.color = c;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
