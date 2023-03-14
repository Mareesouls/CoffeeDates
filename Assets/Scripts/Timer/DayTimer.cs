using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTimer : MonoBehaviour
{

    public bool dayFinished = false;
    public float secondsLeft;
    public bool timerActive = false;

    public void DayStart()
        {
        //Activates the timer on button click by setting the bool to true.
        timerActive = true;
        //This line can make a set timer for all levels, commented out for now so we can just change the public variable in engine for testing purposes
        //secondsLeft = 2;
        }

    public void Update()
        {
        //When timer is active and the time is greater than 0, tics down.
        if (timerActive == true && secondsLeft > 0)
            {
                print(secondsLeft);
                secondsLeft -= Time.deltaTime;
            }
        //When timerhits 0, turns the bool to false and sets the dayFinished bool to true
        if (secondsLeft <= 0)
                {
                dayFinished = true;
                timerActive = false;    
                //print("finish");
                }
        }
}