using System.Collections;
using System.Collections.Generic;
using TMPro;
using Project_UI.Scripts;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private DialogueClass text;
    [SerializeField] private TextMeshProUGUI dialogueTextComponent;
    // Start is called before the first frame update
    void Start()
    {
        dialogueTextComponent.text = text.Dialogue;

    }

    // Pour changer le textMeshProGUI 
}
