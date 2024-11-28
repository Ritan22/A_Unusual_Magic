using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    public static bool canInteract = false;
    private Activator activator;
    public static int goOn;
    // Start is called before the first frame update
    void Start()
    {
        activator = GameObject.FindObjectOfType<Activator>().GetComponent<Activator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            Debug.LogWarning("Hai premuto E");
            activator.StartDialogue();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Interactable"))
        {
            Interactable.isActive = true;
            canInteract = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Interactable"))
        {
            Interactable.isActive = false;
            canInteract = false;
        }

    }
}
