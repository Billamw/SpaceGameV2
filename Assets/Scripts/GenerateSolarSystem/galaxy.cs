using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class galaxy : MonoBehaviour
{
    //Creates a galaxy with multiple solar systems that are spawned in a 10000x10000x10000 cube with a chance of 30%

    private int _xIteration = 0;
    private int _yIteration = 0;
    private int _zIteration = 0;

    public int quadrantSize = 1000000;

    public GameObject spaceShip;
    private Transform _spaceShipT;

    public GameObject solarSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        _spaceShipT = spaceShip.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckBounds())
        {
            Debug.Log("Generating new system.");
            GenerateSolarSystem();
        }
    }

    private bool CheckBounds()
    {
        bool result = false;

        if (_spaceShipT.position.x > quadrantSize * _xIteration)
        {
            _xIteration++;
            result = true;
        }

        if (_spaceShipT.position.y > quadrantSize * _yIteration)
        {
            _yIteration++;
            result = true;
        }

        if (_spaceShipT.position.z > quadrantSize * _zIteration)
        {
            _zIteration++;
            result = true;
        }
        return result;
    }

    private void GenerateSolarSystem()
    {
        Instantiate(
                    solarSystem,
             new Vector3(quadrantSize * _xIteration, quadrantSize * _yIteration, quadrantSize * _zIteration), 
             Quaternion.Euler(0,0,0));
    }
}
