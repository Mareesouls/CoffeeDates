using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temp_CoffeeSelect : MonoBehaviour
{
    public TippingMachine tippingMachine;
    public TMP_Text dialogueText;
    public TMP_Text RequestText;
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
            
        }
    }
}
