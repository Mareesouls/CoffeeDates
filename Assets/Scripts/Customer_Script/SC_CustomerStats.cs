using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//characteristics

public class SC_CustomerStats : MonoBehaviour
{
    public int coffeeID = 0;
    int Tipping = 0;

    void start(){
    //random type of coffee the customer would want
    int coffeeID = 1; //Random.Range(1);


    //Dialogue that would appear when the ask for the coffee
    print("Hello, I'll have a coffee Please.");

    //random tipping 
    int Tipping = Random.Range(5,10);

    }
    
}
