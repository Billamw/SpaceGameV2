using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    [SerializeField] internal SpaceShip spaceShip;

    private Transform spaceShipT;
    private float boost = 1;
    
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
        if (spaceShip.inputScript.boost)
        {
            boost = 7;
        }
        else
        {
            boost = 1;
        }
        Throttle();
        Yaw();
        Roll();
        Pitch();
    }

    private void Throttle()
    {
        spaceShipT.Translate(0, 0, -spaceShip.inputScript.throttle * Time.deltaTime * spaceShip.speedMultiplicator * boost);
        
    }

    private void Yaw()
    {
        spaceShipT.Rotate(Vector3.up, spaceShip.inputScript.yaw * spaceShip.yawMultiplicator);
    }

    private void Roll()
    {
        spaceShipT.Rotate(Vector3.forward, -spaceShip.inputScript.roll * spaceShip.rollMultiplicator);
    }

    private void Pitch()
    {
        spaceShipT.Rotate(Vector3.right, -spaceShip.inputScript.pitch * spaceShip.pitchMultiplicator);
    }
}
