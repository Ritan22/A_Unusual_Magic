using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class Dialogues : MonoBehaviour
{
    //public static bool isActive = false;

    [SerializeField] private List<string> _dialogues = new List<string>();
    public bool isActive = false;
    public int _dialogueIndex = 0;
    public static bool canva = false;
       
    // Start is called before the first frame update
    void Start()
    {
        print(_dialogues.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_dialogueIndex == _dialogues.Count){
            TaskManager.taskManager++;
            canva = false;

        }if (isActive==true && (Input.GetKeyDown(KeyCode.E) /*|| Input.GetKeyDown(KeyCode.Mouse0)*/)){
            canva = true;
            StartDialogue();
        }
        if (isActive==true){
            print("ZIO PORCO");
        }else{print("TUA MADRE TROIA");}

        

    }

    public void StartDialogue()
    {
        print("Dialogo: " + _dialogues[_dialogueIndex++]);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            isActive = true;
            //PlayerInteractor.canInteract = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            isActive = false;
            //PlayerInteractor.canInteract = false;
        }

    }
}
