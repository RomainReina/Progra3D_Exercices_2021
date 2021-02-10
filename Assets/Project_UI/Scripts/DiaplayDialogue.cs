using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using Project_UI.Scripts;
using UnityEngine.SceneManagement;

public class DiaplayDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private UnityEvent onStartEvent = default;
    
    [SerializeField] private DialogueClass text;
    [SerializeField] private TextMeshProUGUI dialogueTextComponent;

    public void OnStart()
    {
        onStartEvent.Invoke();
        dialogueTextComponent.text = text.Dialogue;

    }
}
