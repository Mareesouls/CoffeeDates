using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTSpawnCustomer : MonoBehaviour
{

	public bool customerPresent = false;
	
	public void OtherClick()
    {
        customerPresent = false;
		print("Customer left");
    }
	
    public void OnClick()
    {
        customerPresent = true;
		print("Customer spawned");
    }
}
