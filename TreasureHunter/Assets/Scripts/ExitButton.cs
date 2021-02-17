using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExitButton : MonoBehaviour
{
    public void ExitPlayMode()
    {
        EditorApplication.isPlaying = false;
    }
}
