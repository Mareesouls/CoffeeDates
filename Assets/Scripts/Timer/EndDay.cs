using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDay : MonoBehaviour
{
    public DayTimer dF;
	public TESTSpawnCustomer cP;

    // Changes scene to home when timer is over
    // Needs timer to be done and there to be no customers for this to be clickable
    // Prompts player to finish with customer before being able to finish otherwise

    public void GoingHome()
    {
        if (dF.dayFinished == true)
        {	
			if(cP.customerPresent == false)
			{
			SceneManager.LoadScene(5);
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