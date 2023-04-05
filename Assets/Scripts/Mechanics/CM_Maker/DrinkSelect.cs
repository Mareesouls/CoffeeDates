using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrinkSelect : MonoBehaviour
{
    bool coffeeMade = false;
    public int water;
    public int sugar;
    public int coffee;
    public int milk;
    public CoffeeMachine coffeeMachine;
    public int baristaCoffeeID = 0;
    public TMP_Text completeCoffeeText;


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

    //serve the drink
    public void ServingDrink()
    {
        water=0;
        sugar=0;
        coffee=0;
        milk=0;
        coffeeMade=false;
        completeCoffeeText.text = "Coffee Made: ";
    }


     void Espresso()
    {
        if(water == 0 && sugar == 0 && coffee == 1 && milk == 0 && coffeeMade==false)
        {
            print("You made Espresso");
            coffeeMade = true;
            baristaCoffeeID = 1;
            completeCoffeeText.text = "Coffee Made: Espresso";
        }
    }

    void Doppio()
    {
        if (water == 0 && sugar == 0 && coffee == 2 && milk == 0 && coffeeMade==false)
        {
            print("You made Doppio");
            coffeeMade = true;
            baristaCoffeeID = 2;
            completeCoffeeText.text = "Coffee Made: Doppio";
        }
    }

    void Americano()
    {
        if (water == 1 && coffee == 1 && milk == 0 && coffeeMade==false)
        {
            print("You made Americano");
            coffeeMade = true;
            baristaCoffeeID = 3;
            completeCoffeeText.text = "Coffee Made: Americano";
        }
    }

    void Latte()
    {
        if (water == 0 && coffee == 1 && milk == 2 && coffeeMade==false)
        {
            print("You made Latte");
            coffeeMade = true;
            baristaCoffeeID = 4;
            completeCoffeeText.text = "Coffee Made: Latte";
        }
    }

    void FlatWhite()
    {
        if (water == 0 && coffee == 1 && milk == 1 && coffeeMade==false)
        {
            print("You made FlatWhite");
            coffeeMade = true;
            baristaCoffeeID = 5;
            completeCoffeeText.text = "Coffee Made: FlatWhite";
        }
    }
    //Incase someone made somthing not on the list
    void WeirdCoffee() 
    {
        if(coffeeMade==false)
        {
        print("That item is not on the menu");
        baristaCoffeeID = 100;
        coffeeMade = true;
        completeCoffeeText.text = "Coffee Made: ???";
        }
    }

    
}
