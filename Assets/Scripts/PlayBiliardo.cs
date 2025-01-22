using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBiliardo : MonoBehaviour
{
    [SerializeField] private GameObject cameraEffetto;
    [SerializeField] private GameObject canva;
    [SerializeField] private bool isActive;
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    
      void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E) /*|| Input.GetKeyDown(KeyCode.Mouse0)*/ || Input.GetKeyDown(KeyCode.JoystickButton1)) && isActive){
            canva.SetActive(true);
            player.SetActive(false);
            cameraEffetto.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
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
