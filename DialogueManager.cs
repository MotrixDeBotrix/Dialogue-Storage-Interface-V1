using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public GameObject DialogueStorage;
    private TextMeshProUGUI TextDisplay;

    void Start()
    {

        TextDisplay = GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        TextDisplay.text = GameObject.Find("DialogueStorage").GetComponent<MainDialogueStorage>().output;
    }
}
