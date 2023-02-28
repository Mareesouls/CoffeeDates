using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDay : MonoBehaviour
{
    public DayTimer dayFinished;

    // Changes scene to home when timer is over
    // Needs timer to be done and there to be no customers for this to be clickable
    // Prompts player to finish with customer before being able to finish otherwise

    public void GoingHome()
    {
        if (dayFinished == true)
        {
        SceneManager.LoadScene(5);
        }
    }
}