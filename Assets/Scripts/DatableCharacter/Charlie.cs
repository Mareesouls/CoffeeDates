using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charlie : MonoBehaviour
{

    public static int curCharlieLoveBar;
    public static int maxCharlieLoveBar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToCharlie(int amount)
    {
        //curCharlieLoveBar = amount;
        curCharlieLoveBar++;
        print(curCharlieLoveBar);
    }
}
