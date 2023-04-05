using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatableDialogue : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private void Awake()
    {
        //playerInRange = false;
        visualCue.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        
    }
}
