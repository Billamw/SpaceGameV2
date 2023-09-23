using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{

    [SerializeField] internal SpaceShipInput inputScript;
    [SerializeField] internal SpaceShipMovement movementScript;
    
    //internal spaceship properties:

    [SerializeField] internal int health  = 100;
    [SerializeField] internal float speedMultiplicator  = 1;
    [SerializeField] internal float yawMultiplicator  = 1;

    [SerializeField] internal GameObject spaceShip;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SpaceShip initialized");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
