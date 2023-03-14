using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{ 
    private CustomerSpawner customerSpawner;
    public int desiredCoffee;
    private DialoguBoxManager dialoguBoxManager;
    private TippingMachine tippingMachine;
    int customerTip;

    // Start is called before the first frame update

    void Awake()
    {
        print("customer has arrived");
        //Prefab references
        customerSpawner = GameObject.Find("GameManager").GetComponent<CustomerSpawner>();
        customerSpawner.customerExist = true;
        desiredCoffee = Random.Range(1, 5);
        dialoguBoxManager = GameObject.Find("GameManager").GetComponent<DialoguBoxManager>();
        dialoguBoxManager.ShowTextBox();
        tippingMachine = GameObject.Find("CoffeeMaker").GetComponent<TippingMachine>();

        //Customer Stats
        RequestDrink();
        TippingAmount();
        //In the future include customer appearance and other features
    }

    void RequestDrink()
    {
        tippingMachine.customerRequest = desiredCoffee;
    }

    void TippingAmount() 
    {
        tippingMachine.tippingAmount = customerTip;
    }


}
