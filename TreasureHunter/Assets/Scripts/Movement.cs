using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float m_speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            this.transform.Translate(0, 0, m_speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(m_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-m_speed * Time.deltaTime, 0, 0);
        }
    }
}
