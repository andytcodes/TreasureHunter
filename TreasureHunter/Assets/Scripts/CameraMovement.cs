using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float m_speed;
    void Update()
    {
        float x = 0;
        float y = 0;
        float z = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            x = m_speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            x = -m_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            z = m_speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            z = -m_speed * Time.deltaTime;
        }

        Vector3 dir = new Vector3(x, y, z);
        transform.Translate(dir);
    }
}
