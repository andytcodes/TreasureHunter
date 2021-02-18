using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMovement : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        GameObject cube = GameObject.Find("Cube");
        GameObject sphere = GameObject.Find("TreasureSphere");
        GameObject cam = GameObject.Find("Cam");

        Vector3 cubePos;
        Vector3 spherePos;
        Vector3 camPos;

        cubePos = cube.transform.position;
        spherePos = sphere.transform.position;
        camPos = cam.transform.position;

        cubePos.y = Terrain.activeTerrain.SampleHeight(cube.transform.position) + 1;
        spherePos.y = Terrain.activeTerrain.SampleHeight(sphere.transform.position) + 1;
        camPos.y = Terrain.activeTerrain.SampleHeight(cam.transform.position) + 4;

        cube.transform.position = cubePos;
        sphere.transform.position = spherePos;
        cam.transform.position = camPos;
    }
}
