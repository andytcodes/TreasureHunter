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
        if (Input.GetKey(KeyCode.W)) 
        {
            this.transform.Translate(m_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(-m_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(0, 0, -m_speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(0, 0, m_speed * Time.deltaTime);
        }

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
        //TODO: Implement Winning and Losing Screen according to collision (With timer)
        GameObject treasureSphere = GameObject.Find("TreasureSphere");
        if (this.GetComponent<Collider>().bounds.Contains(treasureSphere.transform.position))
        {
            this.GetComponent<Renderer>().material.color = Color.green;
            treasureSphere.GetComponent<Renderer>().material.color = Color.green;
            SceneManager.LoadScene("WinScene");
        }
        //if timer hits 0, show lose screen
    }
}
