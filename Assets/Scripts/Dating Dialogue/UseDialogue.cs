using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseDialogue : MonoBehaviour
{
    // This Script is only a temporary solution to display orders from customer.
    public int CurrentLine;
    public TMP_Text NPC;
    string customerDrink;


    // Update is called once per frame
    void Update()
    {
    
        if (CurrentLine =>0);
        {
            if (CurrentLine == 1) 
            {
                NPC.text = "Hey! You must be new here.";
                
            }
            else if(CurrentLine == 2)
            {
                NPC.text = "Sorry! I just come here all the time for coffee I should introduce myself."; 
                
                
            }
            else if(CurrentLine == 3)
            {
                NPC.text = "I'm Charlie I basically keep this place afloat by how much I spend.";
                
            }
            else if(CurrentLine == 4)
            {
                NPC.text = "I normally get an *insert drink name*";
                
            }
            else if(CurrentLine == 5)
            {
                NPC.text = "remember that for next time lovely cause you'll be seeing my face a lot.";
                
            }
            else if(CurrentLine = 6)
            {
                NPC.text = "Hmm... I just finished work so I have some time I'll have it here. Thank you!";
            }
        }
    }
}