using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSystems : MonoBehaviour
{
    public GameObject system;

    public int amountOfSystems = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amountOfSystems; i++)
        {
            Sun.sunPosition = new Vector3(Random.Range(0, 10000), Random.Range(0, 10000), Random.Range(0, 10000));
            Sun.sunRotation = Quaternion.Euler(Random.Range(0, 270), 0, Random.Range(0, 270));
            Instantiate(system, Sun.sunPosition, Sun.sunRotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
