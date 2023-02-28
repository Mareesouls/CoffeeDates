using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTSpawnCustomer : MonoBehaviour
{
	
	public bool customerPresent = false;
	
    // Start is called before the first frame update
    public void OnClick()
    {
        customerPresent = true;
		print("Customer spawned");
    }

}
