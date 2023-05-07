using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationExit : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Exit successfully");
        Application.Quit();
    }
}
