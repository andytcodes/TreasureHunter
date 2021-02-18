using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMovement : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        GameObject cube = GameObject.Find("Cube");
        Vector3 cubePos;
        cubePos = cube.transform.position;
        cubePos.y = Terrain.activeTerrain.SampleHeight(cube.transform.position) + 1;
        cube.transform.position = cubePos;
    }
}
