using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    public TippingMachine customerRequest;
    public TippingMachine baristaCoffee;
    int water = 0;
    int sugar = 0;
    public int coffee = 0;
    int milk = 0;
    int maxIngreadients = 6;
    bool coffeeMade = false;
    public int baristaCoffeeID = 0;

    //Check what coffee is made
    void CoffeeComplete()
    {
        Espresso(); 
    }

    //button functions
    public void CoffeeButton()
    {
        if (coffee<maxIngreadients)
        {
            print("Coffee is added");
            coffee++;
        }
        else
        {
            print("You can not add anymore!!!");
        }
    }

    public void SugarButton()
    {
         if (sugar<maxIngreadients)
        {
            print("sugar is added");
            sugar++;
        }
        else
        {
            print("You can not add anymore!!!");
        }
    }

    public void WaterButton()
    {
         if (water<maxIngreadients)
        {
            print("Water is added");
            water++;
        }
        else
        {
            print("You can not add anymore!!!");
        }
    }

    public void MilkButton()
    {
        print("Milk is added");
        milk++;
    }

    public void Reset()
    {
        print("Reset!");
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
        coffeeMade = false;
        if(baristaCoffeeID==0)
        {
            print("You must have something to serve!");
        }
        else
        {
            baristaCoffee = baristaCoffeeID;
        }
    }

    //Drink selection
    void Espresso()
    {
        if(water == 0 && sugar == 0 && coffee == 1 && milk == 0 && !coffeeMade)
        {
            print("You made Espresso");
            coffeeMade = true;
            baristaCoffeeID = 1;
        }

    }

}
