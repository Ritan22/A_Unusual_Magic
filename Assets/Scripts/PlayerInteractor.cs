using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    public static bool canInteract = false;
    private Activator activator;
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
            print("Enabled: " + GameObject.FindObjectOfType<Activator>().GetComponent<Activator>()._enabled);
            activator.StartDialogue();
        }
    }
}
