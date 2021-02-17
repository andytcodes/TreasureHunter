using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wToT : MonoBehaviour
{
    public void LoadTerrain() {

        Debug.Log("Terrain scene loading");
        SceneManager.LoadScene("TreasureTerrain");
    }
}
