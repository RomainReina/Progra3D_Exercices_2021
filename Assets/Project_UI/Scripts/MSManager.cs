using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Project_UI.Scripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MSManager : MonoBehaviour
{
    
    [SerializeField] private List<DialogueMS> listText;
    [SerializeField] private TextMeshProUGUI dialogueTextComponent;

    private int i = 0;
    void Update()
    {
        dialogueTextComponent.text = listText[i].Name + ": " + listText[i].Dialogue;
    }

    

    public void NextSentence()
    {
        i++;
        Debug.Log("i = " + i);
        //dialogueTextComponent.text = listText[_i].Name + ": " + listText[_i].Dialogue;

    }

    public void BackButton()
    {
        i = 0;  // On recommence l'histoire
        Debug.Log("i = " + i);
    }



}