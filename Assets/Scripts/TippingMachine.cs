using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TippingMachine : MonoBehaviour
{
    public bool served = false;
    public int customerRequest = 1;
    public int baristaCoffee = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (served == true)
        {
            print(" COMPLETE");
        }

    }

    public void GetBaristaCoffee(int CoffeeID)
    {
        baristaCoffee=CoffeeID;
    }

    public void GetCustomerRequest()
    {

    }

    void CompareRequest()
    {
        if(customerRequest==baristaCoffee)
        {
            print("You made the correct drink, well done.");
        }
    }
}
