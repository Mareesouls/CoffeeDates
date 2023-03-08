using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour
{   
    public GameObject popUp;
    int fadeOutTime;
    int waitTime;

    //fades out after 2 seconds upon active
    void OnEnable()
    {
        waitTime = 1;
        fadeOutTime = 2;
        StartCoroutine(PopUpTime());
    }

    IEnumerator PopUpTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            //FadeOut();
            popUp.SetActive(false);
        }
        yield break;
    }

    /*void FadeOut()
    {
        
    }
    */
}
