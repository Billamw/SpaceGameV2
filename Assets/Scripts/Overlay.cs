using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Overlay : MonoBehaviour
{
    [SerializeField] internal TextMeshProUGUI overlay;
    [SerializeField] internal SpaceShip spaceShip;

    private Transform spaceShipT;

    private String boost;
    // Start is called before the first frame update
    void Start()
    {
        spaceShipT = spaceShip.spaceShip.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (spaceShip.inputScript.boost)
        {
            boost = "BOOST ACTIVE";
        }
        else
        {
            boost = "";
        }
        overlay.text = "Throttle: " + (Round(spaceShip.inputScript.throttle)*100) + "%\nRoll: " +
                       Round(spaceShipT.rotation.z)*180 + "\nYaw: " + Round(spaceShipT.rotation.y)*180 +
                       "\nPitch: " + Round(spaceShipT.rotation.x)*180 + "\n" + boost;
    }

    private float Round(float value)
    {
        value *= 1000f;
        value = (int)value;
        value = (float)value / 1000f;
        return value;
    }
}
