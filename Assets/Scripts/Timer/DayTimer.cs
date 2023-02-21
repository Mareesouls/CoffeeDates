using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTimer : MonoBehaviour
{

    public bool dayFinished = false;
    public float secondsLeft;
    public bool timerActive = true;
	public bool customerGone = false;


    public void AtCounter()
		{
        customerGone = true;
        print("customer is gone");
		}
		
    void Start()
		{
        print("start");
        //This line can make a set timer for all levels, commented out for now so we can just change the public variable in engine for testing purposes
        //secondsLeft = 2;
		}

    void Update()
		{
        if (timerActive == true)
			{
            if (secondsLeft > 0)
				{
					secondsLeft -= Time.deltaTime;
				}
			}
			
		if (customerGone = true && secondsLeft <= 0)
				{
                dayFinished = true;
                print("finish");
				}
		}
}