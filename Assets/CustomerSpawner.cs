using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour 
{
    public GameObject CustomerPrefab;
    public float NextCustomer;
    public bool customerExist=false;
    public DialoguBoxManager dialoguBoxManager;
    public bool timerEnd=false;

    public void StartOfShift()
    {
        NextCustomer = 1;
        StartCoroutine(OpenStore());
    }


    private void SpawnCustomer()
    {
        if (customerExist == false && timerEnd == false)
        {
            GameObject a = Instantiate(CustomerPrefab, transform.position, Quaternion.identity);
            a.transform.position = new Vector3(-0.44f, 0.3f, -0.09f);
            //NextCustomer = random.range(3,5)
        }else
        {
            dialoguBoxManager.HideTextBox();
        }
    }

    IEnumerator OpenStore()
    {
        while(true)
        {
            yield return new WaitForSeconds(NextCustomer);
            SpawnCustomer();
        }
        yield break;
    }

}

