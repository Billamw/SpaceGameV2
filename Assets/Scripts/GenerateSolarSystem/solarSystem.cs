using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class solarSystem : MonoBehaviour
{
    private Vector3 _sunPosition;
    private Quaternion _sunRotation;

    private float[] orbitDistance;
    private float[] speed;
    private List<GameObject> _planetList = new();
    private GameObject sun;

    // class Planet
    // {
    //     public float orbitDistance;
    //     public float speed;
    //     public GameObject planetObject;
    //     public Planet(GameObject planetObject, float orbitDistance, float speed)
    //     {
    //         this.planetObject = planetObject;
    //         this.orbitDistance = orbitDistance;
    //         this.speed = speed;
    //     }
    // }

    public int size = 4;

    public GameObject sunObject;

    public GameObject planetObject;
    //generate solar system, therefor a sun and some planets and animate them in a local coordinate system
    // Start is called before the first frame update
    void Start()
    {
        //Fill needed variables for generating:
        _sunPosition = new Vector3(Random.Range(0, 10000), Random.Range(0, 10000), Random.Range(0, 10000));
        _sunRotation = Quaternion.Euler(Random.Range(0, 270), 0, Random.Range(0, 270));
        
        orbitDistance = new float[size];
        speed = new float[size];
        
        //Call Generate___() functions:
        GenerateSolarSystem();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateSolarSystem();
    }

    private void AnimateSolarSystem()
    {
        int i = 0;
        foreach (var planet in _planetList)
        {
            planet.transform.RotateAround(sun.transform.position, sun.transform.up, Time.deltaTime*speed[i]*0.1f);
            Debug.Log(sun.transform.up);
            i++;
        }
    }

    private void GenerateSolarSystem()
    {
        GenerateSun();
        GeneratePlanets();
    }

    private void GenerateSun()
    {
        sun = Instantiate(sunObject, _sunPosition, _sunRotation);
    }

    private void GeneratePlanets()
    {
        Debug.Log("Generating planets...");
        for (int i = 0; i < size; i++)
        {
            orbitDistance[i] = (float)i + Random.Range(1f, 5f);
            speed[i] = Random.Range(0.1f, 2f);
            Debug.Log("Orbit of planet " + (i+1) + ": " + orbitDistance[i]);
        }

        for (int i = 0; i < size; i++)
        {
            GameObject planet = Instantiate(planetObject, new Vector3(orbitDistance[i] * 1000, 0, 0), Quaternion.Euler(0, 0, 0));
            planet.transform.Translate(planet.transform.position, sun.transform);
            // planet.transform.position += _sunPosition;
            Debug.Log("Planet " + (i+1) + " instantiated at: " + planet.transform.position);
            _planetList.Add(planet);
            
        }
        Debug.Log("Planets generated...");
    }
}
