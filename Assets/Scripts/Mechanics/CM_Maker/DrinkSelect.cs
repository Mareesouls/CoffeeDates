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


    public void GetStats()
    {

    }


    //Select drink
    public void SelectDrink()
    {
        Espresso();
    }


    void Espresso()
    {
        if(water == 0 && sugar == 0 && coffee == 1 && milk == 0 && !coffeeMade)
        {
            print("You made Espresso");
            coffeeMade = true;
        }

    }

    void Doppio()
    {
        if(water == 0 && sugar == 0 && coffee == 2 && milk == 0 && !coffeeMade)
        {
            print("You made Doppio");
            coffeeMade = true;
        }
    }

    void Americano()
    {
        if(water == 1  && coffee == 1 && !coffeeMade)
        {
            print("You made Americano");
            coffeeMade = true;
        }
    }

}
