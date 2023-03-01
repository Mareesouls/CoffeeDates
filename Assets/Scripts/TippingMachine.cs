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
        customerRequest = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (served == true)
        {
            CompareRequest();
        }

    }

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
