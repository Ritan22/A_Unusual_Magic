using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.UI;

public class Dialogues : MonoBehaviour
{
    //public static bool isActive = false;

    [SerializeField] private List<string> _dialogues = new List<string>();
    private bool isActive = false;
    private int _dialogueIndex = 0;
    public static bool canva = false;
    [SerializeField] private Text text;
    [SerializeField] private bool inizia_Il_Detective;
    [SerializeField] private Image _1;
    [SerializeField] private Image _2;
    private Color grey;
    private Color white;
    [SerializeField] private Sprite sprite;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject other;
    [SerializeField] private int addTask;
    //[SerializeField] private GameObject player;
       
    // Start is called before the first frame update
    void Start()
    {
        grey = new Color(0.44f, 0.44f, 0.44f);
        white = new Color(0.87f, 0.87f, 0.87f);
        _1.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        print("isActive: " + isActive);
        //print("index : " + _dialogueIndex);
        //print("dialogo "+_dialogues.Count);
        
       if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.JoystickButton1)) && _dialogueIndex == _dialogues.Count){
            TaskManager.taskManager++;
            canva = false;
            _dialogueIndex = 0;            
            if (other != null){
                other.SetActive(true);}
            self.SetActive(false);
        }else if (isActive==true && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.JoystickButton1)) && _dialogueIndex != _dialogues.Count){
            canva = true;
            StartDialogue();
        }

    }

    public void StartDialogue()
    {
        _1.sprite = sprite;
        text.text = "" + _dialogues[_dialogueIndex];
        _dialogueIndex++;
        inizia_Il_Detective = !inizia_Il_Detective;
        Dialogatore();
        
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
    private void Dialogatore(){
        if (!inizia_Il_Detective){
            _1.color = grey;
            _2.color = white;
        }else{
            _1.color = white;
            _2.color = grey;
        }
    }
}
