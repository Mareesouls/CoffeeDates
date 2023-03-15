using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temp_CoffeeSelect : MonoBehaviour
{
    // This Script is only a temporary solution to display orders from customer.
    
    public TippingMachine tippingMachine;
    public TMP_Text dialogueText;
    public TMP_Text requestText;
    string customerDrink;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if (tippingMachine.customerRequest>0) 
        {
            if (tippingMachine.customerRequest == 1) 
            {
                dialogueText.text = "I would like to order an Espresso";
                requestText.text = "Coffee Requested: Espresso";
            }
            else if(tippingMachine.customerRequest == 2)
            {
                dialogueText.text = "I would like to order a Doppio";
                requestText.text = "Coffee Requested:  Doppio";
            }
            else if(tippingMachine.customerRequest == 3)
            {
                dialogueText.text = "I would like to order an Americano";
                requestText.text = "Coffee Requested: Americano";
            }
            else if(tippingMachine.customerRequest == 4)
            {
                dialogueText.text = "I would like to order a Latte";
                requestText.text = "Coffee Requested: Latte";
            }
            else if(tippingMachine.customerRequest == 5)
            {
                dialogueText.text = "I would like to order a Flat White";
                requestText.text = "Coffee Requested: Flat White";
            }
        }
    }
}
