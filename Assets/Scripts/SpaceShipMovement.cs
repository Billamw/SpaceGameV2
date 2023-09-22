using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    [SerializeField] internal SpaceShip spaceShip;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SpaceShipMovement initialized");
    }

    // Update is called once per frame
    void Update()
    {
        MoveSpaceship();
        RollSpaceShip();
    }

    private void MoveSpaceship()
    {
        Debug.Log("MovementScript: Moving");
        spaceShip.spaceShip.transform.position =
            spaceShip.spaceShip.transform.position + Vector3.back * spaceShip.speed * Time.deltaTime * spaceShip.inputScript.movementX
                                                   + Vector3.left * spaceShip.speed * Time.deltaTime * spaceShip.inputScript.movementZ;
    }

    private void RollSpaceShip()
    {
        spaceShip.spaceShip.transform.localRotation = Quaternion.Euler(0, spaceShip.inputScript.movementZ*10,0 );
        // spaceShip.spaceShip.transform.eulerAngles = new Vector3(
        //     0,
        //     spaceShip.spaceShip.transform.rotation.y,
        //     10 * spaceShip.inputScript.movementZ);
    }
}
