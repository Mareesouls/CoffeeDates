using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseDialogueCharlie : MonoBehaviour
{
    // This Script is only a temporary solution to display orders from customer.
    public int CurrentLine;
    public TMP_Text NPC;
    string customerDrink;
    //Testing purposes and should be remove afterwards
    void Start()
    {
        CurrentLine = 1;
    }
    // DialogueLines is called once per frame
    void DialogueLines()
    {
    
        if (CurrentLine >= 0)
        {
            if (CurrentLine == 1) 
            {
                NPC.text = "Hey! You must be new here.";
                CurrentLine ++;
            }
            else if(CurrentLine == 2)
            {
                NPC.text = "Sorry! I just come here all the time for coffee I should introduce myself."; 
                CurrentLine ++;   
            }
            else if(CurrentLine == 3)
            {
                NPC.text = "I'm Charlie I basically keep this place afloat by how much I spend.";
                CurrentLine ++;
            }
            else if(CurrentLine == 4)
            {
                NPC.text = "I normally get an *insert drink name*";
                
            }
            else if(CurrentLine == 5)
            {
                NPC.text = "remember that for next time lovely cause you'll be seeing my face a lot.";
                
            }
            else if(CurrentLine == 6)
            {
                NPC.text = "Hmm... I just finished work so I have some time I'll have it here. Thank you!";
            }
            else if(CurrentLine == 7)
            {
                NPC.text = "I wish I worked here! I work across the street at my dad's bakery I come here all the time on my break"; 
            }
            else if(CurrentLine == 8)
            {
                NPC.text = "Or sometimes before I start work... or as a little treat after I finish work.";
            }
            else if(CurrentLine == 9)
            {
                NPC.text = "I should introduce myself. I'm Charlie. I basically keep this place afloat by how much I spend.";
            }
            else if(CurrentLine == 10)
            {
                NPC.text = "I normally get an *insert drink name*.";
            }
            else if(CurrentLine == 11)
            {
                NPC.text = "remember that for next time lovely cause you'll be seeing my face a lot.";
            }
            else if(CurrentLine == 12)
            {
                NPC.text = "Hmm... I just finished work so I have some time I'll have it here. Thank you!.";
            }
            else if(CurrentLine == 13)
            {
                NPC.text = "It looks dead in here for now, you should sit with me if you have the time to?";
            }
            else if(CurrentLine == 14)
            {
                NPC.text = "Yay! I'm really glad you sat with me.";
            }
            else if(CurrentLine == 15)
            {
                NPC.text = "I know this is going to sound weird but I think we're going to be really close friends.";
            }
            else if(CurrentLine == 16)
            {
                NPC.text = "You feel really familiar but I can't place it. Have we met before?";
            }
            else if(CurrentLine == 17)
            {
                NPC.text = "You might have been the only person to escape this town! And now you're coming back?";
            }
            else if(CurrentLine == 18)
            {
                NPC.text = "Nothing ever happens around here and trust me when I say NOTHING.";
            }
            else if(CurrentLine == 19)
            {
                NPC.text = "I wouldn't be surprised if a few of your regulars come in just to see you.";
            }
            else if(CurrentLine == 20)
            {
                NPC.text = "I personally have never travelled past the 'Welcome to Swanford' sign.";
            }
            else if(CurrentLine == 21)
            {
                NPC.text = "I love this town I do but I wish I could travel the world one day.";
            }
            else if(CurrentLine == 22)
            {
                NPC.text = "Trying out all the coffee I want without my dad telling me I have an addiction.";
            }
            else if(CurrentLine == 23)
            {
                NPC.text = "Well, everyone in town knows each other we all went to the same school at one point.";
            }
            else if(CurrentLine == 24)
            {
                NPC.text = "HEY! Wait did you go to school here when you were younger?";
            }
            else if(CurrentLine == 25)
            {
                NPC.text = "YES!! I went to the same one! I'm pretty sure everyone did";
            }
            else if(CurrentLine == 26)
            {
                NPC.text = "but thats so funny who knows maybe we had the same class together at one point";
            }
            else if(CurrentLine == 27)
            {
                NPC.text = "thats why you feel so familiar.";
            }
            else if(CurrentLine == 28)
            {
                NPC.text = "Well I better get going and let you actually do your job. It was nice meeting you *yn*";
            }
            else if(CurrentLine == 29)
            {
                NPC.text = "You want to know more about me?";
            }
            else if(CurrentLine == 30)
            {
                NPC.text = "I don't really get up to much, I do know all the cutest spots in town though.";
            }
            else if(CurrentLine == 31)
            {
                NPC.text =  "There's a new pizza place that just opened up I'll have to take you some time.";
            }
            else if(CurrentLine == 32)
            {
                NPC.text = "Well I better get going and let you actually do your job. It was nice meeting you *yn*";
            }
            else if(CurrentLine == 33)
            {
                NPC.text = "That's so sweet of you!";
            }
            else if(CurrentLine == 34)
            {
                NPC.text = "You have a caring nature around you";
            }
            else if(CurrentLine == 35)
            {
                NPC.text = "I help out at my family's bakery when I can.";
            }
            else if(CurrentLine == 36)
            {
                NPC.text = "Am I going to get you in trouble for sitting down with me?";
            }
            else if(CurrentLine == 37)
            {
                NPC.text = "The whole store to yourself on your first week? That's a lot of responsibility.";
            }
            else if(CurrentLine == 38)
            {
                NPC.text =  "I understand, there's always stuff to do at the bakery as well so I get it.";
            }
        }
    }
    public void ButtonFunction()
    {
      DialogueLines();
    }
}