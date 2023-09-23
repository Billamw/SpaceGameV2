using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    [SerializeField] internal SpaceShip spaceShip;

    private Transform spaceShipT;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SpaceShipMovement initialized");
        spaceShipT = spaceShip.spaceShip.transform;
    }
    
    //Movement Functionality:
    // -Throttle, Brake -> T: Shift, B: Ctrl
    // -Yaw             -> Left Rudder: Q, Right Rudder: E
    // -Pitch           -> Nose Up: S, Nose Down: W
    // -Roll            -> Left: A, Right: D
    
    //Aplly all transformations to local coordinates!

    // Update is called once per frame
    void Update()
    {
        Throttle();
        Yaw();
    }

    private void Throttle()
    {
        spaceShipT.Translate(0, 0, -spaceShip.inputScript.throttle * Time.deltaTime * spaceShip.speedMultiplicator);
    }

    private void Yaw()
    {
        spaceShipT.Rotate(Vector3.up, spaceShip.inputScript.yaw * spaceShip.yawMultiplicator);
    }
}
