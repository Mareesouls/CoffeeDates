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
    int maxIngreadients = 3;
    bool coffeeMade = false;
    public CustomerSpawner customerSpawner;


    //Check what coffee is made
    void CoffeeComplete()
    {
        popUpText.SetActive(true);
        drinkSelect.SelectDrink();
        coffeeMade = true;
    }

    //button functions
    public void CoffeeButton()
    {
        if (drinkSelect.coffee<maxIngreadients)
        {
            //change the coffee and the coffee machine text 
            print("Coffee is added");
            drinkSelect.coffee++;
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
         if (drinkSelect.sugar<maxIngreadients)
        {
            print("sugar is added");
            drinkSelect.sugar++;
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
         if (drinkSelect.water<maxIngreadients)
        {
            print("Water is added");
            drinkSelect.water++;
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
        if (drinkSelect.milk<maxIngreadients)
        {
            print("Milk is added");
            drinkSelect.milk++;
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
        drinkSelect.sugar = 0;
        drinkSelect.milk = 0;
        drinkSelect.water = 0;
        drinkSelect.coffee = 0;
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
