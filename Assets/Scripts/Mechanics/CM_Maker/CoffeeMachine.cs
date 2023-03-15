using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoffeeMachine : MonoBehaviour
{
    public TMP_Text text;
    public GameObject popUpText;
    //PU = Pop up (I will rename this later
    public GameObject servePU;
    public TippingMachine tippingMachine;
    public DrinkSelect drinkSelect;
    public int water = 0;
    public int sugar = 0;
    public int coffee = 0;
    public int milk = 0;
    int maxIngreadients = 3;
    bool coffeeMade = false;
    public CustomerSpawner customerSpawner;


    //Check what coffee is made
    void CoffeeComplete()
    {
        popUpText.SetActive(true);
        drinkSelect.GetStats();
        drinkSelect.SelectDrink();
        coffeeMade = true;
    }

    //button functions
    public void CoffeeButton()
    {
        if (coffee<maxIngreadients)
        {
            //change the coffee and the coffee machine text 
            print("Coffee is added");
            coffee++;
            text.text = "Coffee is added";
        }
        else
        {
            //don't do anything and inform player that they can not add any more
            print("You can not add anymore!!!");
            text.text = "You can not add anymore!!!";
        }
    }

    public void SugarButton()
    {
         if (sugar<maxIngreadients)
        {
            print("sugar is added");
            sugar++;
            text.text = "Sugar is added";
        }
        else
        {
            print("You can not add anymore!!!");
            text.text = "You can not add anymore!!!";
        }
    }

    public void WaterButton()
    {
         if (water<maxIngreadients)
        {
            print("Water is added");
            water++;
            text.text = "Water is added";
        }
        else
        {
            print("You can not add anymore!!!");
            text.text = "You can not add anymore!!!";
        }
    }

    public void MilkButton()
    {
        if (milk<maxIngreadients)
        {
            print("Milk is added");
            milk++;
            text.text = "Milk is added";
        }
        else
        {
            print("You can not add anymore!!!");
            text.text = "You can not add anymore!!!";
        }
    }

    public void Reset()
    {
        //BY FIRE BE PURGED!!!
        print("Reset!");
        text.text = "The Coffee Machine has now reset";
        sugar = 0;
        milk = 0;
        water = 0;
        coffee = 0;
    }

    //Starts Coffee Complete and inform the player that the coffee is done.
    public void Done()
    {
        CoffeeComplete();
        print("Coffee is complete");
    }


    //Serve sends the data from the barista to the tippingmachines
    public void Serve()
    {
        servePU.SetActive(true);
        if(coffeeMade == false)
        {
            print("You must have something to serve!");
        }
        else
        {
            drinkSelect.ServingDrink();
            tippingMachine.CompareRequest();
            customerSpawner.customerExist = false;
        }
    }

}
