using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo2 : MonoBehaviour
{
    public GameObject PrefabCubo;
    public void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboAwake";
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
