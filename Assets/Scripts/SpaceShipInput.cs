using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceShipInput : MonoBehaviour
{
    
    [SerializeField] internal SpaceShip spaceShip;

    internal float throttle;
    internal float pitch;
    internal float yaw;
    internal float roll;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SpaceShipInput initialized");
    }

    // Update is called once per frame
    void Update()
    {
        throttle = Input.GetAxis("SpaceShipThrottle");
        pitch = Input.GetAxis("SpaceShipPitch");
        yaw = Input.GetAxis("SpaceShipYaw");
        roll = Input.GetAxis("SpaceShipRoll");
    }
}
