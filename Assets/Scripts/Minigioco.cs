using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Minigioco : MonoBehaviour
{
    public bool isActive = false;
    public GameObject self;
    public GameObject dx;
    public GameObject sx;
    public GameObject down;
    public GameObject up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && (isActive == true)){
            if (self != null)
                self.SetActive(!self.activeInHierarchy);
            if (dx != null)
                dx.SetActive(!dx.activeInHierarchy);
            if (sx != null)
                sx.SetActive(!sx.activeInHierarchy);
            if (down != null)
                down.SetActive(!down.activeInHierarchy);
            if (up != null)
                up.SetActive(!up.activeInHierarchy);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            isActive = true;
            PlayerInteractor.canInteract = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            isActive = false;
            PlayerInteractor.canInteract = false;
        }

    }
}
