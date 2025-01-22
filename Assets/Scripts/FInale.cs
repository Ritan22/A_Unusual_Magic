using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FInale : MonoBehaviour
{
    [SerializeField] private GameObject scena;
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject Fumetto;
    private bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive && Input.GetKeyDown(KeyCode.E)){
            cam.SetActive(true);
            Fumetto.SetActive(true);
            TaskManager.taskManager = 0;
            scena.SetActive(false);
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
