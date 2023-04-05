using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFeedback : MonoBehaviour
{
    public int Ingredients;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

    public void ChangeColour()
    {
        if(Ingredients==1)
        {
            Light1.GetComponent<Image>().color =new Color32(255,255,255,255);
        }
        else if(Ingredients==2)
        {
            Light2.GetComponent<Image>().color =new Color32(255,255,255,255);
        }
        else if(Ingredients==3)
        {
            Light3.GetComponent<Image>().color =new Color32(255,255,255,255);
        }
        
    }

    public void IncreaseIngredients()
    {
        Ingredients++;
        ChangeColour();
    }    
    
    public void ResetIngredients()
    {
        Ingredients=0;
        Light1.GetComponent<Image>().color =new Color32(100,100,100,255);
        Light2.GetComponent<Image>().color =new Color32(100,100,100,255);
        Light3.GetComponent<Image>().color =new Color32(100,100,100,255);

    }



}
