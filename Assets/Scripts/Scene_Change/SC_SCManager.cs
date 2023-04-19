using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_SCManager : MonoBehaviour
{
    public void SCReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SCSeatingArea()
    {
        SceneManager.LoadScene(3);
    }

    public void SCMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SCCustomerPickup()
    {
        SceneManager.LoadScene(1);
    }

    public void SCCoffeeMachine()
    {
        SceneManager.LoadScene(4);
    }

        public void SCBetweenLevel()
	{
		SceneManager.LoadScene(5);
	}

        public void SCBarista()
    {
        SceneManager.LoadScene(2);
    }
}
