using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TippingMachine : MonoBehaviour
{
    public bool served = false;
    public int customerRequest;
    public int baristaCoffee;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Check if served is true, probably gonna remove this later on
        if (served == true)
        {
            CompareRequest();
        }

    }

    //Compare the CoffeeID of what was served and what was requested
    void CompareRequest()
    {
        if(customerRequest==baristaCoffee)
        {
            print("You made the correct drink, well done.");
        }
        else
        {
            print("Whoops, wrong drink");
        }
    }
}
