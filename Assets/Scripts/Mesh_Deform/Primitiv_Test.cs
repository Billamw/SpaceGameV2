using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiv_Test : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
        for (int i = 0; i < 50; i++)
        {
            mesh.vertices[i] = mesh.vertices[i] * 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
