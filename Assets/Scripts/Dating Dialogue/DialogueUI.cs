using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;

    private void Start()
    {
        textLabel.text = "“Hey! You must be new here.”";
    }
}


