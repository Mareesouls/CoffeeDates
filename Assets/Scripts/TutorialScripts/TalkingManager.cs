using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TalkingManager : MonoBehaviour
{
    //Control line of dialogue
    public TMP_Text managerSpeak;
     

    void Start()
    {
        managerSpeak.text = "Hey! You must be the new hire. I'm the manager here and I'll be teaching you the basics before your first shift!";
        //need something that on click will prompt the next line of text
        managerSpeak.text = "howdy";
    }

}
