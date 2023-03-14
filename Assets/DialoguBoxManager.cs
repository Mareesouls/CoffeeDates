using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialoguBoxManager : MonoBehaviour
{
    public GameObject dialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTextBox()
    {
        dialogueBox.SetActive(true);
    }

    public void HideTextBox()
    {
        dialogueBox.SetActive(false);
    }
}
