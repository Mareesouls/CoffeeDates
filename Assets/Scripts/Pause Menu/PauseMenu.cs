using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour 
public class static bool GameIsPaused = false;

{
void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
}
void Resume()
{

}
void Pause()
{
pauseMenuUI.SetActive(true);
Time.timeScale=0f;
}
}

// {
// public static bool GameIsPaused = false;
// //public PauseMenu menuUI;

// PauseMenu
//     // Update is called once per frame
//     void Update() 
//     {
//         if (Input.GetKeyDown(KeyCode.Escape))
//         {
//             if (GameIsPaused==true)
//             {
//                 Resume();
//             } 
//             else
//             {
//                 Pause();
//             }   
//         }
        
//     }
//     void Resume ()
//     {
//         PauseMenuUI.SetActive(false);
//         Time.timeScale = 1f;
//         GameIsPaused = false;
//     }

//     void Pause ()
//     {
//         pauseMenuUI.SetActive(true);
//         Time.timeScale = 0f;
//         GameIsPaused = true;
//     }
    
// }