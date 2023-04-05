using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {



    // Use this for initialization
    void Start () {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log ("Starting conversation with" + dialogue.name);

        sentences.Clear();

        forench (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    
    public void DisplayNextSentence ()
    {
        if (sentence.Count == 0)
        }
            EndDialogue();
            return;
        }

        string sentence = sentence.Dequeue();
        Debug.Log(sentence);

    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }

}
