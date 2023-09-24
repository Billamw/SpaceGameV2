using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public GameObject sphere;
    public GameObject planet;
    public Vector3 sunPosition;
    private List<GameObject> planetList = new();

    private float[] orbitArray = new float[7];
    private float[] speed = new float[7];
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(sphere, this.transform.position, Quaternion.Euler(0, 0, 0));
        GenerateOrbit();
        SpawnPlanets();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach (var obj in planetList)
        {
            obj.transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime * speed[i] * 100);
            i++;
        }
    }

    private void GenerateOrbit()
    {
        for (int i = 0; i < orbitArray.Length; i++)
        {
            orbitArray[i] = (float)i + Random.Range(0f, 1f);
            speed[i] = Random.Range(0.1f, 2f);
        }
    }

    private void SpawnPlanets()
    {
        for (int i = 0; i < orbitArray.Length; i++)
        {
            planetList.Add(Instantiate(planet, sphere.transform.position + new Vector3(orbitArray[i] * 100f, 0, 0),
                Quaternion.Euler(0, 0, 0)));
            Debug.Log(sphere.transform.position + new Vector3(orbitArray[i] * 100f, 0, 0));
        }
    }
}
