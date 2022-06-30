using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZuWindows : MonoBehaviour
{
    public void Verlassen()
    {
        Application.Quit();
        Debug.Log("Verlassen");
    }
}
