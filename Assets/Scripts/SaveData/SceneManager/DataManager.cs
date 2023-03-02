using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private void Awake()
    {
        //Checks if theres already an instance so we don't get duplicates running!
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        //This is what is letting the script persist during scenes, 'not destroying it on load'.
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
