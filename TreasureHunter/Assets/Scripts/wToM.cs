using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wToM : MonoBehaviour
{
    public void LoadMain() {

        Debug.Log("Main menu loading");
        SceneManager.LoadScene("MainMenu");

    }
}
