using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project_UI.Scripts
{
    [CreateAssetMenu(
        fileName = "NewDialogue",
        menuName = "Dialogue")]
    public class DialogueClass : ScriptableObject
    {
        [SerializeField] private string text;
     

        public string Dialogue => text;
    }
}

