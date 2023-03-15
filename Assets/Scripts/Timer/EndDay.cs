using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDay : MonoBehaviour
{
    public DayTimer dF;
	public CustomerSpawner cP;

    // Changes scene to home when timer is over
    // Needs timer to be done and there to be no customers for this to be clickable
    // Prompts player to finish with customer before being able to finish otherwise

    public void GoingHome()
    {
		//Accesses bool from DayTimer script to see if it's true. If the day is finished continues this if statement, else says the day isn't over.
        if (dF.dayFinished == true)
        {	
			//Checking if a customer is present, will only let you change to the Home scene if there isn't one present (even if the timer has run out!). Otherwise prompts you to finish with your customer first.
			if(cP.customerExist == false)
			{
			SceneManager.LoadScene(2);
			}
			else
			{
				print("You still have a customer!");
			}
		}
		else
		{
			print("Day isn't over yet!");
		}
	}	
}