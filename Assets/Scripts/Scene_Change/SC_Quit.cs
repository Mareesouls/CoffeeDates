using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SC_Quit : MonoBehaviour
{
    public void SCQuit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}                                       