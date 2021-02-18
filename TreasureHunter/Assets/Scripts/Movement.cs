using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float m_speed;
    // Update is called once per frame
    void Update()
    {
        //WASD Movement
        if (this.transform.position.y <= 18)
            cubeMovement(2, m_speed);
        else
            cubeMovement(1, m_speed);
        

        //Rotation
        if (Input.GetKeyUp(KeyCode.Q))
        {
            this.transform.Rotate(0, -40, 0);
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            this.transform.Rotate(0, 40, 0);
        }

        //Collision Start
        GameObject treasureSphere = GameObject.Find("TreasureSphere");
        if (this.GetComponent<Collider>().bounds.Contains(treasureSphere.transform.position))
        {
            this.GetComponent<Renderer>().material.color = Color.green;
            treasureSphere.GetComponent<Renderer>().material.color = Color.green;
            SceneManager.LoadScene("WinScene");
        }
    }

    //Function to determine if cube is in water or not and will adjust speed accordingly
    public static void cubeMovement(int waterOrNot, float m_speed)
    {
        GameObject cube = GameObject.Find("Cube");

        if (Input.GetKey(KeyCode.W))
        {
            cube.transform.Translate(m_speed / waterOrNot * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            cube.transform.Translate(-m_speed / waterOrNot * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cube.transform.Translate(0, 0, -m_speed / waterOrNot * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            cube.transform.Translate(0, 0, m_speed / waterOrNot * Time.deltaTime);
        }
    }
}
