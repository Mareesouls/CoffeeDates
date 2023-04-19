using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseDialogueKit : MonoBehaviour
{
    //This script is only temperary
    public int CurrentLine;
    public TMP_Text NPC;
    string customerDrink;
    //Testing purposes and should be removed afterwards
    void Start()
    {
        CurrentLine = 1;
    }
    //DialogueLines is called once per frame
    void DialogueLines()
    {
        
        if (CurrentLine >= 0)
        {
            if (CurrentLine == 1)
            {
                NPC.text = "Oh uhh hi, I don't normally order anything";
                
            }
            else if(CurrentLine == 2)
            {
                NPC.text = "the other guy that works here normally just lets me sit and write in the seating area";
            }
            else if(CurrentLine == 3)
            {
                NPC.text = "Maybe I'll get a uhh.. *reads menu* regular coffee?";
            }
            else if(CurrentLine == 4)
            {
                NPC.text = "Oh I know I just, felt like something warm today.";
            }
            else if(CurrentLine == 5)
            {
                NPC.text = "It's starting to get cold outside, it wouldn't hurt to try something new";
            }
            else if(CurrentLine == 6)
            {
                NPC.text = " I mean- like- I've had coffee before but just don't normally order.";
            }
            else if(CurrentLine == 7)
            {
                NPC.text = "Okay thank you";
            }
            else if(CurrentLine == 8)
            {
                NPC.text = "Can you also put like extra sugar in coffee?";
            }
            else if(CurrentLine == 9)
            {
                NPC.text = "I just hate how sour it normally is?";
            }
            else if(CurrentLine == 10)
            {
                NPC.text = "Thank you";
            }
            else if(CurrentLine == 11)
            {
                NPC.text = "Oh no! This is terrible";
            }
            else if(CurrentLine == 12)
            {
                NPC.text = "I normally do a lot better stuff";
            }
            else if(CurrentLine == 13)
            {
                NPC.text = "I'm trying to practice landscape, I normally do portraits";
            }
        }
    }
}
