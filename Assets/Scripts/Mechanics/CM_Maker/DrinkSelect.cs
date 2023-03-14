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
    public CoffeeMachine coffeeMachine;
    public int baristaCoffeeID = 0;

    public void GetStats()
    {
        print("Get Stats");
        water = coffeeMachine.water;
        sugar = coffeeMachine.sugar;
        coffee = coffeeMachine.coffee;
        milk = coffeeMachine.milk;

    }


    //Select drink
    public void SelectDrink()
    {
        Espresso();
        Doppio();
        Americano();
        Latte();
        FlatWhite();
        WeirdCoffee();
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

    void Americano()
    {
        if (water == 0 && coffee == 1 && milk == 2 && !coffeeMade)
        {
            print("You made Americano");
            coffeeMade = true;
            baristaCoffeeID = 3;
        }
    }

    void Latte()
    {
        if (water == 0 && coffee == 1 && milk == 2 && !coffeeMade)
        {
            print("You made Latte");
            coffeeMade = true;
            baristaCoffeeID = 4;
        }
    }

    void FlatWhite()
    {
        if (water == 0 && coffee == 1 && milk == 1 && !coffeeMade)
        {
            print("You made FlatWhite");
            coffeeMade = true;
            baristaCoffeeID = 5;
        }
    }

    void WeirdCoffee() 
    {
        print("That item is not on the menu");
        baristaCoffeeID = 100;
        coffeeMade = true;
    }
}
