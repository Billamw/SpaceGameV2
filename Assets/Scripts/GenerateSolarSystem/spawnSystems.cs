using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSystems : MonoBehaviour
{
    public GameObject system;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(system, new Vector3(200, 0, 0), Quaternion.Euler(0, 0, 90));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
