using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TippingMachine : MonoBehaviour
{
    public bool served = false;

    
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
}
