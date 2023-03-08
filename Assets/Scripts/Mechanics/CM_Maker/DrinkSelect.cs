using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkSelect : MonoBehaviour
{
    bool coffeeMade=false;
    int water;
    int sugar;
    int coffee;
    int milk;
    public CoffeeMachine coffeemachine;
    public int baristaCoffeeID = 0;

    public void GetStats()
    {
        print("Get Stats");
    }


    //Select drink
    public void SelectDrink()
    {
        Espresso();
    }

    public void ServingDrink()
    {
        
    }


     void Espresso()
    {
        if(water == 0 && sugar == 0 && coffee == 1 && milk == 0 && !coffeeMade)
        {
            print("You made Espresso");
            coffeeMade = true;
            baristaCoffeeID = 1;
        }
    }

    void Doppio()
    {
        if (water == 0 && sugar == 0 && coffee == 2 && milk == 0 && !coffeeMade)
        {
            print("You made Doppio");
            coffeeMade = true;
            baristaCoffeeID = 2;
        }
    }

    void Latte()
    {
        if (water == 0 && coffee == 1 && milk == 2 && !coffeeMade)
        {
            print("You made Latte");
            coffeeMade = true;
            baristaCoffeeID = 2;
        }
    }

    void FlatWhite()
    {
        if (water == 0 && coffee == 1 && milk == 1 && !coffeeMade)
        {
            print("You made FlatWhite");
            coffeeMade = true;
            baristaCoffeeID = 1;
        }
    }
}
