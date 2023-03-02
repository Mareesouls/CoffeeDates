using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour 
{
    public GameObject CustomerPrefab;
    public float NextCustomer = 7f;

    void Start()
    {
        StartCoroutine(OpenStore());
    }


    private void SpawnCustomer()
    {
        GameObject a = Instantiate(CustomerPrefab, transform.position, Quaternion.identity);
        a.transform.position = new Vector3( -0.44f, 0.3f, -0.09f);
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

