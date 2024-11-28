using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Activator : MonoBehaviour
{
    //public static bool isActive = false;

    [SerializeField] private List<string> _dialogues = new List<string>();
    [SerializeField] private int _dialogueIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {}

    private void Next(int i)
    {
        _dialogueIndex += i;
    }

    public void StartDialogue()
    {
        print("Dialogo: " + _dialogues[_dialogueIndex]);
    }
}
