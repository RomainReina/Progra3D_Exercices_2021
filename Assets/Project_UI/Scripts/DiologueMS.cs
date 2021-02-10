using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project_UI.Scripts
{
    [CreateAssetMenu(
        fileName = "DialogueMarioSonic",
        menuName = "DialogueMS")]

    public class DialogueMS : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private string text;
     

        public string Dialogue => text;
        public string Name => name;
    }
}

