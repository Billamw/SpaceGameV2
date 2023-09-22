using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceShipInput : MonoBehaviour
{
    
    [SerializeField] internal SpaceShip spaceShip;

    internal float movementZ;
    internal float movementX;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SpaceShipInput initialized");
    }

    // Update is called once per frame
    void Update()
    {
        movementZ = Input.GetAxis("Horizontal");
        movementX = Input.GetAxis("Vertical");
    }
}
