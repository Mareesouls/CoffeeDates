using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    int water = 0;
    int sugar = 0;
    public int coffee = 0;
    int milk = 0;
    int maxIngreadients = 6;
    void CoffeeComplete()
    {
    /*Count all values and check what dink is made, if the drink does not match anything the list has to offer, then it pumps out a weird drink.*/
    /*Sets all int to 0*/
    /*Print name of drink*/
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


}
