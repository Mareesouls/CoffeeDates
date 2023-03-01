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
        timerActive = true;
        //This line can make a set timer for all levels, commented out for now so we can just change the public variable in engine for testing purposes
        //secondsLeft = 2;
        }

    public void Update()
        {
        if (timerActive == true && secondsLeft > 0)
            {
                print("start");
                secondsLeft -= Time.deltaTime;
            }
            
        if (secondsLeft <= 0)
                {
                dayFinished = true;
                print("finish");
                }
        }
}