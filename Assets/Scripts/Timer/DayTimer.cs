using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayTimer : MonoBehaviour
{

    public bool dayFinished = false;
    public float secondsLeft;
    public bool timerActive = false;
    public CustomerSpawner customerSpawner;
    public TMP_Text text;
    public GameObject endShiftButton;
    public bool shiftStarted=false;
    public float specialEventTimer;
    //this value below is only used for display purposes, do not use in any other scenarios
    public int minutesLeft;

    public void DayStart()
        {
        customerSpawner.StartOfShift();
        //Activates the timer on button click by setting the bool to true.
        timerActive = true;
        //This line can make a set timer for all levels, commented out for now so we can just change the public variable in engine for testing purposes
        //secondsLeft = 5*60;
        secondsLeft = 2;
        shiftStarted = true;
        //Special event is different each day, at the start of the script it is randomly decided what time the event will happen
        //The special event will alway have at minimum 2 minutes for the player to interact
        specialEventTimer = Random.Range(20,(secondsLeft-20-120));
        print(specialEventTimer);
        }

    public void FixedUpdate()
        {
        //When timer is active and the time is greater than 0, tics down.
        if (timerActive == true && secondsLeft > 0)
            {
                minutesLeft = Mathf.FloorToInt(secondsLeft/60);
                text.text = "Time Left: "+ minutesLeft.ToString()+":"+((Mathf.FloorToInt(secondsLeft))-(minutesLeft*60)).ToString();
                secondsLeft -= Time.deltaTime;
                if(secondsLeft == specialEventTimer)
                {
                    SpecialEvent();
                }
            }
        //When timerhits 0, turns the bool to false and sets the dayFinished bool to true
        if (secondsLeft <= 0 && shiftStarted)
                {
                dayFinished = true;
                timerActive = false;    
                text.text = "Time Left: 00:00";
                customerSpawner.timerEnd = true;
                endShiftButton.SetActive(true);
                //print("finish");
                }
        }

    void SpecialEvent()
    {
        print("Datable character has apearred");
    }

}