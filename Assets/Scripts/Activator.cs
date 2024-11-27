using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public bool _enabled = false;
    [SerializeField] private List<string> _dialogues = new List<string>();
    [SerializeField] private int _dialogueIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // attiva la variabile per il player e per questo oggetto
            _enabled = true;
            PlayerInteractor.canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // disattiva la variabile per il player e per questo oggetto
            _enabled = false;
            PlayerInteractor.canInteract = false;
        }
    }

    private void Next(int i)
    {
        _dialogueIndex += i;
    }

    public void StartDialogue()
    {
        print("Dialogo: " + _dialogues[_dialogueIndex]);
    }
}
