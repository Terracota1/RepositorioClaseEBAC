using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo1 : MonoBehaviour
{
    public GameObject PrefabCubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboUpdate";
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}
