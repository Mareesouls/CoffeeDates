using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TippingMachine : MonoBehaviour
{
    public bool served = false;

    public int customerRequest;
    public int baristaCoffee;
    public int tippingAmount;
    public static int totalTippingAmount;
    public GameObject customer;
    public GameObject dialoguePannel;

    
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
            if(customerRequest >= 0)
            {
                dialoguePannel.SetActive(true);
            }
        }
        else
        {
            print(customerRequest+" and "+ baristaCoffee );
            print("Whoops, wrong drink");
            if(customerRequest >= 0)
            {
                dialoguePannel.SetActive(true);
            }
        }
        customer = GameObject.Find("CUS_SPRT(Clone)");
        Destroy(customer);
    }
}
