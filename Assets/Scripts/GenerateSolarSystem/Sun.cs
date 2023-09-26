using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Sun : MonoBehaviour
{
    public static Sun instance;
    public GameObject sun;
    public GameObject planet;
    public static Vector3 sunPosition;
    public static Quaternion sunRotation;
    private List<GameObject> planetList = new();

    private float[] orbitArray = new float[4];
    private float[] speed = new float[4];

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(sun, sunPosition, sunRotation);
        GenerateOrbit();
        SpawnPlanets();
    }

    // Update is called once per frame
    void Update()
    {
        // int i = 0;
        // foreach (var obj in planetList)
        // {
        //     obj.transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime * speed[i]);
        //     i++;
        // }
    }

    private void GenerateOrbit()
    {
        for (int i = 0; i < orbitArray.Length; i++)
        {
            orbitArray[i] = (float)i + Random.Range(1f, 5f);
            speed[i] = Random.Range(0.1f, 2f);
        }
    }

    private void SpawnPlanets()
    {
        for (int i = 0; i < orbitArray.Length; i++)
        {
            planetList.Add(Instantiate(planet, sunPosition + new Vector3(orbitArray[i] * 1000f, 0, 0),
                sunRotation));
            Debug.Log("planetPOs: " + sunPosition + new Vector3(orbitArray[i] * 1000f, 0, 0));
        }
    }
}
