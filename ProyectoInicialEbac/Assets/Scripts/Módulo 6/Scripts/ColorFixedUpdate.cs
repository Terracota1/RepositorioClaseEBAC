using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFixedUpdate : MonoBehaviour
{
    public static GameObject esfera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        esfera = this.gameObject;
        Color c = new Color(Random.value, Random.value, Random.value);
        esfera.GetComponent<MeshRenderer>().material.color = c;
    }
}
