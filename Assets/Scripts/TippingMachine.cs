using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TippingMachine : MonoBehaviour
{
    public bool served = false;
    public int customerRequest;
    public int baristaCoffee;
    public int tippingAmount;
    public int totalTippingAmount;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Compare the CoffeeID of what was served and what was requested
    public void CompareRequest()
    {
        if(customerRequest==baristaCoffee)
        {
            print("You made the correct drink, well done.");
            totalTippingAmount = +tippingAmount;
        }
        else
        {
            print("Whoops, wrong drink");
        }
    }
}
