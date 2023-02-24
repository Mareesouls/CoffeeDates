using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class SC_CustomerSpawner : MonoBehaviour
{
    //Max customer, cur customer, cur timer
    // int MaxCus = 3;
    //  int CurCus = 0;
    // int CurTimer = 

    //reference the whole panel
    public GameObject dialoguePanel;
    //used to spawn sprite sheet on screen
    public GameObject NPC;
    public Text dialogueText;
    //contain sentences
    public string[] dialogue;
    //find position in the string
    private int index;

    public float wordSpeed;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    } 

    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        if(index< dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
    }


   // if CurTimer =< 0 && 

}
