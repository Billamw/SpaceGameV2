using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiv_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Mesh mesh = GetComponentInChildren<MeshFilter>().mesh;
        // Vector3[] vertices = mesh.vertices;
        //
        // print(vertices.Length);
        //
        // int p = 0;
        // while (p < 100)
        // {
        //     vertices[p] += new Vector3(0, Random.Range(-0.004f, 0.004f), 0);
        //     p++;
        // }
        //
        // mesh.vertices = vertices;
        // mesh.RecalculateNormals();
        // mesh.RecalculateBounds();
        // mesh.RecalculateTangents();
    }

    // Update is called once per frame
    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] += normals[i] * ( 0.05f * Mathf.Sin(Time.time) ) ;
        }

        mesh.vertices = vertices;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        mesh.RecalculateTangents();
    }
}
