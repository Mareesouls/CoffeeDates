using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class SC_CustomerSpawner : MonoBehaviour
{
    public GameObject CUS_SPRT;
    public Vector2 spawnPosition;
    //Max customer, cur customer, cur timer
    // int MaxCus = 3;
    //  int CurCus = 0;
    // int CurTimer = 

    //dialogue when customer spawns
    //reference the whole panel
    //  public GameObject dialoguePanel;
    // public Text dialogueText;
    //contain sentences
    //public string[] dialogue;
    //find position in the string
    //  private int index;

    // public float wordSpeed;

    IEnumerator CustomerSpawning()
    {
        while (true)
        {
            Instantiate(CUS_SPRT, spawnPosition, Quaternion.identity);
            //define your list of actions here
        }
        yield break;
    }

// void Update()
//{
  //  if(Input.GetKeyDown(KeyCode.E))
  //  {
    //    if (dialoguePanel.activeInHierarchy)
      //  {
  //          zeroText();
    ///    }
       // else
     //   {
   //         dialoguePanel.SetActive(true);
//            StartCoroutine(Typing());
   //     }
  //  }
//}

//public void zeroText()
//{
 //   dialogueText.text = "";
 //   index = 0;
 //   dialoguePanel.SetActive(false);
//} 

//IEnumerator Typing()
//{
 //   foreach(char letter in dialogue[index].ToCharArray())
 //   {
  //      dialogueText.text += letter;
 //       yield return new WaitForSeconds(wordSpeed);
 //   }
//}

//public void NextLine()
//{
 //   if(index< dialogue.Length - 1)
  //  {
  //      index++;
  //      dialogueText.text = "";
  //      StartCoroutine(Typing());
 //   }
//}
//

   // if CurTimer =< 0 && 

}
