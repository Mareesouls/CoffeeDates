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
        //Prefab references (Prefabs can not store references so i'm using GameObject.Find)
        //However this also means that we need to maintain the same GameManager and CoffeeMaker accross all levels
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
        //update tippingMachine what order the customer desires
        //This function will also expand in pahse 2 of Coffee Date
        tippingMachine.customerRequest = desiredCoffee;
    }

    void TippingAmount() 
    {
        //The amount of tips the player will recieve if coffee done right
        tippingMachine.tippingAmount = customerTip;
        //this stat is declared in awake
    }


}
